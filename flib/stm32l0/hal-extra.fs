\ base definitions for STM32L053 / extras
\ needs io-extra.fs

[ifndef] IO-PORTS  3 constant IO-PORTS  [then]  \ A..C

: io.all ( -- )  \ display all the readable GPIO registers
  IO-PORTS 0 do i 0 io io. loop ;

