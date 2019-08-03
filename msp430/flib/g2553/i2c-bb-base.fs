\ generated from template: templates/replace_constants.py templates/i2c-bb-base.template g2553/i2c-bb-base.tmplfill g2553/port-regs.fs
\ bit-banged i2c driver, base words
\ There have to be 1..10 kΩ resistors on SDA and SCL to pull them up to idle state.
\ Master only. Supports clock stretching.
\ 270 bytes flash

: 0>scl ( -- ) \ drive SCL low
  %00010000 $29 cbic! \ (%00010000:SCLPIN) \ (P2OUT:SCLOUT) \ ($29:P2OUT)
  ;

: 1>scl ( -- ) \ drive SCL high
  %00010000 $29 cbis! \ (%00010000:SCLPIN) \ (P2OUT:SCLOUT) \ ($29:P2OUT)
  ;

: 1>scl-s ( -- ) \ SCL high, stretching allowed
  %00010000 $2A cbic! \ SCL input \ (%00010000:SCLPIN) \ (P2DIR:SCLDIR) \ ($2A:P2DIR)
  1>scl  \ clear pulling down
  begin %00010000 $28 cbit@ until \ clock stretching to finish \ (%00010000:SCLPIN) \ (P2IN:SCLIN) \ ($28:P2IN)
  %00010000 $2A cbis! \ SCL output \ (%00010000:SCLPIN) \ (P2DIR:SCLDIR) \ ($2A:P2DIR)
  ;

: >sda ( f -- ) \ write f to SDA line
  dup
  %00100000 $29 rot if cbis! else cbic! then \ (%00100000:SDAPIN) \ (P2OUT:SDAOUT) \ ($29:P2OUT)
  %00100000 $2A rot if cbic! else cbis! then \ release to input when 1 \ (%00100000:SDAPIN) \ (P2DIR:SDADIR) \ ($2A:P2DIR)
  ;

: sda> ( -- f ) \ read status of SDA line
  %00100000 $28 c@ and 0<> \ (%00100000:SDAPIN) \ (P2IN:SDAIN) \ ($28:P2IN)
  ;

: i2c-init ( -- )  \ initialise bit-banged I2C
  %00010000 $2A cbis!  \ SCL output \ (%00010000:SCLPIN) \ (P2DIR:SCLDIR) \ ($2A:P2DIR)
  1>scl
  %00100000 $2A cbic!  \ SDA input \ (%00100000:SDAPIN) \ (P2DIR:SDADIR) \ ($2A:P2DIR)
  ;

: i2c-half ( -- )  \ half-cycle timing delay for I2C
  50 0 do loop  ;  \ ? inline
