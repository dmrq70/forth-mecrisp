: rf-encrypt ( addr -- ) \ load 16 bytes as AES password
  RF:AES 16 + RF:AES do  \ loop by register addr
    dup c@ dup i rf!  \ write one, leave ( addr b )
    if 1+ then  \ if b <> 0, advance addr
    loop drop
  RF:PCONF2 rf@ 1 or  RF:PCONF2 rf! ;

: rf-deencrypt ( -- ) \ clear encryption
  RF:PCONF2 rf@ $FE and  RF:PCONF2 rf! ;

: enckey c" beleampanchineto" ;  \ one byte wasted (count)

: rf-listen2 ( -- )  \ init RFM69 and report incoming packets until key press
  rf-init cr
  enckey 1+ rf-encrypt
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


: rf-txtest2 ( n -- )  \ send out a test packet with the number as ASCII chars
  rf-init  16 rf-power enckey 1+ rf-encrypt  0 <# #s #> 0 rf-send ;

