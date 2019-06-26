\ basis: always want this
\ currently takes 512 bytes of flash (note that cornerstone always bumps up to a multiple of 256)

compiletoflash

: cornerstone ( Name ) ( -- )
  <builds does> eraseflashfrom
;

: init \ Launchpad hardware initialisations
  ." <FR2433> free(flash/ram): " $D400 compiletoflash here compiletoram - . flashvar-here here - . cr
\  8 $21 cbis! \ High  (P1OUT)
\  8 $27 cbis! \ Pullup for button  (P1REN)
\  \ 1 64 or $21 cbic! \ LEDs off  (P1OUT)
\  \ 1 64 or $22 cbis! \ LEDs are outputs  (P1DIR)
\  1 $21 cbic! \ red LED off  (P1OUT)
\  1 $22 cbis! \ red LED is output  (P1DIR)  \ P1.6 is MISO 
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

cornerstone <<basis>>
compiletoram
