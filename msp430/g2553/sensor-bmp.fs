\ sensor board deployed with BMP280
\   when reset with UART connected, it should drop into prompt
\   otherwise init devices, sleep and periodically send readings

include basis-sensor.fs

compiletoflash

\ sensor driver
include ../flib/drivers/bmp280.fs

\ radio setup (change settings!)
: enckey s" beleampanchineto" drop ;

: radio-init ( -- ) \ (change settings!)
  42  rf.group !
  22 rf.nodeid !
  rf-init
  enckey rf-encrypt
  16 rf-power
  rf-sleep
  ;


\ packet setup (adjust!)
\ 63 constant GW_ID
\ 9 constant PKTLEN
9 1+ buffer: packet  \ 1+ to make the word-sized params aligned (starts at packet 1+)
: ptype packet 1+  ; \ 1b type
: ptemp packet 2+  ; \ 2b 100* temperature (Celsius) (LSB) 
: ppres packet 4 + ; \ 4b 1* pressure (Pa) (LSB)
: pbatt packet 8 + ; \ 2b 1000* battery (V) (LSB)


: init-once ( -- )
  unfree-pins
  \ %00110000 dup $2A cbis! $29 cbic! \ i2c ($2A:P2DIR) ($29:P2OUT)
  radio-init
  bme-init-sleep drop bme-calib bme-sleep
  0 ptype c! \ type is always zero for these sensors
  ;

: deinit-uart ( -- )
  %110000 $1 cbic! \ disable USART interrupts ($1:IE2)
  %110 dup $26 cbic! \ ($26:P1SEL)
       dup $41 cbic! \ ($41:P1SEL2)
       dup $22 cbis! \ ($22:P1DIR)
           $21 cbic! \ ($21:P1OUT)
  ;

: packet-prepare ( -- ) \ get all measurements (separated for testing)
  vcc \ get 1000*vdd
  analog-off
  pbatt !

  bme-convert ms bme-data bme-sleep
  bme-calc ( dp1 t100 )
  ptemp !  swap ppres 2!
  ;

: packet-send ( -- ) \ send over radio
  ptype  9  63  rf-send  \ PKTLEN GW_ID
  rf-sleep
  ;


\ this runs as the main program
: main ( -- )
  begin
    packet-prepare
    packet-send

    420 0 do 1000 ms loop
  again ;

: init  unattended  init-once deinit-uart main ;

