\ basis: always want this

compiletoflash

: cornerstone ( Name ) ( -- )
  <builds does> eraseflashfrom
;

include port-regs.fs
include timer-regs-min.fs

: init \ Launchpad hardware initialisations
  ." <FR2476> free(flash/ram): " $D400 compiletoflash here compiletoram - . flashvar-here here - . cr
   %00001000 P2OUT cbis! \ High
   %00001000 P2REN cbis! \ Pullup for button P2.3
   %00000001 P4OUT cbis! \ High
   %00000001 P4REN cbis! \ Pullup for button P4.0
   %00000001 P1OUT cbic! \ LED P1.0 off
   %00000001 P1DIR cbis! \ LED is output
   %00000011 P5OUT cbic! \ green red RGB LED off
   %00000011 P5DIR cbis! \ LEDs are outputs
   %10000000 P4OUT cbic! \ blue RGB LED off
   %10000000 P4DIR cbis! \ LED is output
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
