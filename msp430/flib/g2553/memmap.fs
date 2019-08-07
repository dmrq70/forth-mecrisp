\ Memory Map file for MSP430G2553
\ created by svdcutter for Mecrisp Forth by Matthias Koch
\ sdvcutter takes a MSP430xx SVD file created by https://github.com/pftbest/msp430_svd and creates a memmap, register and config.xml file. The config.xml file may be later edited to control the size of the memmap file 
\ By Terry Porter "terry@tjporter.com.au", see attached COPYING.TXT ( BSD License)
\ available forth template words as selected by config.xml

\ ***** SPECIAL_FUNCTION ***** \
$  constant  IE1
$1  constant  IE2
$2  constant  IFG1
$3  constant  IFG2

\ ***** PORT_3_4 ***** \
$10  constant  P3REN
$18  constant  P3IN
$19  constant  P3OUT
$1A  constant  P3DIR
$1B  constant  P3SEL
$43  constant  P3SEL2

\ ***** PORT_1_2 ***** \
$20  constant  P1IN
$21  constant  P1OUT
$22  constant  P1DIR
$23  constant  P1IFG
$24  constant  P1IES
$25  constant  P1IE
$26  constant  P1SEL
$27  constant  P1REN
$28  constant  P2IN
$29  constant  P2OUT
$2A  constant  P2DIR
$2B  constant  P2IFG
$2C  constant  P2IES
$2D  constant  P2IE
$2E  constant  P2SEL
$2F  constant  P2REN
$41  constant  P1SEL2
$42  constant  P2SEL2

\ ***** ADC10 ***** \
$48  constant  ADC10DTC0
$49  constant  ADC10DTC1
$4A  constant  ADC10AE0
$1B0  constant  ADC10CTL0
$1B2  constant  ADC10CTL1
$1B4  constant  ADC10MEM
$1BC  constant  ADC10SA

\ ***** SYSTEM_CLOCK ***** \
$53  constant  BCSCTL3
$56  constant  DCOCTL
$57  constant  BCSCTL1
$58  constant  BCSCTL2

\ ***** COMPARATOR_A ***** \
$59  constant  CACTL1
$5A  constant  CACTL2
$5B  constant  CAPD

\ ***** USCI_A0_UART_MODE ***** \
$5D  constant  UCA0ABCTL
$5E  constant  UCA0IRTCTL
$5F  constant  UCA0IRRCTL
$60  constant  UCA0CTL0
$61  constant  UCA0CTL1
$62  constant  UCA0BR0
$63  constant  UCA0BR1
$64  constant  UCA0MCTL
$65  constant  UCA0STAT
$66  constant  UCA0RXBUF
$67  constant  UCA0TXBUF

\ ***** USCI_A0_SPI_MODE ***** \
$60  constant  UCA0CTL0
$61  constant  UCA0CTL1
$62  constant  UCA0BR0
$63  constant  UCA0BR1
$64  constant  UCA0MCTL
$65  constant  UCA0STAT
$66  constant  UCA0RXBUF
$67  constant  UCA0TXBUF

\ ***** USCI_B0_I2C_MODE ***** \
$68  constant  UCB0CTL0
$69  constant  UCB0CTL1
$6A  constant  UCB0BR0
$6B  constant  UCB0BR1
$6C  constant  UCB0I2CIE
$6D  constant  UCB0STAT
$6E  constant  UCB0RXBUF
$6F  constant  UCB0TXBUF
$118  constant  UCB0I2COA
$11A  constant  UCB0I2CSA

\ ***** USCI_B0_SPI_MODE ***** \
$68  constant  UCB0CTL0
$69  constant  UCB0CTL1
$6A  constant  UCB0BR0
$6B  constant  UCB0BR1
$6D  constant  UCB0STAT
$6E  constant  UCB0RXBUF
$6F  constant  UCB0TXBUF

\ ***** TLV_CALIBRATION_DATA ***** \
$10DA  constant  TLV_ADC10_1_TAG
$10DB  constant  TLV_ADC10_1_LEN
$10F6  constant  TLV_DCO_30_TAG
$10F7  constant  TLV_DCO_30_LEN
$10C0  constant  TLV_CHECKSUM

\ ***** CALIBRATION_DATA ***** \
$10F8  constant  CALDCO_16MHZ
$10F9  constant  CALBC1_16MHZ
$10FA  constant  CALDCO_12MHZ
$10FB  constant  CALBC1_12MHZ
$10FC  constant  CALDCO_8MHZ
$10FD  constant  CALBC1_8MHZ
$10FE  constant  CALDCO_1MHZ
$10FF  constant  CALBC1_1MHZ

\ ***** TIMER_1_A3 ***** \
$11E  constant  TA1IV
$180  constant  TA1CTL
$182  constant  TA1CCTL0
$184  constant  TA1CCTL1
$186  constant  TA1CCTL2
$190  constant  TA1R
$192  constant  TA1CCR0
$194  constant  TA1CCR1
$196  constant  TA1CCR2

\ ***** WATCHDOG_TIMER ***** \
$120  constant  WDTCTL

\ ***** FLASH ***** \
$128  constant  FCTL1
$12A  constant  FCTL2
$12C  constant  FCTL3

\ ***** TIMER_0_A3 ***** \
$12E  constant  TA0IV
$160  constant  TA0CTL
$162  constant  TA0CCTL0
$164  constant  TA0CCTL1
$166  constant  TA0CCTL2
$170  constant  TA0R
$172  constant  TA0CCR0
$174  constant  TA0CCR1
$176  constant  TA0CCR2

\ ***** _INTERRUPTS ***** \


