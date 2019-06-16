\ Busy waits for the given time or slightly more, if interrupts are active.
\ DCO clock is only accurate to +-3% and varies with Vcc and temperature.
\ For precise timings, connect a crystal and use timer.
\ 8 cycles per loop run for 1 us @ 8 MHz.

: us 0 ?do [ $3C00 , $3C00 , ] loop ;
: ms 0 ?do 998 us loop ;

