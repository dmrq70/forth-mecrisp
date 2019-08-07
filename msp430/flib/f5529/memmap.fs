\ Memory Map file for MSP430F5529
\ created by svdcutter for Mecrisp Forth by Matthias Koch
\ sdvcutter takes a MSP430xx SVD file created by https://github.com/pftbest/msp430_svd and creates a memmap, register and config.xml file. The config.xml file may be later edited to control the size of the memmap file 
\ By Terry Porter "terry@tjporter.com.au", see attached COPYING.TXT ( BSD License)
\ available forth template words as selected by config.xml

\ ***** PORT_MAPPING_PORT_4 ***** \
$1E0  constant  P4MAP0
$1E1  constant  P4MAP1
$1E2  constant  P4MAP2
$1E3  constant  P4MAP3
$1E4  constant  P4MAP4
$1E5  constant  P4MAP5
$1E6  constant  P4MAP6
$1E7  constant  P4MAP7

\ ***** PORT_1_2 ***** \
$200  constant  P1IN
$201  constant  P2IN
$202  constant  P1OUT
$203  constant  P2OUT
$204  constant  P1DIR
$205  constant  P2DIR
$206  constant  P1REN
$207  constant  P2REN
$208  constant  P1DS
$209  constant  P2DS
$20A  constant  P1SEL
$20B  constant  P2SEL
$218  constant  P1IES
$219  constant  P2IES
$21A  constant  P1IE
$21B  constant  P2IE
$21C  constant  P1IFG
$21D  constant  P2IFG
$20E  constant  P1IV
$21E  constant  P2IV

\ ***** PORT_3_4 ***** \
$220  constant  P3IN
$221  constant  P4IN
$222  constant  P3OUT
$223  constant  P4OUT
$224  constant  P3DIR
$225  constant  P4DIR
$226  constant  P3REN
$227  constant  P4REN
$228  constant  P3DS
$229  constant  P4DS
$22A  constant  P3SEL
$22B  constant  P4SEL

\ ***** PORT_5_6 ***** \
$240  constant  P5IN
$241  constant  P6IN
$242  constant  P5OUT
$243  constant  P6OUT
$244  constant  P5DIR
$245  constant  P6DIR
$246  constant  P5REN
$247  constant  P6REN
$248  constant  P5DS
$249  constant  P6DS
$24A  constant  P5SEL
$24B  constant  P6SEL

\ ***** PORT_7_8 ***** \
$260  constant  P7IN
$261  constant  P8IN
$262  constant  P7OUT
$263  constant  P8OUT
$264  constant  P7DIR
$265  constant  P8DIR
$266  constant  P7REN
$267  constant  P8REN
$268  constant  P7DS
$269  constant  P8DS
$26A  constant  P7SEL
$26B  constant  P8SEL

\ ***** RTC ***** \
$4B0  constant  RTCSEC
$4B1  constant  RTCMIN
$4B2  constant  RTCHOUR
$4B3  constant  RTCDOW
$4B4  constant  RTCDAY
$4B5  constant  RTCMON
$4B8  constant  RTCAMIN
$4B9  constant  RTCAHOUR
$4BA  constant  RTCADOW
$4BB  constant  RTCADAY
$4A0  constant  RTCCTL01
$4A2  constant  RTCCTL23
$4A8  constant  RTCPS0CTL
$4AA  constant  RTCPS1CTL
$4AC  constant  RTCPS
$4AE  constant  RTCIV
$4B6  constant  RTCYEAR

\ ***** USCI_A0_UART_MODE ***** \
$5C0  constant  UCA0CTL1
$5C1  constant  UCA0CTL0
$5C6  constant  UCA0BR0
$5C7  constant  UCA0BR1
$5C8  constant  UCA0MCTL
$5CA  constant  UCA0STAT
$5CC  constant  UCA0RXBUF
$5CE  constant  UCA0TXBUF
$5D0  constant  UCA0ABCTL
$5D2  constant  UCA0IRTCTL
$5D3  constant  UCA0IRRCTL
$5DC  constant  UCA0IE
$5DD  constant  UCA0IFG
$5DE  constant  UCA0IV

