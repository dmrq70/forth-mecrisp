\ bit-banged i2c driver, base words
\ There have to be 1..10 kΩ resistors on SDA and SCL to pull them up to idle state.
\ Master only. Supports clock stretching.
\ 270 bytes flash

: 0>scl ( -- ) \ drive SCL low
  SCLPIN SCLOUT cbic!
  ;

: 1>scl ( -- ) \ drive SCL high
  SCLPIN SCLOUT cbis!
  ;

: 1>scl-s ( -- ) \ SCL high, stretching allowed
  SCLPIN SCLDIR cbic! \ SCL input
  1>scl  \ clear pulling down
  begin SCLPIN SCLIN cbit@ until \ clock stretching to finish
  SCLPIN SCLDIR cbis! \ SCL output
  ;

: >sda ( f -- ) \ write f to SDA line
  dup
  SDAPIN SDAOUT rot if cbis! else cbic! then
  SDAPIN SDADIR rot if cbic! else cbis! then \ release to input when 1
  ;

: sda> ( -- f ) \ read status of SDA line
  SDAPIN SDAIN c@ and 0<>
  ;

: i2c-init ( -- )  \ initialise bit-banged I2C
  SCLPIN SCLDIR cbis!  \ SCL output
  1>scl
  SDAPIN SDADIR cbic!  \ SDA input
  ;

: i2c-half ( -- )  \ half-cycle timing delay for I2C
  50 0 do loop  ;  \ ? inline
