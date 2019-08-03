\ basis: always want this
\ currently takes 512 bytes of flash (note that cornerstone always bumps up to a multiple of 512)

compiletoflash

: cornerstone ( Name ) ( -- )
  <builds begin here $1FF and while 0 , repeat
  does>   begin dup  $1FF and while 1+  repeat eraseflashfrom
;

: init
  ." <G2553> free(flash/ram): " $D400 compiletoflash here compiletoram - . flashvar-here here - . cr
;

\ Measure Vcc/2 on analog channel 11 with 2.5V reference.
: vcc. 0  11 analog  204,6 f/ 2 f.n ." V " ;

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

: h.2 ( c -- ) base @ hex swap 0 <# # # #> type base ! ; \ Print 2 digits hex

cornerstone <<basis>>
compiletoram
