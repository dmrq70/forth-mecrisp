\ G2553 sensor board deployed with BMP280
\ 2019 flabbergast (public domain: https://unlicense.org/)

\ expects this hardware: https://flabbergast.drak.xyz/posts/msp430-2/#links
\ summary:
\ - 32768Hz crystal between P2.6 and P2.7
\ - RFM69CW radio on P1.5:SCK, P1.6:MISO, P1.7:MOSI (USCI_B0 spi), P2.0 CS
\ - BMP280 sensor on P2.4:SCL, P2.5:SDA (bit-banged I2C)
\ - nothing else (pins are outputs/down)
\ - runs on clean *lowpower* mecrisp on MSP430G2553

\ when reset with UART connected, it should drop into prompt
\ otherwise init devices, sleep and periodically send readings

\ for radio settings see 'radio setup' (group,id,encryption,packet structure)
\ "jeenode-style" packets

include basis-sensor.fs

compiletoflash

\ sensor driver
include ../flib/drivers/bmp280.fs

\ ------------------------------
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

  bme-convert ms bme-data bme-sleep
  bme-calc ( dp1 t100 )
  ptemp !  swap ppres 2!
  ;

: packet-send ( -- ) \ send over radio
  ptype  9 ( PKTLEN )  63 ( GW_ID )  rf-send
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

