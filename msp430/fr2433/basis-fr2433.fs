\ basis: always want this

compiletoflash

: cornerstone ( Name ) ( -- )
  <builds does> eraseflashfrom
;

: init \ Launchpad hardware initialisations
  ." <FR2433> free(flash/ram): " $D400 compiletoflash here compiletoram - . flashvar-here here - . cr
   %10001000 P2OUT cbis! \ High
   %10001000 P2REN cbis! \ Pullups for buttons
         %11 P1OUT cbic! \ LEDs off
         %11 P1DIR cbis! \ LEDs are outputs
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

include fr2433/port-regs.fs

cornerstone <<basis>>
compiletoram
