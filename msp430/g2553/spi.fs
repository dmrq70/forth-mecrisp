\ MSP430(G2553) SPI driver
\   uses USCI_B0 (P1.5 SCK, P1.6 MISO, P1.7 MOSI) {because USCI_A0 is used for USART}
\   2019 flabbergast
\   from templates/g2553-spi.fs with g2553/spi.tmplfill
\   hardcoded P2.0 for CS

: +spi ( -- ) 1 $29 cbic! ; \ select SPI \ (1:SPIPIN) \ (P2OUT:SPIOUT) \ ($29:P2OUT)
: -spi ( -- ) 1 $29 cbis! ; \ deselect SPI \ (1:SPIPIN) \ (P2OUT:SPIOUT) \ ($29:P2OUT)

: >spi> ( c -- c )  \ hardware SPI, 1 byte in, 1 byte out
    begin %1000 $003 bit@ until  \ TXbuf ready? \ (%1000:IFG2_UCB0TXIFG) \ ($003:IFG2)
    $6F c!  \ send byte (UCB0TXBUF)
    begin %0100 $003 bit@ until  \ RXbuf ready? \ (%0100:IFG2_UCB0RXIFG) \ ($003:IFG2)
    $06E c@  \ read byte \ ($06E:UCB0RXBUF)
    ;

\ single byte shortcuts
: spi> ( -- c ) 0 >spi> ;    \ read byte from SPI
: >spi ( c -- ) >spi> drop ; \ write byte to SPI

: spi-init ( -- )  \ set up hardware SPI
    -spi  1 $2A cbis!   \ setup CS pin \ (1:SPIPIN) \ (P2DIR:SPIDIR) \ ($2A:P2DIR)
    %11100000 $26 cbis!    \ setup SCK|MISO|MOSI pins \ (%11100000:SPISELBITS) \ (P1SEL:SPISEL) \ ($26:P1SEL)
    %11100000 $41 cbis!    \ setup SCK|MISO|MOSI pins \ (%11100000:SPISELBITS) \ (P1SEL2:SPISEL2) \ ($41:P1SEL2)
    1 $069 c!               \ put USCI in reset (UCSWRST) \ ($069:UCB0CTL1)
    %10101001 $068 c!       \ 3-pin 8-bit SPI master (UCCKPH|UCMSB|UCMST|UCSYNC) \ ($068:UCB0CTL0)
    %11000000 $069 cbis!    \ clock source SMCLK (UCSSELx) \ ($069:UCB0CTL1)
    2 $06A c! 0 $06B c!   \ prescaler /8 \ ($06B:UCB0BR1) \ ($06A:UCB0BR0)
    1 $069 cbic!            \ init USCI (UCSWRST) \ ($069:UCB0CTL1)
    ;

