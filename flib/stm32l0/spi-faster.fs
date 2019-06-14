\ hardware SPI driver / alternative basic functions: faster

[ifndef] ssel  PA4 variable ssel  [then]  \ can be changed at run time
[ifndef] SCLK  PA5 constant SCLK  [then]
[ifndef] MISO  PA6 constant MISO  [then]
[ifndef] MOSI  PA7 constant MOSI  [then]

0 variable ssel.addr \ address where to toggle chip select
0 variable ssel.bit  \ bitmask to toggle for chip select

\ : +spi ( -- ) ssel @ ioc! ;  \ select SPI
\ : -spi ( -- ) ssel @ ios! ;  \ deselect SPI
\ faster:
: +spi ( -- ) $10000 ssel.bit @ lshift ssel.addr @ ! inline ;  \ select SPI
: -spi ( -- )      1 ssel.bit @ lshift ssel.addr @ ! inline ;  \ deselect SPI

: >spi> ( c -- c )  \ hardware SPI, 8 bits
  $4001300C !  begin $40013008 @ 1 and until  $4001300C @ ;  \  (SPI1-DR SPI1-SR SPI1-DR)

\ single byte transfers
: spi> ( -- c ) 0 >spi> ;     \ read byte from SPI
: >spi ( c -- ) >spi> drop ;  \ write byte to SPI

\ ===== initialization

: fix-ssel ( -- ) \ internal to calculate ssel.bit & ssel.addr
  ssel @
  dup OMODE-PP swap io-mode!
  dup io-base $18 + ssel.addr !  \  (GPIO.BSRR)
  io# ssel.bit !
  -spi
  ;

: spi!ssel ( ssel -- ) \ set chip-select pin, e.g. "PA4 spi!ssel"
  ssel ! fix-ssel
  ;

: spi-init ( -- )  \ set up hardware SPI
  fix-ssel
  OMODE-AF-PP SCLK   io-mode!
  OMODE-AF-PP MISO   io-mode!
  OMODE-AF-PP MOSI   io-mode!

  12 bit $40021034 bis!  \ set SPI1EN  (RCC-APB2ENR)
  %0000001101000100 $40013000 !  \ clk/2, i.e. 8 MHz, master  (SPI1-CR1)
  $40013008 @ drop  \ appears to be needed to avoid hang in some cases  (SPI1-SR)
  2 bit $40013004 bis!  \ SS output enable  (SPI1-CR2)
;
