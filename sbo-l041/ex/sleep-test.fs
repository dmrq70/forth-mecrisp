: usart2-disable ( -- )
  2 bit $40004400 bic!             \ clear TE (USART2-CR1)
  begin 6 bit $4000441C bit@ until \ wait for TC (USART2-ISR)
  3 bit 0 bit or $40004400 bic!    \ clear RE and UE (USART2-CR1)
  IMODE-HIGH PA2 io-mode!
  IMODE-HIGH PA3 io-mode!
  17 bit $40021038 bic!            \ disable USART2 clock (RCC-APB1ENR)
  ;

: extra-ioports-disable ( -- )
  1 bit 2 bit or $4002102C bic!             \ disable PORTB/C clock (RCC-IOPENR)
  ;

\ this helps with 2-3uA (maybe)
: highz-gpio
  IMODE-ADC PA0  io-mode!
\ IMODE-ADC PA1  io-mode!   \ LED
  IMODE-ADC PA2  io-mode!
  IMODE-ADC PA3  io-mode!
\ IMODE-ADC PA4  io-mode!
  IMODE-ADC PA5  io-mode!
  IMODE-ADC PA6  io-mode!
  IMODE-ADC PA7  io-mode!
  IMODE-ADC PA9  io-mode!
  IMODE-ADC PA10 io-mode!
  IMODE-ADC PA13 io-mode!
  IMODE-ADC PA14 io-mode!
  IMODE-ADC PB1  io-mode!
  IMODE-ADC PC14 io-mode!
  IMODE-ADC PC15 io-mode! ;

: stop10s   ( -- )  \ sleep in low-power for 10 sec
  370000 stop-freq ;

: sleep ( -- ) [ $BF30 h, ] inline ; \ WFI Opcode, enters sleep mode

: lp-blips ( -- )
  led-off  rf-init rf-sleep  \ led off, radio sleep
  2.1MHz 1000 systick-hz  \ slow down the clock, adjust systick accordingly
  lptim-init              \ initialise the low-power timer
  highz-gpio              \ correct mode for pins (not much difference?)
  usart2-disable          \ doesn't seems to make any measurable difference (?)
  extra-ioports-disable   \ again no measurable difference
  only-msi
  begin
    led-on sleep led-off  \ a very short 1ms LED blip, but still visible
    stop10s               \ enter stop mode for approx 10 seconds
  again ;

