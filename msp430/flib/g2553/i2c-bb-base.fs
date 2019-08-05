\ generated from template: ./templates/replace_constants.py -i templates/i2c-bb-base.template g2553/i2c-bb-base.tmplfill g2553/port-regs.fs
\ bit-banged i2c driver, base words
\ There have to be 1..10 kΩ resistors on SDA and SCL to pull them up to idle state.
\ Master only. Supports clock stretching.
\ 270 bytes flash

: 0>scl ( -- ) \ drive SCL low
  %00010000 ( SCLPIN ) $29 ( P2OUT ) ( SCLOUT ) cbic!
  ;

: 1>scl ( -- ) \ drive SCL high
  %00010000 ( SCLPIN ) $29 ( P2OUT ) ( SCLOUT ) cbis!
  ;

: 1>scl-s ( -- ) \ SCL high, stretching allowed
  %00010000 ( SCLPIN ) $2A ( P2DIR ) ( SCLDIR ) cbic! \ SCL input
  1>scl  \ clear pulling down
  begin %00010000 ( SCLPIN ) $28 ( P2IN ) ( SCLIN ) cbit@ until \ clock stretching to finish
  %00010000 ( SCLPIN ) $2A ( P2DIR ) ( SCLDIR ) cbis! \ SCL output
  ;

: >sda ( f -- ) \ write f to SDA line
  dup
  %00100000 ( SDAPIN ) $29 ( P2OUT ) ( SDAOUT ) rot if cbis! else cbic! then
  %00100000 ( SDAPIN ) $2A ( P2DIR ) ( SDADIR ) rot if cbic! else cbis! then \ release to input when 1
  ;

: sda> ( -- f ) \ read status of SDA line
  %00100000 ( SDAPIN ) $28 ( P2IN ) ( SDAIN ) c@ and 0<>
  ;

: i2c-init ( -- )  \ initialise bit-banged I2C
  %00010000 ( SCLPIN ) $2A ( P2DIR ) ( SCLDIR ) cbis!  \ SCL output
  1>scl
  %00100000 ( SDAPIN ) $2A ( P2DIR ) ( SDADIR ) cbic!  \ SDA input
  ;

: i2c-half ( -- )  \ half-cycle timing delay for I2C
  50 0 do loop  ;  \ ? inline