\ ***** USCI_A0_SPI_MODE ***** \
$5C0  constant  UCA0CTL1
$5C1  constant  UCA0CTL0
$5C6  constant  UCA0BR0
$5C7  constant  UCA0BR1
$5C8  constant  UCA0MCTL
$5CA  constant  UCA0STAT
$5CC  constant  UCA0RXBUF
$5CE  constant  UCA0TXBUF
$5DC  constant  UCA0IE
$5DD  constant  UCA0IFG
$5DE  constant  UCA0IV

\ ***** USCI_B0_I2C_MODE ***** \
$5E0  constant  UCB0CTL1
$5E1  constant  UCB0CTL0
$5E6  constant  UCB0BR0
$5E7  constant  UCB0BR1
$5EA  constant  UCB0STAT
$5EC  constant  UCB0RXBUF
$5EE  constant  UCB0TXBUF
$5FC  constant  UCB0IE
$5FD  constant  UCB0IFG
$5F0  constant  UCB0I2COA
$5F2  constant  UCB0I2CSA
$5FE  constant  UCB0IV

\ ***** USCI_B0_SPI_MODE ***** \
$5E0  constant  UCB0CTL1
$5E1  constant  UCB0CTL0
$5E6  constant  UCB0BR0
$5E7  constant  UCB0BR1
$5EA  constant  UCB0STAT
$5EC  constant  UCB0RXBUF
$5EE  constant  UCB0TXBUF
$5FC  constant  UCB0IE
$5FD  constant  UCB0IFG
$5FE  constant  UCB0IV

\ ***** USCI_A1_UART_MODE ***** \
$600  constant  UCA1CTL1
$601  constant  UCA1CTL0
$606  constant  UCA1BR0
$607  constant  UCA1BR1
$608  constant  UCA1MCTL
$60A  constant  UCA1STAT
$60C  constant  UCA1RXBUF
$60E  constant  UCA1TXBUF
$610  constant  UCA1ABCTL
$612  constant  UCA1IRTCTL
$613  constant  UCA1IRRCTL
$61C  constant  UCA1IE
$61D  constant  UCA1IFG
$61E  constant  UCA1IV

\ ***** USCI_A1_SPI_MODE ***** \
$600  constant  UCA1CTL1
$601  constant  UCA1CTL0
$606  constant  UCA1BR0
$607  constant  UCA1BR1
$608  constant  UCA1MCTL
$60A  constant  UCA1STAT
$60C  constant  UCA1RXBUF
$60E  constant  UCA1TXBUF
$61C  constant  UCA1IE
$61D  constant  UCA1IFG
$61E  constant  UCA1IV

\ ***** USCI_B1_I2C_MODE ***** \
$620  constant  UCB1CTL1
$621  constant  UCB1CTL0
$626  constant  UCB1BR0
$627  constant  UCB1BR1
$62A  constant  UCB1STAT
$62C  constant  UCB1RXBUF
$62E  constant  UCB1TXBUF
$63C  constant  UCB1IE
$63D  constant  UCB1IFG
$630  constant  UCB1I2COA
$632  constant  UCB1I2CSA
$63E  constant  UCB1IV

\ ***** USCI_B1_SPI_MODE ***** \
$620  constant  UCB1CTL1
$621  constant  UCB1CTL0
$626  constant  UCB1BR0
$627  constant  UCB1BR1
$62A  constant  UCB1STAT
$62C  constant  UCB1RXBUF
$62E  constant  UCB1TXBUF
$63C  constant  UCB1IE
$63D  constant  UCB1IFG
$63E  constant  UCB1IV

