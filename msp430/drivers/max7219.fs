\ Drive 8x8 LED matrix with MAX7219 display chip
\ needs spi.fs
\  by flabbergast
\  largely from flashforth5 tutorial guide

: m-send ( c c -- ) swap +spi >spi >spi -spi ;
: d.normal ( -- ) $0c $01 m-send ;
: d.shutdown ( -- ) $0c $00 m-send ;
: d.test.on ( -- ) $0f $01 m-send ;
: d.test.off ( -- ) $0f $00 m-send ;
: d.noop ( -- ) $00 $00 m-send ;
: d.intensity ( c -- ) $0a swap m-send ;
: d.decode ( c -- ) $09 swap m-send ;
: d.scan.limit ( c -- ) $0b swap m-send ;
: d.set.digit ( cbits cdigit -- ) swap m-send ;

: d.test1 ( -- ) \ everything on
  spi-init d.test.on
  begin key? until
  d.test.off
  ;

: d.test2 ( -- ) \ left 4 LEDs on 1st row
  spi-init d.normal
  $03 d.intensity $00 d.scan.limit
  $f0 $01 d.set.digit
  begin key? until
  d.shutdown
  ;

: d.test3 ( -- ) \ face
  spi-init d.normal
  $01 d.intensity $07 d.scan.limit
  %00000000 $01 d.set.digit
  %01100110 $02 d.set.digit
  %00000000 $03 d.set.digit
  %00011000 $04 d.set.digit
  %00011000 $05 d.set.digit
  %10000001 $06 d.set.digit
  %01000010 $07 d.set.digit
  %00111100 $08 d.set.digit
  begin key? until
  d.shutdown
  ;

