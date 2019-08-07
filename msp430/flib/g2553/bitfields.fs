MSP430G2553 register Word generation reference file for Mecrisp-Stellaris Forth by Matthias Koch.
Uses registers.xsl and your config.xml file.
Do not load this file, just copy and paste what you need into your source file.
Written by Terry Porter "terry@tjporter.com.au" 2016. Released under the GPL V2
 
\ ===================================SPECIAL_FUNCTION =================================== 
\ IE1 ( Interrupt Enable 1 ) 
( IE1-WDTIE-set ) %1  0 lshift IE1 bis! 
( IE1-OFIE-set ) %1  1 lshift IE1 bis! 
( IE1-NMIIE-set ) %1  4 lshift IE1 bis! 
( IE1-ACCVIE-set ) %1  5 lshift IE1 bis! 
 
\ IE2 ( Interrupt Enable 2 ) 
( IE2-UCA0RXIE-set ) %1  0 lshift IE2 bis! 
( IE2-UCA0TXIE-set ) %1  1 lshift IE2 bis! 
( IE2-UCB0RXIE-set ) %1  2 lshift IE2 bis! 
( IE2-UCB0TXIE-set ) %1  3 lshift IE2 bis! 
 
\ IFG1 ( Interrupt Flag 1 ) 
( IFG1-WDTIFG-set ) %1  0 lshift IFG1 bis! 
( IFG1-OFIFG-set ) %1  1 lshift IFG1 bis! 
( IFG1-PORIFG-set ) %1  2 lshift IFG1 bis! 
( IFG1-RSTIFG-set ) %1  3 lshift IFG1 bis! 
( IFG1-NMIIFG-set ) %1  4 lshift IFG1 bis! 
 
\ IFG2 ( Interrupt Flag 2 ) 
( IFG2-UCA0RXIFG-set ) %1  0 lshift IFG2 bis! 
( IFG2-UCA0TXIFG-set ) %1  1 lshift IFG2 bis! 
( IFG2-UCB0RXIFG-set ) %1  2 lshift IFG2 bis! 
( IFG2-UCB0TXIFG-set ) %1  3 lshift IFG2 bis! 


                     
\ ===================================PORT_3_4 =================================== 
\ P3REN ( Port 3 Resistor Enable ) 
( P3REN-P0-set ) %1  0 lshift P3REN bis! 
( P3REN-P1-set ) %1  1 lshift P3REN bis! 
( P3REN-P2-set ) %1  2 lshift P3REN bis! 
( P3REN-P3-set ) %1  3 lshift P3REN bis! 
( P3REN-P4-set ) %1  4 lshift P3REN bis! 
( P3REN-P5-set ) %1  5 lshift P3REN bis! 
( P3REN-P6-set ) %1  6 lshift P3REN bis! 
( P3REN-P7-set ) %1  7 lshift P3REN bis! 
 
\ P3IN ( Port 3 Input ) 
( P3IN-P0-set ) %1  0 lshift P3IN bis! 
( P3IN-P1-set ) %1  1 lshift P3IN bis! 
( P3IN-P2-set ) %1  2 lshift P3IN bis! 
( P3IN-P3-set ) %1  3 lshift P3IN bis! 
( P3IN-P4-set ) %1  4 lshift P3IN bis! 
( P3IN-P5-set ) %1  5 lshift P3IN bis! 
( P3IN-P6-set ) %1  6 lshift P3IN bis! 
( P3IN-P7-set ) %1  7 lshift P3IN bis! 
 
\ P3OUT ( Port 3 Output ) 
( P3OUT-P0-set ) %1  0 lshift P3OUT bis! 
( P3OUT-P1-set ) %1  1 lshift P3OUT bis! 
( P3OUT-P2-set ) %1  2 lshift P3OUT bis! 
( P3OUT-P3-set ) %1  3 lshift P3OUT bis! 
( P3OUT-P4-set ) %1  4 lshift P3OUT bis! 
( P3OUT-P5-set ) %1  5 lshift P3OUT bis! 
( P3OUT-P6-set ) %1  6 lshift P3OUT bis! 
( P3OUT-P7-set ) %1  7 lshift P3OUT bis! 
 
\ P3DIR ( Port 3 Direction ) 
( P3DIR-P0-set ) %1  0 lshift P3DIR bis! 
( P3DIR-P1-set ) %1  1 lshift P3DIR bis! 
( P3DIR-P2-set ) %1  2 lshift P3DIR bis! 
( P3DIR-P3-set ) %1  3 lshift P3DIR bis! 
( P3DIR-P4-set ) %1  4 lshift P3DIR bis! 
( P3DIR-P5-set ) %1  5 lshift P3DIR bis! 
( P3DIR-P6-set ) %1  6 lshift P3DIR bis! 
( P3DIR-P7-set ) %1  7 lshift P3DIR bis! 
 
\ P3SEL ( Port 3 Selection ) 
( P3SEL-P0-set ) %1  0 lshift P3SEL bis! 
( P3SEL-P1-set ) %1  1 lshift P3SEL bis! 
( P3SEL-P2-set ) %1  2 lshift P3SEL bis! 
( P3SEL-P3-set ) %1  3 lshift P3SEL bis! 
( P3SEL-P4-set ) %1  4 lshift P3SEL bis! 
( P3SEL-P5-set ) %1  5 lshift P3SEL bis! 
( P3SEL-P6-set ) %1  6 lshift P3SEL bis! 
( P3SEL-P7-set ) %1  7 lshift P3SEL bis! 
 
\ P3SEL2 ( Port 3 Selection 2 ) 
( P3SEL2-P0-set ) %1  0 lshift P3SEL2 bis! 
( P3SEL2-P1-set ) %1  1 lshift P3SEL2 bis! 
( P3SEL2-P2-set ) %1  2 lshift P3SEL2 bis! 
( P3SEL2-P3-set ) %1  3 lshift P3SEL2 bis! 
( P3SEL2-P4-set ) %1  4 lshift P3SEL2 bis! 
( P3SEL2-P5-set ) %1  5 lshift P3SEL2 bis! 
( P3SEL2-P6-set ) %1  6 lshift P3SEL2 bis! 
( P3SEL2-P7-set ) %1  7 lshift P3SEL2 bis! 


                     
\ ===================================PORT_1_2 =================================== 
\ P1IN ( Port 1 Input ) 
( P1IN-P0-set ) %1  0 lshift P1IN bis! 
( P1IN-P1-set ) %1  1 lshift P1IN bis! 
( P1IN-P2-set ) %1  2 lshift P1IN bis! 
( P1IN-P3-set ) %1  3 lshift P1IN bis! 
( P1IN-P4-set ) %1  4 lshift P1IN bis! 
( P1IN-P5-set ) %1  5 lshift P1IN bis! 
( P1IN-P6-set ) %1  6 lshift P1IN bis! 
( P1IN-P7-set ) %1  7 lshift P1IN bis! 
 
