\ Memory Map file for MSP430FR2433
\ created by svdcutter for Mecrisp Forth by Matthias Koch
\ sdvcutter takes a MSP430xx SVD file created by https://github.com/pftbest/msp430_svd and creates a memmap, register and config.xml file. The config.xml file may be later edited to control the size of the memmap file 
\ By Terry Porter "terry@tjporter.com.au", see attached COPYING.TXT ( BSD License)
\ available forth template words as selected by config.xml

\ ***** PORT_1_2 ***** \
$200  constant  P1IN
$201  constant  P2IN
$202  constant  P1OUT
$203  constant  P2OUT
$204  constant  P1DIR
$205  constant  P2DIR
$206  constant  P1REN
$207  constant  P2REN
$20A  constant  P1SEL0
$20B  constant  P2SEL0
$20C  constant  P1SEL1
$20D  constant  P2SEL1
$218  constant  P1IES
$219  constant  P2IES
$21A  constant  P1IE
$21B  constant  P2IE
$21C  constant  P1IFG
$21D  constant  P2IFG
$20E  constant  P1IV
$21E  constant  P2IV

\ ***** PORT_3 ***** \
$220  constant  P3IN
$222  constant  P3OUT
$224  constant  P3DIR
$226  constant  P3REN
$22A  constant  P3SEL0
$22C  constant  P3SEL1

\ ***** USCI_A0_UART_MODE ***** \
$500  constant  UCA0CTL1
$501  constant  UCA0CTL0
$506  constant  UCA0BR0
$507  constant  UCA0BR1
$50A  constant  UCA0STATW
$510  constant  UCA0ABCTL
$512  constant  UCA0IRTCTL
$513  constant  UCA0IRRCTL
$502  constant  UCA0CTLW1
$508  constant  UCA0MCTLW
$50C  constant  UCA0RXBUF
$50E  constant  UCA0TXBUF
$51E  constant  UCA0IV

\ ***** USCI_A0_SPI_MODE ***** \
$500  constant  UCA0CTL1
$501  constant  UCA0CTL0
$506  constant  UCA0BR0
$507  constant  UCA0BR1
$50A  constant  UCA0STATW
$51A  constant  UCA0IE
$51C  constant  UCA0IFG
$50C  constant  UCA0RXBUF
$50E  constant  UCA0TXBUF
$51E  constant  UCA0IV

\ ***** USCI_A1_UART_MODE ***** \
$520  constant  UCA1CTL1
$521  constant  UCA1CTL0
$526  constant  UCA1BR0
$527  constant  UCA1BR1
$52A  constant  UCA1STATW
$530  constant  UCA1ABCTL
$532  constant  UCA1IRTCTL
$533  constant  UCA1IRRCTL
$522  constant  UCA1CTLW1
$528  constant  UCA1MCTLW
$52C  constant  UCA1RXBUF
$52E  constant  UCA1TXBUF
$53E  constant  UCA1IV

\ ***** USCI_A1_SPI_MODE ***** \
$520  constant  UCA1CTL1
$521  constant  UCA1CTL0
$526  constant  UCA1BR0
$527  constant  UCA1BR1
$52A  constant  UCA1STATW
$53A  constant  UCA1IE
$53C  constant  UCA1IFG
$52C  constant  UCA1RXBUF
$52E  constant  UCA1TXBUF
$53E  constant  UCA1IV

\ ***** USCI_B0_I2C_MODE ***** \
$540  constant  UCB0CTL1
$541  constant  UCB0CTL0
$546  constant  UCB0BR0
$547  constant  UCB0BR1
$548  constant  UCB0STAT
$549  constant  UCB0BCNT
$542  constant  UCB0CTLW1
$54A  constant  UCB0TBCNT
$54C  constant  UCB0RXBUF
$54E  constant  UCB0TXBUF
$554  constant  UCB0I2COA0
$556  constant  UCB0I2COA1
$558  constant  UCB0I2COA2
$55A  constant  UCB0I2COA3
$55C  constant  UCB0ADDRX
$55E  constant  UCB0ADDMASK
$560  constant  UCB0I2CSA
$56A  constant  UCB0IE
$56A  constant  UCB0IE
$56C  constant  UCB0IFG
$56C  constant  UCB0IFG
$56E  constant  UCB0IV

\ ***** USCI_B0_SPI_MODE ***** \
$540  constant  UCB0CTL1
$541  constant  UCB0CTL0
$546  constant  UCB0BR0
$547  constant  UCB0BR1
$54C  constant  UCB0RXBUF
$54E  constant  UCB0TXBUF
$56A  constant  UCB0IE
$56C  constant  UCB0IFG
$56E  constant  UCB0IV

\ ***** SFR ***** \
$100  constant  SFRIE1
$102  constant  SFRIFG1
$104  constant  SFRRPCR

\ ***** PMM ***** \
$120  constant  PMMCTL0
$122  constant  PMMCTL1
$124  constant  PMMCTL2
$12A  constant  PMMIFG
$12E  constant  PMMIE
$130  constant  PM5CTL0

