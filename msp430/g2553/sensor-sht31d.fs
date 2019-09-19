\ G2553 sensor board deployed with SHT31D
\ 2019 flabbergast (public domain: https://unlicense.org/)

\ expects this hardware: https://flabbergast.drak.xyz/posts/msp430-2/#links
\ summary:
\ - 32768Hz crystal between P2.6 and P2.7
\ - RFM69CW radio on P1.5:SCK, P1.6:MISO, P1.7:MOSI (USCI_B0 spi), P2.0 CS
\ - SHT31D sensor on P2.4:SCL, P2.5:SDA (bit-banged I2C)
\ - nothing else (pins are outputs/down)
\ - runs on clean *lowpower* mecrisp on MSP430G2553

\ when reset with UART connected, it should drop into prompt
\ otherwise init devices, sleep and periodically send readings

\ for radio settings see 'radio setup' (group,id,encryption,packet structure)
\ "jeenode-style" packets

include basis-sensor.fs

compiletoflash

\ sensor driver
include ../flib/drivers/sht31d.fs

\ ------------------------------
\ radio setup (change settings!)
: enckey s" echolocatingbat3" drop ;

: radio-init ( -- ) \ (change settings!)
  109 rf.group !
  21 rf.nodeid !
  rf-init
  enckey rf-encrypt
  16 rf-power
  rf-sleep
  ;

\ packet setup (adjust!)
\ 63 constant GW_ID
\ 7 constant PKTLEN
7 1+ buffer: packet  \ 1+ to make the word-sized params aligned (starts at packet 1+)
: ptype packet 1+  ; \ 1b type
: ptemp packet 2+  ; \ 2b 100* temperature (Celsius) (LSB) 
: phum  packet 4 + ; \ 2b 100* relative humidity (%RH) (LSB)
: pbatt packet 6 + ; \ 2b 1000* battery (V) (LSB)


: init-once ( -- )
  unfree-pins
  \ %00110000 dup $2A cbis! $29 cbic! \ i2c ($2A:P2DIR) ($29:P2OUT)
  radio-init
  i2c-init sht-reset
  0 ptype c! \ type is always zero for these sensors
  ;

: deinit-uart ( -- )
  %110000 $1 ( IE2 ) cbic! \ disable USART interrupts
  %110 dup $26 ( P1SEL )  cbic!
       dup $41 ( P1SEL2 ) cbic!
       dup $22 ( P1DIR )  cbis!
           $21 ( P1OUT )  cbic!
  ;

: packet-prepare ( -- ) \ get all measurements (separated for testing)
  vcc ( mV )
  analog-off
  pbatt !

  sht-getmeas
  sht-conv-hum  phum  !
  sht-conv-temp ptemp !
  ;

: packet-send ( -- ) \ send over radio
  ptype  7 ( PKTLEN )  63 ( GW_ID )  rf-send
  rf-sleep
  ;


\ this runs as the main program
: main ( -- )
  1000 ms \ give battery a break after boot
  begin
    packet-prepare
    packet-send

    420 0 do 1000 ms loop \ sleep 7 minutes
  again ;

: init  unattended  init-once deinit-uart main ;

