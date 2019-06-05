\ interface with INA219 current sensor
\ needs i2c

<<<core>>>
compiletoflash

[ifndef] INA.ADDR  $40 constant INA.ADDR  [then]

: ina-writereg ( reg $xxxx -- nak )
  dup $ff and swap 8 rshift rot
  INA.ADDR i2c-addr >i2c >i2c >i2c 0 i2c-xfer ;

: ina-reset ( -- )
  $00 $8000 ina-writereg drop ;

: ina-readfast INA.ADDR i2c-addr >i2c 2 i2c-xfer drop i2c> 8 lshift i2c> or ;
: ina.  $00 ina-readfast hex . decimal ;
: ina-cal. $05 ina-readfast hex . decimal ;

: ina-readreg ( reg -- $xxxx )
  INA.ADDR i2c-addr >i2c 2 i2c-xfer drop
  3 ms \ wait for the conversion to happen
  i2c> 8 lshift i2c> or ;

\ for the config calculation see adafruit_ina219 arduino library
\ or the datasheet

1 variable ina-curdiv

: ina-calib-32v-2a ( -- )
  10 ina-curdiv !
  $05 4096 ina-writereg drop \ INA_REG_CALIBRATION
  $00 \ INA_REG_CONFIG
    $3C1F \ INA_CFG_BVOLTAGERANGE_32V | INA_CFG_GAIN_8_320MV | INA_CFG_BADCRES_12BIT | INA_CFG_SADCRES_12BIT_1S_532US | INA_CFG_MODE_SANDBVOLT_CONTINUOUS
    ina-writereg drop ;

: ina-calib-32v-1a ( -- )
  25 ina-curdiv !
  $05 10240 ina-writereg drop \ INA_REG_CALIBRATION
  $00 \ INA_REG_CONFIG
    $3C1F \ INA_CFG_BVOLTAGERANGE_32V | INA_CFG_GAIN_8_320MV | INA_CFG_BADCRES_12BIT | INA_CFG_SADCRES_12BIT_1S_532US | INA_CFG_MODE_SANDBVOLT_CONTINUOUS
    ina-writereg drop ;

: ina-calib-16v-400ma ( -- )
  20 ina-curdiv !
  $05 8192 ina-writereg drop \ INA_REG_CALIBRATION
  $00 \ INA_REG_CONFIG
    \ $41F \ INA_CFG_BVOLTAGERANGE_16V | INA_CFG_GAIN_1_40MV | INA_CFG_BADCRES_12BIT | INA_CFG_SADCRES_12BIT_1S_532US | INA_CFG_MODE_SANDBVOLT_CONTINUOUS
    $457 \ INA_CFG_BVOLTAGERANGE_16V | INA_CFG_GAIN_1_40MV | INA_CFG_BADCRES_12BIT | INA_CFG_SADCRES_12BIT_4S_2130US | INA_CFG_MODE_SANDBVOLT_CONTINUOUS
    ina-writereg drop ;

: ina-init ( -- )
  i2c-init ina-calib-16v-400ma ;

: ina-busvolt-raw ( -- $xxxx )
  $02 ina-readreg \ INA_REG_BUSVOLTAGE
  3 rshift 2 lshift ;

: ina-shuntvolt-raw ( -- $xxxx )
  $01 ina-readreg ; \ INA_REG_SHUNTVOLTAGE

: ina-curr-raw ( -- $xxxx )
  $04 ina-readreg ; \ INA_REG_CURRENT

: ina-shunt ( -- ) \ +- 327mV
  ina-shuntvolt-raw 0 swap 100,0 f/
  cr ." Shunt voltage (+-327mV) " 2 f.n ." mV" ;

: ina-bus ( -- )
  ina-busvolt-raw 0 swap 1000,0 f/
  cr ." Bus voltage " 3 f.n ." V" ;

: ina-load ( -- )
  ina-busvolt-raw ina-shuntvolt-raw 100 / +
  0 swap 1000,0 f/
  cr ." Load voltage " 3 f.n ." V" ;

: ina-cur ( -- )
  ina-curr-raw 0 swap 0 ina-curdiv @ f/
  cr ." Current " 2 f.n ." mA" ;

