compiletoram eint multitask

0 variable seconds
task: timetask

: time& ( -- )
  timetask background
    begin
      key? if boot-task wake then
      1 seconds +!
      seconds @ . cr
      stop
    again ;

task: blinktask
: blink& ( -- )
  blinktask background
  begin
    key? if boot-task wake then
    PA8 iox!
    stop
  again ;
: blink-wake ( -- ) blinktask wake ;

blink& lowpower& tasks

: tick ( -- ) timetask wake ;

\ ' tick irq-systick !
16000000 $E000E014 ! \ How many ticks between interrupts ?
\        7 $E000E010 ! \ Enable the systick interrupt.

\ stop
