\ sensor board deployed with SHT31-D
\   when reset with UART connected, it should drop into prompt
\   otherwise init devices, deinit USART, slow down and periodically send readings
\ on_top_of board.fs

<<<board>>>
compiletoflash

\ radio setup (change settings!)
: enckey s" beleampanchineto" drop ;

: radio-init ( -- ) \ (change settings!)
  109 rf.group !
  21 rf.nodeid !
  rf-init
  enckey rf-encrypt
  16 rf-power
  rf-sleep
  ;


\ packet setup (adjust!)
63 constant GW_ID
 7 constant PKTLEN
PKTLEN 1+ buffer: packet  \ 1+ to make the word-sized params aligned (starts at packet 1+)
: ptype packet 1+  ; \ 1b type
: ptemp packet 2+  ; \ 2b 100* temperature (Celsius) (LSB) 
: phum  packet 4 + ; \ 2b 100* humidity (%RH) (LSB)
: pbatt packet 6 + ; \ 2b 1000* battery (V) (LSB)


\ lowpower stuff (turn off whatever is not needed)
: usart2-disable ( -- )  \ disable USART2, this kills the console
  2 bit $40004400 bic!             \ clear TE (USART2-CR1)
  begin 6 bit $4000441C bit@ until \ wait for TC (USART2-ISR)
  3 bit 0 bit or $40004400 bic!    \ clear RE and UE (USART2-CR1)
  IMODE-HIGH PA2 io-mode!
  IMODE-HIGH PA3 io-mode!
  17 bit $40021038 bic!            \ disable USART2 clock (RCC-APB1ENR)
  ;

: gpio-highz ( -- )   \ put all unused GPIO into high impedance mode
  IMODE-ADC PA0  io-mode!
\ IMODE-ADC PA1  io-mode!   \ LED
  IMODE-ADC PA2  io-mode!   \ TX
  IMODE-ADC PA3  io-mode!   \ RX
\ IMODE-ADC PA4  io-mode!   \ RF69-CS
\ IMODE-ADC PA5  io-mode!   \ SCK
\ IMODE-ADC PA6  io-mode!   \ MISO
\ IMODE-ADC PA7  io-mode!   \ MOSI
\ IMODE-ADC PA9  io-mode!   \ SCL
\ IMODE-ADC PA10 io-mode!   \ SDA
  IMODE-ADC PA13 io-mode!
  IMODE-ADC PA14 io-mode!
  IMODE-ADC PB1  io-mode!
  IMODE-ADC PC14 io-mode!
  IMODE-ADC PC15 io-mode! ;

: ioports-disable-extra ( -- )
  1 bit 2 bit or $4002102C bic!             \ disable PORTB/C clock (RCC-IOPENR)
  ;

: adc-extrainit ( -- )  \ init adc and enable some extra flags (so can't use the default one)
   9 bit $40021034 bis! \ set ADCEN  (RCC-APB2ENR)
  30 bit $40012410 bis! \ select PCLK/2 as ADC clock  (ADC-CFGR2)
  15 bit $4001240C bis! \ AUTOFF auto off when not in use  (ADC-CFGR1)
  25 bit $40012708 bis! \ LFMEN because freq < 3.5MHz  (ADC-CCR)
   9 bit $40021044 bic! \ ADCSMEN disable ADC in sleep mode / not sure needed? (RCC-APB2SMENR)
  adc-calib  1 $40012408 !   \ perform calibration, then set ADEN to enable ADC  (ADC-CR)
  adc-once drop
  ;

\ sleep routines
: stop1s    ( -- )  \ sleep in low-power for 1 sec
  37000 stop-freq ;
: stop10s   ( -- )  \ sleep in low-power for 10 sec
  370000 stop-freq ;
: stop3m    ( -- )  \ sleep in low power for 3 minutes
  6660000 stop-freq ; \ this is more-less max (16 bit timer, 128 prescaler)
: sleep ( -- ) [ $BF30 h, ] inline ; \ WFI Opcode, enters sleep mode (systick wakes)


\ initialise hardware, turn off unnecessaries, slow down
: init-lowpower ( -- ) \ these will kill USART
  usart2-disable gpio-highz ioports-disable-extra
  only-msi
  ;
: init-once ( -- ) \ this will work on prompt as well
  led-off
  i2c-init adc-extrainit radio-init lptim-init
  2.1MHz  1000 systick-hz
  0 ptype c! \ type is always zero
  ;


\ sensor driver
include ../../flib/i2c/sht31-d.fs

: packet-prepare ( -- ) \ get all measurements (separated for testing)
  adc-vcc \ get 1000*vdd
  \ dup packet 5 + c!  8 rshift packet 6 + c! \ write to packet (byte-by-byte)
  pbatt h!

  sht-getmeas sht-conv-hum swap sht-conv-temp ( h100 t100 -- )
  ptemp h!
  phum  h!
  ;
: packet-send ( -- ) \ send over radio
  ptype  PKTLEN  GW_ID  rf-send
  rf-sleep
  ;

\ this runs as the main program
: main ( -- )
  begin
    led-on sleep led-off
    packet-prepare
    packet-send

    \ SHT31-D sensor goes to sleep automatically when not measuring
    stop3m stop3m
  again ;

: init  init unattended  init-once init-lowpower main ;


\ utils
: rf. ( -- )  \ print out all the RF69 registers
  cr 4 spaces  base @ hex  16 0 do space i . loop  base !
  $60 $00 do
    cr
    i h.2 ." :"
    16 0 do  space
      i j + ?dup if rf@ h.2 else ." --" then
    loop
  $10 +loop ;
 
compiletoram
