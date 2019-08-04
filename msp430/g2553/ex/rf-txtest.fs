compiletoflash

include ../../flib/g2553/spi.fs
include ../../flib/drivers/rf69-tx.fs

: enckey s" beleampanchineto" drop ;

: radio-init ( -- ) \ (change settings!)
  42  rf.group !
  22 rf.nodeid !
  rf-init
  enckey rf-encrypt
  16 rf-power
  rf-sleep
  ;

: txtest ( n -- ) 0 <# #s #> 0 rf-send ;

compiletoram

\ radio-init 123 txtest
