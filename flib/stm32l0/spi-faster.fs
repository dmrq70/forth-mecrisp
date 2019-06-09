\ hardware SPI driver / alternative basic functions: faster

[ifndef] ssel  PA4 variable ssel  [then]  \ can be changed at run time
[ifndef] SCLK  PA5 constant SCLK  [then]
[ifndef] MISO  PA6 constant MISO  [then]
[ifndef] MOSI  PA7 constant MOSI  [then]

0 variable ssel.addr \ address where to toggle chip select
0 variable ssel.bit  \ bitmask to toggle for chip select

$40013000 constant SPI1
     SPI1 $00 + constant SPI1-CR1
     SPI1 $04 + constant SPI1-CR2
     SPI1 $08 + constant SPI1-SR
     SPI1 $0C + constant SPI1-DR
\    SPI1 $10 + constant SPI1-CRCPR
\    SPI1 $14 + constant SPI1-RXCRCR
\    SPI1 $18 + constant SPI1-TXCRCR

\ : +spi ( -- ) ssel @ ioc! ;  \ select SPI
\ : -spi ( -- ) ssel @ ios! ;  \ deselect SPI
\ faster:
: +spi ( -- ) $10000 ssel.bit @ lshift ssel.addr @ ! inline ;  \ select SPI
: -spi ( -- )      1 ssel.bit @ lshift ssel.addr @ ! inline ;  \ deselect SPI

: >spi> ( c -- c )  \ hardware SPI, 8 bits
  SPI1-DR !  begin SPI1-SR @ 1 and until  SPI1-DR @ ;

\ single byte transfers
: spi> ( -- c ) 0 >spi> ;     \ read byte from SPI
: >spi ( c -- ) >spi> drop ;  \ write byte to SPI

\ ===== initialization

: fix-ssel ( -- ) \ internal to calculate ssel.bit & ssel.addr
  ssel @
  dup OMODE-PP swap io-mode!
  dup io-base GPIO.BSRR + ssel.addr !
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

  12 bit RCC-APB2ENR bis!  \ set SPI1EN
  %0000001101000100 SPI1-CR1 !  \ clk/2, i.e. 8 MHz, master
  SPI1-SR @ drop  \ appears to be needed to avoid hang in some cases
  2 bit SPI1-CR2 bis!  \ SS output enable
;
