compiletoram eint multitask

task: blinktask
: blink& ( -- )
  blinktask background
  begin
    PA8 iox!
    1000 ms
  again ;

blink&

