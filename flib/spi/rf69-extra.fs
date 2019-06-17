\ needs rf69-min.fs

: rf. ( -- )  \ print out all the RF69 registers
  cr 4 spaces  base @ hex  16 0 do space i . loop  base !
  $60 $00 do
    cr
    i h.2 ." :"
    16 0 do  space
      i j + ?dup if rf@ h.2 else ." --" then
    loop
  $10 +loop ;

: rf-listen-i ( -- )  \ report incoming packets until key press
  0 rf.last !
  begin
    rf-recv ?dup if
      ." RF69 " rf-info
      dup 0 do
        rf.buf i + c@ h.2
        i 1 = if 2- h.2 space then
      loop  cr
    then
  key? until ;

: rf-listen ( -- )  \ init RFM69 and then listen
  rf-init cr   rf-listen-i ;

: enckey s" beleampanchineto" drop ;

: rf-listen-enc ( -- )  \ init RFM69 and then listen (encrypted version)
  rf-init cr   enckey rf-encrypt   rf-listen-i ;

: rf-txtest ( n -- )  \ send out a test packet with the number as ASCII chars
  rf-init   16 rf-power   0 <# #s #> 0 rf-send ;

: rf-txtest-enc ( n -- )  \ send out a test packet with the number as ASCII chars (encrypted version)
  rf-init   16 rf-power   enckey rf-encrypt   0 <# #s #> 0 rf-send ;

\ rf.
\ rf-listen
\ 12345 rf-txtest
