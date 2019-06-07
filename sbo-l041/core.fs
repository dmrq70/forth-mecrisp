\ core libraries

<<<board>>>
compiletoflash
( core start: ) here dup hex.

\ include ../flib/stm32l0/adc.fs
\ include ../flib/stm32l0/timer.fs
\ include ../flib/stm32l0/pwm.fs

PA9  constant SCL
PA10 constant SDA
\ potentially messes up PA0-PA5 as well
: i2c-pafs $110 PA9 io-base GPIO.AFRH + ! ;
include ../flib/stm32l0/i2c-min.fs

\ pins match jz4
include ../flib/stm32l0/spi-min.fs
\ rf69 rf-rssi needs LED
include ../flib/spi/rf69-min.fs

( core end, size: ) here dup hex. swap - .
cornerstone <<<core>>>
compiletoram
