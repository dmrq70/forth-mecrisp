\ hardware SPI driver / basic functions
\ based upon jcw's embello

: +spi ( -- ) ssel @ ioc! ;  \ select SPI
: -spi ( -- ) ssel @ ios! ;  \ deselect SPI

: >spi> ( c -- c )  \ hardware SPI, 8 bits
  $4001300C !  begin $40013008 @ 1 and until  $4001300C @ ;  \  (SPI1-DR SPI1-SR SPI1-DR)

\ single byte transfers
: spi> ( -- c ) 0 >spi> ;     \ read byte from SPI
: >spi ( c -- ) >spi> drop ;  \ write byte to SPI

\ ===== initialization

: spi-init ( -- )  \ set up hardware SPI
  OMODE-PP    ssel @ io-mode!
  -spi
  OMODE-AF-PP SCLK   io-mode!
  OMODE-AF-PP MISO   io-mode!
  OMODE-AF-PP MOSI   io-mode!

  12 bit $40021034 bis!  \ set SPI1EN  (RCC-APB2ENR)
  %0000001101000100 $40013000 !  \ clk/2, i.e. 8 MHz, master  (SPI1-CR1)
  $40013008 @ drop  \ appears to be needed to avoid hang in some cases  (SPI1-SR)
  2 bit $40013004 bis!  \ SS output enable  (SPI1-CR2)
;