\ ***** ADC12 ***** \
$710  constant  ADC12MCTL0
$711  constant  ADC12MCTL1
$712  constant  ADC12MCTL2
$713  constant  ADC12MCTL3
$714  constant  ADC12MCTL4
$715  constant  ADC12MCTL5
$716  constant  ADC12MCTL6
$717  constant  ADC12MCTL7
$718  constant  ADC12MCTL8
$719  constant  ADC12MCTL9
$71A  constant  ADC12MCTL10
$71B  constant  ADC12MCTL11
$71C  constant  ADC12MCTL12
$71D  constant  ADC12MCTL13
$71E  constant  ADC12MCTL14
$71F  constant  ADC12MCTL15
$700  constant  ADC12CTL0
$702  constant  ADC12CTL1
$704  constant  ADC12CTL2
$70A  constant  ADC12IFG
$70C  constant  ADC12IE
$70E  constant  ADC12IV
$720  constant  ADC12MEM0
$722  constant  ADC12MEM1
$724  constant  ADC12MEM2
$726  constant  ADC12MEM3
$728  constant  ADC12MEM4
$72A  constant  ADC12MEM5
$72C  constant  ADC12MEM6
$72E  constant  ADC12MEM7
$730  constant  ADC12MEM8
$732  constant  ADC12MEM9
$734  constant  ADC12MEM10
$736  constant  ADC12MEM11
$738  constant  ADC12MEM12
$73A  constant  ADC12MEM13
$73C  constant  ADC12MEM14
$73E  constant  ADC12MEM15

\ ***** USB_CONTROL ***** \
$920  constant  USBIEPCNF_0
$921  constant  USBIEPCNT_0
$922  constant  USBOEPCNF_0
$923  constant  USBOEPCNT_0
$92E  constant  USBIEPIE
$92F  constant  USBOEPIE
$930  constant  USBIEPIFG
$931  constant  USBOEPIFG
$93C  constant  USBCTL
$93D  constant  USBIE
$93E  constant  USBIFG
$93F  constant  USBFUNADR
$900  constant  USBKEYID
$902  constant  USBCNF
$904  constant  USBPHYCTL
$908  constant  USBPWRCTL
$910  constant  USBPLLCTL
$912  constant  USBPLLDIVB
$914  constant  USBPLLIR
$932  constant  USBVECINT
$936  constant  USBMAINT
$938  constant  USBTSREG
$93A  constant  USBFN