\ P1OUT ( Port 1 Output ) 
( P1OUT-P0-set ) %1  0 lshift P1OUT bis! 
( P1OUT-P1-set ) %1  1 lshift P1OUT bis! 
( P1OUT-P2-set ) %1  2 lshift P1OUT bis! 
( P1OUT-P3-set ) %1  3 lshift P1OUT bis! 
( P1OUT-P4-set ) %1  4 lshift P1OUT bis! 
( P1OUT-P5-set ) %1  5 lshift P1OUT bis! 
( P1OUT-P6-set ) %1  6 lshift P1OUT bis! 
( P1OUT-P7-set ) %1  7 lshift P1OUT bis! 
 
\ P1DIR ( Port 1 Direction ) 
( P1DIR-P0-set ) %1  0 lshift P1DIR bis! 
( P1DIR-P1-set ) %1  1 lshift P1DIR bis! 
( P1DIR-P2-set ) %1  2 lshift P1DIR bis! 
( P1DIR-P3-set ) %1  3 lshift P1DIR bis! 
( P1DIR-P4-set ) %1  4 lshift P1DIR bis! 
( P1DIR-P5-set ) %1  5 lshift P1DIR bis! 
( P1DIR-P6-set ) %1  6 lshift P1DIR bis! 
( P1DIR-P7-set ) %1  7 lshift P1DIR bis! 
 
\ P1IFG ( Port 1 Interrupt Flag ) 
( P1IFG-P0-set ) %1  0 lshift P1IFG bis! 
( P1IFG-P1-set ) %1  1 lshift P1IFG bis! 
( P1IFG-P2-set ) %1  2 lshift P1IFG bis! 
( P1IFG-P3-set ) %1  3 lshift P1IFG bis! 
( P1IFG-P4-set ) %1  4 lshift P1IFG bis! 
( P1IFG-P5-set ) %1  5 lshift P1IFG bis! 
( P1IFG-P6-set ) %1  6 lshift P1IFG bis! 
( P1IFG-P7-set ) %1  7 lshift P1IFG bis! 
 
\ P1IES ( Port 1 Interrupt Edge Select ) 
( P1IES-P0-set ) %1  0 lshift P1IES bis! 
( P1IES-P1-set ) %1  1 lshift P1IES bis! 
( P1IES-P2-set ) %1  2 lshift P1IES bis! 
( P1IES-P3-set ) %1  3 lshift P1IES bis! 
( P1IES-P4-set ) %1  4 lshift P1IES bis! 
( P1IES-P5-set ) %1  5 lshift P1IES bis! 
( P1IES-P6-set ) %1  6 lshift P1IES bis! 
( P1IES-P7-set ) %1  7 lshift P1IES bis! 
 
\ P1IE ( Port 1 Interrupt Enable ) 
( P1IE-P0-set ) %1  0 lshift P1IE bis! 
( P1IE-P1-set ) %1  1 lshift P1IE bis! 
( P1IE-P2-set ) %1  2 lshift P1IE bis! 
( P1IE-P3-set ) %1  3 lshift P1IE bis! 
( P1IE-P4-set ) %1  4 lshift P1IE bis! 
( P1IE-P5-set ) %1  5 lshift P1IE bis! 
( P1IE-P6-set ) %1  6 lshift P1IE bis! 
( P1IE-P7-set ) %1  7 lshift P1IE bis! 
 
\ P1SEL ( Port 1 Selection ) 
( P1SEL-P0-set ) %1  0 lshift P1SEL bis! 
( P1SEL-P1-set ) %1  1 lshift P1SEL bis! 
( P1SEL-P2-set ) %1  2 lshift P1SEL bis! 
( P1SEL-P3-set ) %1  3 lshift P1SEL bis! 
( P1SEL-P4-set ) %1  4 lshift P1SEL bis! 
( P1SEL-P5-set ) %1  5 lshift P1SEL bis! 
( P1SEL-P6-set ) %1  6 lshift P1SEL bis! 
( P1SEL-P7-set ) %1  7 lshift P1SEL bis! 
 
\ P1REN ( Port 1 Resistor Enable ) 
( P1REN-P0-set ) %1  0 lshift P1REN bis! 
( P1REN-P1-set ) %1  1 lshift P1REN bis! 
( P1REN-P2-set ) %1  2 lshift P1REN bis! 
( P1REN-P3-set ) %1  3 lshift P1REN bis! 
( P1REN-P4-set ) %1  4 lshift P1REN bis! 
( P1REN-P5-set ) %1  5 lshift P1REN bis! 
( P1REN-P6-set ) %1  6 lshift P1REN bis! 
( P1REN-P7-set ) %1  7 lshift P1REN bis! 
 
\ P2IN ( Port 2 Input ) 
( P2IN-P0-set ) %1  0 lshift P2IN bis! 
( P2IN-P1-set ) %1  1 lshift P2IN bis! 
( P2IN-P2-set ) %1  2 lshift P2IN bis! 
( P2IN-P3-set ) %1  3 lshift P2IN bis! 
( P2IN-P4-set ) %1  4 lshift P2IN bis! 
( P2IN-P5-set ) %1  5 lshift P2IN bis! 
( P2IN-P6-set ) %1  6 lshift P2IN bis! 
( P2IN-P7-set ) %1  7 lshift P2IN bis! 
 
\ P2OUT ( Port 2 Output ) 
( P2OUT-P0-set ) %1  0 lshift P2OUT bis! 
( P2OUT-P1-set ) %1  1 lshift P2OUT bis! 
( P2OUT-P2-set ) %1  2 lshift P2OUT bis! 
( P2OUT-P3-set ) %1  3 lshift P2OUT bis! 
( P2OUT-P4-set ) %1  4 lshift P2OUT bis! 
( P2OUT-P5-set ) %1  5 lshift P2OUT bis! 
( P2OUT-P6-set ) %1  6 lshift P2OUT bis! 
( P2OUT-P7-set ) %1  7 lshift P2OUT bis! 
 
\ P2DIR ( Port 2 Direction ) 
( P2DIR-P0-set ) %1  0 lshift P2DIR bis! 
( P2DIR-P1-set ) %1  1 lshift P2DIR bis! 
( P2DIR-P2-set ) %1  2 lshift P2DIR bis! 
( P2DIR-P3-set ) %1  3 lshift P2DIR bis! 
( P2DIR-P4-set ) %1  4 lshift P2DIR bis! 
( P2DIR-P5-set ) %1  5 lshift P2DIR bis! 
( P2DIR-P6-set ) %1  6 lshift P2DIR bis! 
( P2DIR-P7-set ) %1  7 lshift P2DIR bis! 
 
\ P2IFG ( Port 2 Interrupt Flag ) 
( P2IFG-P0-set ) %1  0 lshift P2IFG bis! 
( P2IFG-P1-set ) %1  1 lshift P2IFG bis! 
( P2IFG-P2-set ) %1  2 lshift P2IFG bis! 
( P2IFG-P3-set ) %1  3 lshift P2IFG bis! 
( P2IFG-P4-set ) %1  4 lshift P2IFG bis! 
( P2IFG-P5-set ) %1  5 lshift P2IFG bis! 
( P2IFG-P6-set ) %1  6 lshift P2IFG bis! 
( P2IFG-P7-set ) %1  7 lshift P2IFG bis! 
 
