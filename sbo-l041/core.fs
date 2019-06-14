\ core libraries

<<<board>>>
compiletoflash
( core start: ) here dup hex.

\ include ../flib/stm32l0/timer.fs
\ include ../flib/stm32l0/pwm.fs

PA9  constant SCL
PA10 constant SDA
\ potentially messes up PA0-PA5 as well
: i2c-pafs $110 PA9 io-base $24 + ! ;  \ (GPIO.AFRH)
include ../flib/stm32l0/i2c-min.fs

( core end, size: ) here dup hex. swap - .
cornerstone <<<core>>>
compiletoram
