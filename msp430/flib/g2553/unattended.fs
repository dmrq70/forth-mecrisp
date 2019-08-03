\ unattended quits to the interpreter if the RX pin is connected, not floating
\ else it replaces the key? hook with a test to keep checking for RX reconnect
\ if so, it will reset to end up in the interpreter on the next startup
\ for use with a turnkey app in flash, i.e. ": init init unattended ... ;"

\ needs ms
\ 160 bytes flash

\ RX is P1.1

: rx-connected? ( -- f )  \ true if RX is connected (and idle)
  %10 $21 ( P1OUT ) cbic!  %10 $27 ( P1REN ) cbis!  \ RX pulldown (already is input)
  %10 $20 ( P1IN ) cbit@  0<>  \ check RX
  %10 $27 ( P1REN ) cbic!  %10 $21 ( P1OUT ) cbis!  \ RX disable pulldown
  dup if 1 ms serial-key? if serial-key drop then then \ flush any input noise
;

: fake-key? ( -- f )  \ check for RX pin being pulled high
  rx-connected? if reset then false ;

: unattended
  rx-connected? if quit then \ return to command prompt
  ['] fake-key? hook-key? ! ;
