\ base definitions for STM32L053 / extras
\ needs io-extra.fs

: io.all ( -- )  \ display all the readable GPIO registers
  IO-PORTS 0 do i 0 io io. loop ;

