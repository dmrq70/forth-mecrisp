\ board definitions
\ needs always.fs

eraseflash
compiletoflash
( board start: ) here dup hex.

include ../flib/mecrisp/hexdump-min.fs
include ../flib/stm32l0/io-min.fs
include ../flib/pkg/pins20.fs
include ../flib/stm32l0/hal-min.fs
include ../flib/stm32l0/sleep-min.fs
include ../flib/stm32l0/adc-min.fs

PA1 constant LED \ sbo active low
\ PB3 constant LED \ nucleo32 active high
PB1 constant BTN \ -1 pressed, 0 not

: led-off LED ios! ;
: led-on LED ioc! ;

PA4 variable ssel
PA5 constant SCLK
PA6 constant MISO
PA7 constant MOSI
include ../flib/stm32l0/spi-min.fs
\ rf69 rf-rssi needs LED
include ../flib/spi/rf69-min.fs

: hello ( -- ) flash-kb . ." KB <n041> " hwid hex.
  $8000 compiletoflash here -  flashvar-here compiletoram here -
  ." ram/flash: " . . ." free " ;

: init ( -- )  \ board initialisation
  \ init  \ uses new uart init convention
  OMODE-PP LED io-mode!
  IMODE-FLOAT BTN io-mode!
\ 16MHz ( set by Mecrisp on startup to get an accurate USART baud rate )
  8 $4002104C !  \ set USART2 clock to HSI16, independent of sysclk (sbo uses USART2!!)  (RCC-CCIPR)
  1000 systick-hz
  led-on
  hello ." ok." cr
;

: rx-connected? ( -- f )  \ true if RX is connected (and idle)
  IMODE-LOW PA3 io-mode!  PA3 io@ 0<>  OMODE-AF-PP PA3 io-mode!
  dup if 1 ms serial-key? if serial-key drop then then \ flush any input noise
;

: fake-key? ( -- f )  \ check for RX pin being pulled high
  rx-connected? if reset then false ;

\ unattended quits to the interpreter if the RX pin is connected, not floating
\ else it replaces the key? hook with a test to keep checking for RX reconnect
\ if so, it will reset to end up in the interpreter on the next startup
\ for use with a turnkey app in flash, i.e. ": init init unattended ... ;"

: unattended
  rx-connected? if quit then \ return to command prompt
  ['] fake-key? hook-key? ! ;

( board end, size: ) here dup hex. swap - .
cornerstone <<<board>>>
compiletoram
