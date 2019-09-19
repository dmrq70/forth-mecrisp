\ Sensirion SHT31-D driver
\ by flabbergast
\ needs i2c

\ $44 constant SHT-ADDR
\ so write $88, read $89

\ single shot with clock stretching, repeatability (high - med - low)
\   $2c $06     $2c $0d     $2c $10
\ single shot without clock stretching, repeatability (high - med - low)
\   $24 $00     $24 $0b     $24 $16
\  response  TEMP_H TEMP_L CRC HUM_H HUM_L CRC
\ periodic modes, repeatability (H/M/L)
\    0.5 meas/s    $20 $32    $20 $24    $20 $2f
\      1 meas/s    $21 $30    $21 $26    $21 $2d
\      2 meas/s    $22 $36    $22 $20    $22 $2b
\      4 meas/s    $23 $34    $23 $22    $23 $29
\     10 meas/s    $27 $37    $27 $21    $27 $2a
\    accelerated response time cmd (ART)    $2b $32
\    fetch result    $e0 $00  -> T_H T_L CRC H_H H_L CRC
\    stop            $30 $93
\ soft reset  $30 $a2
\ heater  enable $30 $6d   disable $30 $66
\ status reg read  $f3 $2d  ->  SR_H SR_L CRC
\ status reg clear $30 $41

\ RH = 100 * HUM / (2^16 - 1)
\ T [deg C] = -45 + 175 * TEMP / (2^16 - 1)

\ we do not check CRC in these functions

\ crc8 basic, bit-by-bit (should work on 16bit forth)
\ polynomial hardcoded to $31 = %00110001 (x^8+x^5+x^4+1)
\ SHT31-D initial value is $ff
: crc8 ( char char -- char ) \ initial new -> crc
  xor 8 lshift
  8 0 do
    dup  $8000 and 0<> if
      $131 7 lshift  xor then
    shl
  loop
  8 rshift ;

: sht-pre ( reg1 reg2 -- nak )  \ common preamble
  i2c-start $88 >i2c drop  swap  >i2c drop >i2c  ;

: sht-reset ( -- )  $30 $A2 sht-pre drop  1 ms ;

: sht-readstat ( -- w )
  $f3 $2d sht-pre drop
  i2c-start $89 >i2c drop  0 i2c>  8 lshift  0 i2c> or  1 i2c> i2c-stop drop
  ;

: sht-getmeas ( -- traw hraw )
  $2c $06 sht-pre drop
  i2c-start $89 >i2c drop  0 i2c>  8 lshift  0 i2c> or  0 i2c> drop
                           0 i2c>  8 lshift  0 i2c> or  1 i2c> i2c-stop drop
  ;

: sht-conv-hum ( hraw -- h100 )
  10000 65535 u*/ ;
  
: sht-conv-temp ( traw -- t100 )
  17500 65535 u*/ 4500 - ;


\ extra stuff

: sht-ticker ( -- )
  begin
    ." Tick... "
    sht-getmeas
    ." Humidity: " sht-conv-hum 0 100 0 f/ 1 f.n
    ." %RH    Temperature: "
    sht-conv-temp 0 100 0 f/ 1 f.n  ." degree Celsius" cr
    1000 ms 1000 ms
  key? until
  ;