: help ( -- ) cr \ print out some help
." INA219 board usage" cr
." ina-init ina-reset ina-calib-32v-2a ina-calib-32v-1a ina-calib-16v-400ma" cr
." ina. (reads reg 0, should give 399F on reset) ina-cal. (reads reg 5)" cr
." ina-shunt ina-bus ina-load ina-cur" cr
." internal fn: ina-busvolt-raw ina-shuntvolt-raw ina-curr-raw" cr
." internal var: ina-curdiv" cr
." Connect: Vin+ to power source, Vin- to device" cr
;

compiletoram

\ $00   constant INA_REG_CONFIG
\ $01   constant INA_REG_SHUNTVOLTAGE
\ $02   constant INA_REG_BUSVOLTAGE
\ $03   constant INA_REG_POWER
\ $04   constant INA_REG_CURRENT
\ $05   constant INA_REG_CALIBRATION
\ 
\ $8000 constant INA_CFG_RESET                      \ Reset Bit
\ 
\ $2000 constant INA_CFG_BVOLTAGERANGE_MASK         \ Bus Voltage Range Mask
\ $0000 constant INA_CFG_BVOLTAGERANGE_16V          \ 0-16V Range
\ $2000 constant INA_CFG_BVOLTAGERANGE_32V          \ 0-32V Range
\ 
\ $1800 constant INA_CFG_GAIN_MASK                  \ Gain Mask
\ $0000 constant INA_CFG_GAIN_1_40MV                \ Gain 1, 40mV Range
\ $0800 constant INA_CFG_GAIN_2_80MV                \ Gain 2, 80mV Range
\ $1000 constant INA_CFG_GAIN_4_160MV               \ Gain 4, 160mV Range
\ $1800 constant INA_CFG_GAIN_8_320MV               \ Gain 8, 320mV Range
\ 
\ $0780 constant INA_CFG_BADCRES_MASK               \ Bus ADC Resolution Mask
\ $0080 constant INA_CFG_BADCRES_9BIT               \ 9-bit bus res = 0..511
\ $0100 constant INA_CFG_BADCRES_10BIT              \ 10-bit bus res = 0..1023
\ $0200 constant INA_CFG_BADCRES_11BIT              \ 11-bit bus res = 0..2047
\ $0400 constant INA_CFG_BADCRES_12BIT              \ 12-bit bus res = 0..4097
\ 
\ $0078 constant INA_CFG_SADCRES_MASK               \ Shunt ADC Resolution and Averaging Mask
\ $0000 constant INA_CFG_SADCRES_9BIT_1S_84US       \ 1 x 9-bit shunt sample
\ $0008 constant INA_CFG_SADCRES_10BIT_1S_148US     \ 1 x 10-bit shunt sample
\ $0010 constant INA_CFG_SADCRES_11BIT_1S_276US     \ 1 x 11-bit shunt sample
\ $0018 constant INA_CFG_SADCRES_12BIT_1S_532US     \ 1 x 12-bit shunt sample
\ $0048 constant INA_CFG_SADCRES_12BIT_2S_1060US    \ 2 x 12-bit shunt samples averaged together
\ $0050 constant INA_CFG_SADCRES_12BIT_4S_2130US    \ 4 x 12-bit shunt samples averaged together
\ $0058 constant INA_CFG_SADCRES_12BIT_8S_4260US    \ 8 x 12-bit shunt samples averaged together
\ $0060 constant INA_CFG_SADCRES_12BIT_16S_8510US   \ 16 x 12-bit shunt samples averaged together
\ $0068 constant INA_CFG_SADCRES_12BIT_32S_17MS     \ 32 x 12-bit shunt samples averaged together
\ $0070 constant INA_CFG_SADCRES_12BIT_64S_34MS     \ 64 x 12-bit shunt samples averaged together
\ $0078 constant INA_CFG_SADCRES_12BIT_128S_69MS    \ 128 x 12-bit shunt samples averaged together
\ 
\ $0007 constant INA_CFG_MODE_MASK                  \ Operating Mode Mask
\ $0000 constant INA_CFG_MODE_POWERDOWN
\ $0001 constant INA_CFG_MODE_SVOLT_TRIGGERED
\ $0002 constant INA_CFG_MODE_BVOLT_TRIGGERED
\ $0003 constant INA_CFG_MODE_SANDBVOLT_TRIGGERED
\ $0004 constant INA_CFG_MODE_ADCOFF
\ $0005 constant INA_CFG_MODE_SVOLT_CONTINUOUS
\ $0006 constant INA_CFG_MODE_BVOLT_CONTINUOUS
\ $0007 constant INA_CFG_MODE_SANDBVOLT_CONTINUOUS

