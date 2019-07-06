\ USB console for the bat board with F072
\ modelled after Jean-Claude Wippler's USB console for F103 boards
\   in embello: https://git.jeelabs.org/jcw/embello

$5000 eraseflashfrom  \ this must be loaded on top of a *clean* Mecrisp image!
cr
compiletoflash

include hal-stm32f0.fs
include ../flib/any/ring.fs
include usb.fs

: init ( -- )
  \ with the 'spezial' mecrisp base, mecrisp's init doesn't run so...
  %111 17 lshift RCC-AHBENR bis!  \ enable GPIO ABC
  48MHz-after-reset               \ go to 48MHz
  usb-clk                         \ prepare HSI48 clock and CRS
  usb-io                          \ switch on USB console
;

( usb end: ) here hex.
cornerstone eraseflash
