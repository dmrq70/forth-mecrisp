\ generated from template: ../templates/replace_constants.py -i spi.template spi.tmplfill usci-regs.fs port-regs.fs
\ MSP430(G2553) SPI driver
\   uses USCI_B0 (P1.5 SCK, P1.6 MISO, P1.7 MOSI) {because USCI_A0 is used for USART}
\   2019 flabbergast

: +spi ( -- ) 1 ( SPIPIN ) $29 ( P2OUT ) ( SPIOUT ) cbic! ; \ select SPI
: -spi ( -- ) 1 ( SPIPIN ) $29 ( P2OUT ) ( SPIOUT ) cbis! ; \ deselect SPI

: >spi> ( c -- c )  \ hardware SPI, 1 byte in, 1 byte out
    begin %1000 ( IFG2_UCB0TXIFG ) $003 ( IFG2 ) bit@ until  \ TXbuf ready?
    $6F c!  \ send byte (UCB0TXBUF)
    begin %0100 ( IFG2_UCB0RXIFG ) $003 ( IFG2 ) bit@ until  \ RXbuf ready?
    $06E ( UCB0RXBUF ) c@  \ read byte
    ;

\ single byte shortcuts
: spi> ( -- c ) 0 >spi> ;    \ read byte from SPI
: >spi ( c -- ) >spi> drop ; \ write byte to SPI

: spi-init ( -- )  \ set up hardware SPI
    -spi  1 ( SPIPIN ) $2A ( P2DIR ) ( SPIDIR ) cbis!   \ setup CS pin
    %11100000 ( SPISELBITS ) $26 ( P1SEL ) ( SPISEL )  cbis!    \ setup SCK|MISO|MOSI pins
    %11100000 ( SPISELBITS ) $41 ( P1SEL2 ) ( SPISEL2 ) cbis!    \ setup SCK|MISO|MOSI pins
    1 $069 ( UCB0CTL1 ) c!               \ put USCI in reset (UCSWRST)
    %10101001 $068 ( UCB0CTL0 ) c!       \ 3-pin 8-bit SPI master (UCCKPH|UCMSB|UCMST|UCSYNC)
    %11000000 $069 ( UCB0CTL1 ) cbis!    \ clock source SMCLK (UCSSELx)
    2 $06A ( UCB0BR0 ) c! 0 $06B ( UCB0BR1 ) c!   \ prescaler /8
    1 $069 ( UCB0CTL1 ) cbic!            \ init USCI (UCSWRST)
    ;