\ P2IES ( Port 2 Interrupt Edge Select ) 
( P2IES-P0-set ) %1  0 lshift P2IES bis! 
( P2IES-P1-set ) %1  1 lshift P2IES bis! 
( P2IES-P2-set ) %1  2 lshift P2IES bis! 
( P2IES-P3-set ) %1  3 lshift P2IES bis! 
( P2IES-P4-set ) %1  4 lshift P2IES bis! 
( P2IES-P5-set ) %1  5 lshift P2IES bis! 
( P2IES-P6-set ) %1  6 lshift P2IES bis! 
( P2IES-P7-set ) %1  7 lshift P2IES bis! 
 
\ P2IE ( Port 2 Interrupt Enable ) 
( P2IE-P0-set ) %1  0 lshift P2IE bis! 
( P2IE-P1-set ) %1  1 lshift P2IE bis! 
( P2IE-P2-set ) %1  2 lshift P2IE bis! 
( P2IE-P3-set ) %1  3 lshift P2IE bis! 
( P2IE-P4-set ) %1  4 lshift P2IE bis! 
( P2IE-P5-set ) %1  5 lshift P2IE bis! 
( P2IE-P6-set ) %1  6 lshift P2IE bis! 
( P2IE-P7-set ) %1  7 lshift P2IE bis! 
 
\ P2SEL ( Port 2 Selection ) 
( P2SEL-P0-set ) %1  0 lshift P2SEL bis! 
( P2SEL-P1-set ) %1  1 lshift P2SEL bis! 
( P2SEL-P2-set ) %1  2 lshift P2SEL bis! 
( P2SEL-P3-set ) %1  3 lshift P2SEL bis! 
( P2SEL-P4-set ) %1  4 lshift P2SEL bis! 
( P2SEL-P5-set ) %1  5 lshift P2SEL bis! 
( P2SEL-P6-set ) %1  6 lshift P2SEL bis! 
( P2SEL-P7-set ) %1  7 lshift P2SEL bis! 
 
\ P2REN ( Port 2 Resistor Enable ) 
( P2REN-P0-set ) %1  0 lshift P2REN bis! 
( P2REN-P1-set ) %1  1 lshift P2REN bis! 
( P2REN-P2-set ) %1  2 lshift P2REN bis! 
( P2REN-P3-set ) %1  3 lshift P2REN bis! 
( P2REN-P4-set ) %1  4 lshift P2REN bis! 
( P2REN-P5-set ) %1  5 lshift P2REN bis! 
( P2REN-P6-set ) %1  6 lshift P2REN bis! 
( P2REN-P7-set ) %1  7 lshift P2REN bis! 
 
\ P1SEL2 ( Port 1 Selection 2 ) 
( P1SEL2-P0-set ) %1  0 lshift P1SEL2 bis! 
( P1SEL2-P1-set ) %1  1 lshift P1SEL2 bis! 
( P1SEL2-P2-set ) %1  2 lshift P1SEL2 bis! 
( P1SEL2-P3-set ) %1  3 lshift P1SEL2 bis! 
( P1SEL2-P4-set ) %1  4 lshift P1SEL2 bis! 
( P1SEL2-P5-set ) %1  5 lshift P1SEL2 bis! 
( P1SEL2-P6-set ) %1  6 lshift P1SEL2 bis! 
( P1SEL2-P7-set ) %1  7 lshift P1SEL2 bis! 
 
\ P2SEL2 ( Port 2 Selection 2 ) 
( P2SEL2-P0-set ) %1  0 lshift P2SEL2 bis! 
( P2SEL2-P1-set ) %1  1 lshift P2SEL2 bis! 
( P2SEL2-P2-set ) %1  2 lshift P2SEL2 bis! 
( P2SEL2-P3-set ) %1  3 lshift P2SEL2 bis! 
( P2SEL2-P4-set ) %1  4 lshift P2SEL2 bis! 
( P2SEL2-P5-set ) %1  5 lshift P2SEL2 bis! 
( P2SEL2-P6-set ) %1  6 lshift P2SEL2 bis! 
( P2SEL2-P7-set ) %1  7 lshift P2SEL2 bis! 


                     
\ ===================================ADC10 =================================== 
\ ADC10DTC0 ( ADC10 Data Transfer Control 0 ) 
( ADC10DTC0-ADC10FETCH-set ) %1  0 lshift ADC10DTC0 bis! 
( ADC10DTC0-ADC10B1-set ) %1  1 lshift ADC10DTC0 bis! 
( ADC10DTC0-ADC10CT-set ) %1  2 lshift ADC10DTC0 bis! 
( ADC10DTC0-ADC10TB-set ) %1  3 lshift ADC10DTC0 bis! 
 
\ ADC10DTC1 ( ADC10 Data Transfer Control 1 ) 
 
\ ADC10AE0 ( ADC10 Analog Enable 0 ) 
 
\ ADC10CTL0 ( ADC10 Control 0 ) 
( ADC10CTL0-ADC10SC-set ) %1  0 lshift ADC10CTL0 bis! 
( ADC10CTL0-ENC-set ) %1  1 lshift ADC10CTL0 bis! 
( ADC10CTL0-ADC10IFG-set ) %1  2 lshift ADC10CTL0 bis! 
( ADC10CTL0-ADC10IE-set ) %1  3 lshift ADC10CTL0 bis! 
( ADC10CTL0-ADC10ON-set ) %1  4 lshift ADC10CTL0 bis! 
( ADC10CTL0-REFON-set ) %1  5 lshift ADC10CTL0 bis! 
( ADC10CTL0-REF2_5V-set ) %1  6 lshift ADC10CTL0 bis! 
( ADC10CTL0-MSC-set ) %1  7 lshift ADC10CTL0 bis! 
( ADC10CTL0-REFBURST-set ) %1  8 lshift ADC10CTL0 bis! 
( ADC10CTL0-REFOUT-set ) %1  9 lshift ADC10CTL0 bis! 
( ADC10CTL0-ADC10SR-set ) %1  10 lshift ADC10CTL0 bis! 
( ADC10CTL0-ADC10SHT-set ) %xx  11 lshift
    \ %0: ADC10SHT_0      ( 4 x ADC10CLKs ) 
    \ %1: ADC10SHT_1      ( 8 x ADC10CLKs ) 
    \ %11: ADC10SHT_2      ( 16 x ADC10CLKs ) 
    \ %111: ADC10SHT_3      ( 64 x ADC10CLKs )  ADC10CTL0 bis! 
( ADC10CTL0-SREF-set ) %xxx  13 lshift
    \ %0: SREF_0      ( VR+ = AVCC and VR- = AVSS ) 
    \ %1: SREF_1      ( VR+ = VREF+ and VR- = AVSS ) 
    \ %11: SREF_2      ( VR+ = VEREF+ and VR- = AVSS ) 
    \ %111: SREF_3      ( VR+ = VEREF+ and VR- = AVSS ) 
    \ %1111: SREF_4      ( VR+ = AVCC and VR- = VREF-/VEREF- ) 
    \ %11111: SREF_5      ( VR+ = VREF+ and VR- = VREF-/VEREF- ) 
    \ %111111: SREF_6      ( VR+ = VEREF+ and VR- = VREF-/VEREF- ) 
    \ %1111111: SREF_7      ( VR+ = VEREF+ and VR- = VREF-/VEREF- )  ADC10CTL0 bis! 
 
