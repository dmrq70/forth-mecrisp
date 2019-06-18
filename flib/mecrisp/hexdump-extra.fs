\ hex output and dump utilities
\ from jcw's embello
\ adapted from mecrisp 2.0.2 (GPL3)

: .v ( ... -- ... )  \ view stack, this is a slightly cleaner version of .s
  depth 100 u< if
    ." Stack #" depth . ." < "
    \ -1 depth negate ?do sp@ i 2+ cells - @ . loop
    -1 depth negate ?do
      sp@ i 2+ cells - @
      dup $10000 u> if [char] $ emit hex. else . then
    loop
    ." >" cr
  else
    ." Stack underflow (" depth . ." )" cr
  then ;

$FF variable hex.empty  \ needs to be variable, some flash is zero when empty

: hexdump ( -- ) \ dumps entire flash as Intel hex
  cr
\ STM32F103x8: Complete: $FFFF $0000
\ STM32F103xB: 128 KB would need a somewhat different hex file format
  $FFFF $0000  \ Complete image with Dictionary
  do
    \ Check if this line is entirely empty:
    0                 \ Not worthy to print
    i #16 + i do      \ Scan data
      i c@ hex.empty @ <> or  \ Set flag if there is a non-empty byte
    loop

    if
      ." :10" i h.4 ." 00"  \ Write record-intro with 4 digits.
      $10           \ Begin checksum
      i          +  \ Sum the address bytes
      i 8 rshift +  \ separately into the checksum

      i #16 + i do
        i c@ h.2  \ Print data with 2 digits
        i c@ +    \ Sum it up for Checksum
      loop

      negate h.2  \ Write Checksum
      cr
    then

  #16 +loop
  ." :00000001FF" cr
;

