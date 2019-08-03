\ MSP430(G2553) SPI driver
\   uses USCI_B0 (P1.5 SCK, P1.6 MISO, P1.7 MOSI) {because USCI_A0 is used for USART}
\   2019 flabbergast

: +spi ( -- ) SPIPIN SPIOUT cbic! ; \ select SPI
: -spi ( -- ) SPIPIN SPIOUT cbis! ; \ deselect SPI

: >spi> ( c -- c )  \ hardware SPI, 1 byte in, 1 byte out
    begin IFG2_UCB0TXIFG IFG2 bit@ until  \ TXbuf ready?
    $6F c!  \ send byte (UCB0TXBUF)
    begin IFG2_UCB0RXIFG IFG2 bit@ until  \ RXbuf ready?
    UCB0RXBUF c@  \ read byte
    ;

\ single byte shortcuts
: spi> ( -- c ) 0 >spi> ;    \ read byte from SPI
: >spi ( c -- ) >spi> drop ; \ write byte to SPI

: spi-init ( -- )  \ set up hardware SPI
    -spi  SPIPIN SPIDIR cbis!   \ setup CS pin
    SPISELBITS SPISEL  cbis!    \ setup SCK|MISO|MOSI pins
    SPISELBITS SPISEL2 cbis!    \ setup SCK|MISO|MOSI pins
    1 UCB0CTL1 c!               \ put USCI in reset (UCSWRST)
    %10101001 UCB0CTL0 c!       \ 3-pin 8-bit SPI master (UCCKPH|UCMSB|UCMST|UCSYNC)
    %11000000 UCB0CTL1 cbis!    \ clock source SMCLK (UCSSELx)
    2 UCB0BR0 c! 0 UCB0BR1 c!   \ prescaler /8
    1 UCB0CTL1 cbic!            \ init USCI (UCSWRST)
    ;

