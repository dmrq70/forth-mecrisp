MSP430FR2433 register Word generation reference file for Mecrisp-Stellaris Forth by Matthias Koch.
Uses registers.xsl and your config.xml file.
Do not load this file, just copy and paste what you need into your source file.
Written by Terry Porter "terry@tjporter.com.au" 2016. Released under the GPL V2
 
\ ===================================PORT_1_2 =================================== 
\ P1IN ( Port 1 Input ) 
( P1IN-P1IN0-set ) %1  0 lshift P1IN bis! 
( P1IN-P1IN1-set ) %1  1 lshift P1IN bis! 
( P1IN-P1IN2-set ) %1  2 lshift P1IN bis! 
( P1IN-P1IN3-set ) %1  3 lshift P1IN bis! 
( P1IN-P1IN4-set ) %1  4 lshift P1IN bis! 
( P1IN-P1IN5-set ) %1  5 lshift P1IN bis! 
( P1IN-P1IN6-set ) %1  6 lshift P1IN bis! 
( P1IN-P1IN7-set ) %1  7 lshift P1IN bis! 
 
\ P2IN ( Port 2 Input ) 
( P2IN-P2IN0-set ) %1  0 lshift P2IN bis! 
( P2IN-P2IN1-set ) %1  1 lshift P2IN bis! 
( P2IN-P2IN2-set ) %1  2 lshift P2IN bis! 
( P2IN-P2IN3-set ) %1  3 lshift P2IN bis! 
( P2IN-P2IN4-set ) %1  4 lshift P2IN bis! 
( P2IN-P2IN5-set ) %1  5 lshift P2IN bis! 
( P2IN-P2IN6-set ) %1  6 lshift P2IN bis! 
( P2IN-P2IN7-set ) %1  7 lshift P2IN bis! 
 
\ P1OUT ( Port 1 Output ) 
( P1OUT-P1OUT0-set ) %1  0 lshift P1OUT bis! 
( P1OUT-P1OUT1-set ) %1  1 lshift P1OUT bis! 
( P1OUT-P1OUT2-set ) %1  2 lshift P1OUT bis! 
( P1OUT-P1OUT3-set ) %1  3 lshift P1OUT bis! 
( P1OUT-P1OUT4-set ) %1  4 lshift P1OUT bis! 
( P1OUT-P1OUT5-set ) %1  5 lshift P1OUT bis! 
( P1OUT-P1OUT6-set ) %1  6 lshift P1OUT bis! 
( P1OUT-P1OUT7-set ) %1  7 lshift P1OUT bis! 
 
\ P2OUT ( Port 2 Output ) 
( P2OUT-P2OUT0-set ) %1  0 lshift P2OUT bis! 
( P2OUT-P2OUT1-set ) %1  1 lshift P2OUT bis! 
( P2OUT-P2OUT2-set ) %1  2 lshift P2OUT bis! 
( P2OUT-P2OUT3-set ) %1  3 lshift P2OUT bis! 
( P2OUT-P2OUT4-set ) %1  4 lshift P2OUT bis! 
( P2OUT-P2OUT5-set ) %1  5 lshift P2OUT bis! 
( P2OUT-P2OUT6-set ) %1  6 lshift P2OUT bis! 
( P2OUT-P2OUT7-set ) %1  7 lshift P2OUT bis! 
 
\ P1DIR ( Port 1 Direction ) 
( P1DIR-P1DIR0-set ) %1  0 lshift P1DIR bis! 
( P1DIR-P1DIR1-set ) %1  1 lshift P1DIR bis! 
( P1DIR-P1DIR2-set ) %1  2 lshift P1DIR bis! 
( P1DIR-P1DIR3-set ) %1  3 lshift P1DIR bis! 
( P1DIR-P1DIR4-set ) %1  4 lshift P1DIR bis! 
( P1DIR-P1DIR5-set ) %1  5 lshift P1DIR bis! 
( P1DIR-P1DIR6-set ) %1  6 lshift P1DIR bis! 
( P1DIR-P1DIR7-set ) %1  7 lshift P1DIR bis! 
 
\ P2DIR ( Port 2 Direction ) 
( P2DIR-P2DIR0-set ) %1  0 lshift P2DIR bis! 
( P2DIR-P2DIR1-set ) %1  1 lshift P2DIR bis! 
( P2DIR-P2DIR2-set ) %1  2 lshift P2DIR bis! 
( P2DIR-P2DIR3-set ) %1  3 lshift P2DIR bis! 
( P2DIR-P2DIR4-set ) %1  4 lshift P2DIR bis! 
( P2DIR-P2DIR5-set ) %1  5 lshift P2DIR bis! 
( P2DIR-P2DIR6-set ) %1  6 lshift P2DIR bis! 
( P2DIR-P2DIR7-set ) %1  7 lshift P2DIR bis! 
 
\ P1REN ( Port 1 Resistor Enable ) 
( P1REN-P1REN0-set ) %1  0 lshift P1REN bis! 
( P1REN-P1REN1-set ) %1  1 lshift P1REN bis! 
( P1REN-P1REN2-set ) %1  2 lshift P1REN bis! 
( P1REN-P1REN3-set ) %1  3 lshift P1REN bis! 
( P1REN-P1REN4-set ) %1  4 lshift P1REN bis! 
( P1REN-P1REN5-set ) %1  5 lshift P1REN bis! 
( P1REN-P1REN6-set ) %1  6 lshift P1REN bis! 
( P1REN-P1REN7-set ) %1  7 lshift P1REN bis! 
 
\ P2REN ( Port 2 Resistor Enable ) 
( P2REN-P2REN0-set ) %1  0 lshift P2REN bis! 
( P2REN-P2REN1-set ) %1  1 lshift P2REN bis! 
( P2REN-P2REN2-set ) %1  2 lshift P2REN bis! 
( P2REN-P2REN3-set ) %1  3 lshift P2REN bis! 
( P2REN-P2REN4-set ) %1  4 lshift P2REN bis! 
( P2REN-P2REN5-set ) %1  5 lshift P2REN bis! 
( P2REN-P2REN6-set ) %1  6 lshift P2REN bis! 
( P2REN-P2REN7-set ) %1  7 lshift P2REN bis! 
 
\ P1SEL0 ( Port 1 Selection 0 ) 
( P1SEL0-P1SEL0_0-set ) %1  0 lshift P1SEL0 bis! 
( P1SEL0-P1SEL0_1-set ) %1  1 lshift P1SEL0 bis! 
( P1SEL0-P1SEL0_2-set ) %1  2 lshift P1SEL0 bis! 
( P1SEL0-P1SEL0_3-set ) %1  3 lshift P1SEL0 bis! 
( P1SEL0-P1SEL0_4-set ) %1  4 lshift P1SEL0 bis! 
( P1SEL0-P1SEL0_5-set ) %1  5 lshift P1SEL0 bis! 
( P1SEL0-P1SEL0_6-set ) %1  6 lshift P1SEL0 bis! 
( P1SEL0-P1SEL0_7-set ) %1  7 lshift P1SEL0 bis! 
 
\ P2SEL0 ( Port 2 Selection 0 ) 
( P2SEL0-P2SEL0_0-set ) %1  0 lshift P2SEL0 bis! 
( P2SEL0-P2SEL0_1-set ) %1  1 lshift P2SEL0 bis! 
( P2SEL0-P2SEL0_2-set ) %1  2 lshift P2SEL0 bis! 
( P2SEL0-P2SEL0_3-set ) %1  3 lshift P2SEL0 bis! 
( P2SEL0-P2SEL0_4-set ) %1  4 lshift P2SEL0 bis! 
( P2SEL0-P2SEL0_5-set ) %1  5 lshift P2SEL0 bis! 
( P2SEL0-P2SEL0_6-set ) %1  6 lshift P2SEL0 bis! 
( P2SEL0-P2SEL0_7-set ) %1  7 lshift P2SEL0 bis! 
 
\ P1SEL1 ( Port 1 Selection 1 ) 
( P1SEL1-P1SEL1_0-set ) %1  0 lshift P1SEL1 bis! 
( P1SEL1-P1SEL1_1-set ) %1  1 lshift P1SEL1 bis! 
( P1SEL1-P1SEL1_2-set ) %1  2 lshift P1SEL1 bis! 
( P1SEL1-P1SEL1_3-set ) %1  3 lshift P1SEL1 bis! 
( P1SEL1-P1SEL1_4-set ) %1  4 lshift P1SEL1 bis! 
( P1SEL1-P1SEL1_5-set ) %1  5 lshift P1SEL1 bis! 
( P1SEL1-P1SEL1_6-set ) %1  6 lshift P1SEL1 bis! 
( P1SEL1-P1SEL1_7-set ) %1  7 lshift P1SEL1 bis! 
 
\ P2SEL1 ( Port 2 Selection 1 ) 
( P2SEL1-P2SEL1_0-set ) %1  0 lshift P2SEL1 bis! 
( P2SEL1-P2SEL1_1-set ) %1  1 lshift P2SEL1 bis! 
( P2SEL1-P2SEL1_2-set ) %1  2 lshift P2SEL1 bis! 
( P2SEL1-P2SEL1_3-set ) %1  3 lshift P2SEL1 bis! 
( P2SEL1-P2SEL1_4-set ) %1  4 lshift P2SEL1 bis! 
( P2SEL1-P2SEL1_5-set ) %1  5 lshift P2SEL1 bis! 
( P2SEL1-P2SEL1_6-set ) %1  6 lshift P2SEL1 bis! 
( P2SEL1-P2SEL1_7-set ) %1  7 lshift P2SEL1 bis! 
 
\ P1IES ( Port 1 Interrupt Edge Select ) 
( P1IES-P1IES0-set ) %1  0 lshift P1IES bis! 
( P1IES-P1IES1-set ) %1  1 lshift P1IES bis! 
( P1IES-P1IES2-set ) %1  2 lshift P1IES bis! 
( P1IES-P1IES3-set ) %1  3 lshift P1IES bis! 
( P1IES-P1IES4-set ) %1  4 lshift P1IES bis! 
( P1IES-P1IES5-set ) %1  5 lshift P1IES bis! 
( P1IES-P1IES6-set ) %1  6 lshift P1IES bis! 
( P1IES-P1IES7-set ) %1  7 lshift P1IES bis! 
 
\ P2IES ( Port 2 Interrupt Edge Select ) 
( P2IES-P2IES0-set ) %1  0 lshift P2IES bis! 
( P2IES-P2IES1-set ) %1  1 lshift P2IES bis! 
( P2IES-P2IES2-set ) %1  2 lshift P2IES bis! 
( P2IES-P2IES3-set ) %1  3 lshift P2IES bis! 
( P2IES-P2IES4-set ) %1  4 lshift P2IES bis! 
( P2IES-P2IES5-set ) %1  5 lshift P2IES bis! 
( P2IES-P2IES6-set ) %1  6 lshift P2IES bis! 
( P2IES-P2IES7-set ) %1  7 lshift P2IES bis! 
 
\ P1IE ( Port 1 Interrupt Enable ) 
( P1IE-P1IE0-set ) %1  0 lshift P1IE bis! 
( P1IE-P1IE1-set ) %1  1 lshift P1IE bis! 
( P1IE-P1IE2-set ) %1  2 lshift P1IE bis! 
( P1IE-P1IE3-set ) %1  3 lshift P1IE bis! 
( P1IE-P1IE4-set ) %1  4 lshift P1IE bis! 
( P1IE-P1IE5-set ) %1  5 lshift P1IE bis! 
( P1IE-P1IE6-set ) %1  6 lshift P1IE bis! 
( P1IE-P1IE7-set ) %1  7 lshift P1IE bis! 
 
\ P2IE ( Port 2 Interrupt Enable ) 
( P2IE-P2IE0-set ) %1  0 lshift P2IE bis! 
( P2IE-P2IE1-set ) %1  1 lshift P2IE bis! 
( P2IE-P2IE2-set ) %1  2 lshift P2IE bis! 
( P2IE-P2IE3-set ) %1  3 lshift P2IE bis! 
( P2IE-P2IE4-set ) %1  4 lshift P2IE bis! 
( P2IE-P2IE5-set ) %1  5 lshift P2IE bis! 
( P2IE-P2IE6-set ) %1  6 lshift P2IE bis! 
( P2IE-P2IE7-set ) %1  7 lshift P2IE bis! 
 
\ P1IFG ( Port 1 Interrupt Flag ) 
( P1IFG-P1IFG0-set ) %1  0 lshift P1IFG bis! 
( P1IFG-P1IFG1-set ) %1  1 lshift P1IFG bis! 
( P1IFG-P1IFG2-set ) %1  2 lshift P1IFG bis! 
( P1IFG-P1IFG3-set ) %1  3 lshift P1IFG bis! 
( P1IFG-P1IFG4-set ) %1  4 lshift P1IFG bis! 
( P1IFG-P1IFG5-set ) %1  5 lshift P1IFG bis! 
( P1IFG-P1IFG6-set ) %1  6 lshift P1IFG bis! 
( P1IFG-P1IFG7-set ) %1  7 lshift P1IFG bis! 
 
\ P2IFG ( Port 2 Interrupt Flag ) 
( P2IFG-P2IFG0-set ) %1  0 lshift P2IFG bis! 
( P2IFG-P2IFG1-set ) %1  1 lshift P2IFG bis! 
( P2IFG-P2IFG2-set ) %1  2 lshift P2IFG bis! 
( P2IFG-P2IFG3-set ) %1  3 lshift P2IFG bis! 
( P2IFG-P2IFG4-set ) %1  4 lshift P2IFG bis! 
( P2IFG-P2IFG5-set ) %1  5 lshift P2IFG bis! 
( P2IFG-P2IFG6-set ) %1  6 lshift P2IFG bis! 
( P2IFG-P2IFG7-set ) %1  7 lshift P2IFG bis! 
 
