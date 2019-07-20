\ basis: always want this

compiletoflash

: cornerstone ( Name ) ( -- )
  <builds does> eraseflashfrom
;

: init \ Launchpad hardware initialisations
  ." <FR2433> free(flash/ram): " $D400 compiletoflash here compiletoram - . flashvar-here here - . cr
   %10001000 $0203 cbis! \ High \ ($0203:P2OUT)
   %10001000 $0207 cbis! \ Pullups for buttons \ ($0207:P2REN)
         %11 $0202 cbic! \ LEDs off \ ($0202:P1OUT)
         %11 $0204 cbis! \ LEDs are outputs \ ($0204:P1DIR)
;

: delayticks ( ticks -- ) \ Wait desired number of ticks with 32768 Hz.
  ['] wakeup irq-timerb0 ! \ Set Wakeup-Interrupt (Timer1)
  $10  $03C2 !  \ CCIE (enable interrupt) \ ($03C2:TA1CCTL0)
  4    $03C0 bis! \ clear timer \ ($03C0:TA1CTL)
       $03D2 !   \ set delay \ ($03D2:TA1CCR0)
  $110 $03C0 !    \ ACLK source, UP mode \ ($03C0:TA1CTL)
  lpm3
  4    $03C0 !    \ stop and reset timer \ ($03C0:TA1CTL)
;

: ms ( ms -- ) 32768 1000 u*/ delayticks ; \ Maximum is about 1000 ms

: h.2 ( c -- ) base @ hex swap 0 <# # # #> type base ! ; \ Print 2 digits hex

include fr2433/port-regs.fs

cornerstone <<basis>>
compiletoram
