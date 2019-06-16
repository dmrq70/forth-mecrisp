\ basis: always want this
\ currently takes 512 bytes of flash (note that cornerstone always bumps up to a multiple of 256)

compiletoflash

: cornerstone ( Name ) ( -- )
  <builds begin here $1FF and while 0 , repeat
  does>   begin dup  $1FF and while 1+  repeat eraseflashfrom
;

: init \ Launchpad hardware initialisations
  ." free(flash ram): " $D400 compiletoflash here compiletoram - . flashvar-here here - . cr
  8 $21 cbis! \ High  (P1OUT)
  8 $27 cbis! \ Pullup for button  (P1REN)
  \ 1 64 or $21 cbic! \ LEDs off  (P1OUT)
  \ 1 64 or $22 cbis! \ LEDs are outputs  (P1DIR)
  1 $21 cbic! \ red LED off  (P1OUT)
  1 $22 cbis! \ red LED is output  (P1DIR)  \ P1.6 is MISO 
;

\ Measure Vcc/2 on analog channel 11 with 2.5V reference.
: vcc. 0  11 analog  204,6 f/ 2 f.n ." V " ; 

: delayticks ( ticks -- ) \ Wait desired number of ticks with 32768 Hz.
\ Second Timer, free
  ['] wakeup irq-timerb0 ! \ Set Wakeup-Interrupt
  $10  $0182 ! \ Enable Interrupt
  0    $0190 ! \ Clear TAR
       $0192 ! \ Set desired delay
  $110 $0180 ! \ ACLK, Up-Mode
  lpm3         \ Sleep in LPM3
  0 $180 !     \ Stop Timer
;

: ms ( ms -- ) 32768 1000 u*/ delayticks ; \ Maximum is about 1000 ms

: h.2 ( c -- ) base @ hex swap 0 <# # # #> type base ! ; \ Print 2 digits hex

\ include SPI driver (on USCI_B0 (P1.5 SCK, P1.6 MISO, P1.7 MOSI); P2.0 CS)

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
    2 $6A c! 0 $6B c! \ prescaler /2  (UCB0BR0, UCB0BR1)
    1 $69 cbic! \ leave reset, initialize USCI state machine  (UCSWRST @ UCB0CTL1)
    ;

\ Ports

$20 constant P1IN
$21 constant P1OUT
$22 constant P1DIR
$23 constant P1IFG
$24 constant P1IES
$25 constant P1IE
$26 constant P1SEL
$27 constant P1REN
$41 constant P1SEL2

$28 constant P2IN
$29 constant P2OUT
$2A constant P2DIR
$2B constant P2IFG
$2C constant P2IES
$2D constant P2IE
$2E constant P2SEL
$2F constant P2REN
$42 constant P2SEL2

cornerstone <<basis>>
compiletoram
