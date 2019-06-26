\ bit-banged i2c driver, base words
\ There have to be 1..10 kΩ resistors on SDA and SCL to pull them up to idle state.
\ Master only. Supports clock stretching.
\ hardcoded SCL:P2.4 SDA:P2.5
\ 270 bytes flash

: 0>scl ( -- ) \ drive SCL low
  %00010000 $29 cbic! \ (P2OUT)
  ;

: 1>scl ( -- ) \ drive SCL high
  %00010000 $29 cbis! \ (P2OUT)
  ;

: 1>scl-s ( -- ) \ SCL high, stretching allowed
  %00010000 $2A cbic! \ SCL input
  1>scl  \ clear pulling down (P2DIR)
  begin %00010000 $28 cbit@ until \ clock stretching to finish (P2IN)
  %00010000 $2A cbis! \ SCL output (P2DIR)
  ;

: >sda ( f -- ) \ write f to SDA line
  dup
  %00100000 $29 rot if cbis! else cbic! then \ (P2OUT)
  %00100000 $2A rot if cbic! else cbis! then \ release to input when 1 (P2DIR)
  ;

: sda> ( -- f ) \ read status of SDA line
  %00100000 $28 c@ and 0<> \ (P2IN)
  ;

: i2c-init ( -- )  \ initialise bit-banged I2C
  %00010000 $2A cbis!  \ SCL output (P2DIR)
  1>scl
  %00100000 $2A cbic!  \ SDA input (P2DIR)
  ;

: i2c-half ( -- )  \ half-cycle timing delay for I2C
  50 0 do loop  ;  \ ? inline