\ ***** SYS ***** \
$140  constant  SYSCTL
$142  constant  SYSBSLC
$146  constant  SYSJMBC
$148  constant  SYSJMBI0
$14A  constant  SYSJMBI1
$14C  constant  SYSJMBO0
$14E  constant  SYSJMBO1
$158  constant  SYSBERRIV
$15A  constant  SYSUNIV
$15C  constant  SYSSNIV
$15E  constant  SYSRSTIV
$160  constant  SYSCFG0
$162  constant  SYSCFG1
$164  constant  SYSCFG2

\ ***** CS ***** \
$180  constant  CSCTL0
$182  constant  CSCTL1
$184  constant  CSCTL2
$186  constant  CSCTL3
$188  constant  CSCTL4
$18A  constant  CSCTL5
$18C  constant  CSCTL6
$18E  constant  CSCTL7
$190  constant  CSCTL8

\ ***** FRAM ***** \
$1A0  constant  FRCTL0
$1A4  constant  GCCTL0
$1A6  constant  GCCTL1

\ ***** CRC16 ***** \
$1C0  constant  CRCDI
$1C2  constant  CRCDIRB
$1C4  constant  CRCINIRES
$1C6  constant  CRCRESR

\ ***** WATCHDOG_TIMER ***** \
$1CC  constant  WDTCTL

\ ***** REAL_TIME_CLOCK ***** \
$300  constant  RTCCTL
$304  constant  RTCIV
$308  constant  RTCMOD
$30C  constant  RTCCNT

\ ***** TIMER_0_A3 ***** \
$380  constant  TA0CTL
$382  constant  TA0CCTL0
$384  constant  TA0CCTL1
$386  constant  TA0CCTL2
$390  constant  TA0R
$392  constant  TA0CCR0
$394  constant  TA0CCR1
$396  constant  TA0CCR2
$3A0  constant  TA0EX0
$3AE  constant  TA0IV

\ ***** TIMER_1_A3 ***** \
$3C0  constant  TA1CTL
$3C2  constant  TA1CCTL0
$3C4  constant  TA1CCTL1
$3C6  constant  TA1CCTL2
$3D0  constant  TA1R
$3D2  constant  TA1CCR0
$3D4  constant  TA1CCR1
$3D6  constant  TA1CCR2
$3E0  constant  TA1EX0
$3EE  constant  TA1IV

\ ***** TIMER_2_A2 ***** \
$400  constant  TA2CTL
$402  constant  TA2CCTL0
$404  constant  TA2CCTL1
$410  constant  TA2R
$412  constant  TA2CCR0
$414  constant  TA2CCR1
$420  constant  TA2EX0
$42E  constant  TA2IV

\ ***** TIMER_3_A2 ***** \
$440  constant  TA3CTL
$442  constant  TA3CCTL0
$444  constant  TA3CCTL1
$450  constant  TA3R
$452  constant  TA3CCR0
$454  constant  TA3CCR1
$460  constant  TA3EX0
$46E  constant  TA3IV

\ ***** MPY_16 ***** \
$4C0  constant  MPY
$4C2  constant  MPYS
$4C4  constant  MAC
$4C6  constant  MACS
$4C8  constant  OP2
$4CA  constant  RESLO
$4CC  constant  RESHI
$4CE  constant  SUMEXT
$4EC  constant  MPY32CTL0

\ ***** MPY_32 ***** \
$4D0  constant  MPY32L
$4D2  constant  MPY32H
$4D4  constant  MPYS32L
$4D6  constant  MPYS32H
$4D8  constant  MAC32L
$4DA  constant  MAC32H
$4DC  constant  MACS32L
$4DE  constant  MACS32H
$4E0  constant  OP2L
$4E2  constant  OP2H
$4E4  constant  RES0
$4E6  constant  RES1
$4E8  constant  RES2
$4EA  constant  RES3

\ ***** BACKUP_MEMORY ***** \
$660  constant  BAKMEM0
$662  constant  BAKMEM1
$664  constant  BAKMEM2
$666  constant  BAKMEM3
$668  constant  BAKMEM4
$66A  constant  BAKMEM5
$66C  constant  BAKMEM6
$66E  constant  BAKMEM7
$670  constant  BAKMEM8
$672  constant  BAKMEM9
$674  constant  BAKMEM10
$676  constant  BAKMEM11
$678  constant  BAKMEM12
$67A  constant  BAKMEM13
$67C  constant  BAKMEM14
$67E  constant  BAKMEM15

\ ***** ADC ***** \
$700  constant  ADCCTL0
$702  constant  ADCCTL1
$704  constant  ADCCTL2
$706  constant  ADCLO
$708  constant  ADCHI
$70A  constant  ADCMCTL0
$712  constant  ADCMEM0
$71A  constant  ADCIE
$71C  constant  ADCIFG
$71E  constant  ADCIV

\ ***** _INTERRUPTS ***** \