\ P1IV ( Port 1 Interrupt Vector Word ) 
 
\ P2IV ( Port 2 Interrupt Vector Word ) 


                     
\ ===================================PORT_3 =================================== 
\ P3IN ( Port 3 Input ) 
( P3IN-P3IN0-set ) %1  0 lshift P3IN bis! 
( P3IN-P3IN1-set ) %1  1 lshift P3IN bis! 
( P3IN-P3IN2-set ) %1  2 lshift P3IN bis! 
( P3IN-P3IN3-set ) %1  3 lshift P3IN bis! 
( P3IN-P3IN4-set ) %1  4 lshift P3IN bis! 
( P3IN-P3IN5-set ) %1  5 lshift P3IN bis! 
( P3IN-P3IN6-set ) %1  6 lshift P3IN bis! 
( P3IN-P3IN7-set ) %1  7 lshift P3IN bis! 
 
\ P3OUT ( Port 3 Output ) 
( P3OUT-P3OUT0-set ) %1  0 lshift P3OUT bis! 
( P3OUT-P3OUT1-set ) %1  1 lshift P3OUT bis! 
( P3OUT-P3OUT2-set ) %1  2 lshift P3OUT bis! 
( P3OUT-P3OUT3-set ) %1  3 lshift P3OUT bis! 
( P3OUT-P3OUT4-set ) %1  4 lshift P3OUT bis! 
( P3OUT-P3OUT5-set ) %1  5 lshift P3OUT bis! 
( P3OUT-P3OUT6-set ) %1  6 lshift P3OUT bis! 
( P3OUT-P3OUT7-set ) %1  7 lshift P3OUT bis! 
 
\ P3DIR ( Port 3 Direction ) 
( P3DIR-P3DIR0-set ) %1  0 lshift P3DIR bis! 
( P3DIR-P3DIR1-set ) %1  1 lshift P3DIR bis! 
( P3DIR-P3DIR2-set ) %1  2 lshift P3DIR bis! 
( P3DIR-P3DIR3-set ) %1  3 lshift P3DIR bis! 
( P3DIR-P3DIR4-set ) %1  4 lshift P3DIR bis! 
( P3DIR-P3DIR5-set ) %1  5 lshift P3DIR bis! 
( P3DIR-P3DIR6-set ) %1  6 lshift P3DIR bis! 
( P3DIR-P3DIR7-set ) %1  7 lshift P3DIR bis! 
 
\ P3REN ( Port 3 Resistor Enable ) 
( P3REN-P3REN0-set ) %1  0 lshift P3REN bis! 
( P3REN-P3REN1-set ) %1  1 lshift P3REN bis! 
( P3REN-P3REN2-set ) %1  2 lshift P3REN bis! 
( P3REN-P3REN3-set ) %1  3 lshift P3REN bis! 
( P3REN-P3REN4-set ) %1  4 lshift P3REN bis! 
( P3REN-P3REN5-set ) %1  5 lshift P3REN bis! 
( P3REN-P3REN6-set ) %1  6 lshift P3REN bis! 
( P3REN-P3REN7-set ) %1  7 lshift P3REN bis! 
 
\ P3SEL0 ( Port 3 Selection0 ) 
( P3SEL0-P3SEL0_0-set ) %1  0 lshift P3SEL0 bis! 
( P3SEL0-P3SEL0_1-set ) %1  1 lshift P3SEL0 bis! 
( P3SEL0-P3SEL0_2-set ) %1  2 lshift P3SEL0 bis! 
( P3SEL0-P3SEL0_3-set ) %1  3 lshift P3SEL0 bis! 
( P3SEL0-P3SEL0_4-set ) %1  4 lshift P3SEL0 bis! 
( P3SEL0-P3SEL0_5-set ) %1  5 lshift P3SEL0 bis! 
( P3SEL0-P3SEL0_6-set ) %1  6 lshift P3SEL0 bis! 
( P3SEL0-P3SEL0_7-set ) %1  7 lshift P3SEL0 bis! 
 
\ P3SEL1 ( Port 3 Selection1 ) 
( P3SEL1-P3SEL1_0-set ) %1  0 lshift P3SEL1 bis! 
( P3SEL1-P3SEL1_1-set ) %1  1 lshift P3SEL1 bis! 
( P3SEL1-P3SEL1_2-set ) %1  2 lshift P3SEL1 bis! 
( P3SEL1-P3SEL1_3-set ) %1  3 lshift P3SEL1 bis! 
( P3SEL1-P3SEL1_4-set ) %1  4 lshift P3SEL1 bis! 
( P3SEL1-P3SEL1_5-set ) %1  5 lshift P3SEL1 bis! 
( P3SEL1-P3SEL1_6-set ) %1  6 lshift P3SEL1 bis! 
( P3SEL1-P3SEL1_7-set ) %1  7 lshift P3SEL1 bis! 


                     
\ ===================================USCI_A0_UART_MODE =================================== 
\ UCA0CTL1 ( USCI A0 Control Register 1 ) 
 
\ UCA0CTL0 ( USCI A0 Control Register 0 ) 
 
\ UCA0BR0 ( USCI A0 Baud Rate 0 ) 
 
\ UCA0BR1 ( USCI A0 Baud Rate 1 ) 
 
\ UCA0STATW ( USCI A0 Status Register ) 
( UCA0STATW-UCBUSY-set ) %1  0 lshift UCA0STATW bis! 
( UCA0STATW-UCADDR-set ) %1  1 lshift UCA0STATW bis! 
( UCA0STATW-UCRXERR-set ) %1  2 lshift UCA0STATW bis! 
( UCA0STATW-UCBRK-set ) %1  3 lshift UCA0STATW bis! 
( UCA0STATW-UCPE-set ) %1  4 lshift UCA0STATW bis! 
( UCA0STATW-UCOE-set ) %1  5 lshift UCA0STATW bis! 
( UCA0STATW-UCFE-set ) %1  6 lshift UCA0STATW bis! 
( UCA0STATW-UCLISTEN-set ) %1  7 lshift UCA0STATW bis! 
 
\ UCA0ABCTL ( USCI A0 LIN Control ) 
( UCA0ABCTL-UCABDEN-set ) %1  0 lshift UCA0ABCTL bis! 
( UCA0ABCTL-UCBTOE-set ) %1  2 lshift UCA0ABCTL bis! 
( UCA0ABCTL-UCSTOE-set ) %1  3 lshift UCA0ABCTL bis! 
( UCA0ABCTL-UCDELIM0-set ) %1  4 lshift UCA0ABCTL bis! 
( UCA0ABCTL-UCDELIM1-set ) %1  5 lshift UCA0ABCTL bis! 
 
\ UCA0IRTCTL ( USCI A0 IrDA Transmit Control ) 
 
\ UCA0IRRCTL ( USCI A0 IrDA Receive Control ) 
 
\ UCA0CTLW1 ( USCI A0 Control Word Register 1 ) 
( UCA0CTLW1-UCGLIT-set ) %xx  0 lshift
    \ %0: UCGLIT_0      ( USCI Deglitch time: 0 ) 
    \ %1: UCGLIT_1      ( USCI Deglitch time: 1 ) 
    \ %11: UCGLIT_2      ( USCI Deglitch time: 2 ) 
    \ %111: UCGLIT_3      ( USCI Deglitch time: 3 )  UCA0CTLW1 bis! 
 
\ UCA0MCTLW ( USCI A0 Modulation Control ) 
( UCA0MCTLW-UCOS16-set ) %1  0 lshift UCA0MCTLW bis! 
( UCA0MCTLW-UCBRF-set ) %xxxx  4 lshift
    \ %0: UCBRF_0      ( USCI First Stage Modulation: 0 ) 
    \ %1: UCBRF_1      ( USCI First Stage Modulation: 1 ) 
    \ %11: UCBRF_2      ( USCI First Stage Modulation: 2 ) 
    \ %111: UCBRF_3      ( USCI First Stage Modulation: 3 ) 
    \ %1111: UCBRF_4      ( USCI First Stage Modulation: 4 ) 
    \ %11111: UCBRF_5      ( USCI First Stage Modulation: 5 ) 
    \ %111111: UCBRF_6      ( USCI First Stage Modulation: 6 ) 
    \ %1111111: UCBRF_7      ( USCI First Stage Modulation: 7 ) 
    \ %11111111: UCBRF_8      ( USCI First Stage Modulation: 8 ) 
    \ %111111111: UCBRF_9      ( USCI First Stage Modulation: 9 ) 
    \ %1111111111: UCBRF_10      ( USCI First Stage Modulation: A ) 
    \ %11111111111: UCBRF_11      ( USCI First Stage Modulation: B ) 
    \ %111111111111: UCBRF_12      ( USCI First Stage Modulation: C ) 
    \ %1111111111111: UCBRF_13      ( USCI First Stage Modulation: D ) 
    \ %11111111111111: UCBRF_14      ( USCI First Stage Modulation: E ) 
    \ %111111111111111: UCBRF_15      ( USCI First Stage Modulation: F )  UCA0MCTLW bis! 
( UCA0MCTLW-UCBRS0-set ) %1  8 lshift UCA0MCTLW bis! 
( UCA0MCTLW-UCBRS1-set ) %1  9 lshift UCA0MCTLW bis! 
( UCA0MCTLW-UCBRS2-set ) %1  10 lshift UCA0MCTLW bis! 
( UCA0MCTLW-UCBRS3-set ) %1  11 lshift UCA0MCTLW bis! 
( UCA0MCTLW-UCBRS4-set ) %1  12 lshift UCA0MCTLW bis! 
( UCA0MCTLW-UCBRS5-set ) %1  13 lshift UCA0MCTLW bis! 
( UCA0MCTLW-UCBRS6-set ) %1  14 lshift UCA0MCTLW bis! 
( UCA0MCTLW-UCBRS7-set ) %1  15 lshift UCA0MCTLW bis! 
 
\ UCA0RXBUF ( USCI A0 Receive Buffer ) 
 
\ UCA0TXBUF ( USCI A0 Transmit Buffer ) 
 
\ UCA0IV ( USCI A0 Interrupt Vector Register ) 


                     
\ ===================================USCI_A0_SPI_MODE =================================== 
\ UCA0CTL1 ( USCI A0 Control Register 1 ) 
 
\ UCA0CTL0 ( USCI A0 Control Register 0 ) 
 
\ UCA0BR0 ( USCI A0 Baud Rate 0 ) 
 
\ UCA0BR1 ( USCI A0 Baud Rate 1 ) 
 
\ UCA0STATW ( USCI A0 Status Register ) 
( UCA0STATW-UCBUSY-set ) %1  0 lshift UCA0STATW bis! 
( UCA0STATW-UCOE-set ) %1  5 lshift UCA0STATW bis! 
( UCA0STATW-UCFE-set ) %1  6 lshift UCA0STATW bis! 
( UCA0STATW-UCLISTEN-set ) %1  7 lshift UCA0STATW bis! 
 
\ UCA0IE ( USCI A0 Interrupt Enable Register ) 
( UCA0IE-UCRXIE-set ) %1  0 lshift UCA0IE bis! 
( UCA0IE-UCTXIE-set ) %1  1 lshift UCA0IE bis! 
 
\ UCA0IFG ( USCI A0 Interrupt Flags Register ) 
( UCA0IFG-UCRXIFG-set ) %1  0 lshift UCA0IFG bis! 
( UCA0IFG-UCTXIFG-set ) %1  1 lshift UCA0IFG bis! 
 
\ UCA0RXBUF ( USCI A0 Receive Buffer ) 
 
\ UCA0TXBUF ( USCI A0 Transmit Buffer ) 
 
\ UCA0IV ( USCI A0 Interrupt Vector Register ) 


                     
\ ===================================USCI_A1_UART_MODE =================================== 
\ UCA1CTL1 ( USCI A1 Control Register 1 ) 
 
\ UCA1CTL0 ( USCI A1 Control Register 0 ) 
 
\ UCA1BR0 ( USCI A1 Baud Rate 0 ) 
 
\ UCA1BR1 ( USCI A1 Baud Rate 1 ) 
 
\ UCA1STATW ( USCI A1 Status Register ) 
( UCA1STATW-UCBUSY-set ) %1  0 lshift UCA1STATW bis! 
( UCA1STATW-UCADDR-set ) %1  1 lshift UCA1STATW bis! 
( UCA1STATW-UCRXERR-set ) %1  2 lshift UCA1STATW bis! 
( UCA1STATW-UCBRK-set ) %1  3 lshift UCA1STATW bis! 
( UCA1STATW-UCPE-set ) %1  4 lshift UCA1STATW bis! 
( UCA1STATW-UCOE-set ) %1  5 lshift UCA1STATW bis! 
( UCA1STATW-UCFE-set ) %1  6 lshift UCA1STATW bis! 
( UCA1STATW-UCLISTEN-set ) %1  7 lshift UCA1STATW bis! 
 
\ UCA1ABCTL ( USCI A1 LIN Control ) 
( UCA1ABCTL-UCABDEN-set ) %1  0 lshift UCA1ABCTL bis! 
( UCA1ABCTL-UCBTOE-set ) %1  2 lshift UCA1ABCTL bis! 
( UCA1ABCTL-UCSTOE-set ) %1  3 lshift UCA1ABCTL bis! 
( UCA1ABCTL-UCDELIM0-set ) %1  4 lshift UCA1ABCTL bis! 
( UCA1ABCTL-UCDELIM1-set ) %1  5 lshift UCA1ABCTL bis! 
 