\ ADC10CTL1 ( ADC10 Control 1 ) 
( ADC10CTL1-ADC10BUSY-set ) %1  0 lshift ADC10CTL1 bis! 
( ADC10CTL1-CONSEQ-set ) %xx  1 lshift
    \ %0: CONSEQ_0      ( Single channel single conversion ) 
    \ %1: CONSEQ_1      ( Sequence of channels ) 
    \ %11: CONSEQ_2      ( Repeat single channel ) 
    \ %111: CONSEQ_3      ( Repeat sequence of channels )  ADC10CTL1 bis! 
( ADC10CTL1-ADC10SSEL-set ) %xx  3 lshift
    \ %0: ADC10SSEL_0      ( ADC10OSC ) 
    \ %1: ADC10SSEL_1      ( ACLK ) 
    \ %11: ADC10SSEL_2      ( MCLK ) 
    \ %111: ADC10SSEL_3      ( SMCLK )  ADC10CTL1 bis! 
( ADC10CTL1-ADC10DIV-set ) %xxx  5 lshift
    \ %0: ADC10DIV_0      ( ADC10 Clock Divider Select 0 ) 
    \ %1: ADC10DIV_1      ( ADC10 Clock Divider Select 1 ) 
    \ %11: ADC10DIV_2      ( ADC10 Clock Divider Select 2 ) 
    \ %111: ADC10DIV_3      ( ADC10 Clock Divider Select 3 ) 
    \ %1111: ADC10DIV_4      ( ADC10 Clock Divider Select 4 ) 
    \ %11111: ADC10DIV_5      ( ADC10 Clock Divider Select 5 ) 
    \ %111111: ADC10DIV_6      ( ADC10 Clock Divider Select 6 ) 
    \ %1111111: ADC10DIV_7      ( ADC10 Clock Divider Select 7 )  ADC10CTL1 bis! 
( ADC10CTL1-ISSH-set ) %1  8 lshift ADC10CTL1 bis! 
( ADC10CTL1-ADC10DF-set ) %1  9 lshift ADC10CTL1 bis! 
( ADC10CTL1-SHS-set ) %xx  10 lshift
    \ %0: SHS_0      ( ADC10SC ) 
    \ %1: SHS_1      ( TA3 OUT1 ) 
    \ %11: SHS_2      ( TA3 OUT0 ) 
    \ %111: SHS_3      ( TA3 OUT2 )  ADC10CTL1 bis! 
( ADC10CTL1-INCH-set ) %xxxx  12 lshift
    \ %0: INCH_0      ( Selects Channel 0 ) 
    \ %1: INCH_1      ( Selects Channel 1 ) 
    \ %11: INCH_2      ( Selects Channel 2 ) 
    \ %111: INCH_3      ( Selects Channel 3 ) 
    \ %1111: INCH_4      ( Selects Channel 4 ) 
    \ %11111: INCH_5      ( Selects Channel 5 ) 
    \ %111111: INCH_6      ( Selects Channel 6 ) 
    \ %1111111: INCH_7      ( Selects Channel 7 ) 
    \ %11111111: INCH_8      ( Selects Channel 8 ) 
    \ %111111111: INCH_9      ( Selects Channel 9 ) 
    \ %1111111111: INCH_10      ( Selects Channel 10 ) 
    \ %11111111111: INCH_11      ( Selects Channel 11 ) 
    \ %111111111111: INCH_12      ( Selects Channel 12 ) 
    \ %1111111111111: INCH_13      ( Selects Channel 13 ) 
    \ %11111111111111: INCH_14      ( Selects Channel 14 ) 
    \ %111111111111111: INCH_15      ( Selects Channel 15 )  ADC10CTL1 bis! 
 
\ ADC10MEM ( ADC10 Memory ) 
 
\ ADC10SA ( ADC10 Data Transfer Start Address ) 


                     
\ ===================================SYSTEM_CLOCK =================================== 
\ BCSCTL3 ( Basic Clock System Control 3 ) 
( BCSCTL3-LFXT1OF-set ) %1  0 lshift BCSCTL3 bis! 
( BCSCTL3-XT2OF-set ) %1  1 lshift BCSCTL3 bis! 
( BCSCTL3-XCAP-set ) %xx  2 lshift
    \ %0: XCAP_0      ( XIN/XOUT Cap : 0 pF ) 
    \ %1: XCAP_1      ( XIN/XOUT Cap : 6 pF ) 
    \ %11: XCAP_2      ( XIN/XOUT Cap : 10 pF ) 
    \ %111: XCAP_3      ( XIN/XOUT Cap : 12.5 pF )  BCSCTL3 bis! 
( BCSCTL3-LFXT1S-set ) %xx  4 lshift
    \ %0: LFXT1S_0      ( Mode 0 for LFXT1 : Normal operation ) 
    \ %1: LFXT1S_1      ( Mode 1 for LFXT1 : Reserved ) 
    \ %11: LFXT1S_2      ( Mode 2 for LFXT1 : VLO ) 
    \ %111: LFXT1S_3      ( Mode 3 for LFXT1 : Digital input signal )  BCSCTL3 bis! 
( BCSCTL3-XT2S-set ) %xx  6 lshift
    \ %0: XT2S_0      ( Mode 0 for XT2 : 0.4 - 1 MHz ) 
    \ %1: XT2S_1      ( Mode 1 for XT2 : 1 - 4 MHz ) 
    \ %11: XT2S_2      ( Mode 2 for XT2 : 2 - 16 MHz ) 
    \ %111: XT2S_3      ( Mode 3 for XT2 : Digital input signal )  BCSCTL3 bis! 
 
\ DCOCTL ( DCO Clock Frequency Control ) 
( DCOCTL-MOD0-set ) %1  0 lshift DCOCTL bis! 
( DCOCTL-MOD1-set ) %1  1 lshift DCOCTL bis! 
( DCOCTL-MOD2-set ) %1  2 lshift DCOCTL bis! 
( DCOCTL-MOD3-set ) %1  3 lshift DCOCTL bis! 
( DCOCTL-MOD4-set ) %1  4 lshift DCOCTL bis! 
( DCOCTL-DCO0-set ) %1  5 lshift DCOCTL bis! 
( DCOCTL-DCO1-set ) %1  6 lshift DCOCTL bis! 
( DCOCTL-DCO2-set ) %1  7 lshift DCOCTL bis! 
 
\ BCSCTL1 ( Basic Clock System Control 1 ) 
( BCSCTL1-RSEL0-set ) %1  0 lshift BCSCTL1 bis! 
( BCSCTL1-RSEL1-set ) %1  1 lshift BCSCTL1 bis! 
( BCSCTL1-RSEL2-set ) %1  2 lshift BCSCTL1 bis! 
( BCSCTL1-RSEL3-set ) %1  3 lshift BCSCTL1 bis! 
( BCSCTL1-DIVA-set ) %xx  4 lshift
    \ %0: DIVA_0      ( ACLK Divider 0: /1 ) 
    \ %1: DIVA_1      ( ACLK Divider 1: /2 ) 
    \ %11: DIVA_2      ( ACLK Divider 2: /4 ) 
    \ %111: DIVA_3      ( ACLK Divider 3: /8 )  BCSCTL1 bis! 
