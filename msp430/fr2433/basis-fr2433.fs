\ basis: always want this

compiletoflash

: cornerstone ( Name ) ( -- )
  <builds does> eraseflashfrom
;

include port-regs.fs
include timer-regs.fs

: init \ Launchpad hardware initialisations
  ." <FR2433> free(flash/ram): " $D400 compiletoflash here compiletoram - . flashvar-here here - . cr
;

: delayticks ( ticks -- ) \ Wait desired number of ticks with 32768 Hz.
  ['] wakeup irq-timerb0 ! \ Set Wakeup-Interrupt (Timer1)
  $10  TA1CCTL0 !  \ CCIE (enable interrupt)
  4    TA1CTL bis! \ clear timer
       TA1CCR0 !   \ set delay
  $110 TA1CTL !    \ ACLK source, UP mode
  lpm3
  4    TA1CTL !    \ stop and reset timer
;

: ms ( ms -- ) 32768 1000 u*/ delayticks ; \ Maximum is about 1000 ms

: h.2 ( c -- ) base @ hex swap 0 <# # # #> type base ! ; \ Print 2 digits hex

cornerstone <<basis>>
compiletoram
