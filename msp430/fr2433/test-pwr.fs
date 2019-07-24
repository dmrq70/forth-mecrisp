\ These are the remains of my attempt to use XT1 instead of REFO on my FR2433 launchpad

\ Why? Because REFO eats up 15uA of power. So lpm3 doesn't go below 16uA. Lpm4 does,
\      but only wakeup from that is an external interrupt (so no timer).
\ 16uA is way too much. G2553 has no-problemo-2uA with XT1; STM32L0x1 goes to 2uA stop mode
\      with some effort (w/o crystal, but only 2.1MHz).
\ Anyway, I enabled the onboard crystal on the launchpad (resoldered the 0R resistors).
\ On reset, FR2433 probably tries to set XT1 by default, then mecrisp switches to REFO.
\ On reset, MCU is showing XT1 fault XT1OFFG@CSCTL7 is set.

\ OK, so figured out a sequence which seems to work (datasheet and lots of testing).
\ - XT1 doesn't work on boot because it requires P2.0,P2.1 set to AF through P2SEL0.
\ - clearing fault 3 places: XT1OFFG,DCOFFG@CSCTL7, OFIFG@SFRIFG1
\ - so seq: enable P2.0/1 in P2SEL0
\           clear faults (FLL should auto switch to XT1 now, assuming CSCTL3 as from reset)
\           switch ACLK source to XT1 (CSCTL4) - reset state is REFO
\ - after this lpm3 goes down to cca 1.8uA
\ With the words here it would go `xt1-enable clear-faults mclk-xt1-fll aclk-xt1`

\ The remaining gripes, have to do with the MCU design:
\  - Can't turn REFO off or test if it's on other than doing lpm3 and measuring the
\    power consumption.
\  - Because of the 'auto switch to REFO backup if XT1 fault', I can't find out from
\    the registers if ACLK/FLL/whatever use REFO or XT1 - the auto-backup doesn't
\    change the registers at all (as far as I can tell).
\    Don't even know how to find out if XT1 is working at all.
\   I mean if the faults are clear, the regs *should* reflect the state of the system....

$0102 constant SFRIFG1  \ OFIFG bit 1

: xt1-clear-fault ( -- )
  begin
    2 $018E bic!  \ clear fault \ ($018E:CSCTL7)
    2 $018E bit@ not until \ ($018E:CSCTL7)
  ;
: xt1-enable ( -- )
  %11        $020B cbis!  \ P2.0 P2.1 set as XOUT XIN \ ($020B:P2SEL0)
  xt1-clear-fault
  ;
: xt1-noautooff ( -- )
  1 CSCTL6 bic! ;  \ XT1AUTOOFF
: xt1-autooff ( -- )
  1 CSCTL6 bis! ;  \ XT1AUTOOFF
: xt1-drive ( u -- )  \ set drive 0-3
  CSCTL6 @  %11 6 lshift bic
  6 lshift or  CSCTL6 ! ;

: aclk-xt1 ( -- ) \ Enable XT1 and set it as ACLK source
  xt1-enable
  1 8 lshift $0188  bis!  \ XT1CLK is not ACLK source \ ($0188:CSCTL4)
  1 8 lshift $0188  bic!  \ XT1CLK is ACLK source \ ($0188:CSCTL4)
  ;

: dco-clear-fault ( -- )
  begin
    1 0 lshift $018E bic!  \ clear fault \ ($018E:CSCTL7)
    1 0 lshift $018E bit@ not until \ ($018E:CSCTL7)
  ;
: clear-faults ( -- )
  dco-clear-fault
  xt1-clear-fault
  2 SFRIFG1 bic!
  ;

: aclk-out ( -- ) \ on P2.2
  1 2 lshift $205 cbis!  \ P2DIR
  1 2 lshift $20D cbis! \ P2SEL1
  ;
: aclk-disableautooff ( -- ) 1 0 lshift $018C bic! ; \ ($018C:CSCTL6)

\ $18E bit 1: XT1 fault (csctl7)
: a  CSCTL7 @ hex. ;
: o  2 SFRIFG1 bit@ . ;
: aclkcf 2 CSCTL7 bic! ; 
: fll-src-xt1 ( -- ) 1 4 lshift CSCTL3 bic! ;

: fll-disable ( -- ) [ $D032 , $0040 , ] inline ; \ Set   SCG0  Opcode bis #40, r2
: fll-enable  ( -- ) [ $C032 , $0040 , ] inline ;  \ Clear SCG0  Opcode bic #40, r2
: mclk-xt1-fll
  xt1-enable
  fll-disable
  $10          CSCTL3 ! \ Select REFO as FLL reference
  nop nop nop nop
  0            CSCTL3 ! \ Select XT1 as FLL reference
  $0150        CSCTL0 ! \ A good DCO guess for quickly reaching target frequency
  3 1 lshift   CSCTL1 ! \ DCO Range around 8 MHz
  244          CSCTL2 ! \ XT1 * 244 = 32768 Hz * 244 = 7 995 392 Hz
  nop nop nop         \ Wait a little bit
  fll-enable
  begin $0300 CSCTL7 bit@ not until \ Wait for FLL to lock
;

: testticks ( ticks -- ) \ Wait desired number of ticks with 32768 Hz.
  ['] wakeup irq-timerb0 ! \ Set Wakeup-Interrupt (Timer1)
  $10  $03C2 !  \ CCIE (enable interrupt) \ ($03C2:TA1CCTL0)
  4    $03C0 bis! \ clear timer \ ($03C0:TA1CTL)
       $03D2 !   \ set delay \ ($03D2:TA1CCR0)
  $110 $03C0 !    \ ACLK source, UP mode \ ($03C0:TA1CTL)
  lpm3
  4    $03C0 !    \ stop and reset timer \ ($03C0:TA1CTL)
;

: all-out $ff $204 c!  $fc $205 c!  $ff $224 c! ; \ tx/rx xin/xout have alt.fun. anyway?
: t  \ aclk-xt1 all-out
  begin
    1 $202 cbis! \ p1out
    32768 testticks
    1 $202 cbic!
    10 1 do 32768 testticks loop
    2 $18e bit@ if 2 $202 cbis! else 2 $202 cbic! then
  again ;

