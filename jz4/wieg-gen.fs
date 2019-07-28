PA9 constant W0
PA10 constant W1

: setup ( -- )
  OMODE-PP W0 io-mode!
  OMODE-PP W1 io-mode!
  W0 ios! W1 ios!
  ;

: out ( c-addr len -- )
  0 do
    dup i + c@
    [char] 1 = if W1 else W0 then
    dup ioc!
    50 us
    ios!
    2 ms
    loop drop
  20 ms
  ;

: code s" 10000010001100000001000101" ;

