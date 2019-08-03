\ USCI registers
\ G2553 datasheet, p19

$001 constant IE2
$003 constant IFG2

%0001 constant IFG2_UCA0RXIFG
%0010 constant IFG2_UCA0TXIFG
%0100 constant IFG2_UCB0RXIFG
%1000 constant IFG2_UCB0TXIFG

$05D constant UCA0ABCTL
$05E constant UCA0IRTCTL
$05F constant UCA0IRRCTL
$060 constant UCA0CTL0
$061 constant UCA0CTL1
$062 constant UCA0BR0
$063 constant UCA0BR1
$064 constant UCA0MCTL
$065 constant UCA0STAT
$066 constant UCA0RXBUF
$067 constant UCA0TXBUF

$068 constant UCB0CTL0
$069 constant UCB0CTL1
$06A constant UCB0BR0
$06B constant UCB0BR1
$06C constant UCB0CIE
$06D constant UCB0STAT
$06E constant UCB0RXBUF
$06F constant UCB0TXBUF
$118 constant UCB0OA
$11A constant USB0SA
