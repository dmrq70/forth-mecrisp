\ bit-banged i2c driver
\ adapted from http://excamera.com/sphinx/article-forth-i2c.html
\ This driver is master-only. NOTE it is *not* word compatible with jcw's.
\ There have to be 1..10 kΩ resistors on SDA and SCL to pull them up to idle state.
\ hardcoded SCL:P2.4 SDA:P2.5, modified for MSP430
\ 514 bytes flash

: 0>scl ( -- ) \ drive SCL low
  %00010000 $29 cbic! \ (P2OUT)
  ;

: 1>scl ( -- ) \ drive SCL high
  %00010000 $29 cbis! \ (P2OUT)
  ;

: >sda ( f -- ) \ write f to SDA line
  dup
  %00100000 $29 rot if cbis! else cbic! then \ (P2OUT)
  %00100000 $2A rot if cbic! else cbis! then \ release to input when 1 (P2DIR)
  ;

: sda> ( -- f ) \ read status of SDA line
  %00100000 $28 c@ and 0<> \ (P2IN)
  ;

: i2c-init ( -- )  \ initialise bit-banged I2C
  %00010000 $2A cbis!  \ SCL output (P2DIR)
  1>scl
  %00100000 $2A cbic!  \ SDA input (P2DIR)
  ;

: i2c-half ( -- )  \ half-cycle timing delay for I2C
  50 0 do loop  ;  \ ? inline

: i2c-start ( -- )  \ with SCL high, change SDA from 1 to 0
  1 >sda i2c-half 1>scl i2c-half 0 >sda i2c-half 0>scl ;
: i2c-stop  ( -- )  \ with SCL high, change SDA from 0 to 1
  0 >sda i2c-half 1>scl i2c-half 1 >sda i2c-half ;

: b>i2c ( f -- )  \ send one I2C bit
  0<> >sda i2c-half 1>scl i2c-half 0>scl ;
: i2c>b ( -- f )  \ receive one I2C bit
  1 >sda i2c-half 1>scl i2c-half sda> 0>scl ;

: >i2c ( b -- nak )  \ send one byte
  8 0 do dup 128 and b>i2c shl loop drop i2c>b ;
: i2c> ( nak -- b )  \ read one byte
  0 8 0 do shl i2c>b 1 and + loop swap b>i2c ;


\ eeprom example (24lc02b, so only one byte address)
\ i2c-init
\ : eep-pre ( addr -- )  i2c-start  $50 >i2c drop  >i2c drop  ;  \ common preamble
\ : eep! ( c addr -- )  eep-pre  >i2c drop  i2c-stop ;  \ write c to addr
\ : eep@ ( addr -- c )  eep-pre  i2c-start  $51 >i2c drop  1 i2c>  i2c-stop ;  \ read c from addr