\ ***** USB_OPERATION ***** \
$1C00  constant  USBSTABUFF
$236F  constant  USBTOPBUFF
$2370  constant  USBOEP0BUF
$2378  constant  USBIEP0BUF
$2380  constant  USBSUBLK
$2388  constant  USBOEPCNF_1
$2389  constant  USBOEPBBAX_1
$238A  constant  USBOEPBCTX_1
$238D  constant  USBOEPBBAY_1
$238E  constant  USBOEPBCTY_1
$238F  constant  USBOEPSIZXY_1
$2390  constant  USBOEPCNF_2
$2391  constant  USBOEPBBAX_2
$2392  constant  USBOEPBCTX_2
$2395  constant  USBOEPBBAY_2
$2396  constant  USBOEPBCTY_2
$2397  constant  USBOEPSIZXY_2
$2398  constant  USBOEPCNF_3
$2399  constant  USBOEPBBAX_3
$239A  constant  USBOEPBCTX_3
$239D  constant  USBOEPBBAY_3
$239E  constant  USBOEPBCTY_3
$239F  constant  USBOEPSIZXY_3
$23A0  constant  USBOEPCNF_4
$23A1  constant  USBOEPBBAX_4
$23A2  constant  USBOEPBCTX_4
$23A5  constant  USBOEPBBAY_4
$23A6  constant  USBOEPBCTY_4
$23A7  constant  USBOEPSIZXY_4
$23A8  constant  USBOEPCNF_5
$23A9  constant  USBOEPBBAX_5
$23AA  constant  USBOEPBCTX_5
$23AD  constant  USBOEPBBAY_5
$23AE  constant  USBOEPBCTY_5
$23AF  constant  USBOEPSIZXY_5
$23B0  constant  USBOEPCNF_6
$23B1  constant  USBOEPBBAX_6
$23B2  constant  USBOEPBCTX_6
$23B5  constant  USBOEPBBAY_6
$23B6  constant  USBOEPBCTY_6
$23B7  constant  USBOEPSIZXY_6
$23B8  constant  USBOEPCNF_7
$23B9  constant  USBOEPBBAX_7
$23BA  constant  USBOEPBCTX_7
$23BD  constant  USBOEPBBAY_7
$23BE  constant  USBOEPBCTY_7
$23BF  constant  USBOEPSIZXY_7
$23C8  constant  USBIEPCNF_1
$23C9  constant  USBIEPBBAX_1
$23CA  constant  USBIEPBCTX_1
$23CD  constant  USBIEPBBAY_1
$23CE  constant  USBIEPBCTY_1
$23CF  constant  USBIEPSIZXY_1
$23D0  constant  USBIEPCNF_2
$23D1  constant  USBIEPBBAX_2
$23D2  constant  USBIEPBCTX_2
$23D5  constant  USBIEPBBAY_2
$23D6  constant  USBIEPBCTY_2
$23D7  constant  USBIEPSIZXY_2
$23D8  constant  USBIEPCNF_3
$23D9  constant  USBIEPBBAX_3
$23DA  constant  USBIEPBCTX_3
$23DD  constant  USBIEPBBAY_3
$23DE  constant  USBIEPBCTY_3
$23DF  constant  USBIEPSIZXY_3
$23E0  constant  USBIEPCNF_4
$23E1  constant  USBIEPBBAX_4
$23E2  constant  USBIEPBCTX_4
$23E5  constant  USBIEPBBAY_4
$23E6  constant  USBIEPBCTY_4
$23E7  constant  USBIEPSIZXY_4
$23E8  constant  USBIEPCNF_5
$23E9  constant  USBIEPBBAX_5
$23EA  constant  USBIEPBCTX_5
$23ED  constant  USBIEPBBAY_5
$23EE  constant  USBIEPBCTY_5
$23EF  constant  USBIEPSIZXY_5
$23F0  constant  USBIEPCNF_6
$23F1  constant  USBIEPBBAX_6
$23F2  constant  USBIEPBCTX_6
$23F5  constant  USBIEPBBAY_6
$23F6  constant  USBIEPBCTY_6
$23F7  constant  USBIEPSIZXY_6
$23F8  constant  USBIEPCNF_7
$23F9  constant  USBIEPBBAX_7
$23FA  constant  USBIEPBCTX_7
$23FD  constant  USBIEPBBAY_7
$23FE  constant  USBIEPBCTY_7
$23FF  constant  USBIEPSIZXY_7

\ ***** SFR ***** \
$100  constant  SFRIE1
$102  constant  SFRIFG1
$104  constant  SFRRPCR

\ ***** PMM ***** \
$120  constant  PMMCTL0
$122  constant  PMMCTL1
$124  constant  SVSMHCTL
$126  constant  SVSMLCTL
$128  constant  SVSMIO
$12C  constant  PMMIFG
$12E  constant  PMMRIE
$130  constant  PM5CTL0

\ ***** FLASH ***** \
$140  constant  FCTL1
$144  constant  FCTL3
$146  constant  FCTL4

\ ***** CRC16 ***** \
$150  constant  CRCDI
$152  constant  CRCDIRB
$154  constant  CRCINIRES
$156  constant  CRCRESR

\ ***** RC ***** \
$158  constant  RCCTL0

\ ***** WATCHDOG_TIMER ***** \
$15C  constant  WDTCTL

\ ***** UCS ***** \
$160  constant  UCSCTL0
$162  constant  UCSCTL1
$164  constant  UCSCTL2
$166  constant  UCSCTL3
$168  constant  UCSCTL4
$16A  constant  UCSCTL5
$16C  constant  UCSCTL6
$16E  constant  UCSCTL7
$170  constant  UCSCTL8

