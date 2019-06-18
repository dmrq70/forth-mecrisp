\ read out the HTU21D temperature/humidity sensor
\ by flabbergast
\ needs i2c

[ifndef] HTU.ADDR  $40 constant HTU.ADDR  [then]

: htu-reset ( -- nak ) \ soft reset of the sensor
  HTU.ADDR i2c-addr $FE >i2c 0 i2c-xfer
  15 ms ;

: htu-init ( -- )
  i2c-init 15 ms htu-reset drop ;

: htu-readreg ( -- reg ) \ read HTU21's user register
  HTU.ADDR i2c-addr $E7 >i2c 0 i2c-xfer drop 1 i2c-xfer drop i2c> ;

: htu-writereg ( reg -- nak ) \ write HTU21's user register
  HTU.ADDR i2c-addr $E6 >i2c   >i2c 0 i2c-xfer ;

: htu-readb ( reg -- read ) \ read temp or hum (blocks i2c for up to 50ms)
  HTU.ADDR i2c-addr   >i2c 0 i2c-xfer drop
  3 i2c-xfer drop i2c> i2c> i2c>
  drop swap 8 lshift or ;

: htu-rawtb ( -- rawt ) \ temp reading (blocks)
  $E3 htu-readb ;

: htu-rawhb ( -- rawh ) \ hum reading (blocks)
  $E5 htu-readb ;

: htu-t100 ( -- t100 ) \ 100*temp (Celsius)
  htu-rawtb 17572 * 16 rshift 4685 - ;

: htu-h10 ( -- h10 ) \ 10*rel hum (%)
  htu-rawhb 1250 * 16 rshift 60 - ;

: htu-batlow? ( -- batlow? ) \ test htu's battery flag
  htu-readreg %01000000 and ;

\ extra stuff

: htu-ticker begin ." T: " htu-t100 . ."  H: " htu-h10 . cr 1000 ms  key? until ;

