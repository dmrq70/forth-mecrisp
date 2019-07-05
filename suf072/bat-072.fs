\ USB console for the bat board with F072
\ modelled after Jean-Claude Wippler's USB console for F103 boards
\   in embello: https://git.jeelabs.org/jcw/embello

$5000 eraseflashfrom  \ this must be loaded on top of a *clean* Mecrisp image!
cr
compiletoflash

include hal-stm32f0.fs
include ../flib/any/ring.fs
include usb.fs

: led-on 1 15 lshift $48000018 bis! ;
: led-of 1 31 lshift $48000018 bis! ;

: do-usb 
  23 bit RCC-APB1ENR bis!  \ USBEN (also done in usb-io, but need this for DPPU here
  usb-clk
  15 bit USB-BCDR hbic!  \ disconnect USB
  100000 0 do loop
  15 bit USB-BCDR hbis!  \ enable pullup on D+ line (DPPU)

  usb-io  \ switch to USB as console
;

: init ( -- )
  init
  \ with the 'spezial' mecrisp base, mecrisp's init doesn't run so...
  %111 17 lshift RCC-AHBENR bis!  \ enable GPIO ABC
  48MHz-after-reset
  \ 48MHz

  $68280000 $48000000 ! \ PA15 LED output
;

include ../flib/mecrisp/hexdump-min.fs

( usb end: ) here hex.
cornerstone eraseflash

\ include ../g6u/board.fs
\ include ../g6u/core.fs

( enter "hexdump" for a full dump of flash memory... ) space
