\ board definitions
\ needs always.fs

eraseflash
compiletoflash
( board start: ) here dup hex.

include ../flib/mecrisp/calltrace.fs
include ../flib/mecrisp/cond.fs
include ../flib/mecrisp/hexdump.fs
include ../flib/stm32l0/io.fs
include ../flib/pkg/pins48.fs
include ../flib/stm32l0/hal.fs
include ../flib/stm32l0/adc.fs
include ../flib/stm32l0/timer.fs
include ../flib/stm32l0/pwm.fs
include ../flib/stm32l0/sleep.fs
include ../flib/mecrisp/multi.fs

PB8 constant SCL
PB9 constant SDA
: i2c-pafs ( -- ) \ set alternate function for SDA/SCL pins
  PB8 io-base $24 + \ register addr \ ($24:GPIO.AFRH)
  dup @  $FFFFFF00 and  $11 or ! ;
include ../flib/stm32l0/i2c.fs

PB8 variable ssel  \ can be changed at run time
PB3 constant SCLK
PB4 constant MISO
PB5 constant MOSI
include ../flib/stm32l0/spi.fs

PA15 constant LED
PA1 constant BTN \ -1 pressed, 0 not

: led-off LED ioc! ;
: led-on LED ios! ;

: hello ( -- ) flash-kb . ." KB <tbb2> " hwid hex.
  $10000 compiletoflash here -  flashvar-here compiletoram here -
  ." ram/flash: " . . ." free " ;

: init ( -- )  \ board initialisation
  init  \ uses new uart init convention
  ['] ct-irq irq-fault !  \ show call trace in unhandled exceptions
  $00 hex.empty !  \ empty flash shows up as $00 iso $FF on these chips
  OMODE-PP LED io-mode!
  IMODE-FLOAT BTN io-mode!
\ 16MHz ( set by Mecrisp on startup to get an accurate USART baud rate )
  2 RCC-CCIPR !  \ set USART1 clock to HSI16, independent of sysclk
  1000 systick-hz
  led-on
  hello ." ok." cr
;

: rx-connected? ( -- f )  \ true if RX is connected (and idle)
  IMODE-LOW PA10 io-mode!  PA10 io@ 0<>  OMODE-AF-PP PA10 io-mode!
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