\ UCA1IRTCTL ( USCI A1 IrDA Transmit Control ) 
 
\ UCA1IRRCTL ( USCI A1 IrDA Receive Control ) 
 
\ UCA1CTLW1 ( USCI A1 Control Word Register 1 ) 
( UCA1CTLW1-UCGLIT-set ) %xx  0 lshift
    \ %0: UCGLIT_0      ( USCI Deglitch time: 0 ) 
    \ %1: UCGLIT_1      ( USCI Deglitch time: 1 ) 
    \ %11: UCGLIT_2      ( USCI Deglitch time: 2 ) 
    \ %111: UCGLIT_3      ( USCI Deglitch time: 3 )  UCA1CTLW1 bis! 
 
\ UCA1MCTLW ( USCI A1 Modulation Control ) 
( UCA1MCTLW-UCOS16-set ) %1  0 lshift UCA1MCTLW bis! 
( UCA1MCTLW-UCBRF-set ) %xxxx  4 lshift
    \ %0: UCBRF_0      ( USCI First Stage Modulation: 0 ) 
    \ %1: UCBRF_1      ( USCI First Stage Modulation: 1 ) 
    \ %11: UCBRF_2      ( USCI First Stage Modulation: 2 ) 
    \ %111: UCBRF_3      ( USCI First Stage Modulation: 3 ) 
    \ %1111: UCBRF_4      ( USCI First Stage Modulation: 4 ) 
    \ %11111: UCBRF_5      ( USCI First Stage Modulation: 5 ) 
    \ %111111: UCBRF_6      ( USCI First Stage Modulation: 6 ) 
    \ %1111111: UCBRF_7      ( USCI First Stage Modulation: 7 ) 
    \ %11111111: UCBRF_8      ( USCI First Stage Modulation: 8 ) 
    \ %111111111: UCBRF_9      ( USCI First Stage Modulation: 9 ) 
    \ %1111111111: UCBRF_10      ( USCI First Stage Modulation: A ) 
    \ %11111111111: UCBRF_11      ( USCI First Stage Modulation: B ) 
    \ %111111111111: UCBRF_12      ( USCI First Stage Modulation: C ) 
    \ %1111111111111: UCBRF_13      ( USCI First Stage Modulation: D ) 
    \ %11111111111111: UCBRF_14      ( USCI First Stage Modulation: E ) 
    \ %111111111111111: UCBRF_15      ( USCI First Stage Modulation: F )  UCA1MCTLW bis! 
( UCA1MCTLW-UCBRS0-set ) %1  8 lshift UCA1MCTLW bis! 
( UCA1MCTLW-UCBRS1-set ) %1  9 lshift UCA1MCTLW bis! 
( UCA1MCTLW-UCBRS2-set ) %1  10 lshift UCA1MCTLW bis! 
( UCA1MCTLW-UCBRS3-set ) %1  11 lshift UCA1MCTLW bis! 
( UCA1MCTLW-UCBRS4-set ) %1  12 lshift UCA1MCTLW bis! 
( UCA1MCTLW-UCBRS5-set ) %1  13 lshift UCA1MCTLW bis! 
( UCA1MCTLW-UCBRS6-set ) %1  14 lshift UCA1MCTLW bis! 
( UCA1MCTLW-UCBRS7-set ) %1  15 lshift UCA1MCTLW bis! 
 
\ UCA1RXBUF ( USCI A1 Receive Buffer ) 
 
\ UCA1TXBUF ( USCI A1 Transmit Buffer ) 
 
\ UCA1IV ( USCI A1 Interrupt Vector Register ) 


                     
\ ===================================USCI_A1_SPI_MODE =================================== 
\ UCA1CTL1 ( USCI A1 Control Register 1 ) 
 
\ UCA1CTL0 ( USCI A1 Control Register 0 ) 
 
\ UCA1BR0 ( USCI A1 Baud Rate 0 ) 
 
\ UCA1BR1 ( USCI A1 Baud Rate 1 ) 
 
\ UCA1STATW ( USCI A1 Status Register ) 
( UCA1STATW-UCBUSY-set ) %1  0 lshift UCA1STATW bis! 
( UCA1STATW-UCOE-set ) %1  5 lshift UCA1STATW bis! 
( UCA1STATW-UCFE-set ) %1  6 lshift UCA1STATW bis! 
( UCA1STATW-UCLISTEN-set ) %1  7 lshift UCA1STATW bis! 
 
\ UCA1IE ( USCI A1 Interrupt Enable Register ) 
( UCA1IE-UCRXIE-set ) %1  0 lshift UCA1IE bis! 
( UCA1IE-UCTXIE-set ) %1  1 lshift UCA1IE bis! 
 
\ UCA1IFG ( USCI A1 Interrupt Flags Register ) 
( UCA1IFG-UCRXIFG-set ) %1  0 lshift UCA1IFG bis! 
( UCA1IFG-UCTXIFG-set ) %1  1 lshift UCA1IFG bis! 
 
\ UCA1RXBUF ( USCI A1 Receive Buffer ) 
 
\ UCA1TXBUF ( USCI A1 Transmit Buffer ) 
 
\ UCA1IV ( USCI A1 Interrupt Vector Register ) 


                     
\ ===================================USCI_B0_I2C_MODE =================================== 
\ UCB0CTL1 ( USCI B0 Control Register 1 ) 
 
\ UCB0CTL0 ( USCI B0 Control Register 0 ) 
 
\ UCB0BR0 ( USCI B0 Baud Rate 0 ) 
 
\ UCB0BR1 ( USCI B0 Baud Rate 1 ) 
 
\ UCB0STAT ( USCI B0 Status Register ) 
( UCB0STAT-UCBBUSY-set ) %1  4 lshift UCB0STAT bis! 
( UCB0STAT-UCGC-set ) %1  5 lshift UCB0STAT bis! 
( UCB0STAT-UCSCLLOW-set ) %1  6 lshift UCB0STAT bis! 
 
\ UCB0BCNT ( USCI B0 Byte Counter Register ) 
( UCB0BCNT-UCBCNT0-set ) %1  0 lshift UCB0BCNT bis! 
( UCB0BCNT-UCBCNT1-set ) %1  1 lshift UCB0BCNT bis! 
( UCB0BCNT-UCBCNT2-set ) %1  2 lshift UCB0BCNT bis! 
( UCB0BCNT-UCBCNT3-set ) %1  3 lshift UCB0BCNT bis! 
( UCB0BCNT-UCBCNT4-set ) %1  4 lshift UCB0BCNT bis! 
( UCB0BCNT-UCBCNT5-set ) %1  5 lshift UCB0BCNT bis! 
( UCB0BCNT-UCBCNT6-set ) %1  6 lshift UCB0BCNT bis! 
( UCB0BCNT-UCBCNT7-set ) %1  7 lshift UCB0BCNT bis! 
 
\ UCB0CTLW1 ( USCI B0 Control Word Register 1 ) 
( UCB0CTLW1-UCGLIT-set ) %xx  0 lshift
    \ %0: UCGLIT_0      ( USCI Deglitch time: 0 ) 
    \ %1: UCGLIT_1      ( USCI Deglitch time: 1 ) 
    \ %11: UCGLIT_2      ( USCI Deglitch time: 2 ) 
    \ %111: UCGLIT_3      ( USCI Deglitch time: 3 )  UCB0CTLW1 bis! 
( UCB0CTLW1-UCASTP-set ) %xx  2 lshift
    \ %0: UCASTP_0      ( USCI Automatic Stop condition generation: 0 ) 
    \ %1: UCASTP_1      ( USCI Automatic Stop condition generation: 1 ) 
    \ %11: UCASTP_2      ( USCI Automatic Stop condition generation: 2 ) 
    \ %111: UCASTP_3      ( USCI Automatic Stop condition generation: 3 )  UCB0CTLW1 bis! 
( UCB0CTLW1-UCSWACK-set ) %1  4 lshift UCB0CTLW1 bis! 
( UCB0CTLW1-UCSTPNACK-set ) %1  5 lshift UCB0CTLW1 bis! 
( UCB0CTLW1-UCCLTO-set ) %xx  6 lshift
    \ %0: UCCLTO_0      ( USCI Clock low timeout: 0 ) 
    \ %1: UCCLTO_1      ( USCI Clock low timeout: 1 ) 
    \ %11: UCCLTO_2      ( USCI Clock low timeout: 2 ) 
    \ %111: UCCLTO_3      ( USCI Clock low timeout: 3 )  UCB0CTLW1 bis! 
( UCB0CTLW1-UCETXINT-set ) %1  8 lshift UCB0CTLW1 bis! 
 
\ UCB0TBCNT ( USCI B0 Byte Counter Threshold Register ) 
 
\ UCB0RXBUF ( USCI B0 Receive Buffer ) 
 
\ UCB0TXBUF ( USCI B0 Transmit Buffer ) 
 
\ UCB0I2COA0 ( USCI B0 I2C Own Address 0 ) 
( UCB0I2COA0-UCOA0-set ) %1  0 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOA1-set ) %1  1 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOA2-set ) %1  2 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOA3-set ) %1  3 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOA4-set ) %1  4 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOA5-set ) %1  5 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOA6-set ) %1  6 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOA7-set ) %1  7 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOA8-set ) %1  8 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOA9-set ) %1  9 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCOAEN-set ) %1  10 lshift UCB0I2COA0 bis! 
( UCB0I2COA0-UCGCEN-set ) %1  15 lshift UCB0I2COA0 bis! 
 
\ UCB0I2COA1 ( USCI B0 I2C Own Address 1 ) 
( UCB0I2COA1-UCOA0-set ) %1  0 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOA1-set ) %1  1 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOA2-set ) %1  2 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOA3-set ) %1  3 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOA4-set ) %1  4 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOA5-set ) %1  5 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOA6-set ) %1  6 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOA7-set ) %1  7 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOA8-set ) %1  8 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOA9-set ) %1  9 lshift UCB0I2COA1 bis! 
( UCB0I2COA1-UCOAEN-set ) %1  10 lshift UCB0I2COA1 bis! 
 
\ UCB0I2COA2 ( USCI B0 I2C Own Address 2 ) 
( UCB0I2COA2-UCOA0-set ) %1  0 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOA1-set ) %1  1 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOA2-set ) %1  2 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOA3-set ) %1  3 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOA4-set ) %1  4 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOA5-set ) %1  5 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOA6-set ) %1  6 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOA7-set ) %1  7 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOA8-set ) %1  8 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOA9-set ) %1  9 lshift UCB0I2COA2 bis! 
( UCB0I2COA2-UCOAEN-set ) %1  10 lshift UCB0I2COA2 bis! 
 
\ UCB0I2COA3 ( USCI B0 I2C Own Address 3 ) 
( UCB0I2COA3-UCOA0-set ) %1  0 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOA1-set ) %1  1 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOA2-set ) %1  2 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOA3-set ) %1  3 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOA4-set ) %1  4 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOA5-set ) %1  5 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOA6-set ) %1  6 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOA7-set ) %1  7 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOA8-set ) %1  8 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOA9-set ) %1  9 lshift UCB0I2COA3 bis! 
( UCB0I2COA3-UCOAEN-set ) %1  10 lshift UCB0I2COA3 bis! 
 
\ UCB0ADDRX ( USCI B0 Received Address Register ) 
( UCB0ADDRX-UCADDRX0-set ) %1  0 lshift UCB0ADDRX bis! 
( UCB0ADDRX-UCADDRX1-set ) %1  1 lshift UCB0ADDRX bis! 
( UCB0ADDRX-UCADDRX2-set ) %1  2 lshift UCB0ADDRX bis! 
( UCB0ADDRX-UCADDRX3-set ) %1  3 lshift UCB0ADDRX bis! 
( UCB0ADDRX-UCADDRX4-set ) %1  4 lshift UCB0ADDRX bis! 
( UCB0ADDRX-UCADDRX5-set ) %1  5 lshift UCB0ADDRX bis! 
( UCB0ADDRX-UCADDRX6-set ) %1  6 lshift UCB0ADDRX bis! 
( UCB0ADDRX-UCADDRX7-set ) %1  7 lshift UCB0ADDRX bis! 
( UCB0ADDRX-UCADDRX8-set ) %1  8 lshift UCB0ADDRX bis! 
( UCB0ADDRX-UCADDRX9-set ) %1  9 lshift UCB0ADDRX bis! 
 
\ UCB0ADDMASK ( USCI B0 Address Mask Register ) 
( UCB0ADDMASK-UCADDMASK0-set ) %1  0 lshift UCB0ADDMASK bis! 
( UCB0ADDMASK-UCADDMASK1-set ) %1  1 lshift UCB0ADDMASK bis! 
( UCB0ADDMASK-UCADDMASK2-set ) %1  2 lshift UCB0ADDMASK bis! 
( UCB0ADDMASK-UCADDMASK3-set ) %1  3 lshift UCB0ADDMASK bis! 
( UCB0ADDMASK-UCADDMASK4-set ) %1  4 lshift UCB0ADDMASK bis! 
( UCB0ADDMASK-UCADDMASK5-set ) %1  5 lshift UCB0ADDMASK bis! 
( UCB0ADDMASK-UCADDMASK6-set ) %1  6 lshift UCB0ADDMASK bis! 
( UCB0ADDMASK-UCADDMASK7-set ) %1  7 lshift UCB0ADDMASK bis! 
( UCB0ADDMASK-UCADDMASK8-set ) %1  8 lshift UCB0ADDMASK bis! 
( UCB0ADDMASK-UCADDMASK9-set ) %1  9 lshift UCB0ADDMASK bis! 
 
