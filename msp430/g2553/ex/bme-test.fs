include basis-g2553.fs

compiletoflash

include ../flib/g2553/i2c-bb-base.fs
include ../flib/drivers/i2c-bb.fs
include ../flib/drivers/bme280.fs

: ii bme-init-sleep drop bme-calib ;
: id bme-init-sleep bme-waddr $d0 >i2c drop bme-raddr 1 i2c> i2c-stop ;
: m
  bme-convert ms bme-data bme-calc ( h100 dp1 t100 )
  bme-sleep
  . d. .
  ;

\ ii id . m