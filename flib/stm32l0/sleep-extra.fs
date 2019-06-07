\ support for fow-power sleep / extras

: lptim? ( -- )  \ dump the low-power timer registers
  LPTIM1
  cr  ." ISR " dup @ h.2 space 4 +
      ." ICR " dup @ h.2 space 4 +
      ." IER " dup @ h.2 space 4 +
     ." CFGR " dup @ hex.      4 +
       ." CR " dup @ h.2 space 4 +
      ." CMP " dup @ h.4 space 4 +
      ." ARR " dup @ h.4 space 4 +
      ." CNT " dup @ h.4 space drop ;

: stop100ms ( -- )  \ sleep in low-power for 100 ms
  3700   stop-freq ;
: stop1s    ( -- )  \ sleep in low-power for 1 sec
  37000  stop-freq ;
: stop10s   ( -- )  \ sleep in low-power for 10 sec
  370000 stop-freq ;

\ : lp-blink ( -- )  only-msi  begin  stop1s led iox!  again ;
\
\ rf-init rf-sleep
\ led-off 2.1MHz 1000 systick-hz
\ lptim-init lp-blink