\ UCB0I2CSA ( USCI B0 I2C Slave Address ) 
( UCB0I2CSA-UCSA0-set ) %1  0 lshift UCB0I2CSA bis! 
( UCB0I2CSA-UCSA1-set ) %1  1 lshift UCB0I2CSA bis! 
( UCB0I2CSA-UCSA2-set ) %1  2 lshift UCB0I2CSA bis! 
( UCB0I2CSA-UCSA3-set ) %1  3 lshift UCB0I2CSA bis! 
( UCB0I2CSA-UCSA4-set ) %1  4 lshift UCB0I2CSA bis! 
( UCB0I2CSA-UCSA5-set ) %1  5 lshift UCB0I2CSA bis! 
( UCB0I2CSA-UCSA6-set ) %1  6 lshift UCB0I2CSA bis! 
( UCB0I2CSA-UCSA7-set ) %1  7 lshift UCB0I2CSA bis! 
( UCB0I2CSA-UCSA8-set ) %1  8 lshift UCB0I2CSA bis! 
( UCB0I2CSA-UCSA9-set ) %1  9 lshift UCB0I2CSA bis! 
 
\ UCB0IE ( USCI B0 Interrupt Enable Register ) 
 
\ UCB0IE ( USCI B0 Interrupt Enable Register ) 
( UCB0IE-UCRXIE0-set ) %1  0 lshift UCB0IE bis! 
( UCB0IE-UCTXIE0-set ) %1  1 lshift UCB0IE bis! 
( UCB0IE-UCSTTIE-set ) %1  2 lshift UCB0IE bis! 
( UCB0IE-UCSTPIE-set ) %1  3 lshift UCB0IE bis! 
( UCB0IE-UCALIE-set ) %1  4 lshift UCB0IE bis! 
( UCB0IE-UCNACKIE-set ) %1  5 lshift UCB0IE bis! 
( UCB0IE-UCBCNTIE-set ) %1  6 lshift UCB0IE bis! 
( UCB0IE-UCCLTOIE-set ) %1  7 lshift UCB0IE bis! 
( UCB0IE-UCRXIE1-set ) %1  8 lshift UCB0IE bis! 
( UCB0IE-UCTXIE1-set ) %1  9 lshift UCB0IE bis! 
( UCB0IE-UCRXIE2-set ) %1  10 lshift UCB0IE bis! 
( UCB0IE-UCTXIE2-set ) %1  11 lshift UCB0IE bis! 
( UCB0IE-UCRXIE3-set ) %1  12 lshift UCB0IE bis! 
( UCB0IE-UCTXIE3-set ) %1  13 lshift UCB0IE bis! 
( UCB0IE-UCBIT9IE-set ) %1  14 lshift UCB0IE bis! 
 
\ UCB0IFG ( USCI B0 Interrupt Flags Register ) 
 
\ UCB0IFG ( USCI B0 Interrupt Flags Register ) 
( UCB0IFG-UCRXIFG0-set ) %1  0 lshift UCB0IFG bis! 
( UCB0IFG-UCTXIFG0-set ) %1  1 lshift UCB0IFG bis! 
( UCB0IFG-UCSTTIFG-set ) %1  2 lshift UCB0IFG bis! 
( UCB0IFG-UCSTPIFG-set ) %1  3 lshift UCB0IFG bis! 
( UCB0IFG-UCALIFG-set ) %1  4 lshift UCB0IFG bis! 
( UCB0IFG-UCNACKIFG-set ) %1  5 lshift UCB0IFG bis! 
( UCB0IFG-UCBCNTIFG-set ) %1  6 lshift UCB0IFG bis! 
( UCB0IFG-UCCLTOIFG-set ) %1  7 lshift UCB0IFG bis! 
( UCB0IFG-UCRXIFG1-set ) %1  8 lshift UCB0IFG bis! 
( UCB0IFG-UCTXIFG1-set ) %1  9 lshift UCB0IFG bis! 
( UCB0IFG-UCRXIFG2-set ) %1  10 lshift UCB0IFG bis! 
( UCB0IFG-UCTXIFG2-set ) %1  11 lshift UCB0IFG bis! 
( UCB0IFG-UCRXIFG3-set ) %1  12 lshift UCB0IFG bis! 
( UCB0IFG-UCTXIFG3-set ) %1  13 lshift UCB0IFG bis! 
( UCB0IFG-UCBIT9IFG-set ) %1  14 lshift UCB0IFG bis! 
 
\ UCB0IV ( USCI B0 Interrupt Vector Register ) 


                     
\ ===================================USCI_B0_SPI_MODE =================================== 
\ UCB0CTL1 ( USCI B0 Control Register 1 ) 
 
\ UCB0CTL0 ( USCI B0 Control Register 0 ) 
 
\ UCB0BR0 ( USCI B0 Baud Rate 0 ) 
 
\ UCB0BR1 ( USCI B0 Baud Rate 1 ) 
 
\ UCB0RXBUF ( USCI B0 Receive Buffer ) 
 
\ UCB0TXBUF ( USCI B0 Transmit Buffer ) 
 
\ UCB0IE ( USCI B0 Interrupt Enable Register ) 
( UCB0IE-UCRXIE-set ) %1  0 lshift UCB0IE bis! 
( UCB0IE-UCTXIE-set ) %1  1 lshift UCB0IE bis! 
 
\ UCB0IFG ( USCI B0 Interrupt Flags Register ) 
( UCB0IFG-UCRXIFG-set ) %1  0 lshift UCB0IFG bis! 
( UCB0IFG-UCTXIFG-set ) %1  1 lshift UCB0IFG bis! 
 
\ UCB0IV ( USCI B0 Interrupt Vector Register ) 


                     
\ ===================================SFR =================================== 
\ SFRIE1 ( Interrupt Enable 1 ) 
( SFRIE1-WDTIE-set ) %1  0 lshift SFRIE1 bis! 
( SFRIE1-OFIE-set ) %1  1 lshift SFRIE1 bis! 
( SFRIE1-VMAIE-set ) %1  3 lshift SFRIE1 bis! 
( SFRIE1-NMIIE-set ) %1  4 lshift SFRIE1 bis! 
( SFRIE1-JMBINIE-set ) %1  6 lshift SFRIE1 bis! 
( SFRIE1-JMBOUTIE-set ) %1  7 lshift SFRIE1 bis! 
 
\ SFRIFG1 ( Interrupt Flag 1 ) 
( SFRIFG1-WDTIFG-set ) %1  0 lshift SFRIFG1 bis! 
( SFRIFG1-OFIFG-set ) %1  1 lshift SFRIFG1 bis! 
( SFRIFG1-VMAIFG-set ) %1  3 lshift SFRIFG1 bis! 
( SFRIFG1-NMIIFG-set ) %1  4 lshift SFRIFG1 bis! 
( SFRIFG1-JMBINIFG-set ) %1  6 lshift SFRIFG1 bis! 
( SFRIFG1-JMBOUTIFG-set ) %1  7 lshift SFRIFG1 bis! 
 
\ SFRRPCR ( RESET Pin Control Register ) 
( SFRRPCR-SYSNMI-set ) %1  0 lshift SFRRPCR bis! 
( SFRRPCR-SYSNMIIES-set ) %1  1 lshift SFRRPCR bis! 
( SFRRPCR-SYSRSTUP-set ) %1  2 lshift SFRRPCR bis! 
( SFRRPCR-SYSRSTRE-set ) %1  3 lshift SFRRPCR bis! 


                     
\ ===================================PMM =================================== 
\ PMMCTL0 ( PMM Control 0 ) 
( PMMCTL0-PMMSWBOR-set ) %1  2 lshift PMMCTL0 bis! 
( PMMCTL0-PMMSWPOR-set ) %1  3 lshift PMMCTL0 bis! 
( PMMCTL0-PMMREGOFF-set ) %1  4 lshift PMMCTL0 bis! 
( PMMCTL0-SVSHE-set ) %1  6 lshift PMMCTL0 bis! 
 
\ PMMCTL1 ( PMM Control 1 ) 
 
\ PMMCTL2 ( PMM Control 2 ) 
( PMMCTL2-INTREFEN-set ) %1  0 lshift PMMCTL2 bis! 
( PMMCTL2-EXTREFEN-set ) %1  1 lshift PMMCTL2 bis! 
( PMMCTL2-TSENSOREN-set ) %1  3 lshift PMMCTL2 bis! 
( PMMCTL2-REFGENACT-set ) %1  8 lshift PMMCTL2 bis! 
( PMMCTL2-REFBGACT-set ) %1  9 lshift PMMCTL2 bis! 
( PMMCTL2-BGMODE-set ) %1  11 lshift PMMCTL2 bis! 
( PMMCTL2-REFGENRDY-set ) %1  12 lshift PMMCTL2 bis! 
( PMMCTL2-REFBGRDY-set ) %1  13 lshift PMMCTL2 bis! 
 
\ PMMIFG ( PMM Interrupt Flag ) 
( PMMIFG-PMMBORIFG-set ) %1  8 lshift PMMIFG bis! 
( PMMIFG-PMMRSTIFG-set ) %1  9 lshift PMMIFG bis! 
( PMMIFG-PMMPORIFG-set ) %1  10 lshift PMMIFG bis! 
( PMMIFG-SVSHIFG-set ) %1  13 lshift PMMIFG bis! 
( PMMIFG-PMMLPM5IFG-set ) %1  15 lshift PMMIFG bis! 
 
\ PMMIE ( PMM Interrupt Enable ) 
 
\ PM5CTL0 ( PMM Power Mode 5 Control Register 0 ) 
( PM5CTL0-LOCKLPM5-set ) %1  0 lshift PM5CTL0 bis! 
( PM5CTL0-LPM5SW-set ) %1  4 lshift PM5CTL0 bis! 
( PM5CTL0-LPM5SM-set ) %1  5 lshift PM5CTL0 bis! 


                     
\ ===================================SYS =================================== 
\ SYSCTL ( System control ) 
( SYSCTL-SYSRIVECT-set ) %1  0 lshift SYSCTL bis! 
( SYSCTL-SYSPMMPE-set ) %1  2 lshift SYSCTL bis! 
( SYSCTL-SYSBSLIND-set ) %1  4 lshift SYSCTL bis! 
( SYSCTL-SYSJTAGPIN-set ) %1  5 lshift SYSCTL bis! 
 
\ SYSBSLC ( Boot strap configuration area ) 
( SYSBSLC-SYSBSLR-set ) %1  2 lshift SYSBSLC bis! 
( SYSBSLC-SYSBSLOFF-set ) %1  14 lshift SYSBSLC bis! 
( SYSBSLC-SYSBSLPE-set ) %1  15 lshift SYSBSLC bis! 
 
\ SYSJMBC ( JTAG mailbox control ) 
( SYSJMBC-JMBIN0FG-set ) %1  0 lshift SYSJMBC bis! 
( SYSJMBC-JMBIN1FG-set ) %1  1 lshift SYSJMBC bis! 
( SYSJMBC-JMBOUT0FG-set ) %1  2 lshift SYSJMBC bis! 
( SYSJMBC-JMBOUT1FG-set ) %1  3 lshift SYSJMBC bis! 
( SYSJMBC-JMBMODE-set ) %1  4 lshift SYSJMBC bis! 
( SYSJMBC-JMBCLR0OFF-set ) %1  6 lshift SYSJMBC bis! 
( SYSJMBC-JMBCLR1OFF-set ) %1  7 lshift SYSJMBC bis! 
 
\ SYSJMBI0 ( JTAG mailbox input 0 ) 
 
\ SYSJMBI1 ( JTAG mailbox input 1 ) 
 
\ SYSJMBO0 ( JTAG mailbox output 0 ) 
 
\ SYSJMBO1 ( JTAG mailbox output 1 ) 
 
\ SYSBERRIV ( Bus Error vector generator ) 
 
\ SYSUNIV ( User NMI vector generator ) 
 
\ SYSSNIV ( System NMI vector generator ) 
 
\ SYSRSTIV ( Reset vector generator ) 
 
\ SYSCFG0 ( System Configuration 0 ) 
( SYSCFG0-PFWP-set ) %1  0 lshift SYSCFG0 bis! 
( SYSCFG0-DFWP-set ) %1  1 lshift SYSCFG0 bis! 
 
\ SYSCFG1 ( System Configuration 1 ) 
( SYSCFG1-IREN-set ) %1  0 lshift SYSCFG1 bis! 
( SYSCFG1-IRPSEL-set ) %1  1 lshift SYSCFG1 bis! 
( SYSCFG1-IRMSEL-set ) %1  2 lshift SYSCFG1 bis! 
( SYSCFG1-IRDSSEL-set ) %1  3 lshift SYSCFG1 bis! 
( SYSCFG1-IRDATA-set ) %1  4 lshift SYSCFG1 bis! 
 
