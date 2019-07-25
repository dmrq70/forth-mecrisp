: eep-pre ( addr -- )  i2c-start  $A0 >i2c drop  >i2c drop  ;  \ common preamble
: eep! ( c addr -- )  eep-pre  >i2c drop  i2c-stop ;  \ write c to addr
: eep@ ( addr -- c )  eep-pre  i2c-start  $A1 >i2c drop  1 i2c>  i2c-stop ;  \ read c from addr

