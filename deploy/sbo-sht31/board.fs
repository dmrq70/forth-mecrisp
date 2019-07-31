\ on_top_of always.fs
\ board definitions

eraseflash
compiletoflash
( board start: ) here dup hex.

include ../../flib/mecrisp/hexdump-min.fs
include ../../flib/stm32l0/io-min.fs
include ../../flib/pkg/pins20.fs
include ../../flib/stm32l0/hal-min.fs
include ../../flib/stm32l0/sleep-min.fs
include ../../flib/stm32l0/adc-min.fs

PA1 constant LED \ sbo active low
\ PB3 constant LED \ nucleo32 active high
PB1 constant BTN \ -1 pressed, 0 not

: led-off LED ios! ;
: led-on LED ioc! ;

PA4 variable ssel
PA5 constant SCLK
PA6 constant MISO
PA7 constant MOSI
include ../../flib/stm32l0/spi-min.fs
\ rf69 rf-rssi needs LED
include ../../flib/spi/rf69-min.fs

PA9  constant SCL
PA10 constant SDA
\ potentially messes up PA0-PA5 as well
: i2c-pafs $110 PA9 io-base $24 + ! ;  \ (GPIO.AFRH)
include ../../flib/stm32l0/i2c-min.fs

: sleep ( -- ) [ $BF30 h, ] inline ; \ WFI Opcode, enters sleep mode (systick wakes)

: hello ( -- ) flash-kb . ." KB <n041> " hwid hex.
  $8000 compiletoflash here -  flashvar-here compiletoram here -
  ." ram/flash: " . . ." free " ;

: init ( -- )  \ board initialisation
  init  \ uses new uart init convention
  %10001100 $4002102C bic! \ disable ioports C D H (RCC-IOPENR)
  OMODE-PP LED io-mode!
  IMODE-FLOAT BTN io-mode!
\ 16MHz ( set by Mecrisp on startup to get an accurate USART baud rate )
  8 $4002104C !  \ set USART2 clock to HSI16, independent of sysclk (sbo uses USART2!!)  (RCC-CCIPR)
  1000 systick-hz
  led-on
  hello ." ok." cr
;

: rx-connected? ( -- f )  \ true if RX is connected (and idle)
  IMODE-LOW PA3 io-mode! sleep PA3 io@ 0<>  OMODE-AF-PP PA3 io-mode!
  dup if sleep serial-key? if serial-key drop then then \ flush any input noise
;

: fake-key? ( -- f )  \ check for RX pin being pulled high
  rx-connected? if reset then false ;

: unattended
  rx-connected? if quit then \ return to command prompt
  ['] fake-key? hook-key? ! ;

( board end, size: ) here dup hex. swap - .
cornerstone <<<board>>>
compiletoram