\ SYSCFG2 ( System Configuration 2 ) 
( SYSCFG2-ADCPCTL0-set ) %1  0 lshift SYSCFG2 bis! 
( SYSCFG2-ADCPCTL1-set ) %1  1 lshift SYSCFG2 bis! 
( SYSCFG2-ADCPCTL2-set ) %1  2 lshift SYSCFG2 bis! 
( SYSCFG2-ADCPCTL3-set ) %1  3 lshift SYSCFG2 bis! 
( SYSCFG2-ADCPCTL4-set ) %1  4 lshift SYSCFG2 bis! 
( SYSCFG2-ADCPCTL5-set ) %1  5 lshift SYSCFG2 bis! 
( SYSCFG2-ADCPCTL6-set ) %1  6 lshift SYSCFG2 bis! 
( SYSCFG2-ADCPCTL7-set ) %1  7 lshift SYSCFG2 bis! 


                     
\ ===================================CS =================================== 
\ CSCTL0 ( CS Control Register 0 ) 
( CSCTL0-DCO0-set ) %1  0 lshift CSCTL0 bis! 
( CSCTL0-DCO1-set ) %1  1 lshift CSCTL0 bis! 
( CSCTL0-DCO2-set ) %1  2 lshift CSCTL0 bis! 
( CSCTL0-DCO3-set ) %1  3 lshift CSCTL0 bis! 
( CSCTL0-DCO4-set ) %1  4 lshift CSCTL0 bis! 
( CSCTL0-DCO5-set ) %1  5 lshift CSCTL0 bis! 
( CSCTL0-DCO6-set ) %1  6 lshift CSCTL0 bis! 
( CSCTL0-DCO7-set ) %1  7 lshift CSCTL0 bis! 
( CSCTL0-DCO8-set ) %1  8 lshift CSCTL0 bis! 
( CSCTL0-MOD0-set ) %1  9 lshift CSCTL0 bis! 
( CSCTL0-MOD1-set ) %1  10 lshift CSCTL0 bis! 
( CSCTL0-MOD2-set ) %1  11 lshift CSCTL0 bis! 
( CSCTL0-MOD3-set ) %1  12 lshift CSCTL0 bis! 
( CSCTL0-MOD4-set ) %1  13 lshift CSCTL0 bis! 
 
\ CSCTL1 ( CS Control Register 1 ) 
( CSCTL1-DISMOD-set ) %1  0 lshift CSCTL1 bis! 
( CSCTL1-DCORSEL-set ) %xxx  1 lshift
    \ %0: DCORSEL_0      ( DCO frequency range select: 0 ) 
    \ %1: DCORSEL_1      ( DCO frequency range select: 1 ) 
    \ %11: DCORSEL_2      ( DCO frequency range select: 2 ) 
    \ %111: DCORSEL_3      ( DCO frequency range select: 3 ) 
    \ %1111: DCORSEL_4      ( DCO frequency range select: 4 ) 
    \ %11111: DCORSEL_5      ( DCO frequency range select: 5 ) 
    \ %111111: DCORSEL_6      ( DCO frequency range select: 6 ) 
    \ %1111111: DCORSEL_7      ( DCO frequency range select: 7 )  CSCTL1 bis! 
( CSCTL1-DCOFTRIM-set ) %xxx  4 lshift
    \ %0: DCOFTRIM_0      ( DCO frequency trim: 0 ) 
    \ %1: DCOFTRIM_1      ( DCO frequency trim: 1 ) 
    \ %11: DCOFTRIM_2      ( DCO frequency trim: 2 ) 
    \ %111: DCOFTRIM_3      ( DCO frequency trim: 3 ) 
    \ %1111: DCOFTRIM_4      ( DCO frequency trim: 4 ) 
    \ %11111: DCOFTRIM_5      ( DCO frequency trim: 5 ) 
    \ %111111: DCOFTRIM_6      ( DCO frequency trim: 6 ) 
    \ %1111111: DCOFTRIM_7      ( DCO frequency trim: 7 )  CSCTL1 bis! 
( CSCTL1-DCOFTRIMEN-set ) %1  7 lshift CSCTL1 bis! 
 
\ CSCTL2 ( CS Control Register 2 ) 
( CSCTL2-FLLN0-set ) %1  0 lshift CSCTL2 bis! 
( CSCTL2-FLLN1-set ) %1  1 lshift CSCTL2 bis! 
( CSCTL2-FLLN2-set ) %1  2 lshift CSCTL2 bis! 
( CSCTL2-FLLN3-set ) %1  3 lshift CSCTL2 bis! 
( CSCTL2-FLLN4-set ) %1  4 lshift CSCTL2 bis! 
( CSCTL2-FLLN5-set ) %1  5 lshift CSCTL2 bis! 
( CSCTL2-FLLN6-set ) %1  6 lshift CSCTL2 bis! 
( CSCTL2-FLLN7-set ) %1  7 lshift CSCTL2 bis! 
( CSCTL2-FLLN8-set ) %1  8 lshift CSCTL2 bis! 
( CSCTL2-FLLN9-set ) %1  9 lshift CSCTL2 bis! 
( CSCTL2-FLLD-set ) %xxx  12 lshift
    \ %0: FLLD_0      ( Multiply Selected Loop Freq. By 1 ) 
    \ %1: FLLD_1      ( Multiply Selected Loop Freq. By 2 ) 
    \ %11: FLLD_2      ( Multiply Selected Loop Freq. By 4 ) 
    \ %111: FLLD_3      ( Multiply Selected Loop Freq. By 8 ) 
    \ %1111: FLLD_4      ( Multiply Selected Loop Freq. By 16 ) 
    \ %11111: FLLD_5      ( Multiply Selected Loop Freq. By 32 ) 
    \ %111111: FLLD_6      ( Reserved ) 
    \ %1111111: FLLD_7      ( Reserved )  CSCTL2 bis! 
 
\ CSCTL3 ( CS Control Register 3 ) 
( CSCTL3-FLLREFDIV-set ) %xxx  0 lshift
    \ %0: FLLREFDIV_0      ( Reference Divider: f(LFCLK)/1 ) 
    \ %1: FLLREFDIV_1      ( Reference Divider: f(LFCLK)/2 ) 
    \ %11: FLLREFDIV_2      ( Reference Divider: f(LFCLK)/4 ) 
    \ %111: FLLREFDIV_3      ( Reference Divider: f(LFCLK)/8 ) 
    \ %1111: FLLREFDIV_4      ( Reference Divider: f(LFCLK)/12 ) 
    \ %11111: FLLREFDIV_5      ( Reference Divider: f(LFCLK)/16 ) 
    \ %111111: FLLREFDIV_6      ( Reference Divider: f(LFCLK)/16 ) 
    \ %1111111: FLLREFDIV_7      ( Reference Divider: f(LFCLK)/16 )  CSCTL3 bis! 
( CSCTL3-SELREF-set ) %xx  4 lshift
    \ %0: SELREF_0      ( FLL Reference Clock Select 0 ) 
    \ %1: SELREF_1      ( FLL Reference Clock Select 1 ) 
    \ %11: SELREF_2      ( FLL Reference Clock Select 2 ) 
    \ %111: SELREF_3      ( FLL Reference Clock Select 3 )  CSCTL3 bis! 
 
\ CSCTL4 ( CS Control Register 4 ) 
( CSCTL4-SELMS-set ) %xxx  0 lshift
    \ %0: SELMS_0      ( MCLK and SMCLK Source Select 0 ) 
    \ %1: SELMS_1      ( MCLK and SMCLK Source Select 1 ) 
    \ %11: SELMS_2      ( MCLK and SMCLK Source Select 2 ) 
    \ %111: SELMS_3      ( MCLK and SMCLK Source Select 3 ) 
    \ %1111: SELMS_4      ( MCLK and SMCLK Source Select 4 ) 
    \ %11111: SELMS_5      ( MCLK and SMCLK Source Select 5 ) 
    \ %111111: SELMS_6      ( MCLK and SMCLK Source Select 6 ) 
    \ %1111111: SELMS_7      ( MCLK and SMCLK Source Select 7 )  CSCTL4 bis! 
( CSCTL4-SELA-set ) %1  8 lshift CSCTL4 bis! 
 
\ CSCTL5 ( CS Control Register 5 ) 
( CSCTL5-DIVM-set ) %xxx  0 lshift
    \ %0: DIVM_0      ( MCLK Source Divider 0 ) 
    \ %1: DIVM_1      ( MCLK Source Divider 1 ) 
    \ %11: DIVM_2      ( MCLK Source Divider 2 ) 
    \ %111: DIVM_3      ( MCLK Source Divider 3 ) 
    \ %1111: DIVM_4      ( MCLK Source Divider 4 ) 
    \ %11111: DIVM_5      ( MCLK Source Divider 5 ) 
    \ %111111: DIVM_6      ( MCLK Source Divider 6 ) 
    \ %1111111: DIVM_7      ( MCLK Source Divider 7 )  CSCTL5 bis! 
( CSCTL5-DIVS-set ) %xx  4 lshift
    \ %0: DIVS_0      ( SMCLK Source Divider 0 ) 
    \ %1: DIVS_1      ( SMCLK Source Divider 1 ) 
    \ %11: DIVS_2      ( SMCLK Source Divider 2 ) 
    \ %111: DIVS_3      ( SMCLK Source Divider 3 )  CSCTL5 bis! 
( CSCTL5-SMCLKOFF-set ) %1  8 lshift CSCTL5 bis! 
( CSCTL5-VLOAUTOOFF-set ) %1  12 lshift CSCTL5 bis! 
 
\ CSCTL6 ( CS Control Register 6 ) 
( CSCTL6-XT1AUTOOFF-set ) %1  0 lshift CSCTL6 bis! 
( CSCTL6-XT1AGCOFF-set ) %1  1 lshift CSCTL6 bis! 
( CSCTL6-XT1BYPASS-set ) %1  4 lshift CSCTL6 bis! 
( CSCTL6-XTS-set ) %1  5 lshift CSCTL6 bis! 
( CSCTL6-XT1DRIVE-set ) %xx  6 lshift
    \ %0: XT1DRIVE_0      ( XT1 Drive Level mode: 0 ) 
    \ %1: XT1DRIVE_1      ( XT1 Drive Level mode: 1 ) 
    \ %11: XT1DRIVE_2      ( XT1 Drive Level mode: 2 ) 
    \ %111: XT1DRIVE_3      ( XT1 Drive Level mode: 3 )  CSCTL6 bis! 
 
\ CSCTL7 ( CS Control Register 7 ) 
( CSCTL7-DCOFFG-set ) %1  0 lshift CSCTL7 bis! 
( CSCTL7-XT1OFFG-set ) %1  1 lshift CSCTL7 bis! 
( CSCTL7-FLLULIFG-set ) %1  4 lshift CSCTL7 bis! 
( CSCTL7-ENSTFCNT1-set ) %1  6 lshift CSCTL7 bis! 
( CSCTL7-FLLUNLOCK-set ) %xx  8 lshift
    \ %0: FLLUNLOCK_0      ( FLL unlock condition: 0 ) 
    \ %1: FLLUNLOCK_1      ( FLL unlock condition: 1 ) 
    \ %11: FLLUNLOCK_2      ( FLL unlock condition: 2 ) 
    \ %111: FLLUNLOCK_3      ( FLL unlock condition: 3 )  CSCTL7 bis! 
( CSCTL7-FLLUNLOCKHIS-set ) %xx  10 lshift
    \ %0: FLLUNLOCKHIS_0      ( Unlock history: 0 ) 
    \ %1: FLLUNLOCKHIS_1      ( Unlock history: 1 ) 
    \ %11: FLLUNLOCKHIS_2      ( Unlock history: 2 ) 
    \ %111: FLLUNLOCKHIS_3      ( Unlock history: 3 )  CSCTL7 bis! 
( CSCTL7-FLLULPUC-set ) %1  12 lshift CSCTL7 bis! 
( CSCTL7-FLLWARNEN-set ) %1  13 lshift CSCTL7 bis! 
 
\ CSCTL8 ( CS Control Register 8 ) 
( CSCTL8-ACLKREQEN-set ) %1  0 lshift CSCTL8 bis! 
( CSCTL8-MCLKREQEN-set ) %1  1 lshift CSCTL8 bis! 
( CSCTL8-SMCLKREQEN-set ) %1  2 lshift CSCTL8 bis! 
( CSCTL8-MODOSCREQEN-set ) %1  3 lshift CSCTL8 bis! 


                     
\ ===================================FRAM =================================== 
\ FRCTL0 ( FRAM Controller Control 0 ) 
( FRCTL0-NWAITS-set ) %xxx  4 lshift
    \ %0: NWAITS_0      ( FRAM Wait state control: 0 ) 
    \ %1: NWAITS_1      ( FRAM Wait state control: 1 ) 
    \ %11: NWAITS_2      ( FRAM Wait state control: 2 ) 
    \ %111: NWAITS_3      ( FRAM Wait state control: 3 ) 
    \ %1111: NWAITS_4      ( FRAM Wait state control: 4 ) 
    \ %11111: NWAITS_5      ( FRAM Wait state control: 5 ) 
    \ %111111: NWAITS_6      ( FRAM Wait state control: 6 ) 
    \ %1111111: NWAITS_7      ( FRAM Wait state control: 7 )  FRCTL0 bis! 
 
\ GCCTL0 ( General Control 0 ) 
( GCCTL0-FRLPMPWR-set ) %1  1 lshift GCCTL0 bis! 
( GCCTL0-FRPWR-set ) %1  2 lshift GCCTL0 bis! 
( GCCTL0-ACCTEIE-set ) %1  3 lshift GCCTL0 bis! 
( GCCTL0-CBDIE-set ) %1  5 lshift GCCTL0 bis! 
( GCCTL0-UBDIE-set ) %1  6 lshift GCCTL0 bis! 
( GCCTL0-UBDRSTEN-set ) %1  7 lshift GCCTL0 bis! 
 
\ GCCTL1 ( General Control 1 ) 
( GCCTL1-CBDIFG-set ) %1  1 lshift GCCTL1 bis! 
( GCCTL1-UBDIFG-set ) %1  2 lshift GCCTL1 bis! 
( GCCTL1-ACCTEIFG-set ) %1  3 lshift GCCTL1 bis! 


                     
\ ===================================CRC16 =================================== 
\ CRCDI ( CRC Data In Register ) 
 
