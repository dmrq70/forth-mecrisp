: i2c. ( -- )  \ scan and report all I2C devices on the bus
  128 0 do
    cr i h.2 ." :"
    16 0 do  space
      i j +
      dup $08 < over $77 > or if drop 2 spaces else
        dup shl i2c-start >i2c i2c-stop  if drop ." --" else h.2 then
      then
    loop
  16 +loop ;


