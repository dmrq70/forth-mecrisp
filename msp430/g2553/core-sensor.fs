\ on_top_of basis-g2553.fs

<<basis>>
compiletoflash

include ../flib/g2553/spi.fs
include ../flib/drivers/rf69-tx.fs
include ../flib/g2553/i2c-bb-base.fs
include ../flib/drivers/i2c-bb.fs

: tie-free-pins ( -- )
  %00011001 $21 cbis! \ for uart add %110 ($21:P1OUT)
  %00111110 $29 cbis! \ ($29:P2OUT)
  ;

compiletoram