\ CRCDIRB ( CRC data in reverse byte Register ) 
 
\ CRCINIRES ( CRC Initialisation Register and Result Register ) 
 
\ CRCRESR ( CRC reverse result Register ) 


                     
\ ===================================WATCHDOG_TIMER =================================== 
\ WDTCTL ( Watchdog Timer Control ) 
( WDTCTL-WDTIS-set ) %xxx  0 lshift
    \ %0: WDTIS_0      ( WDT - Timer Interval Select: /2G ) 
    \ %1: WDTIS_1      ( WDT - Timer Interval Select: /128M ) 
    \ %11: WDTIS_2      ( WDT - Timer Interval Select: /8192k ) 
    \ %111: WDTIS_3      ( WDT - Timer Interval Select: /512k ) 
    \ %1111: WDTIS_4      ( WDT - Timer Interval Select: /32k ) 
    \ %11111: WDTIS_5      ( WDT - Timer Interval Select: /8192 ) 
    \ %111111: WDTIS_6      ( WDT - Timer Interval Select: /512 ) 
    \ %1111111: WDTIS_7      ( WDT - Timer Interval Select: /64 )  WDTCTL bis! 
( WDTCTL-WDTCNTCL-set ) %1  3 lshift WDTCTL bis! 
( WDTCTL-WDTTMSEL-set ) %1  4 lshift WDTCTL bis! 
( WDTCTL-WDTSSEL-set ) %xx  5 lshift
    \ %0: WDTSSEL_0      ( WDT - Timer Clock Source Select: SMCLK ) 
    \ %1: WDTSSEL_1      ( WDT - Timer Clock Source Select: ACLK ) 
    \ %11: WDTSSEL_2      ( WDT - Timer Clock Source Select: VLO_CLK ) 
    \ %111: WDTSSEL_3      ( WDT - Timer Clock Source Select: reserved )  WDTCTL bis! 
( WDTCTL-WDTHOLD-set ) %1  7 lshift WDTCTL bis! 


                     
\ ===================================REAL_TIME_CLOCK =================================== 
\ RTCCTL ( RTC control Register ) 
( RTCCTL-RTCIF-set ) %1  0 lshift RTCCTL bis! 
( RTCCTL-RTCIE-set ) %1  1 lshift RTCCTL bis! 
( RTCCTL-RTCSR-set ) %1  6 lshift RTCCTL bis! 
( RTCCTL-RTCPS-set ) %xxx  8 lshift
    \ %0: RTCPS_0      ( Low-Power-Counter Clock Pre-divider Select: 0 ) 
    \ %1: RTCPS_1      ( Low-Power-Counter Clock Pre-divider Select: 1 ) 
    \ %11: RTCPS_2      ( Low-Power-Counter Clock Pre-divider Select: 2 ) 
    \ %111: RTCPS_3      ( Low-Power-Counter Clock Pre-divider Select: 3 ) 
    \ %1111: RTCPS_4      ( Low-Power-Counter Clock Pre-divider Select: 4 ) 
    \ %11111: RTCPS_5      ( Low-Power-Counter Clock Pre-divider Select: 5 ) 
    \ %111111: RTCPS_6      ( Low-Power-Counter Clock Pre-divider Select: 6 ) 
    \ %1111111: RTCPS_7      ( Low-Power-Counter Clock Pre-divider Select: 7 )  RTCCTL bis! 
( RTCCTL-RTCSS-set ) %xx  12 lshift
    \ %0: RTCSS_0      ( Low-Power-Counter Clock Source Select: 0 ) 
    \ %1: RTCSS_1      ( Low-Power-Counter Clock Source Select: 1 ) 
    \ %11: RTCSS_2      ( Low-Power-Counter Clock Source Select: 2 ) 
    \ %111: RTCSS_3      ( Low-Power-Counter Clock Source Select: 3 )  RTCCTL bis! 
 
\ RTCIV ( RTC interrupt vector ) 
 
\ RTCMOD ( RTC moduloRegister ) 
 
\ RTCCNT ( RTC counter Register ) 


                     
\ ===================================TIMER_0_A3 =================================== 
\ TA0CTL ( Timer0_A3 Control ) 
( TA0CTL-TAIFG-set ) %1  0 lshift TA0CTL bis! 
( TA0CTL-TAIE-set ) %1  1 lshift TA0CTL bis! 
( TA0CTL-TACLR-set ) %1  2 lshift TA0CTL bis! 
( TA0CTL-MC-set ) %xx  4 lshift
    \ %0: MC_0      ( Timer A mode control: 0 - Stop ) 
    \ %1: MC_1      ( Timer A mode control: 1 - Up to CCR0 ) 
    \ %11: MC_2      ( Timer A mode control: 2 - Continuous up ) 
    \ %111: MC_3      ( Timer A mode control: 3 - Up/Down )  TA0CTL bis! 
( TA0CTL-ID-set ) %xx  6 lshift
    \ %0: ID_0      ( Timer A input divider: 0 - /1 ) 
    \ %1: ID_1      ( Timer A input divider: 1 - /2 ) 
    \ %11: ID_2      ( Timer A input divider: 2 - /4 ) 
    \ %111: ID_3      ( Timer A input divider: 3 - /8 )  TA0CTL bis! 
( TA0CTL-TASSEL-set ) %xx  8 lshift
    \ %0: TASSEL_0      ( Timer A clock source select: 0 - TACLK ) 
    \ %1: TASSEL_1      ( Timer A clock source select: 1 - ACLK ) 
    \ %11: TASSEL_2      ( Timer A clock source select: 2 - SMCLK ) 
    \ %111: TASSEL_3      ( Timer A clock source select: 3 - INCLK )  TA0CTL bis! 
 
