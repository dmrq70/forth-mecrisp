\ basis for sensor boards

eraseflash
compiletoflash

\ : cornerstone ( Name ) ( -- )
\   <builds begin here $1FF and while 0 , repeat
\   does>   begin dup  $1FF and while 1+  repeat eraseflashfrom
\ ;

\ : h.2 ( c -- ) base @ hex swap 0 <# # # #> type base ! ; \ Print 2 digits hex

\ : init
\   ." <G2553> " $D400 compiletoflash here compiletoram - . flashvar-here here - . cr
\ ;

\ Measure Vcc/2 on analog channel 11 with 2.5V reference.
: vcc ( -- mv ) 0  11 analog  0,2046 f/ swap drop ;

: delayticks ( ticks -- ) \ Wait desired number of ticks with 32768 Hz.
\ Second Timer, free
  ['] wakeup irq-timerb0 ! \ Set Wakeup-Interrupt
  $10  $0182 ! \ Enable Interrupt  (TBCCTL0)
  0    $0190 ! \ Clear TAR         (TBR)
       $0192 ! \ Set desired delay (TBCCR0)
  $110 $0180 ! \ ACLK, Up-Mode     (TBCTL)
  lpm3         \ Sleep in LPM3
  0 $180 !     \ Stop Timer
;

: ms ( ms -- ) 32768 1000 u*/ delayticks ; \ Maximum is about 1000 ms

include ../flib/g2553/unattended.fs
include ../flib/g2553/spi.fs
include ../flib/drivers/rf69-tx.fs
include ../flib/g2553/i2c-bb-base.fs
include ../flib/drivers/i2c-bb.fs

: tie-free-pins ( -- )
  %00011001 $22 cbis! \ for uart add %110 ($22:P1DIR)
  %00001110 $2A cbis! \ for i2c add %110000 ($2A:P2DIR)
  ;

compiletoram

\ do not cornerstone, flash is very tight
