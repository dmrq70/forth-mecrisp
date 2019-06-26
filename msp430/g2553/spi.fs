\ MSP430(G2553) SPI driver
\   uses USCI_B0 (P1.5 SCK, P1.6 MISO, P1.7 MOSI) {because USCI_A0 is used for USART}
\   hardcoded P2.0 for CS
\   (c) 2019 flabbergast

\ registers, ref man p444
\ UCB0CTL0 068h
\ UCB0CTL1 069h
\ UCB0BR0 06Ah
\ UCB0BR1 06Bh
\ UCB0STAT 06Dh
\ UCB0RXBUF 06Eh
\ UCB0TXBUF 06Fh
\ IE2 001h
\ IFG2 003h

: +spi ( -- ) 1 $29 cbic! ; \ select SPI  (P2OUT)
: -spi ( -- ) 1 $29 cbis! ; \ deselect SPI  (P2OUT)

: >spi> ( c -- c )  \ hardware SPI, 1 byte in, 1 byte out
    begin %1000 $03 bit@ until  \ TXbuf ready? (UCB0TXIFG @ IFG2)
    $6F c!  \ send byte (UCB0TXBUF)
    begin %0100 $03 bit@ until  \ RXbuf ready? (UCB0RXIFG @ IFG2)
    $6E c@  \ read byte (UCB0RXBUF)
    ;

\ single byte shortcuts
: spi> ( -- c ) 0 >spi> ;    \ read byte from SPI
: >spi ( c -- ) >spi> drop ; \ write byte to SPI

: spi-init ( -- )  \ set up hardware SPI
    -spi  1 $2A cbis!   \ setup CS pin  (P2DIR)
    %11100000 $26 cbis!  %11100000 $41 cbis!  \ setup SCK|MISO|MOSI pins  (P1SEL, P1SEL2)
    1 $69 c! \ put USCI in reset  (UCSWRST @ UCB0CTL1)
    %10101001 $68 c! \ 3-pin 8-bit SPI master  (UCCKPH|UCMSB|UCMST|UCSYNC @ UCB0CTL0)
    %11000000 $69 cbis! \ clock source SMCLK  (UCSSELx @ UCB0CTL1)
    2 $6A c! 0 $6B c! \ prescaler /8  (UCB0BR0, UCB0BR1)
    1 $69 cbic! \ leave reset, initialize USCI state machine  (UCSWRST @ UCB0CTL1)
    ;