\ TA0CCTL0 ( Timer0_A3 Capture/Compare Control 0 ) 
( TA0CCTL0-CCIFG-set ) %1  0 lshift TA0CCTL0 bis! 
( TA0CCTL0-COV-set ) %1  1 lshift TA0CCTL0 bis! 
( TA0CCTL0-OUT-set ) %1  2 lshift TA0CCTL0 bis! 
( TA0CCTL0-CCI-set ) %1  3 lshift TA0CCTL0 bis! 
( TA0CCTL0-CCIE-set ) %1  4 lshift TA0CCTL0 bis! 
( TA0CCTL0-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA0CCTL0 bis! 
( TA0CCTL0-CAP-set ) %1  8 lshift TA0CCTL0 bis! 
( TA0CCTL0-SCCI-set ) %1  10 lshift TA0CCTL0 bis! 
( TA0CCTL0-SCS-set ) %1  11 lshift TA0CCTL0 bis! 
( TA0CCTL0-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA0CCTL0 bis! 
( TA0CCTL0-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA0CCTL0 bis! 
 
\ TA0CCTL1 ( Timer0_A3 Capture/Compare Control 1 ) 
( TA0CCTL1-CCIFG-set ) %1  0 lshift TA0CCTL1 bis! 
( TA0CCTL1-COV-set ) %1  1 lshift TA0CCTL1 bis! 
( TA0CCTL1-OUT-set ) %1  2 lshift TA0CCTL1 bis! 
( TA0CCTL1-CCI-set ) %1  3 lshift TA0CCTL1 bis! 
( TA0CCTL1-CCIE-set ) %1  4 lshift TA0CCTL1 bis! 
( TA0CCTL1-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA0CCTL1 bis! 
( TA0CCTL1-CAP-set ) %1  8 lshift TA0CCTL1 bis! 
( TA0CCTL1-SCCI-set ) %1  10 lshift TA0CCTL1 bis! 
( TA0CCTL1-SCS-set ) %1  11 lshift TA0CCTL1 bis! 
( TA0CCTL1-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA0CCTL1 bis! 
( TA0CCTL1-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA0CCTL1 bis! 
 
\ TA0CCTL2 ( Timer0_A3 Capture/Compare Control 2 ) 
( TA0CCTL2-CCIFG-set ) %1  0 lshift TA0CCTL2 bis! 
( TA0CCTL2-COV-set ) %1  1 lshift TA0CCTL2 bis! 
( TA0CCTL2-OUT-set ) %1  2 lshift TA0CCTL2 bis! 
( TA0CCTL2-CCI-set ) %1  3 lshift TA0CCTL2 bis! 
( TA0CCTL2-CCIE-set ) %1  4 lshift TA0CCTL2 bis! 
( TA0CCTL2-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA0CCTL2 bis! 
( TA0CCTL2-CAP-set ) %1  8 lshift TA0CCTL2 bis! 
( TA0CCTL2-SCCI-set ) %1  10 lshift TA0CCTL2 bis! 
( TA0CCTL2-SCS-set ) %1  11 lshift TA0CCTL2 bis! 
( TA0CCTL2-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA0CCTL2 bis! 
( TA0CCTL2-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA0CCTL2 bis! 
 
\ TA0R ( Timer0_A3 ) 
 
\ TA0CCR0 ( Timer0_A3 Capture/Compare 0 ) 
 
\ TA0CCR1 ( Timer0_A3 Capture/Compare 1 ) 
 
\ TA0CCR2 ( Timer0_A3 Capture/Compare 2 ) 
 
\ TA0EX0 ( Timer0_A3 Expansion Register 0 ) 
( TA0EX0-TAIDEX-set ) %xxx  0 lshift
    \ %0: TAIDEX_0      ( Timer A Input divider expansion : /1 ) 
    \ %1: TAIDEX_1      ( Timer A Input divider expansion : /2 ) 
    \ %11: TAIDEX_2      ( Timer A Input divider expansion : /3 ) 
    \ %111: TAIDEX_3      ( Timer A Input divider expansion : /4 ) 
    \ %1111: TAIDEX_4      ( Timer A Input divider expansion : /5 ) 
    \ %11111: TAIDEX_5      ( Timer A Input divider expansion : /6 ) 
    \ %111111: TAIDEX_6      ( Timer A Input divider expansion : /7 ) 
    \ %1111111: TAIDEX_7      ( Timer A Input divider expansion : /8 )  TA0EX0 bis! 
 
\ TA0IV ( Timer0_A3 Interrupt Vector Word ) 


                     
\ ===================================TIMER_1_A3 =================================== 
\ TA1CTL ( Timer1_A3 Control ) 
( TA1CTL-TAIFG-set ) %1  0 lshift TA1CTL bis! 
( TA1CTL-TAIE-set ) %1  1 lshift TA1CTL bis! 
( TA1CTL-TACLR-set ) %1  2 lshift TA1CTL bis! 
( TA1CTL-MC-set ) %xx  4 lshift
    \ %0: MC_0      ( Timer A mode control: 0 - Stop ) 
    \ %1: MC_1      ( Timer A mode control: 1 - Up to CCR0 ) 
    \ %11: MC_2      ( Timer A mode control: 2 - Continuous up ) 
    \ %111: MC_3      ( Timer A mode control: 3 - Up/Down )  TA1CTL bis! 
( TA1CTL-ID-set ) %xx  6 lshift
    \ %0: ID_0      ( Timer A input divider: 0 - /1 ) 
    \ %1: ID_1      ( Timer A input divider: 1 - /2 ) 
    \ %11: ID_2      ( Timer A input divider: 2 - /4 ) 
    \ %111: ID_3      ( Timer A input divider: 3 - /8 )  TA1CTL bis! 
( TA1CTL-TASSEL-set ) %xx  8 lshift
    \ %0: TASSEL_0      ( Timer A clock source select: 0 - TACLK ) 
    \ %1: TASSEL_1      ( Timer A clock source select: 1 - ACLK ) 
    \ %11: TASSEL_2      ( Timer A clock source select: 2 - SMCLK ) 
    \ %111: TASSEL_3      ( Timer A clock source select: 3 - INCLK )  TA1CTL bis! 
 
\ TA1CCTL0 ( Timer1_A3 Capture/Compare Control 0 ) 
( TA1CCTL0-CCIFG-set ) %1  0 lshift TA1CCTL0 bis! 
( TA1CCTL0-COV-set ) %1  1 lshift TA1CCTL0 bis! 
( TA1CCTL0-OUT-set ) %1  2 lshift TA1CCTL0 bis! 
( TA1CCTL0-CCI-set ) %1  3 lshift TA1CCTL0 bis! 
( TA1CCTL0-CCIE-set ) %1  4 lshift TA1CCTL0 bis! 
( TA1CCTL0-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA1CCTL0 bis! 
( TA1CCTL0-CAP-set ) %1  8 lshift TA1CCTL0 bis! 
( TA1CCTL0-SCCI-set ) %1  10 lshift TA1CCTL0 bis! 
( TA1CCTL0-SCS-set ) %1  11 lshift TA1CCTL0 bis! 
( TA1CCTL0-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA1CCTL0 bis! 
( TA1CCTL0-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA1CCTL0 bis! 
 
\ TA1CCTL1 ( Timer1_A3 Capture/Compare Control 1 ) 
( TA1CCTL1-CCIFG-set ) %1  0 lshift TA1CCTL1 bis! 
( TA1CCTL1-COV-set ) %1  1 lshift TA1CCTL1 bis! 
( TA1CCTL1-OUT-set ) %1  2 lshift TA1CCTL1 bis! 
( TA1CCTL1-CCI-set ) %1  3 lshift TA1CCTL1 bis! 
( TA1CCTL1-CCIE-set ) %1  4 lshift TA1CCTL1 bis! 
( TA1CCTL1-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA1CCTL1 bis! 
( TA1CCTL1-CAP-set ) %1  8 lshift TA1CCTL1 bis! 
( TA1CCTL1-SCCI-set ) %1  10 lshift TA1CCTL1 bis! 
( TA1CCTL1-SCS-set ) %1  11 lshift TA1CCTL1 bis! 
( TA1CCTL1-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA1CCTL1 bis! 
( TA1CCTL1-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA1CCTL1 bis! 
 
\ TA1CCTL2 ( Timer1_A3 Capture/Compare Control 2 ) 
( TA1CCTL2-CCIFG-set ) %1  0 lshift TA1CCTL2 bis! 
( TA1CCTL2-COV-set ) %1  1 lshift TA1CCTL2 bis! 
( TA1CCTL2-OUT-set ) %1  2 lshift TA1CCTL2 bis! 
( TA1CCTL2-CCI-set ) %1  3 lshift TA1CCTL2 bis! 
( TA1CCTL2-CCIE-set ) %1  4 lshift TA1CCTL2 bis! 
( TA1CCTL2-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA1CCTL2 bis! 
( TA1CCTL2-CAP-set ) %1  8 lshift TA1CCTL2 bis! 
( TA1CCTL2-SCCI-set ) %1  10 lshift TA1CCTL2 bis! 
( TA1CCTL2-SCS-set ) %1  11 lshift TA1CCTL2 bis! 
( TA1CCTL2-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA1CCTL2 bis! 
( TA1CCTL2-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA1CCTL2 bis! 
 
\ TA1R ( Timer1_A3 ) 
 
\ TA1CCR0 ( Timer1_A3 Capture/Compare 0 ) 
 
\ TA1CCR1 ( Timer1_A3 Capture/Compare 1 ) 
 
\ TA1CCR2 ( Timer1_A3 Capture/Compare 2 ) 
 
\ TA1EX0 ( Timer1_A3 Expansion Register 0 ) 
( TA1EX0-TAIDEX-set ) %xxx  0 lshift
    \ %0: TAIDEX_0      ( Timer A Input divider expansion : /1 ) 
    \ %1: TAIDEX_1      ( Timer A Input divider expansion : /2 ) 
    \ %11: TAIDEX_2      ( Timer A Input divider expansion : /3 ) 
    \ %111: TAIDEX_3      ( Timer A Input divider expansion : /4 ) 
    \ %1111: TAIDEX_4      ( Timer A Input divider expansion : /5 ) 
    \ %11111: TAIDEX_5      ( Timer A Input divider expansion : /6 ) 
    \ %111111: TAIDEX_6      ( Timer A Input divider expansion : /7 ) 
    \ %1111111: TAIDEX_7      ( Timer A Input divider expansion : /8 )  TA1EX0 bis! 
 
\ TA1IV ( Timer1_A3 Interrupt Vector Word ) 


                     
\ ===================================TIMER_2_A2 =================================== 
\ TA2CTL ( Timer2_A2 Control ) 
( TA2CTL-TAIFG-set ) %1  0 lshift TA2CTL bis! 
( TA2CTL-TAIE-set ) %1  1 lshift TA2CTL bis! 
( TA2CTL-TACLR-set ) %1  2 lshift TA2CTL bis! 
( TA2CTL-MC-set ) %xx  4 lshift
    \ %0: MC_0      ( Timer A mode control: 0 - Stop ) 
    \ %1: MC_1      ( Timer A mode control: 1 - Up to CCR0 ) 
    \ %11: MC_2      ( Timer A mode control: 2 - Continuous up ) 
    \ %111: MC_3      ( Timer A mode control: 3 - Up/Down )  TA2CTL bis! 
( TA2CTL-ID-set ) %xx  6 lshift
    \ %0: ID_0      ( Timer A input divider: 0 - /1 ) 
    \ %1: ID_1      ( Timer A input divider: 1 - /2 ) 
    \ %11: ID_2      ( Timer A input divider: 2 - /4 ) 
    \ %111: ID_3      ( Timer A input divider: 3 - /8 )  TA2CTL bis! 
( TA2CTL-TASSEL-set ) %xx  8 lshift
    \ %0: TASSEL_0      ( Timer A clock source select: 0 - TACLK ) 
    \ %1: TASSEL_1      ( Timer A clock source select: 1 - ACLK ) 
    \ %11: TASSEL_2      ( Timer A clock source select: 2 - SMCLK ) 
    \ %111: TASSEL_3      ( Timer A clock source select: 3 - INCLK )  TA2CTL bis! 
 
\ TA2CCTL0 ( Timer2_A2 Capture/Compare Control 0 ) 
( TA2CCTL0-CCIFG-set ) %1  0 lshift TA2CCTL0 bis! 
( TA2CCTL0-COV-set ) %1  1 lshift TA2CCTL0 bis! 
( TA2CCTL0-OUT-set ) %1  2 lshift TA2CCTL0 bis! 
( TA2CCTL0-CCI-set ) %1  3 lshift TA2CCTL0 bis! 
( TA2CCTL0-CCIE-set ) %1  4 lshift TA2CCTL0 bis! 
( TA2CCTL0-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA2CCTL0 bis! 
( TA2CCTL0-CAP-set ) %1  8 lshift TA2CCTL0 bis! 
( TA2CCTL0-SCCI-set ) %1  10 lshift TA2CCTL0 bis! 
( TA2CCTL0-SCS-set ) %1  11 lshift TA2CCTL0 bis! 
( TA2CCTL0-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA2CCTL0 bis! 
( TA2CCTL0-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA2CCTL0 bis! 
 
\ TA2CCTL1 ( Timer2_A2 Capture/Compare Control 1 ) 
( TA2CCTL1-CCIFG-set ) %1  0 lshift TA2CCTL1 bis! 
( TA2CCTL1-COV-set ) %1  1 lshift TA2CCTL1 bis! 
( TA2CCTL1-OUT-set ) %1  2 lshift TA2CCTL1 bis! 
( TA2CCTL1-CCI-set ) %1  3 lshift TA2CCTL1 bis! 
( TA2CCTL1-CCIE-set ) %1  4 lshift TA2CCTL1 bis! 
( TA2CCTL1-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA2CCTL1 bis! 
( TA2CCTL1-CAP-set ) %1  8 lshift TA2CCTL1 bis! 
( TA2CCTL1-SCCI-set ) %1  10 lshift TA2CCTL1 bis! 
( TA2CCTL1-SCS-set ) %1  11 lshift TA2CCTL1 bis! 
( TA2CCTL1-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA2CCTL1 bis! 
( TA2CCTL1-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA2CCTL1 bis! 
 
\ TA2R ( Timer2_A2 ) 
 
\ TA2CCR0 ( Timer2_A2 Capture/Compare 0 ) 
 
\ TA2CCR1 ( Timer2_A2 Capture/Compare 1 ) 
 
\ TA2EX0 ( Timer2_A2 Expansion Register 0 ) 
( TA2EX0-TAIDEX-set ) %xxx  0 lshift
    \ %0: TAIDEX_0      ( Timer A Input divider expansion : /1 ) 
    \ %1: TAIDEX_1      ( Timer A Input divider expansion : /2 ) 
    \ %11: TAIDEX_2      ( Timer A Input divider expansion : /3 ) 
    \ %111: TAIDEX_3      ( Timer A Input divider expansion : /4 ) 
    \ %1111: TAIDEX_4      ( Timer A Input divider expansion : /5 ) 
    \ %11111: TAIDEX_5      ( Timer A Input divider expansion : /6 ) 
    \ %111111: TAIDEX_6      ( Timer A Input divider expansion : /7 ) 
    \ %1111111: TAIDEX_7      ( Timer A Input divider expansion : /8 )  TA2EX0 bis! 
 
\ TA2IV ( Timer2_A2 Interrupt Vector Word ) 


                     
\ ===================================TIMER_3_A2 =================================== 
\ TA3CTL ( Timer3_A2 Control ) 
( TA3CTL-TAIFG-set ) %1  0 lshift TA3CTL bis! 
( TA3CTL-TAIE-set ) %1  1 lshift TA3CTL bis! 
( TA3CTL-TACLR-set ) %1  2 lshift TA3CTL bis! 
( TA3CTL-MC-set ) %xx  4 lshift
    \ %0: MC_0      ( Timer A mode control: 0 - Stop ) 
    \ %1: MC_1      ( Timer A mode control: 1 - Up to CCR0 ) 
    \ %11: MC_2      ( Timer A mode control: 2 - Continuous up ) 
    \ %111: MC_3      ( Timer A mode control: 3 - Up/Down )  TA3CTL bis! 
( TA3CTL-ID-set ) %xx  6 lshift
    \ %0: ID_0      ( Timer A input divider: 0 - /1 ) 
    \ %1: ID_1      ( Timer A input divider: 1 - /2 ) 
    \ %11: ID_2      ( Timer A input divider: 2 - /4 ) 
    \ %111: ID_3      ( Timer A input divider: 3 - /8 )  TA3CTL bis! 
( TA3CTL-TASSEL-set ) %xx  8 lshift
    \ %0: TASSEL_0      ( Timer A clock source select: 0 - TACLK ) 
    \ %1: TASSEL_1      ( Timer A clock source select: 1 - ACLK ) 
    \ %11: TASSEL_2      ( Timer A clock source select: 2 - SMCLK ) 
    \ %111: TASSEL_3      ( Timer A clock source select: 3 - INCLK )  TA3CTL bis! 
 
\ TA3CCTL0 ( Timer3_A2 Capture/Compare Control 0 ) 
( TA3CCTL0-CCIFG-set ) %1  0 lshift TA3CCTL0 bis! 
( TA3CCTL0-COV-set ) %1  1 lshift TA3CCTL0 bis! 
( TA3CCTL0-OUT-set ) %1  2 lshift TA3CCTL0 bis! 
( TA3CCTL0-CCI-set ) %1  3 lshift TA3CCTL0 bis! 
( TA3CCTL0-CCIE-set ) %1  4 lshift TA3CCTL0 bis! 
( TA3CCTL0-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA3CCTL0 bis! 
( TA3CCTL0-CAP-set ) %1  8 lshift TA3CCTL0 bis! 
( TA3CCTL0-SCCI-set ) %1  10 lshift TA3CCTL0 bis! 
( TA3CCTL0-SCS-set ) %1  11 lshift TA3CCTL0 bis! 
( TA3CCTL0-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA3CCTL0 bis! 
( TA3CCTL0-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA3CCTL0 bis! 
 
\ TA3CCTL1 ( Timer3_A2 Capture/Compare Control 1 ) 
( TA3CCTL1-CCIFG-set ) %1  0 lshift TA3CCTL1 bis! 
( TA3CCTL1-COV-set ) %1  1 lshift TA3CCTL1 bis! 
( TA3CCTL1-OUT-set ) %1  2 lshift TA3CCTL1 bis! 
( TA3CCTL1-CCI-set ) %1  3 lshift TA3CCTL1 bis! 
( TA3CCTL1-CCIE-set ) %1  4 lshift TA3CCTL1 bis! 
( TA3CCTL1-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA3CCTL1 bis! 
( TA3CCTL1-CAP-set ) %1  8 lshift TA3CCTL1 bis! 
( TA3CCTL1-SCCI-set ) %1  10 lshift TA3CCTL1 bis! 
( TA3CCTL1-SCS-set ) %1  11 lshift TA3CCTL1 bis! 
( TA3CCTL1-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA3CCTL1 bis! 
( TA3CCTL1-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA3CCTL1 bis! 
 
\ TA3R ( Timer3_A2 ) 
 
\ TA3CCR0 ( Timer3_A2 Capture/Compare 0 ) 
 
\ TA3CCR1 ( Timer3_A2 Capture/Compare 1 ) 
 
\ TA3EX0 ( Timer3_A2 Expansion Register 0 ) 
( TA3EX0-TAIDEX-set ) %xxx  0 lshift
    \ %0: TAIDEX_0      ( Timer A Input divider expansion : /1 ) 
    \ %1: TAIDEX_1      ( Timer A Input divider expansion : /2 ) 
    \ %11: TAIDEX_2      ( Timer A Input divider expansion : /3 ) 
    \ %111: TAIDEX_3      ( Timer A Input divider expansion : /4 ) 
    \ %1111: TAIDEX_4      ( Timer A Input divider expansion : /5 ) 
    \ %11111: TAIDEX_5      ( Timer A Input divider expansion : /6 ) 
    \ %111111: TAIDEX_6      ( Timer A Input divider expansion : /7 ) 
    \ %1111111: TAIDEX_7      ( Timer A Input divider expansion : /8 )  TA3EX0 bis! 
 
\ TA3IV ( Timer3_A2 Interrupt Vector Word ) 


                     
\ ===================================MPY_16 =================================== 
\ MPY ( Multiply Unsigned/Operand 1 ) 
 
\ MPYS ( Multiply Signed/Operand 1 ) 
 
\ MAC ( Multiply Unsigned and Accumulate/Operand 1 ) 
 
\ MACS ( Multiply Signed and Accumulate/Operand 1 ) 
 
\ OP2 ( Operand 2 ) 
 
\ RESLO ( Result Low Word ) 
 
\ RESHI ( Result High Word ) 
 
\ SUMEXT ( Sum Extend ) 
 
\ MPY32CTL0 ( MPY32 Control Register 0 ) 
( MPY32CTL0-MPYC-set ) %1  0 lshift MPY32CTL0 bis! 
( MPY32CTL0-MPYFRAC-set ) %1  2 lshift MPY32CTL0 bis! 
( MPY32CTL0-MPYSAT-set ) %1  3 lshift MPY32CTL0 bis! 
( MPY32CTL0-MPYM-set ) %xx  4 lshift
    \ %0: MPYM_0      ( Multiplier mode: MPY ) 
    \ %1: MPYM_1      ( Multiplier mode: MPYS ) 
    \ %11: MPYM_2      ( Multiplier mode: MAC ) 
    \ %111: MPYM_3      ( Multiplier mode: MACS )  MPY32CTL0 bis! 
( MPY32CTL0-OP1_32-set ) %1  6 lshift MPY32CTL0 bis! 
( MPY32CTL0-OP2_32-set ) %1  7 lshift MPY32CTL0 bis! 
( MPY32CTL0-MPYDLYWRTEN-set ) %1  8 lshift MPY32CTL0 bis! 
( MPY32CTL0-MPYDLY32-set ) %1  9 lshift MPY32CTL0 bis! 


                     
\ ===================================MPY_32 =================================== 
\ MPY32L ( 32-bit operand 1 - multiply - low word ) 
 
\ MPY32H ( 32-bit operand 1 - multiply - high word ) 
 
\ MPYS32L ( 32-bit operand 1 - signed multiply - low word ) 
 
\ MPYS32H ( 32-bit operand 1 - signed multiply - high word ) 
 
\ MAC32L ( 32-bit operand 1 - multiply accumulate - low word ) 
 
\ MAC32H ( 32-bit operand 1 - multiply accumulate - high word ) 
 
\ MACS32L ( 32-bit operand 1 - signed multiply accumulate - low word ) 
 
\ MACS32H ( 32-bit operand 1 - signed multiply accumulate - high word ) 
 
\ OP2L ( 32-bit operand 2 - low word ) 
 
\ OP2H ( 32-bit operand 2 - high word ) 
 
\ RES0 ( 32x32-bit result 0 - least significant word ) 
 
\ RES1 ( 32x32-bit result 1 ) 
 
\ RES2 ( 32x32-bit result 2 ) 
 
\ RES3 ( 32x32-bit result 3 - most significant word ) 


                     
\ ===================================BACKUP_MEMORY =================================== 
\ BAKMEM0 ( Battery Backup Memory 0 ) 
 
\ BAKMEM1 ( Battery Backup Memory 1 ) 
 
\ BAKMEM2 ( Battery Backup Memory 2 ) 
 
\ BAKMEM3 ( Battery Backup Memory 3 ) 
 
\ BAKMEM4 ( Battery Backup Memory 4 ) 
 
\ BAKMEM5 ( Battery Backup Memory 5 ) 
 
\ BAKMEM6 ( Battery Backup Memory 6 ) 
 
\ BAKMEM7 ( Battery Backup Memory 7 ) 
 
\ BAKMEM8 ( Battery Backup Memory 8 ) 
 
\ BAKMEM9 ( Battery Backup Memory 9 ) 
 
\ BAKMEM10 ( Battery Backup Memory 10 ) 
 
\ BAKMEM11 ( Battery Backup Memory 11 ) 
 
\ BAKMEM12 ( Battery Backup Memory 12 ) 
 
\ BAKMEM13 ( Battery Backup Memory 13 ) 
 
\ BAKMEM14 ( Battery Backup Memory 14 ) 
 
\ BAKMEM15 ( Battery Backup Memory 15 ) 


                     
\ ===================================ADC =================================== 
\ ADCCTL0 ( ADC Control 0 ) 
( ADCCTL0-ADCSC-set ) %1  0 lshift ADCCTL0 bis! 
( ADCCTL0-ADCENC-set ) %1  1 lshift ADCCTL0 bis! 
( ADCCTL0-ADCON-set ) %1  4 lshift ADCCTL0 bis! 
( ADCCTL0-ADCMSC-set ) %1  7 lshift ADCCTL0 bis! 
( ADCCTL0-ADCSHT-set ) %xxxx  8 lshift
    \ %0: ADCSHT_0      ( ADC Sample Hold Select 0 ) 
    \ %1: ADCSHT_1      ( ADC Sample Hold Select 1 ) 
    \ %11: ADCSHT_2      ( ADC Sample Hold Select 2 ) 
    \ %111: ADCSHT_3      ( ADC Sample Hold Select 3 ) 
    \ %1111: ADCSHT_4      ( ADC Sample Hold Select 4 ) 
    \ %11111: ADCSHT_5      ( ADC Sample Hold Select 5 ) 
    \ %111111: ADCSHT_6      ( ADC Sample Hold Select 6 ) 
    \ %1111111: ADCSHT_7      ( ADC Sample Hold Select 7 ) 
    \ %11111111: ADCSHT_8      ( ADC Sample Hold Select 8 ) 
    \ %111111111: ADCSHT_9      ( ADC Sample Hold Select 9 ) 
    \ %1111111111: ADCSHT_10      ( ADC Sample Hold Select 10 ) 
    \ %11111111111: ADCSHT_11      ( ADC Sample Hold Select 11 ) 
    \ %111111111111: ADCSHT_12      ( ADC Sample Hold Select 12 ) 
    \ %1111111111111: ADCSHT_13      ( ADC Sample Hold Select 13 ) 
    \ %11111111111111: ADCSHT_14      ( ADC Sample Hold Select 14 ) 
    \ %111111111111111: ADCSHT_15      ( ADC Sample Hold Select 15 )  ADCCTL0 bis! 
 
\ ADCCTL1 ( ADC Control 1 ) 
( ADCCTL1-ADCBUSY-set ) %1  0 lshift ADCCTL1 bis! 
( ADCCTL1-ADCCONSEQ-set ) %xx  1 lshift
    \ %0: ADCCONSEQ_0      ( ADC Conversion Sequence Select: 0 ) 
    \ %1: ADCCONSEQ_1      ( ADC Conversion Sequence Select: 1 ) 
    \ %11: ADCCONSEQ_2      ( ADC Conversion Sequence Select: 2 ) 
    \ %111: ADCCONSEQ_3      ( ADC Conversion Sequence Select: 3 )  ADCCTL1 bis! 
( ADCCTL1-ADCSSEL-set ) %xx  3 lshift
    \ %0: ADCSSEL_0      ( ADC Clock Source Select: 0 ) 
    \ %1: ADCSSEL_1      ( ADC Clock Source Select: 1 ) 
    \ %11: ADCSSEL_2      ( ADC Clock Source Select: 2 ) 
    \ %111: ADCSSEL_3      ( ADC Clock Source Select: 3 )  ADCCTL1 bis! 
( ADCCTL1-ADCDIV-set ) %xxx  5 lshift
    \ %0: ADCDIV_0      ( ADC Clock Divider Select: 0 ) 
    \ %1: ADCDIV_1      ( ADC Clock Divider Select: 1 ) 
    \ %11: ADCDIV_2      ( ADC Clock Divider Select: 2 ) 
    \ %111: ADCDIV_3      ( ADC Clock Divider Select: 3 ) 
    \ %1111: ADCDIV_4      ( ADC Clock Divider Select: 4 ) 
    \ %11111: ADCDIV_5      ( ADC Clock Divider Select: 5 ) 
    \ %111111: ADCDIV_6      ( ADC Clock Divider Select: 6 ) 
    \ %1111111: ADCDIV_7      ( ADC Clock Divider Select: 7 )  ADCCTL1 bis! 
( ADCCTL1-ADCISSH-set ) %1  8 lshift ADCCTL1 bis! 
( ADCCTL1-ADCSHP-set ) %1  9 lshift ADCCTL1 bis! 
( ADCCTL1-ADCSHS-set ) %xx  10 lshift
    \ %0: ADCSHS_0      ( ADC Sample/Hold Source: 0 ) 
    \ %1: ADCSHS_1      ( ADC Sample/Hold Source: 1 ) 
    \ %11: ADCSHS_2      ( ADC Sample/Hold Source: 2 ) 
    \ %111: ADCSHS_3      ( ADC Sample/Hold Source: 3 )  ADCCTL1 bis! 
 
\ ADCCTL2 ( ADC Control 2 ) 
( ADCCTL2-ADCSR-set ) %1  2 lshift ADCCTL2 bis! 
( ADCCTL2-ADCDF-set ) %1  3 lshift ADCCTL2 bis! 
( ADCCTL2-ADCRES-set ) %xx  4 lshift
    \ %0: ADCRES_0      ( 8 bit ) 
    \ %1: ADCRES_1      ( 10 bit ) 
    \ %11: ADCRES_2      ( Reserved ) 
    \ %111: ADCRES_3      ( Reserved )  ADCCTL2 bis! 
( ADCCTL2-ADCPDIV-set ) %xx  8 lshift
    \ %0: ADCPDIV_0      ( ADC predivider /1 ) 
    \ %1: ADCPDIV_1      ( ADC predivider /2 ) 
    \ %11: ADCPDIV_2      ( ADC predivider /64 ) 
    \ %111: ADCPDIV_3      ( ADC predivider reserved )  ADCCTL2 bis! 
 
\ ADCLO ( ADC Window Comparator High Threshold ) 
 
\ ADCHI ( ADC Window Comparator High Threshold ) 
 
\ ADCMCTL0 ( ADC Memory Control 0 ) 
( ADCMCTL0-ADCINCH-set ) %xxxx  0 lshift
    \ %0: ADCINCH_0      ( ADC Input Channel 0 ) 
    \ %1: ADCINCH_1      ( ADC Input Channel 1 ) 
    \ %11: ADCINCH_2      ( ADC Input Channel 2 ) 
    \ %111: ADCINCH_3      ( ADC Input Channel 3 ) 
    \ %1111: ADCINCH_4      ( ADC Input Channel 4 ) 
    \ %11111: ADCINCH_5      ( ADC Input Channel 5 ) 
    \ %111111: ADCINCH_6      ( ADC Input Channel 6 ) 
    \ %1111111: ADCINCH_7      ( ADC Input Channel 7 ) 
    \ %11111111: ADCINCH_8      ( ADC Input Channel 8 ) 
    \ %111111111: ADCINCH_9      ( ADC Input Channel 9 ) 
    \ %1111111111: ADCINCH_10      ( ADC Input Channel 10 ) 
    \ %11111111111: ADCINCH_11      ( ADC Input Channel 11 ) 
    \ %111111111111: ADCINCH_12      ( ADC Input Channel 12 ) 
    \ %1111111111111: ADCINCH_13      ( ADC Input Channel 13 ) 
    \ %11111111111111: ADCINCH_14      ( ADC Input Channel 14 ) 
    \ %111111111111111: ADCINCH_15      ( ADC Input Channel 15 )  ADCMCTL0 bis! 
( ADCMCTL0-ADCSREF-set ) %xxx  4 lshift
    \ %0: ADCSREF_0      ( ADC Select Reference 0 ) 
    \ %1: ADCSREF_1      ( ADC Select Reference 1 ) 
    \ %11: ADCSREF_2      ( ADC Select Reference 2 ) 
    \ %111: ADCSREF_3      ( ADC Select Reference 3 ) 
    \ %1111: ADCSREF_4      ( ADC Select Reference 4 ) 
    \ %11111: ADCSREF_5      ( ADC Select Reference 5 ) 
    \ %111111: ADCSREF_6      ( ADC Select Reference 6 ) 
    \ %1111111: ADCSREF_7      ( ADC Select Reference 7 )  ADCMCTL0 bis! 
 
\ ADCMEM0 ( ADC Conversion Memory 0 ) 
 
\ ADCIE ( ADC Interrupt Enable ) 
( ADCIE-ADCIE0-set ) %1  0 lshift ADCIE bis! 
( ADCIE-ADCINIE-set ) %1  1 lshift ADCIE bis! 
( ADCIE-ADCLOIE-set ) %1  2 lshift ADCIE bis! 
( ADCIE-ADCHIIE-set ) %1  3 lshift ADCIE bis! 
( ADCIE-ADCOVIE-set ) %1  4 lshift ADCIE bis! 
( ADCIE-ADCTOVIE-set ) %1  5 lshift ADCIE bis! 
 
\ ADCIFG ( ADC Interrupt Flag ) 
( ADCIFG-ADCIFG0-set ) %1  0 lshift ADCIFG bis! 
( ADCIFG-ADCINIFG-set ) %1  1 lshift ADCIFG bis! 
( ADCIFG-ADCLOIFG-set ) %1  2 lshift ADCIFG bis! 
( ADCIFG-ADCHIIFG-set ) %1  3 lshift ADCIFG bis! 
( ADCIFG-ADCOVIFG-set ) %1  4 lshift ADCIFG bis! 
( ADCIFG-ADCTOVIFG-set ) %1  5 lshift ADCIFG bis! 
 
\ ADCIV ( ADC Interrupt Vector Word ) 


                     
\ ===================================_INTERRUPTS ===================================
\ PORT2 $FFDA Port 2
\ PORT1 $FFDC Port 1
\ ADC $FFDE ADC
\ USCI_B0 $FFE0 USCI B0 Receive/Transmit
\ USCI_A1 $FFE2 USCI A1 Receive/Transmit
\ USCI_A0 $FFE4 USCI A0 Receive/Transmit
\ WDT $FFE6 Watchdog Timer
\ RTC $FFE8 RTC
\ TIMER3_A1 $FFEA Timer3_A2 CC1, TA
\ TIMER3_A0 $FFEC Timer3_A2 CC0
\ TIMER2_A1 $FFEE Timer2_A2 CC1, TA
\ TIMER2_A0 $FFF0 Timer2_A2 CC0
\ TIMER1_A1 $FFF2 Timer1_A3 CC1-2, TA
\ TIMER1_A0 $FFF4 Timer1_A3 CC0
\ TIMER0_A1 $FFF6 Timer0_A3 CC1-2, TA
\ TIMER0_A0 $FFE8 Timer0_A3 CC0
\ UNMI $FFFA User Non-maskable
\ SYSNMI $FFFC System Non-maskable

                    
