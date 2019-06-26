\ bit-banged i2c driver, generic part
\ adapted from http://excamera.com/sphinx/article-forth-i2c.html
\ This driver is master-only. NOTE it is *not* word compatible with jcw's.
\ needs i2c-bb-base (base words)
\ 294 bytes flash

: i2c-start ( -- )  \ with SCL high, change SDA from 1 to 0
  1 >sda i2c-half 1>scl i2c-half 0 >sda i2c-half 0>scl ;
: i2c-stop  ( -- )  \ with SCL high, change SDA from 0 to 1
  0 >sda i2c-half 1>scl i2c-half 1 >sda i2c-half ;

: b>i2c ( f -- )  \ send one I2C bit
  0<> >sda i2c-half 1>scl-s i2c-half 0>scl ;
: i2c>b ( -- f )  \ receive one I2C bit
  1 >sda i2c-half 1>scl-s i2c-half sda> 0>scl ;

: >i2c ( b -- nak )  \ send one byte
  8 0 do dup 128 and b>i2c shl loop drop i2c>b ;
: i2c> ( nak -- b )  \ read one byte
  0 8 0 do shl i2c>b 1 and + loop swap b>i2c ;


\ eeprom example (24lc02b, so only one byte address)
\ i2c-init
\ : eep-pre ( addr -- )  i2c-start  $50 >i2c drop  >i2c drop  ;  \ common preamble
\ : eep! ( c addr -- )  eep-pre  >i2c drop  i2c-stop ;  \ write c to addr
\ : eep@ ( addr -- c )  eep-pre  i2c-start  $51 >i2c drop  1 i2c>  i2c-stop ;  \ read c from addr

