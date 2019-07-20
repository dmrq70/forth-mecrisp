: aclk-xt1 ( -- ) \ Enable XT1 and set it as ACLK source
  %11        $020B cbis!  \ P2.0 P2.1 set as XOUT XIN \ ($020B:P2SEL0)
  1 8 lshift $0188  bic!  \ XT1CLK is ACLK source \ ($0188:CSCTL4)
  ;

: aclk-out ( -- ) \ on P2.2
  1 2 lshift p2dir cbis!
  1 2 lshift p2sel1 cbis!
  ;

: aclk-disableautooff ( -- ) 1 0 lshift $018C bic! ; \ ($018C:CSCTL6)

\ $18E bit 1: XT1 fault

: testticks ( ticks -- ) \ Wait desired number of ticks with 32768 Hz.
  ['] wakeup irq-timerb0 ! \ Set Wakeup-Interrupt (Timer1)
  $10  $03C2 !  \ CCIE (enable interrupt) \ ($03C2:TA1CCTL0)
  4    $03C0 bis! \ clear timer \ ($03C0:TA1CTL)
       $03D2 !   \ set delay \ ($03D2:TA1CCR0)
  $110 $03C0 !    \ ACLK source, UP mode \ ($03C0:TA1CTL)
  lpm3
  4    $03C0 !    \ stop and reset timer \ ($03C0:TA1CTL)
;


: all-out $ff p1dir c!  $ff p2dir c!  $ff p3dir c! ; \ tx/rx xin/xout hava alt.fun. anyway
: t aclk-xt1 all-out
  begin
    1 p1out cbis!
    32768 testticks
    1 p1out cbic!
    10 1 do 32768 testticks loop
    2 $18e bit@ if 2 p1out cbic! else 2 p1out cbis! then
  again ;