( BCSCTL1-XTS-set ) %1  6 lshift BCSCTL1 bis! 
( BCSCTL1-XT2OFF-set ) %1  7 lshift BCSCTL1 bis! 
 
\ BCSCTL2 ( Basic Clock System Control 2 ) 
( BCSCTL2-DIVS-set ) %xx  1 lshift
    \ %0: DIVS_0      ( SMCLK Divider 0: /1 ) 
    \ %1: DIVS_1      ( SMCLK Divider 1: /2 ) 
    \ %11: DIVS_2      ( SMCLK Divider 2: /4 ) 
    \ %111: DIVS_3      ( SMCLK Divider 3: /8 )  BCSCTL2 bis! 
( BCSCTL2-SELS-set ) %1  3 lshift BCSCTL2 bis! 
( BCSCTL2-DIVM-set ) %xx  4 lshift
    \ %0: DIVM_0      ( MCLK Divider 0: /1 ) 
    \ %1: DIVM_1      ( MCLK Divider 1: /2 ) 
    \ %11: DIVM_2      ( MCLK Divider 2: /4 ) 
    \ %111: DIVM_3      ( MCLK Divider 3: /8 )  BCSCTL2 bis! 
( BCSCTL2-SELM-set ) %xx  6 lshift
    \ %0: SELM_0      ( MCLK Source Select 0: DCOCLK ) 
    \ %1: SELM_1      ( MCLK Source Select 1: DCOCLK ) 
    \ %11: SELM_2      ( MCLK Source Select 2: XT2CLK/LFXTCLK ) 
    \ %111: SELM_3      ( MCLK Source Select 3: LFXTCLK )  BCSCTL2 bis! 


                     
\ ===================================COMPARATOR_A =================================== 
\ CACTL1 ( Comparator A Control 1 ) 
( CACTL1-CAIFG-set ) %1  0 lshift CACTL1 bis! 
( CACTL1-CAIE-set ) %1  1 lshift CACTL1 bis! 
( CACTL1-CAIES-set ) %1  2 lshift CACTL1 bis! 
( CACTL1-CAON-set ) %1  3 lshift CACTL1 bis! 
( CACTL1-CAREF-set ) %xx  4 lshift
    \ %0: CAREF_0      ( Comp. A Int. Ref. Select 0 : Off ) 
    \ %1: CAREF_1      ( Comp. A Int. Ref. Select 1 : 0.25*Vcc ) 
    \ %11: CAREF_2      ( Comp. A Int. Ref. Select 2 : 0.5*Vcc ) 
    \ %111: CAREF_3      ( Comp. A Int. Ref. Select 3 : Vt )  CACTL1 bis! 
( CACTL1-CARSEL-set ) %1  6 lshift CACTL1 bis! 
( CACTL1-CAEX-set ) %1  7 lshift CACTL1 bis! 
 
\ CACTL2 ( Comparator A Control 2 ) 
( CACTL2-CAOUT-set ) %1  0 lshift CACTL2 bis! 
( CACTL2-CAF-set ) %1  1 lshift CACTL2 bis! 
( CACTL2-P2CA0-set ) %1  2 lshift CACTL2 bis! 
( CACTL2-P2CA1-set ) %1  3 lshift CACTL2 bis! 
( CACTL2-P2CA2-set ) %1  4 lshift CACTL2 bis! 
( CACTL2-P2CA3-set ) %1  5 lshift CACTL2 bis! 
( CACTL2-P2CA4-set ) %1  6 lshift CACTL2 bis! 
( CACTL2-CASHORT-set ) %1  7 lshift CACTL2 bis! 
 
\ CAPD ( Comparator A Port Disable ) 
( CAPD-CAPD0-set ) %1  0 lshift CAPD bis! 
( CAPD-CAPD1-set ) %1  1 lshift CAPD bis! 
( CAPD-CAPD2-set ) %1  2 lshift CAPD bis! 
( CAPD-CAPD3-set ) %1  3 lshift CAPD bis! 
( CAPD-CAPD4-set ) %1  4 lshift CAPD bis! 
( CAPD-CAPD5-set ) %1  5 lshift CAPD bis! 
( CAPD-CAPD6-set ) %1  6 lshift CAPD bis! 
( CAPD-CAPD7-set ) %1  7 lshift CAPD bis! 


                     
\ ===================================USCI_A0_UART_MODE =================================== 
\ UCA0ABCTL ( USCI A0 LIN Control ) 
( UCA0ABCTL-UCABDEN-set ) %1  0 lshift UCA0ABCTL bis! 
( UCA0ABCTL-UCBTOE-set ) %1  2 lshift UCA0ABCTL bis! 
( UCA0ABCTL-UCSTOE-set ) %1  3 lshift UCA0ABCTL bis! 
( UCA0ABCTL-UCDELIM0-set ) %1  4 lshift UCA0ABCTL bis! 
( UCA0ABCTL-UCDELIM1-set ) %1  5 lshift UCA0ABCTL bis! 
 
\ UCA0IRTCTL ( USCI A0 IrDA Transmit Control ) 
( UCA0IRTCTL-UCIREN-set ) %1  0 lshift UCA0IRTCTL bis! 
( UCA0IRTCTL-UCIRTXCLK-set ) %1  1 lshift UCA0IRTCTL bis! 
( UCA0IRTCTL-UCIRTXPL0-set ) %1  2 lshift UCA0IRTCTL bis! 
( UCA0IRTCTL-UCIRTXPL1-set ) %1  3 lshift UCA0IRTCTL bis! 
( UCA0IRTCTL-UCIRTXPL2-set ) %1  4 lshift UCA0IRTCTL bis! 
( UCA0IRTCTL-UCIRTXPL3-set ) %1  5 lshift UCA0IRTCTL bis! 
( UCA0IRTCTL-UCIRTXPL4-set ) %1  6 lshift UCA0IRTCTL bis! 
( UCA0IRTCTL-UCIRTXPL5-set ) %1  7 lshift UCA0IRTCTL bis! 
 
\ UCA0IRRCTL ( USCI A0 IrDA Receive Control ) 
( UCA0IRRCTL-UCIRRXFE-set ) %1  0 lshift UCA0IRRCTL bis! 
( UCA0IRRCTL-UCIRRXPL-set ) %1  1 lshift UCA0IRRCTL bis! 
( UCA0IRRCTL-UCIRRXFL0-set ) %1  2 lshift UCA0IRRCTL bis! 
( UCA0IRRCTL-UCIRRXFL1-set ) %1  3 lshift UCA0IRRCTL bis! 
( UCA0IRRCTL-UCIRRXFL2-set ) %1  4 lshift UCA0IRRCTL bis! 
( UCA0IRRCTL-UCIRRXFL3-set ) %1  5 lshift UCA0IRRCTL bis! 
( UCA0IRRCTL-UCIRRXFL4-set ) %1  6 lshift UCA0IRRCTL bis! 
( UCA0IRRCTL-UCIRRXFL5-set ) %1  7 lshift UCA0IRRCTL bis! 
 
