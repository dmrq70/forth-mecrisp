\ I/O pin primitives

: bit ( u -- u )  \ turn a bit position into a single-bit mask
  1 swap lshift  1-foldable ;
: bit! ( mask addr f -- )  \ set or clear specified bit(s)
  if bis! else bic! then ;

: io ( port# pin# -- pin )  \ combine port and pin into single int
  swap 8 lshift or  2-foldable ;
: io# ( pin -- u )  \ convert pin to bit position
  $1F and  1-foldable ;
: io-mask ( pin -- u )  \ convert pin to bit mask
  io# bit  1-foldable ;
: io-port ( pin -- u )  \ convert pin to port number (A=0, B=1, etc)
  8 rshift  1-foldable ;
: io-base ( pin -- addr )  \ convert pin to GPIO base address
  $F00 and 2 lshift $50000000 +  1-foldable ;  \ GPIO-BASE
: io@ ( pin -- u )  \ get pin value (0 or -1)
  dup io-base $10 + @ swap io# rshift 1 and negate ;  \ GPIO.IDR
: ios! ( pin -- )  \ set pin to high
  dup io-mask swap io-base $18 + ! ;  \ GPIO.BSRR
: ioc! ( pin -- )  \ clear pin to low
  16 + ios! ;
: io! ( f pin -- )  \ set pin value
  \ use upper 16 bits in BSRR to reset with same operation
  swap 0= $10 and + ios! ;
: iox! ( pin -- )  \ toggle pin
  dup io@ 0= swap io! ;

\ b6 = type, b5-4 = pull, b3-2 = mode, b1..0 = speed

%0000000 constant IMODE-FLOAT  \ input, floating
%0010000 constant IMODE-HIGH   \ input, pull up
%0100000 constant IMODE-LOW    \ input, pull down
%0001100 constant IMODE-ADC    \ input, analog

%0001010 constant OMODE-AF-PP  \ alternate function, push-pull
%1001010 constant OMODE-AF-OD  \ alternate function, open drain
%0000110 constant OMODE-PP     \ output, push-pull
%1000110 constant OMODE-OD     \ output, open drain

-2 constant OMODE-WEAK  \ add to OMODE-* for 400 KHz iso 10 MHz drive
-1 constant OMODE-SLOW  \ add to OMODE-* for 2 MHz iso 10 MHz drive
 1 constant OMODE-FAST  \ add to OMODE-* for 35 MHz iso 10 MHz drive


: io-config ( bits pin offset -- )  \ replace 2 bits in specified h/w register
  over io-base + >r   ( bits pin R: addr )
  io# shl             ( bits shift R: addr )
  %11 over lshift     ( bits shift mask R: addr )
  r@ @ swap bic       ( bits shift cleared R: addr )
  rot %11 and         ( shift cleared value R: addr )
  rot lshift or r> ! ;

: io-mode! ( mode pin -- )  \ set the CNF and MODE bits for a pin
  over          over $08 io-config  \ GPIO.OSPEEDR
  over 2 rshift over $00 io-config  \ GPIO.MODER
  over 4 rshift over $0C io-config  \ GPIO.PUPDR
  \ open drain mode config
  dup io-mask swap io-base $04 +    \ GPIO.OTYPER
  ( mode mask addr ) rot %1000000 and bit! ;

