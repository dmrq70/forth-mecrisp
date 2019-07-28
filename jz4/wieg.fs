compiletoram? [if]  forgetram  [then]

$E000E100 constant NVIC-ISER \ IRQ 0 to 31 Set Enable Register (prog.man.)

include ../flib/stm32l0/exti-regs.fs

$40010000 constant SYSCFG
SYSCFG $8 + constant SYSCFG-EXTICR1
SYSCFG $C + constant SYSCFG-EXTICR2

\ ---------------------
\ w1 receiver interrupt
 
\ PA0:zero PA1:one (adjusting requires many places: exti setup, isr)

4 cells buffer: w1recv  \ receive buffer
w1recv variable w1ptr   \ word currently written into
1 ror variable w1bit    \ next bit to be received
0 variable w1bit~us     \ micros when last bit received
false variable w1msg-on \ are we receiving?

: ext01-isr ( -- ) \ interrupt handler for EXTI0 and EXTI1
  true w1msg-on !                      \ activity flag
  w1bit~us @ 20 +  micros  dup w1bit~us !  ( -- last+20 millis )
  < if                                 \ debounce width 20 millis
    2 EXTI-PR bit@ if                  \ line ONE
      w1bit @  w1ptr @  bis!  then     \ record 1
    w1bit @ ror  dup  w1bit !          \ shift bit ( -- w1bit )
    1 ror = if 1 cells w1ptr +! then   \ advance word
  then
  %11 EXTI-PR !                        \ clear interrupts on EXTI 0-1 lines
  ;

: enable-w1 ( -- ) \ set up and start external interrupts
  ['] ext01-isr irq-exti0_1 !          \ install interrupt handler EXTI 0-1

  IMODE-HIGH  PA0 io-mode!             \ set pin to input-floating mode (should have ext pullup)
  5 bit NVIC-ISER bis!                 \ enable EXTI0_1 interrupt 5 (NVIC in ref.man.)
  %1111 0  lshift SYSCFG-EXTICR1 bic!  \ select P<A>0 (reset value)
  0 bit EXTI-IMR bis!                  \ enable PA<0>
  0 bit EXTI-FTSR bis!                 \ trigger on PA<0> falling edge

  IMODE-HIGH  PA1 io-mode!             \ set pin to input-floating mode (should have ext pullup)
  %1111 4  lshift SYSCFG-EXTICR1 bic!  \ select P<A>1 (reset value)
  1 bit EXTI-IMR bis!                  \ enable PA<1>
  1 bit EXTI-FTSR bis!                 \ trigger on PA<1> falling edge
  ;

: clear1recv ( -- )                    \ clear buffer
  w1recv 4 cells 0 fill
  1 ror w1bit !
  w1recv w1ptr !
  ;


\ -----------------
\ printing routines

: 8rol ( u -- u ) \ cyclically rotate 8 bits left
  [ $2018 h,      \ movs r0 #18
    $41C6 h, ] ;  \ rors r6 r0

: h.8 ( u -- ) base @ hex swap 0 <# # # # # # # # # #> type base ! ;

: b.32 ( u -- ) base @ binary swap 0 <# 
  32 0 do # loop
  #> type base ! ;

: printwieghex ( bitpos e-bufaddr b-bufaddr -- )
  ." 0x"
  over swap ?do                        \ print full words
    i @ h.8  1 cells +loop
  @  swap  ( -- word bitpos )          \ partial word by bytes
  clz 8 / 1+ 0 do                      \ how many bytes to print?
    8rol dup h.2  loop  drop
  ;

: printwiegbin ( bitpos e-bufaddr b-bufaddr -- )
  ." 0b"
  over swap ?do                        \ print full words
    i @ b.32  1 cells +loop
  @  swap                     ( w b )  \ partial word
  clz tuck  32 swap -  rshift ( b w )  \ save the width, shift the word
  base @ -rot binary  <#  ( bas b w )  \ save base, change to bin, start build
  0  rot 0 do # loop  #> type          \ print bits ( # expects double )
  base !                               \ restore base
  ;

: p1hex ( -- ) \ print w1 hex format
  w1bit @  w1ptr @  w1recv  printwieghex cr ;

: p1bin ( -- ) \ print w1 bin format
  w1bit @  w1ptr @  w1recv  printwiegbin cr ;


\ -----
\ tasks

task: w1task
: w1& ( -- )
  clear1recv
  enable-w1
  w1task activate
  begin
    w1msg-on @ if
      w1bit~us @ 30000 +  micros u< if
        dint
        false w1msg-on !
        p1hex clear1recv
        eint
        LED ioc! 1 ms LED ios!
      then
    then
    10 ms \ will switch tasks in this time
  again ;
    
\ multitask w1&



\ -----------
\ rubbish bin

\ : testpr
\   $ABCDEF01 w1recv !
\   w1recv 4 + w1ptr !
\   $98765000 w1ptr @ !
\   $00000100 w1bit !
\   p1bin
\   ;