\ UCA0CTL0 ( USCI A0 Control Register 0 ) 
( UCA0CTL0-UCSYNC-set ) %1  0 lshift UCA0CTL0 bis! 
( UCA0CTL0-UCMODE-set ) %xx  1 lshift
    \ %0: UCMODE_0      ( Sync. Mode: USCI Mode: 0 ) 
    \ %1: UCMODE_1      ( Sync. Mode: USCI Mode: 1 ) 
    \ %11: UCMODE_2      ( Sync. Mode: USCI Mode: 2 ) 
    \ %111: UCMODE_3      ( Sync. Mode: USCI Mode: 3 )  UCA0CTL0 bis! 
( UCA0CTL0-UCSPB-set ) %1  3 lshift UCA0CTL0 bis! 
( UCA0CTL0-UC7BIT-set ) %1  4 lshift UCA0CTL0 bis! 
( UCA0CTL0-UCMSB-set ) %1  5 lshift UCA0CTL0 bis! 
( UCA0CTL0-UCPAR-set ) %1  6 lshift UCA0CTL0 bis! 
( UCA0CTL0-UCPEN-set ) %1  7 lshift UCA0CTL0 bis! 
 
\ UCA0CTL1 ( USCI A0 Control Register 1 ) 
( UCA0CTL1-UCSWRST-set ) %1  0 lshift UCA0CTL1 bis! 
( UCA0CTL1-UCTXBRK-set ) %1  1 lshift UCA0CTL1 bis! 
( UCA0CTL1-UCTXADDR-set ) %1  2 lshift UCA0CTL1 bis! 
( UCA0CTL1-UCDORM-set ) %1  3 lshift UCA0CTL1 bis! 
( UCA0CTL1-UCBRKIE-set ) %1  4 lshift UCA0CTL1 bis! 
( UCA0CTL1-UCRXEIE-set ) %1  5 lshift UCA0CTL1 bis! 
( UCA0CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCA0CTL1 bis! 
 
\ UCA0BR0 ( USCI A0 Baud Rate 0 ) 
 
\ UCA0BR1 ( USCI A0 Baud Rate 1 ) 
 
\ UCA0MCTL ( USCI A0 Modulation Control ) 
( UCA0MCTL-UCOS16-set ) %1  0 lshift UCA0MCTL bis! 
( UCA0MCTL-UCBRS-set ) %xxx  1 lshift
    \ %0: UCBRS_0      ( USCI Second Stage Modulation: 0 ) 
    \ %1: UCBRS_1      ( USCI Second Stage Modulation: 1 ) 
    \ %11: UCBRS_2      ( USCI Second Stage Modulation: 2 ) 
    \ %111: UCBRS_3      ( USCI Second Stage Modulation: 3 ) 
    \ %1111: UCBRS_4      ( USCI Second Stage Modulation: 4 ) 
    \ %11111: UCBRS_5      ( USCI Second Stage Modulation: 5 ) 
    \ %111111: UCBRS_6      ( USCI Second Stage Modulation: 6 ) 
    \ %1111111: UCBRS_7      ( USCI Second Stage Modulation: 7 )  UCA0MCTL bis! 
( UCA0MCTL-UCBRF-set ) %xxxx  4 lshift
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
    \ %111111111111111: UCBRF_15      ( USCI First Stage Modulation: F )  UCA0MCTL bis! 
 
\ UCA0STAT ( USCI A0 Status Register ) 
( UCA0STAT-UCBUSY-set ) %1  0 lshift UCA0STAT bis! 
( UCA0STAT-UCADDR-set ) %1  1 lshift UCA0STAT bis! 
( UCA0STAT-UCRXERR-set ) %1  2 lshift UCA0STAT bis! 
( UCA0STAT-UCBRK-set ) %1  3 lshift UCA0STAT bis! 
( UCA0STAT-UCPE-set ) %1  4 lshift UCA0STAT bis! 
( UCA0STAT-UCOE-set ) %1  5 lshift UCA0STAT bis! 
( UCA0STAT-UCFE-set ) %1  6 lshift UCA0STAT bis! 
( UCA0STAT-UCLISTEN-set ) %1  7 lshift UCA0STAT bis! 
 
\ UCA0RXBUF ( USCI A0 Receive Buffer ) 
 
\ UCA0TXBUF ( USCI A0 Transmit Buffer ) 


                     
\ ===================================USCI_A0_SPI_MODE =================================== 
\ UCA0CTL0 ( USCI A0 Control Register 0 ) 
( UCA0CTL0-UCSYNC-set ) %1  0 lshift UCA0CTL0 bis! 
( UCA0CTL0-UCMODE-set ) %xx  1 lshift
    \ %0: UCMODE_0      ( Sync. Mode: USCI Mode: 0 ) 
    \ %1: UCMODE_1      ( Sync. Mode: USCI Mode: 1 ) 
    \ %11: UCMODE_2      ( Sync. Mode: USCI Mode: 2 ) 
    \ %111: UCMODE_3      ( Sync. Mode: USCI Mode: 3 )  UCA0CTL0 bis! 
( UCA0CTL0-UCMST-set ) %1  3 lshift UCA0CTL0 bis! 
( UCA0CTL0-UC7BIT-set ) %1  4 lshift UCA0CTL0 bis! 
( UCA0CTL0-UCMSB-set ) %1  5 lshift UCA0CTL0 bis! 
( UCA0CTL0-UCCKPL-set ) %1  6 lshift UCA0CTL0 bis! 
( UCA0CTL0-UCCKPH-set ) %1  7 lshift UCA0CTL0 bis! 
 
\ UCA0CTL1 ( USCI A0 Control Register 1 ) 
( UCA0CTL1-UCSWRST-set ) %1  0 lshift UCA0CTL1 bis! 
( UCA0CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCA0CTL1 bis! 
 
\ UCA0BR0 ( USCI A0 Baud Rate 0 ) 
 
\ UCA0BR1 ( USCI A0 Baud Rate 1 ) 
 
\ UCA0MCTL ( USCI A0 Modulation Control ) 
 
\ UCA0STAT ( USCI A0 Status Register ) 
( UCA0STAT-UCBUSY-set ) %1  0 lshift UCA0STAT bis! 
( UCA0STAT-UCOE-set ) %1  5 lshift UCA0STAT bis! 
( UCA0STAT-UCFE-set ) %1  6 lshift UCA0STAT bis! 
( UCA0STAT-UCLISTEN-set ) %1  7 lshift UCA0STAT bis! 
 
\ UCA0RXBUF ( USCI A0 Receive Buffer ) 
 
\ UCA0TXBUF ( USCI A0 Transmit Buffer ) 


                     
\ ===================================USCI_B0_I2C_MODE =================================== 
\ UCB0CTL0 ( USCI B0 Control Register 0 ) 
( UCB0CTL0-UCSYNC-set ) %1  0 lshift UCB0CTL0 bis! 
( UCB0CTL0-UCMODE-set ) %xx  1 lshift
    \ %0: UCMODE_0      ( Sync. Mode: USCI Mode: 0 ) 
    \ %1: UCMODE_1      ( Sync. Mode: USCI Mode: 1 ) 
    \ %11: UCMODE_2      ( Sync. Mode: USCI Mode: 2 ) 
    \ %111: UCMODE_3      ( Sync. Mode: USCI Mode: 3 )  UCB0CTL0 bis! 
( UCB0CTL0-UCMST-set ) %1  3 lshift UCB0CTL0 bis! 
( UCB0CTL0-UCMM-set ) %1  5 lshift UCB0CTL0 bis! 
( UCB0CTL0-UCSLA10-set ) %1  6 lshift UCB0CTL0 bis! 
( UCB0CTL0-UCA10-set ) %1  7 lshift UCB0CTL0 bis! 
 
\ UCB0CTL1 ( USCI B0 Control Register 1 ) 
( UCB0CTL1-UCSWRST-set ) %1  0 lshift UCB0CTL1 bis! 
( UCB0CTL1-UCTXSTT-set ) %1  1 lshift UCB0CTL1 bis! 
( UCB0CTL1-UCTXSTP-set ) %1  2 lshift UCB0CTL1 bis! 
( UCB0CTL1-UCTXNACK-set ) %1  3 lshift UCB0CTL1 bis! 
( UCB0CTL1-UCTR-set ) %1  4 lshift UCB0CTL1 bis! 
( UCB0CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCB0CTL1 bis! 
 
\ UCB0BR0 ( USCI B0 Baud Rate 0 ) 
 
\ UCB0BR1 ( USCI B0 Baud Rate 1 ) 
 
\ UCB0I2CIE ( USCI B0 I2C Interrupt Enable Register ) 
( UCB0I2CIE-UCALIE-set ) %1  0 lshift UCB0I2CIE bis! 
( UCB0I2CIE-UCSTTIE-set ) %1  1 lshift UCB0I2CIE bis! 
( UCB0I2CIE-UCSTPIE-set ) %1  2 lshift UCB0I2CIE bis! 
( UCB0I2CIE-UCNACKIE-set ) %1  3 lshift UCB0I2CIE bis! 
 
\ UCB0STAT ( USCI B0 Status Register ) 
( UCB0STAT-UCALIFG-set ) %1  0 lshift UCB0STAT bis! 
( UCB0STAT-UCSTTIFG-set ) %1  1 lshift UCB0STAT bis! 
( UCB0STAT-UCSTPIFG-set ) %1  2 lshift UCB0STAT bis! 
( UCB0STAT-UCNACKIFG-set ) %1  3 lshift UCB0STAT bis! 
( UCB0STAT-UCBBUSY-set ) %1  4 lshift UCB0STAT bis! 
( UCB0STAT-UCGC-set ) %1  5 lshift UCB0STAT bis! 
( UCB0STAT-UCSCLLOW-set ) %1  6 lshift UCB0STAT bis! 
( UCB0STAT-UCLISTEN-set ) %1  7 lshift UCB0STAT bis! 
 
\ UCB0RXBUF ( USCI B0 Receive Buffer ) 
 
\ UCB0TXBUF ( USCI B0 Transmit Buffer ) 
 
\ UCB0I2COA ( USCI B0 I2C Own Address ) 
( UCB0I2COA-UCOA0-set ) %1  0 lshift UCB0I2COA bis! 
( UCB0I2COA-UCOA1-set ) %1  1 lshift UCB0I2COA bis! 
( UCB0I2COA-UCOA2-set ) %1  2 lshift UCB0I2COA bis! 
( UCB0I2COA-UCOA3-set ) %1  3 lshift UCB0I2COA bis! 
( UCB0I2COA-UCOA4-set ) %1  4 lshift UCB0I2COA bis! 
( UCB0I2COA-UCOA5-set ) %1  5 lshift UCB0I2COA bis! 
( UCB0I2COA-UCOA6-set ) %1  6 lshift UCB0I2COA bis! 
( UCB0I2COA-UCOA7-set ) %1  7 lshift UCB0I2COA bis! 
( UCB0I2COA-UCOA8-set ) %1  8 lshift UCB0I2COA bis! 
( UCB0I2COA-UCOA9-set ) %1  9 lshift UCB0I2COA bis! 
( UCB0I2COA-UCGCEN-set ) %1  15 lshift UCB0I2COA bis! 
 
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


                     
\ ===================================USCI_B0_SPI_MODE =================================== 
\ UCB0CTL0 ( USCI B0 Control Register 0 ) 
( UCB0CTL0-UCSYNC-set ) %1  0 lshift UCB0CTL0 bis! 
( UCB0CTL0-UCMODE-set ) %xx  1 lshift
    \ %0: UCMODE_0      ( Sync. Mode: USCI Mode: 0 ) 
    \ %1: UCMODE_1      ( Sync. Mode: USCI Mode: 1 ) 
    \ %11: UCMODE_2      ( Sync. Mode: USCI Mode: 2 ) 
    \ %111: UCMODE_3      ( Sync. Mode: USCI Mode: 3 )  UCB0CTL0 bis! 
( UCB0CTL0-UCMST-set ) %1  3 lshift UCB0CTL0 bis! 
( UCB0CTL0-UC7BIT-set ) %1  4 lshift UCB0CTL0 bis! 
( UCB0CTL0-UCMSB-set ) %1  5 lshift UCB0CTL0 bis! 
( UCB0CTL0-UCCKPL-set ) %1  6 lshift UCB0CTL0 bis! 
( UCB0CTL0-UCCKPH-set ) %1  7 lshift UCB0CTL0 bis! 
 
\ UCB0CTL1 ( USCI B0 Control Register 1 ) 
( UCB0CTL1-UCSWRST-set ) %1  0 lshift UCB0CTL1 bis! 
( UCB0CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCB0CTL1 bis! 
 
\ UCB0BR0 ( USCI B0 Baud Rate 0 ) 
 
\ UCB0BR1 ( USCI B0 Baud Rate 1 ) 
 
\ UCB0STAT ( USCI B0 Status Register ) 
( UCB0STAT-UCBUSY-set ) %1  0 lshift UCB0STAT bis! 
( UCB0STAT-UCOE-set ) %1  5 lshift UCB0STAT bis! 
( UCB0STAT-UCFE-set ) %1  6 lshift UCB0STAT bis! 
( UCB0STAT-UCLISTEN-set ) %1  7 lshift UCB0STAT bis! 
 
\ UCB0RXBUF ( USCI B0 Receive Buffer ) 
 
\ UCB0TXBUF ( USCI B0 Transmit Buffer ) 


                     
\ ===================================TLV_CALIBRATION_DATA =================================== 
\ TLV_ADC10_1_TAG ( TLV ADC10_1 TAG ) 
 
\ TLV_ADC10_1_LEN ( TLV ADC10_1 LEN ) 
 
\ TLV_DCO_30_TAG ( TLV TAG_DCO30 TAG ) 
 
\ TLV_DCO_30_LEN ( TLV TAG_DCO30 LEN ) 
 
\ TLV_CHECKSUM ( TLV CHECK SUM ) 


                     
\ ===================================CALIBRATION_DATA =================================== 
\ CALDCO_16MHZ ( DCOCTL  Calibration Data for 16MHz ) 
 
\ CALBC1_16MHZ ( BCSCTL1 Calibration Data for 16MHz ) 
 
\ CALDCO_12MHZ ( DCOCTL  Calibration Data for 12MHz ) 
 
\ CALBC1_12MHZ ( BCSCTL1 Calibration Data for 12MHz ) 
 
\ CALDCO_8MHZ ( DCOCTL  Calibration Data for 8MHz ) 
 
\ CALBC1_8MHZ ( BCSCTL1 Calibration Data for 8MHz ) 
 
\ CALDCO_1MHZ ( DCOCTL  Calibration Data for 1MHz ) 
 
\ CALBC1_1MHZ ( BCSCTL1 Calibration Data for 1MHz ) 


                     
\ ===================================TIMER_1_A3 =================================== 
\ TA1IV ( Timer1_A3 Interrupt Vector Word ) 
 
\ TA1CTL ( Timer1_A3 Control ) 
( TA1CTL-TAIFG-set ) %1  0 lshift TA1CTL bis! 
( TA1CTL-TAIE-set ) %1  1 lshift TA1CTL bis! 
( TA1CTL-TACLR-set ) %1  2 lshift TA1CTL bis! 
( TA1CTL-MC-set ) %xx  4 lshift
    \ %0: MC_0      ( Timer A mode control: 0 - Stop ) 
    \ %1: MC_1      ( Timer A mode control: 1 - Up to CCR0 ) 
    \ %11: MC_2      ( Timer A mode control: 2 - Continous up ) 
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
 
\ TA1R ( Timer1_A3 Counter Register ) 
 
\ TA1CCR0 ( Timer1_A3 Capture/Compare 0 ) 
 
\ TA1CCR1 ( Timer1_A3 Capture/Compare 1 ) 
 
\ TA1CCR2 ( Timer1_A3 Capture/Compare 2 ) 


                     
\ ===================================WATCHDOG_TIMER =================================== 
\ WDTCTL ( Watchdog Timer Control ) 
( WDTCTL-WDTIS0-set ) %1  0 lshift WDTCTL bis! 
( WDTCTL-WDTIS1-set ) %1  1 lshift WDTCTL bis! 
( WDTCTL-WDTSSEL-set ) %1  2 lshift WDTCTL bis! 
( WDTCTL-WDTCNTCL-set ) %1  3 lshift WDTCTL bis! 
( WDTCTL-WDTTMSEL-set ) %1  4 lshift WDTCTL bis! 
( WDTCTL-WDTNMI-set ) %1  5 lshift WDTCTL bis! 
( WDTCTL-WDTNMIES-set ) %1  6 lshift WDTCTL bis! 
( WDTCTL-WDTHOLD-set ) %1  7 lshift WDTCTL bis! 


                     
\ ===================================FLASH =================================== 
\ FCTL1 ( FLASH Control 1 ) 
( FCTL1-ERASE-set ) %1  1 lshift FCTL1 bis! 
( FCTL1-MERAS-set ) %1  2 lshift FCTL1 bis! 
( FCTL1-WRT-set ) %1  6 lshift FCTL1 bis! 
( FCTL1-BLKWRT-set ) %1  7 lshift FCTL1 bis! 
 
\ FCTL2 ( FLASH Control 2 ) 
( FCTL2-FN0-set ) %1  0 lshift FCTL2 bis! 
( FCTL2-FN1-set ) %1  1 lshift FCTL2 bis! 
( FCTL2-FN2-set ) %1  2 lshift FCTL2 bis! 
( FCTL2-FN3-set ) %1  3 lshift FCTL2 bis! 
( FCTL2-FN4-set ) %1  4 lshift FCTL2 bis! 
( FCTL2-FN5-set ) %1  5 lshift FCTL2 bis! 
( FCTL2-FSSEL-set ) %xx  6 lshift
    \ %0: FSSEL_0      ( Flash clock select: 0 - ACLK ) 
    \ %1: FSSEL_1      ( Flash clock select: 1 - MCLK ) 
    \ %11: FSSEL_2      ( Flash clock select: 2 - SMCLK ) 
    \ %111: FSSEL_3      ( Flash clock select: 3 - SMCLK )  FCTL2 bis! 
 
\ FCTL3 ( FLASH Control 3 ) 
( FCTL3-BUSY-set ) %1  0 lshift FCTL3 bis! 
( FCTL3-KEYV-set ) %1  1 lshift FCTL3 bis! 
( FCTL3-ACCVIFG-set ) %1  2 lshift FCTL3 bis! 
( FCTL3-WAIT-set ) %1  3 lshift FCTL3 bis! 
( FCTL3-LOCK-set ) %1  4 lshift FCTL3 bis! 
( FCTL3-EMEX-set ) %1  5 lshift FCTL3 bis! 
( FCTL3-LOCKA-set ) %1  6 lshift FCTL3 bis! 
( FCTL3-FAIL-set ) %1  7 lshift FCTL3 bis! 


                     
\ ===================================TIMER_0_A3 =================================== 
\ TA0IV ( Timer0_A3 Interrupt Vector Word ) 
 
\ TA0CTL ( Timer0_A3 Control ) 
( TA0CTL-TAIFG-set ) %1  0 lshift TA0CTL bis! 
( TA0CTL-TAIE-set ) %1  1 lshift TA0CTL bis! 
( TA0CTL-TACLR-set ) %1  2 lshift TA0CTL bis! 
( TA0CTL-MC-set ) %xx  4 lshift
    \ %0: MC_0      ( Timer A mode control: 0 - Stop ) 
    \ %1: MC_1      ( Timer A mode control: 1 - Up to CCR0 ) 
    \ %11: MC_2      ( Timer A mode control: 2 - Continous up ) 
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
 
\ TA0R ( Timer0_A3 Counter Register ) 
 
\ TA0CCR0 ( Timer0_A3 Capture/Compare 0 ) 
 
\ TA0CCR1 ( Timer0_A3 Capture/Compare 1 ) 
 
\ TA0CCR2 ( Timer0_A3 Capture/Compare 2 ) 


                     
\ ===================================_INTERRUPTS ===================================
\ TRAPINT $FFE0 TRAPINT
\ PORT1 $FFE4 Port 1
\ PORT2 $FFE6 Port 2
\ ADC10 $FFEA ADC10
\ USCIAB0TX $FFEC USCI A0/B0 Transmit
\ USCIAB0RX $FFEE USCI A0/B0 Receive
\ TIMER0_A1 $FFF0 Timer0)A CC1, TA0
\ TIMER0_A0 $FFF2 Timer0_A CC0
\ WDT $FFF4 Watchdog Timer
\ COMPARATORA $FFF6 Comparator A
\ TIMER1_A1 $FFF8 Timer1_A CC1-4, TA1
\ TIMER1_A0 $FFFA Timer1_A CC0
\ NMI $FFFC Non-maskable

                    
