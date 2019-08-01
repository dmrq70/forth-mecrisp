\ on_top_of basis-g2553.fs

<<basis>>
compiletoflash

include spi.fs
include ../drivers/rf69-tx.fs
include i2c-bb-base.fs
include ../drivers/i2c-bb.fs

: tie-free-pins ( -- )
  %00011001 ( %110 or ( uart ) $21 cbis! \ ($21:P1OUT)
  %00111110 $29 cbis! \ ($29:P2OUT)
  ;

reset
