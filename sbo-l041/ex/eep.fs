
: testread $50 i2c-addr 0 >i2c 0 >i2c 0 i2c-xfer 3 i2c-xfer i2c> i2c> i2c> ;
: testwrite $50 i2c-addr 0 >i2c 0 >i2c 1 >i2c 2 >i2c 0 i2c-xfer ;

