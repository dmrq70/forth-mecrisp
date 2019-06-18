\ hardware i2c driver / basic functions
\ from jcw's embello

: i2c-init ( -- )  \ initialise I2C hardware
  OMODE-AF-OD SCL io-mode!
  OMODE-AF-OD SDA io-mode!

  \ : i2c-pafs $11000000 PB6 io-base GPIO.AFRL + ! ;
  i2c-pafs  \ set alternate function

  21 bit $40021038 bis!  \ set I2C1EN  (RCC-APB1ENR)
  $00300619 $40005410 !  \  (I2C1-TIMINGR)
;

100 buffer: i2c.buf
 0 variable i2c.ptr

: i2c-reset ( -- )  i2c.buf i2c.ptr ! ;

: i2c-addr ( u -- )  shl $40005404 !  i2c-reset ;  \  (I2C1-CR2)

: i2c++ ( -- addr )  i2c.ptr @  dup 1+ i2c.ptr ! ;

: >i2c ( u -- )  i2c++ c! ;
: i2c> ( -- u )  i2c++ c@ ;
: i2c>h ( -- u )  i2c> i2c> 8 lshift or ;


: i2c-start ( rd -- )
  if 10 bit $40005404 bis! then  \ RD_WRN  (I2C1-CR2)
  13 bit $40005404 bis!  \ START  (I2C1-CR2)
;

: i2c-stop  ( -- )
  14 bit $40005404 bis!  \ STOP  (I2C1-CR2)
  begin 15 bit $40005418 bit@ not until  \ !BUSY  (I2C1-ISR)
;

: i2c-setn ( u -- )  \ prepare for N-byte transfer and reset buffer pointer
  16 lshift $40005404 @ $FF00FFFF and or $40005404 !  i2c-reset ;  \ (I2C1-CR2)  (I2C1-CR2)
  
: i2c-wr ( -- )  \ send bytes to the I2C interface
  begin
    begin %1011001 $40005418 bit@ until  \ wait for TCR, STOPF, NACKF, or TXE  (I2C1-ISR)
  %1011000 $40005418 bit@ not while  \ while !TCR, !STOPF, and !NACKF  (I2C1-ISR)
    i2c> $40005428 c!  \  (I2C1-TXDR)
  repeat
;

: i2c-rd ( -- )  \ receive bytes from the I2C interface
  begin
    begin %1011100 $40005418 bit@ until  \ wait for TCR, STOPF, NACKF, or RXNE  (I2C1-ISR)
  2 bit $40005418 bit@ while  \ while RXNE  (I2C1-ISR)
    $40005424 c@ >i2c  \  (I2C1-RXDR)
  repeat ;

\ there are 4 cases:
\   tx>0 rx>0 : START - tx - RESTART - rx - STOP
\   tx>0 rx=0 : START - tx - STOP
\   tx=0 rx>0 : START - rx - STOP
\   tx=0 rx=0 : START - STOP          (used for presence detection)

: i2c-xfer ( u -- nak )
  0 bit $40005400 bic!  0 bit $40005400 bis!  \ toggle PE low to reset  (I2C1-CR1)  (I2C1-CR1)
  i2c.ptr @ i2c.buf - ?dup if
    i2c-setn  0 i2c-start  i2c-wr  \ tx>0
  else
    dup 0= if 0 i2c-start then  \ tx=0 rx=0
  then
  ?dup if
    i2c-setn  1 i2c-start  i2c-rd  \ rx>0
  then
  i2c-stop i2c-reset
  4 bit $40005418 bit@ 0<>  \ NAKF  (I2C1-ISR)
;

