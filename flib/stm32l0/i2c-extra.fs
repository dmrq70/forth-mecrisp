\ hardware i2c driver / convenience functions
\ from jcw's embello

$40005400 constant I2C1
     I2C1 $00 + constant I2C1-CR1
     I2C1 $04 + constant I2C1-CR2
\    I2C1 $08 + constant I2C1-OAR1
\    I2C1 $0C + constant I2C1-OAR2
     I2C1 $10 + constant I2C1-TIMINGR
\    I2C1 $14 + constant I2C1-TIMEOUTR
     I2C1 $18 + constant I2C1-ISR
     I2C1 $1C + constant I2C1-ICR
\    I2C1 $20 + constant I2C1-PXCR
     I2C1 $24 + constant I2C1-RXDR
     I2C1 $28 + constant I2C1-TXDR


: i2c? ( -- )
  I2C1
  cr ."       CR1 " dup @ hex. 4 +
          ."  CR2 " dup @ hex. 4 +
         ."  OAR1 " dup @ h.4 space 4 +
         ."  OAR2 " dup @ h.4 space 4 +
      ."  TIMINGR " dup @ hex. 4 +
  cr ."  TIMEOUTR " dup @ hex. 4 +
          ."  ISR " dup @ hex. 4 +
         ."   ICR " dup @ h.4 space 4 +
         ."  PXCR " dup @ h.2 space 4 +
       ."    RXDR " dup @ h.2 space 4 +
         ."  TXDR " dup @ h.2 space drop ;

: i2c. ( -- )  \ scan and report all I2C devices on the bus
  128 0 do
    cr i h.2 ." :"
    16 0 do  space
      i j +
      dup $08 < over $77 > or if drop 2 spaces else
        dup i2c-addr  0 i2c-xfer  if drop ." --" else h.2 then
      then
    loop
  16 +loop ;
