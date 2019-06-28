: rf-encrypt ( addr -- ) \ load 16 bytes as AES password, enable encryption
  RF:AES 16 + RF:AES do  \ loop by register addr
    dup c@ dup i rf!  \ write one, leave ( addr b )
    if 1+ then  \ if b <> 0, advance addr
    loop drop
  RF:PCONF2 rf@ 1 or  RF:PCONF2 rf! ;

: rf-deencrypt ( -- ) \ clear encryption
  RF:PCONF2 rf@ $FE and  RF:PCONF2 rf! ;

: enckey s" echolocatingbat3" drop ;

: rf-listen-enc ( -- )  \ init RFM69 and then listen (encrypted version)
  rf-init cr   enckey rf-encrypt
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

: rf-txtest-enc ( n -- )  \ send out a test packet with the number as ASCII chars (encrypted version)
  rf-init   16 rf-power   enckey rf-encrypt   0 <# #s #> 0 rf-send ;

