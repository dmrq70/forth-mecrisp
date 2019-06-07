\ I/O pin primitives / convenience functions

: io. ( pin -- )  \ display readable GPIO registers associated with a pin
  cr
   ." PIN " dup io#  dup .  10 < if space then
  ." PORT " dup io-port [char] A + emit
  io-base
    ."   MODER " dup @ hex. 4 +
  ."    OTYPER " dup @ h.4  4 +
  ."   OSPEEDR " dup @ hex. 4 +
      ."  PUPD " dup @ hex. 4 +
  cr 14 spaces
       ."  IDR " dup @ h.4  4 +
       ."  ODR " dup @ h.4  12 +
    ."    AFRL " dup @ hex. 4 +
       ." AFRH " dup @ hex. drop ;

