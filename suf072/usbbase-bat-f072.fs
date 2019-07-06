\ USB console for the bat board with F072
\ modelled after Jean-Claude Wippler's USB console for F103 boards
\   in embello: https://git.jeelabs.org/jcw/embello

$5000 eraseflashfrom  \ this must be loaded on top of a *clean* Mecrisp image!
cr
compiletoflash

include ../flib/mecrisp/calltrace.fs
include hal-stm32f0.fs
include ../flib/any/ring.fs
include usb.fs

: init ( -- )
  init
  \ with the 'spezial' mecrisp base, mecrisp's init doesn't run so...
  ['] ct-irq irq-fault !  \ show call trace in unhandled exceptions
  %111 17 lshift RCC-AHBENR bis!  \ enable GPIO ABC
  48MHz-after-reset
  usb-clk
;

include ../flib/mecrisp/hexdump-min.fs

( usb end: ) here hex.
cornerstone eraseflash

\ include ../g6u/board.fs
\ include ../g6u/core.fs

( enter "hexdump" for a full dump of flash memory... ) space