\ ***** SYS ***** \
$180  constant  SYSCTL
$182  constant  SYSBSLC
$186  constant  SYSJMBC
$188  constant  SYSJMBI0
$18A  constant  SYSJMBI1
$18C  constant  SYSJMBO0
$18E  constant  SYSJMBO1
$198  constant  SYSBERRIV
$19A  constant  SYSUNIV
$19C  constant  SYSSNIV
$19E  constant  SYSRSTIV

\ ***** SHARED_REFERENCE ***** \
$1B0  constant  REFCTL0

\ ***** PORT_MAPPING_CONTROL ***** \
$1C0  constant  PMAPKEYID
$1C2  constant  PMAPCTL

\ ***** PORT_J ***** \
$320  constant  PJIN
$322  constant  PJOUT
$324  constant  PJDIR
$326  constant  PJREN
$328  constant  PJDS

\ ***** TIMER_0_A5 ***** \
$340  constant  TA0CTL
$342  constant  TA0CCTL0
$344  constant  TA0CCTL1
$346  constant  TA0CCTL2
$348  constant  TA0CCTL3
$34A  constant  TA0CCTL4
$350  constant  TA0R
$352  constant  TA0CCR0
$354  constant  TA0CCR1
$356  constant  TA0CCR2
$358  constant  TA0CCR3
$35A  constant  TA0CCR4
$360  constant  TA0EX0
$36E  constant  TA0IV

\ ***** TIMER_1_A3 ***** \
$380  constant  TA1CTL
$382  constant  TA1CCTL0
$384  constant  TA1CCTL1
$386  constant  TA1CCTL2
$390  constant  TA1R
$392  constant  TA1CCR0
$394  constant  TA1CCR1
$396  constant  TA1CCR2
$3A0  constant  TA1EX0
$3AE  constant  TA1IV

\ ***** TIMER_0_B7 ***** \
$3C0  constant  TB0CTL
$3C2  constant  TB0CCTL0
$3C4  constant  TB0CCTL1
$3C6  constant  TB0CCTL2
$3C8  constant  TB0CCTL3
$3CA  constant  TB0CCTL4
$3CC  constant  TB0CCTL5
$3CE  constant  TB0CCTL6
$3D0  constant  TB0R
$3D2  constant  TB0CCR0
$3D4  constant  TB0CCR1
$3D6  constant  TB0CCR2
$3D8  constant  TB0CCR3
$3DA  constant  TB0CCR4
$3DC  constant  TB0CCR5
$3DE  constant  TB0CCR6
$3E0  constant  TB0EX0
$3EE  constant  TB0IV

\ ***** TIMER_2_A3 ***** \
$400  constant  TA2CTL
$402  constant  TA2CCTL0
$404  constant  TA2CCTL1
$406  constant  TA2CCTL2
$410  constant  TA2R
$412  constant  TA2CCR0
$414  constant  TA2CCR1
$416  constant  TA2CCR2
$420  constant  TA2EX0
$42E  constant  TA2IV

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

\ ***** DMA ***** \
$500  constant  DMACTL0
$502  constant  DMACTL1
$504  constant  DMACTL2
$506  constant  DMACTL3
$508  constant  DMACTL4
$50E  constant  DMAIV
$510  constant  DMA0CTL
$51A  constant  DMA0SZ
$520  constant  DMA1CTL
$52A  constant  DMA1SZ
$530  constant  DMA2CTL
$53A  constant  DMA2SZ
$512  constant  DMA0SA
$516  constant  DMA0DA
$522  constant  DMA1SA
$526  constant  DMA1DA
$532  constant  DMA2SA
$536  constant  DMA2DA

\ ***** COMPARATOR_B ***** \
$8C0  constant  CBCTL0
$8C2  constant  CBCTL1
$8C4  constant  CBCTL2
$8C6  constant  CBCTL3
$8CC  constant  CBINT
$8CE  constant  CBIV

\ ***** _INTERRUPTS ***** \


