\ crc8
\ by flabbergast
\ crc8 with fixed polynomial, hardcoded (to $31 = %00110001 (x^8+x^5+x^4+1))

\ basic implementation, bit-by-bit (should work on 16bit forth)
: crc8 ( char char -- char ) \ initial new -> crc
  xor 8 lshift
  8 0 do
    dup  $8000 and 0<> if
      $131 7 lshift  xor then
    shl
  loop
  8 rshift ;
