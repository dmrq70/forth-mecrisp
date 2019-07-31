\ bit-banged i2c driver
\ from jcw's embello
\ adapted from http://excamera.com/sphinx/article-forth-i2c.html

\ This driver is master-only. It supports clock stretching.
\ There have to be 1..10 kΩ resistors on SDA and SCL to pull them up to idle state.

\ by flabbergast: hardcoded SCL:P2.4 SDA:P2.5, modified for MSP430
\   it's more complicated than it really needs to be for basic i2c stuff
\   but it is word compatible with jcw's i2c driver for stm32
\ = 898 bytes flash

0 variable i2c.adr
0 variable i2c.nak
0 variable i2c.prv
0 variable i2c.cnt

: 0>scl ( -- ) \ drive SCL low
  %00010000 $29 cbic! \ (P2OUT)
  ;

: 1>scl ( -- ) \ drive SCL high
  %00010000 $29 cbis! \ (P2OUT)
  ;

: 1>scl-s ( -- ) \ SCL high, stretching allowed
  %00010000 $2A cbic! \ SCL input
  1>scl  \ clear pulling down (P2DIR)
  begin %00010000 $28 cbit@ until \ clock stretching to finish (P2IN)
  %00010000 $2A cbis! \ SCL output (P2DIR)
  ;

\ : >sda ( f -- ) \ write f to SDA line (0 or 1)
\   4 lshift $29 c@ %11101111 and or $29 c! ;

: >sda ( f -- ) \ write f to SDA line
  0<> dup
  %00100000 $29 rot if cbis! else cbic! then \ (P2OUT)
  %00100000 $2A rot if cbic! else cbis! then \ release to input when 1 (P2DIR)
  ;

: sda> ( -- f ) \ read status of SDA line
  %00100000 $28 c@ and 0<> \ (P2IN)
  ;

: i2c-init ( -- )  \ initialise bit-banged I2C
  \ %00110000 $2F cbis!  \ pullups for P2.4 P2.5 (P2REN)
  %00010000 $2A cbis!  \ SCL output (P2DIR)
  1>scl
  %00100000 $2A cbic!  \ SDA inputs (P2DIR)
  ;

: i2c-half ( -- )  \ half-cycle timing delay for I2C
  50 0 do loop  ;  \ ? inline

: i2c-start ( -- )  \ with SCL high, change SDA from 1 to 0
  1 >sda i2c-half 1>scl i2c-half 0 >sda i2c-half 0>scl ;
: i2c-stop  ( -- )  \ with SCL high, change SDA from 0 to 1
  0 >sda i2c-half 1>scl i2c-half 1 >sda i2c-half ;

: b>i2c ( f -- )  \ send one I2C bit
  >sda i2c-half 1>scl-s i2c-half 0>scl ;
: i2c>b ( -- f )  \ receive one I2C bit
  1 >sda i2c-half 1>scl-s i2c-half sda> 0>scl ;

: x>i2c ( b -- nak )  \ send one byte
  8 0 do dup 128 and b>i2c shl loop drop i2c>b ;
: xi2c> ( nak -- b )  \ read one byte
  0 8 0 do shl i2c>b 1 and + loop swap b>i2c ;

: i2c-flush ( -- )
  i2c.prv @ x>i2c  ?dup if i2c.nak ! then ;

: >i2c ( u -- )  \ send one byte out to the I2C bus
  i2c-flush  i2c.prv ! ;

: i2c> ( -- u )  \ read one byte back from the I2C bus
  i2c.cnt @ dup if
    1- dup i2c.cnt !
    0= xi2c>
  then ;

\ : i2c>h ( -- u )  i2c> i2c> 8 lshift or ;

: i2c-addr ( u -- )  \ start a new I2C transaction
  shl  dup i2c.adr !  i2c.prv !  0 i2c.nak !  i2c-start ;

: i2c-xfer ( u -- nak )  \ prepare for the reply
  dup i2c.cnt !  if
    i2c-start i2c.adr @ 1+ i2c.prv ! i2c-flush
  else
    i2c-flush
    1>scl-s  \ i2c-stop
  then
  i2c.nak @
  dup if i2c-stop 0 i2c.cnt ! then  \ ignore reads if we had a nak
;

\ extra stuff

: i2c. ( -- )  \ scan and report all I2C devices on the bus
  128 0 do
    cr i h.2 ." :"
    16 0 do  space
      i j +
      dup $08 < over $77 > or if drop 2 spaces else
        dup i2c-addr  0 i2c-xfer  if drop ." --" else h.2 then
      then
    loop
  16 +loop ;



\ eeprom example (24lc02b, so only one byte address)
\ i2c-init
\ : r $50 i2c-addr 0 >i2c 0 i2c-xfer ( ack ) drop  3 i2c-xfer ( ack ) drop  i2c> i2c> i2c> i2c-stop . . . ; 
\ : w $50 i2c-addr 0 >i2c 51 >i2c 2 >i2c i2c-flush i2c-stop ;

