\ basis: always want this

compiletoflash

: cornerstone ( Name ) ( -- )
  <builds does> eraseflashfrom
;

: init \ Launchpad hardware initialisations
  ." <FR2433> free(flash/ram): " $D400 compiletoflash here compiletoram - . flashvar-here here - . cr
   %10001000 $203 cbis! \ High  (P2OUT)
   %10001000 $207 cbis! \ Pullups for buttons  (P2REN)
   %11 $202 cbic! \ LEDs off  (P1OUT)
   %11 $204 cbis! \ LEDs are outputs  (P1DIR)
;

\ : delayticks ( ticks -- ) \ Wait desired number of ticks with 32768 Hz.
\ \ Second Timer, free
\   ['] wakeup irq-timerb0 ! \ Set Wakeup-Interrupt
\   $10  $0182 ! \ Enable Interrupt
\   0    $0190 ! \ Clear TAR
\        $0192 ! \ Set desired delay
\   $110 $0180 ! \ ACLK, Up-Mode
\   lpm3         \ Sleep in LPM3
\   0 $180 !     \ Stop Timer
\ ;

\ : ms ( ms -- ) 32768 1000 u*/ delayticks ; \ Maximum is about 1000 ms

: h.2 ( c -- ) base @ hex swap 0 <# # # #> type base ! ; \ Print 2 digits hex

include fr2433/port-regs.fs

cornerstone <<basis>>
compiletoram
