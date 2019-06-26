\ read out the HTU21D temperature/humidity sensor
\ by flabbergast
\ needs i2c

\ $40 constant HTU.ADDR 
\ so write $80, read $81

: htu-pre ( regaddr -- nak ) i2c-start  $80 >i2c drop  >i2c  ; \ common preamble

: htu-reset ( -- nak ) \ soft reset of the sensor
  $FE htu-pre i2c-stop
  15 ms ;

: htu-init ( -- )
  i2c-init 15 ms htu-reset drop ;

: htu-readreg ( -- reg ) \ read HTU21's user register
  $E7 htu-pre drop  i2c-start $81 >i2c drop  1 i2c>  i2c-stop ;

: htu-writereg ( reg -- nak ) \ write HTU21's user register
  $E6 htu-pre drop  >i2c  i2c-stop ;

: htu-readb ( reg -- read ) \ read temp or hum (blocks i2c for up to 50ms)
  htu-pre drop
  i2c-start $81 >i2c drop  0 i2c> 0 i2c> 1 i2c>  i2c-stop
  drop swap 8 lshift or ;

: htu-rawtb ( -- rawt ) \ temp reading (blocks)
  $E3 htu-readb ;  \ $E3 "hold master" (req. clock stretching); $F3 "no hold master"

: htu-rawhb ( -- rawh ) \ hum reading (blocks)
  $E5 htu-readb ;  \ $E5 "hold master" (req. clock stretching); $F5 "no hold master"

: htu-t100 ( -- t100 ) \ 100*temp (Celsius)
  htu-rawtb shr 17572 $8000 u*/  4685 - ;
  \ htu-rawtb 17572 * 16 rshift 4685 - ;

: htu-h10 ( -- h10 ) \ 10*rel hum (%)
  htu-rawhb shr 1250 $8000 u*/  60 - ;
  \ htu-rawhb 1250 * 16 rshift 60 - ;

: htu-batlow? ( -- batlow? ) \ test htu's battery flag
  htu-readreg %01000000 and ;

\ extra stuff

: htu-ticker begin ." T: " htu-t100 . ."  H: " htu-h10 . cr 1000 ms  key? until ;

