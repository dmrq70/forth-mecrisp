\ generated from template: ./templates/replace_constants.py templates/i2c-bb-base.fs fr2476/i2c-bb-base.tmplfill fr2476/port-regs.fs
\ bit-banged i2c driver, base words
\ There have to be 1..10 kΩ resistors on SDA and SCL to pull them up to idle state.
\ Master only. Supports clock stretching.
\ 270 bytes flash

: 0>scl ( -- ) \ drive SCL low
  %00000010 $0243 cbic! \ (%00000010:SCLPIN) \ (P6OUT:SCLOUT) \ ($0243:P6OUT)
  ;

: 1>scl ( -- ) \ drive SCL high
  %00000010 $0243 cbis! \ (%00000010:SCLPIN) \ (P6OUT:SCLOUT) \ ($0243:P6OUT)
  ;

: 1>scl-s ( -- ) \ SCL high, stretching allowed
  %00000010 $0245 cbic! \ SCL input \ (%00000010:SCLPIN) \ (P6DIR:SCLDIR) \ ($0245:P6DIR)
  1>scl  \ clear pulling down
  begin %00000010 $0241 cbit@ until \ clock stretching to finish \ (%00000010:SCLPIN) \ (P6IN:SCLIN) \ ($0241:P6IN)
  %00000010 $0245 cbis! \ SCL output \ (%00000010:SCLPIN) \ (P6DIR:SCLDIR) \ ($0245:P6DIR)
  ;

: >sda ( f -- ) \ write f to SDA line
  dup
  %00000100 $0243 rot if cbis! else cbic! then \ (%00000100:SDAPIN) \ (P6OUT:SDAOUT) \ ($0243:P6OUT)
  %00000100 $0245 rot if cbic! else cbis! then \ release to input when 1 \ (%00000100:SDAPIN) \ (P6DIR:SDADIR) \ ($0245:P6DIR)
  ;

: sda> ( -- f ) \ read status of SDA line
  %00000100 $0241 c@ and 0<> \ (%00000100:SDAPIN) \ (P6IN:SDAIN) \ ($0241:P6IN)
  ;

: i2c-init ( -- )  \ initialise bit-banged I2C
  %00000010 $0245 cbis!  \ SCL output \ (%00000010:SCLPIN) \ (P6DIR:SCLDIR) \ ($0245:P6DIR)
  1>scl
  %00000100 $0245 cbic!  \ SDA input \ (%00000100:SDAPIN) \ (P6DIR:SDADIR) \ ($0245:P6DIR)
  ;

: i2c-half ( -- )  \ half-cycle timing delay for I2C
  50 0 do loop  ;  \ ? inline
