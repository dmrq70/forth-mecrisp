MSP430F5529 register Word generation reference file for Mecrisp-Stellaris Forth by Matthias Koch.
Uses registers.xsl and your config.xml file.
Do not load this file, just copy and paste what you need into your source file.
Written by Terry Porter "terry@tjporter.com.au" 2016. Released under the GPL V2
 
\ ===================================PORT_MAPPING_PORT_4 =================================== 
\ P4MAP0 ( Port P4.0 mapping register ) 
( P4MAP0-PMAP0-set ) %1  0 lshift P4MAP0 bis! 
( P4MAP0-PMAP1-set ) %1  1 lshift P4MAP0 bis! 
( P4MAP0-PMAP2-set ) %1  2 lshift P4MAP0 bis! 
( P4MAP0-PMAP3-set ) %1  3 lshift P4MAP0 bis! 
( P4MAP0-PMAP4-set ) %1  4 lshift P4MAP0 bis! 
( P4MAP0-PMAP5-set ) %1  5 lshift P4MAP0 bis! 
( P4MAP0-PMAP6-set ) %1  6 lshift P4MAP0 bis! 
( P4MAP0-PMAP7-set ) %1  7 lshift P4MAP0 bis! 
 
\ P4MAP1 ( Port P4.1 mapping register ) 
( P4MAP1-PMAP0-set ) %1  0 lshift P4MAP1 bis! 
( P4MAP1-PMAP1-set ) %1  1 lshift P4MAP1 bis! 
( P4MAP1-PMAP2-set ) %1  2 lshift P4MAP1 bis! 
( P4MAP1-PMAP3-set ) %1  3 lshift P4MAP1 bis! 
( P4MAP1-PMAP4-set ) %1  4 lshift P4MAP1 bis! 
( P4MAP1-PMAP5-set ) %1  5 lshift P4MAP1 bis! 
( P4MAP1-PMAP6-set ) %1  6 lshift P4MAP1 bis! 
( P4MAP1-PMAP7-set ) %1  7 lshift P4MAP1 bis! 
 
\ P4MAP2 ( Port P4.2 mapping register ) 
( P4MAP2-PMAP0-set ) %1  0 lshift P4MAP2 bis! 
( P4MAP2-PMAP1-set ) %1  1 lshift P4MAP2 bis! 
( P4MAP2-PMAP2-set ) %1  2 lshift P4MAP2 bis! 
( P4MAP2-PMAP3-set ) %1  3 lshift P4MAP2 bis! 
( P4MAP2-PMAP4-set ) %1  4 lshift P4MAP2 bis! 
( P4MAP2-PMAP5-set ) %1  5 lshift P4MAP2 bis! 
( P4MAP2-PMAP6-set ) %1  6 lshift P4MAP2 bis! 
( P4MAP2-PMAP7-set ) %1  7 lshift P4MAP2 bis! 
 
\ P4MAP3 ( Port P4.3 mapping register ) 
( P4MAP3-PMAP0-set ) %1  0 lshift P4MAP3 bis! 
( P4MAP3-PMAP1-set ) %1  1 lshift P4MAP3 bis! 
( P4MAP3-PMAP2-set ) %1  2 lshift P4MAP3 bis! 
( P4MAP3-PMAP3-set ) %1  3 lshift P4MAP3 bis! 
( P4MAP3-PMAP4-set ) %1  4 lshift P4MAP3 bis! 
( P4MAP3-PMAP5-set ) %1  5 lshift P4MAP3 bis! 
( P4MAP3-PMAP6-set ) %1  6 lshift P4MAP3 bis! 
( P4MAP3-PMAP7-set ) %1  7 lshift P4MAP3 bis! 
 
\ P4MAP4 ( Port P4.4 mapping register ) 
( P4MAP4-PMAP0-set ) %1  0 lshift P4MAP4 bis! 
( P4MAP4-PMAP1-set ) %1  1 lshift P4MAP4 bis! 
( P4MAP4-PMAP2-set ) %1  2 lshift P4MAP4 bis! 
( P4MAP4-PMAP3-set ) %1  3 lshift P4MAP4 bis! 
( P4MAP4-PMAP4-set ) %1  4 lshift P4MAP4 bis! 
( P4MAP4-PMAP5-set ) %1  5 lshift P4MAP4 bis! 
( P4MAP4-PMAP6-set ) %1  6 lshift P4MAP4 bis! 
( P4MAP4-PMAP7-set ) %1  7 lshift P4MAP4 bis! 
 
\ P4MAP5 ( Port P4.5 mapping register ) 
( P4MAP5-PMAP0-set ) %1  0 lshift P4MAP5 bis! 
( P4MAP5-PMAP1-set ) %1  1 lshift P4MAP5 bis! 
( P4MAP5-PMAP2-set ) %1  2 lshift P4MAP5 bis! 
( P4MAP5-PMAP3-set ) %1  3 lshift P4MAP5 bis! 
( P4MAP5-PMAP4-set ) %1  4 lshift P4MAP5 bis! 
( P4MAP5-PMAP5-set ) %1  5 lshift P4MAP5 bis! 
( P4MAP5-PMAP6-set ) %1  6 lshift P4MAP5 bis! 
( P4MAP5-PMAP7-set ) %1  7 lshift P4MAP5 bis! 
 
\ P4MAP6 ( Port P4.6 mapping register ) 
( P4MAP6-PMAP0-set ) %1  0 lshift P4MAP6 bis! 
( P4MAP6-PMAP1-set ) %1  1 lshift P4MAP6 bis! 
( P4MAP6-PMAP2-set ) %1  2 lshift P4MAP6 bis! 
( P4MAP6-PMAP3-set ) %1  3 lshift P4MAP6 bis! 
( P4MAP6-PMAP4-set ) %1  4 lshift P4MAP6 bis! 
( P4MAP6-PMAP5-set ) %1  5 lshift P4MAP6 bis! 
( P4MAP6-PMAP6-set ) %1  6 lshift P4MAP6 bis! 
( P4MAP6-PMAP7-set ) %1  7 lshift P4MAP6 bis! 
 
\ P4MAP7 ( Port P4.7 mapping register ) 
( P4MAP7-PMAP0-set ) %1  0 lshift P4MAP7 bis! 
( P4MAP7-PMAP1-set ) %1  1 lshift P4MAP7 bis! 
( P4MAP7-PMAP2-set ) %1  2 lshift P4MAP7 bis! 
( P4MAP7-PMAP3-set ) %1  3 lshift P4MAP7 bis! 
( P4MAP7-PMAP4-set ) %1  4 lshift P4MAP7 bis! 
( P4MAP7-PMAP5-set ) %1  5 lshift P4MAP7 bis! 
( P4MAP7-PMAP6-set ) %1  6 lshift P4MAP7 bis! 
( P4MAP7-PMAP7-set ) %1  7 lshift P4MAP7 bis! 


                     
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
 
\ P1DS ( Port 1 Drive Strenght ) 
( P1DS-P1DS0-set ) %1  0 lshift P1DS bis! 
( P1DS-P1DS1-set ) %1  1 lshift P1DS bis! 
( P1DS-P1DS2-set ) %1  2 lshift P1DS bis! 
( P1DS-P1DS3-set ) %1  3 lshift P1DS bis! 
( P1DS-P1DS4-set ) %1  4 lshift P1DS bis! 
( P1DS-P1DS5-set ) %1  5 lshift P1DS bis! 
( P1DS-P1DS6-set ) %1  6 lshift P1DS bis! 
( P1DS-P1DS7-set ) %1  7 lshift P1DS bis! 
 
\ P2DS ( Port 2 Drive Strenght ) 
( P2DS-P2DS0-set ) %1  0 lshift P2DS bis! 
( P2DS-P2DS1-set ) %1  1 lshift P2DS bis! 
( P2DS-P2DS2-set ) %1  2 lshift P2DS bis! 
( P2DS-P2DS3-set ) %1  3 lshift P2DS bis! 
( P2DS-P2DS4-set ) %1  4 lshift P2DS bis! 
( P2DS-P2DS5-set ) %1  5 lshift P2DS bis! 
( P2DS-P2DS6-set ) %1  6 lshift P2DS bis! 
( P2DS-P2DS7-set ) %1  7 lshift P2DS bis! 
 
\ P1SEL ( Port 1 Selection ) 
( P1SEL-P1SEL0-set ) %1  0 lshift P1SEL bis! 
( P1SEL-P1SEL1-set ) %1  1 lshift P1SEL bis! 
( P1SEL-P1SEL2-set ) %1  2 lshift P1SEL bis! 
( P1SEL-P1SEL3-set ) %1  3 lshift P1SEL bis! 
( P1SEL-P1SEL4-set ) %1  4 lshift P1SEL bis! 
( P1SEL-P1SEL5-set ) %1  5 lshift P1SEL bis! 
( P1SEL-P1SEL6-set ) %1  6 lshift P1SEL bis! 
( P1SEL-P1SEL7-set ) %1  7 lshift P1SEL bis! 
 
\ P2SEL ( Port 2 Selection ) 
( P2SEL-P2SEL0-set ) %1  0 lshift P2SEL bis! 
( P2SEL-P2SEL1-set ) %1  1 lshift P2SEL bis! 
( P2SEL-P2SEL2-set ) %1  2 lshift P2SEL bis! 
( P2SEL-P2SEL3-set ) %1  3 lshift P2SEL bis! 
( P2SEL-P2SEL4-set ) %1  4 lshift P2SEL bis! 
( P2SEL-P2SEL5-set ) %1  5 lshift P2SEL bis! 
( P2SEL-P2SEL6-set ) %1  6 lshift P2SEL bis! 
( P2SEL-P2SEL7-set ) %1  7 lshift P2SEL bis! 
 
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


                     
\ ===================================PORT_3_4 =================================== 
\ P3IN ( Port 3 Input ) 
( P3IN-P3IN0-set ) %1  0 lshift P3IN bis! 
( P3IN-P3IN1-set ) %1  1 lshift P3IN bis! 
( P3IN-P3IN2-set ) %1  2 lshift P3IN bis! 
( P3IN-P3IN3-set ) %1  3 lshift P3IN bis! 
( P3IN-P3IN4-set ) %1  4 lshift P3IN bis! 
( P3IN-P3IN5-set ) %1  5 lshift P3IN bis! 
( P3IN-P3IN6-set ) %1  6 lshift P3IN bis! 
( P3IN-P3IN7-set ) %1  7 lshift P3IN bis! 
 
\ P4IN ( Port 4 Input ) 
( P4IN-P4IN0-set ) %1  0 lshift P4IN bis! 
( P4IN-P4IN1-set ) %1  1 lshift P4IN bis! 
( P4IN-P4IN2-set ) %1  2 lshift P4IN bis! 
( P4IN-P4IN3-set ) %1  3 lshift P4IN bis! 
( P4IN-P4IN4-set ) %1  4 lshift P4IN bis! 
( P4IN-P4IN5-set ) %1  5 lshift P4IN bis! 
( P4IN-P4IN6-set ) %1  6 lshift P4IN bis! 
( P4IN-P4IN7-set ) %1  7 lshift P4IN bis! 
 
\ P3OUT ( Port 3 Output ) 
( P3OUT-P3OUT0-set ) %1  0 lshift P3OUT bis! 
( P3OUT-P3OUT1-set ) %1  1 lshift P3OUT bis! 
( P3OUT-P3OUT2-set ) %1  2 lshift P3OUT bis! 
( P3OUT-P3OUT3-set ) %1  3 lshift P3OUT bis! 
( P3OUT-P3OUT4-set ) %1  4 lshift P3OUT bis! 
( P3OUT-P3OUT5-set ) %1  5 lshift P3OUT bis! 
( P3OUT-P3OUT6-set ) %1  6 lshift P3OUT bis! 
( P3OUT-P3OUT7-set ) %1  7 lshift P3OUT bis! 
 
\ P4OUT ( Port 4 Output ) 
( P4OUT-P4OUT0-set ) %1  0 lshift P4OUT bis! 
( P4OUT-P4OUT1-set ) %1  1 lshift P4OUT bis! 
( P4OUT-P4OUT2-set ) %1  2 lshift P4OUT bis! 
( P4OUT-P4OUT3-set ) %1  3 lshift P4OUT bis! 
( P4OUT-P4OUT4-set ) %1  4 lshift P4OUT bis! 
( P4OUT-P4OUT5-set ) %1  5 lshift P4OUT bis! 
( P4OUT-P4OUT6-set ) %1  6 lshift P4OUT bis! 
( P4OUT-P4OUT7-set ) %1  7 lshift P4OUT bis! 
 
\ P3DIR ( Port 3 Direction ) 
( P3DIR-P3DIR0-set ) %1  0 lshift P3DIR bis! 
( P3DIR-P3DIR1-set ) %1  1 lshift P3DIR bis! 
( P3DIR-P3DIR2-set ) %1  2 lshift P3DIR bis! 
( P3DIR-P3DIR3-set ) %1  3 lshift P3DIR bis! 
( P3DIR-P3DIR4-set ) %1  4 lshift P3DIR bis! 
( P3DIR-P3DIR5-set ) %1  5 lshift P3DIR bis! 
( P3DIR-P3DIR6-set ) %1  6 lshift P3DIR bis! 
( P3DIR-P3DIR7-set ) %1  7 lshift P3DIR bis! 
 
\ P4DIR ( Port 4 Direction ) 
( P4DIR-P4DIR0-set ) %1  0 lshift P4DIR bis! 
( P4DIR-P4DIR1-set ) %1  1 lshift P4DIR bis! 
( P4DIR-P4DIR2-set ) %1  2 lshift P4DIR bis! 
( P4DIR-P4DIR3-set ) %1  3 lshift P4DIR bis! 
( P4DIR-P4DIR4-set ) %1  4 lshift P4DIR bis! 
( P4DIR-P4DIR5-set ) %1  5 lshift P4DIR bis! 
( P4DIR-P4DIR6-set ) %1  6 lshift P4DIR bis! 
( P4DIR-P4DIR7-set ) %1  7 lshift P4DIR bis! 
 
\ P3REN ( Port 3 Resistor Enable ) 
( P3REN-P3REN0-set ) %1  0 lshift P3REN bis! 
( P3REN-P3REN1-set ) %1  1 lshift P3REN bis! 
( P3REN-P3REN2-set ) %1  2 lshift P3REN bis! 
( P3REN-P3REN3-set ) %1  3 lshift P3REN bis! 
( P3REN-P3REN4-set ) %1  4 lshift P3REN bis! 
( P3REN-P3REN5-set ) %1  5 lshift P3REN bis! 
( P3REN-P3REN6-set ) %1  6 lshift P3REN bis! 
( P3REN-P3REN7-set ) %1  7 lshift P3REN bis! 
 
\ P4REN ( Port 4 Resistor Enable ) 
( P4REN-P4REN0-set ) %1  0 lshift P4REN bis! 
( P4REN-P4REN1-set ) %1  1 lshift P4REN bis! 
( P4REN-P4REN2-set ) %1  2 lshift P4REN bis! 
( P4REN-P4REN3-set ) %1  3 lshift P4REN bis! 
( P4REN-P4REN4-set ) %1  4 lshift P4REN bis! 
( P4REN-P4REN5-set ) %1  5 lshift P4REN bis! 
( P4REN-P4REN6-set ) %1  6 lshift P4REN bis! 
( P4REN-P4REN7-set ) %1  7 lshift P4REN bis! 
 
\ P3DS ( Port 3 Drive Strenght ) 
( P3DS-P3DS0-set ) %1  0 lshift P3DS bis! 
( P3DS-P3DS1-set ) %1  1 lshift P3DS bis! 
( P3DS-P3DS2-set ) %1  2 lshift P3DS bis! 
( P3DS-P3DS3-set ) %1  3 lshift P3DS bis! 
( P3DS-P3DS4-set ) %1  4 lshift P3DS bis! 
( P3DS-P3DS5-set ) %1  5 lshift P3DS bis! 
( P3DS-P3DS6-set ) %1  6 lshift P3DS bis! 
( P3DS-P3DS7-set ) %1  7 lshift P3DS bis! 
 
\ P4DS ( Port 4 Drive Strenght ) 
( P4DS-P4DS0-set ) %1  0 lshift P4DS bis! 
( P4DS-P4DS1-set ) %1  1 lshift P4DS bis! 
( P4DS-P4DS2-set ) %1  2 lshift P4DS bis! 
( P4DS-P4DS3-set ) %1  3 lshift P4DS bis! 
( P4DS-P4DS4-set ) %1  4 lshift P4DS bis! 
( P4DS-P4DS5-set ) %1  5 lshift P4DS bis! 
( P4DS-P4DS6-set ) %1  6 lshift P4DS bis! 
( P4DS-P4DS7-set ) %1  7 lshift P4DS bis! 
 
\ P3SEL ( Port 3 Selection ) 
( P3SEL-P3SEL0-set ) %1  0 lshift P3SEL bis! 
( P3SEL-P3SEL1-set ) %1  1 lshift P3SEL bis! 
( P3SEL-P3SEL2-set ) %1  2 lshift P3SEL bis! 
( P3SEL-P3SEL3-set ) %1  3 lshift P3SEL bis! 
( P3SEL-P3SEL4-set ) %1  4 lshift P3SEL bis! 
( P3SEL-P3SEL5-set ) %1  5 lshift P3SEL bis! 
( P3SEL-P3SEL6-set ) %1  6 lshift P3SEL bis! 
( P3SEL-P3SEL7-set ) %1  7 lshift P3SEL bis! 
 
\ P4SEL ( Port 4 Selection ) 
( P4SEL-P4SEL0-set ) %1  0 lshift P4SEL bis! 
( P4SEL-P4SEL1-set ) %1  1 lshift P4SEL bis! 
( P4SEL-P4SEL2-set ) %1  2 lshift P4SEL bis! 
( P4SEL-P4SEL3-set ) %1  3 lshift P4SEL bis! 
( P4SEL-P4SEL4-set ) %1  4 lshift P4SEL bis! 
( P4SEL-P4SEL5-set ) %1  5 lshift P4SEL bis! 
( P4SEL-P4SEL6-set ) %1  6 lshift P4SEL bis! 
( P4SEL-P4SEL7-set ) %1  7 lshift P4SEL bis! 


                     
\ ===================================PORT_5_6 =================================== 
\ P5IN ( Port 5 Input ) 
( P5IN-P5IN0-set ) %1  0 lshift P5IN bis! 
( P5IN-P5IN1-set ) %1  1 lshift P5IN bis! 
( P5IN-P5IN2-set ) %1  2 lshift P5IN bis! 
( P5IN-P5IN3-set ) %1  3 lshift P5IN bis! 
( P5IN-P5IN4-set ) %1  4 lshift P5IN bis! 
( P5IN-P5IN5-set ) %1  5 lshift P5IN bis! 
( P5IN-P5IN6-set ) %1  6 lshift P5IN bis! 
( P5IN-P5IN7-set ) %1  7 lshift P5IN bis! 
 
\ P6IN ( Port 6 Input ) 
( P6IN-P6IN0-set ) %1  0 lshift P6IN bis! 
( P6IN-P6IN1-set ) %1  1 lshift P6IN bis! 
( P6IN-P6IN2-set ) %1  2 lshift P6IN bis! 
( P6IN-P6IN3-set ) %1  3 lshift P6IN bis! 
( P6IN-P6IN4-set ) %1  4 lshift P6IN bis! 
( P6IN-P6IN5-set ) %1  5 lshift P6IN bis! 
( P6IN-P6IN6-set ) %1  6 lshift P6IN bis! 
( P6IN-P6IN7-set ) %1  7 lshift P6IN bis! 
 
\ P5OUT ( Port 5 Output ) 
( P5OUT-P5OUT0-set ) %1  0 lshift P5OUT bis! 
( P5OUT-P5OUT1-set ) %1  1 lshift P5OUT bis! 
( P5OUT-P5OUT2-set ) %1  2 lshift P5OUT bis! 
( P5OUT-P5OUT3-set ) %1  3 lshift P5OUT bis! 
( P5OUT-P5OUT4-set ) %1  4 lshift P5OUT bis! 
( P5OUT-P5OUT5-set ) %1  5 lshift P5OUT bis! 
( P5OUT-P5OUT6-set ) %1  6 lshift P5OUT bis! 
( P5OUT-P5OUT7-set ) %1  7 lshift P5OUT bis! 
 
\ P6OUT ( Port 6 Output ) 
( P6OUT-P6OUT0-set ) %1  0 lshift P6OUT bis! 
( P6OUT-P6OUT1-set ) %1  1 lshift P6OUT bis! 
( P6OUT-P6OUT2-set ) %1  2 lshift P6OUT bis! 
( P6OUT-P6OUT3-set ) %1  3 lshift P6OUT bis! 
( P6OUT-P6OUT4-set ) %1  4 lshift P6OUT bis! 
( P6OUT-P6OUT5-set ) %1  5 lshift P6OUT bis! 
( P6OUT-P6OUT6-set ) %1  6 lshift P6OUT bis! 
( P6OUT-P6OUT7-set ) %1  7 lshift P6OUT bis! 
 
\ P5DIR ( Port 5 Direction ) 
( P5DIR-P5DIR0-set ) %1  0 lshift P5DIR bis! 
( P5DIR-P5DIR1-set ) %1  1 lshift P5DIR bis! 
( P5DIR-P5DIR2-set ) %1  2 lshift P5DIR bis! 
( P5DIR-P5DIR3-set ) %1  3 lshift P5DIR bis! 
( P5DIR-P5DIR4-set ) %1  4 lshift P5DIR bis! 
( P5DIR-P5DIR5-set ) %1  5 lshift P5DIR bis! 
( P5DIR-P5DIR6-set ) %1  6 lshift P5DIR bis! 
( P5DIR-P5DIR7-set ) %1  7 lshift P5DIR bis! 
 
\ P6DIR ( Port 6 Direction ) 
( P6DIR-P6DIR0-set ) %1  0 lshift P6DIR bis! 
( P6DIR-P6DIR1-set ) %1  1 lshift P6DIR bis! 
( P6DIR-P6DIR2-set ) %1  2 lshift P6DIR bis! 
( P6DIR-P6DIR3-set ) %1  3 lshift P6DIR bis! 
( P6DIR-P6DIR4-set ) %1  4 lshift P6DIR bis! 
( P6DIR-P6DIR5-set ) %1  5 lshift P6DIR bis! 
( P6DIR-P6DIR6-set ) %1  6 lshift P6DIR bis! 
( P6DIR-P6DIR7-set ) %1  7 lshift P6DIR bis! 
 
\ P5REN ( Port 5 Resistor Enable ) 
( P5REN-P5REN0-set ) %1  0 lshift P5REN bis! 
( P5REN-P5REN1-set ) %1  1 lshift P5REN bis! 
( P5REN-P5REN2-set ) %1  2 lshift P5REN bis! 
( P5REN-P5REN3-set ) %1  3 lshift P5REN bis! 
( P5REN-P5REN4-set ) %1  4 lshift P5REN bis! 
( P5REN-P5REN5-set ) %1  5 lshift P5REN bis! 
( P5REN-P5REN6-set ) %1  6 lshift P5REN bis! 
( P5REN-P5REN7-set ) %1  7 lshift P5REN bis! 
 
\ P6REN ( Port 6 Resistor Enable ) 
( P6REN-P6REN0-set ) %1  0 lshift P6REN bis! 
( P6REN-P6REN1-set ) %1  1 lshift P6REN bis! 
( P6REN-P6REN2-set ) %1  2 lshift P6REN bis! 
( P6REN-P6REN3-set ) %1  3 lshift P6REN bis! 
( P6REN-P6REN4-set ) %1  4 lshift P6REN bis! 
( P6REN-P6REN5-set ) %1  5 lshift P6REN bis! 
( P6REN-P6REN6-set ) %1  6 lshift P6REN bis! 
( P6REN-P6REN7-set ) %1  7 lshift P6REN bis! 
 
\ P5DS ( Port 5 Drive Strenght ) 
( P5DS-P5DS0-set ) %1  0 lshift P5DS bis! 
( P5DS-P5DS1-set ) %1  1 lshift P5DS bis! 
( P5DS-P5DS2-set ) %1  2 lshift P5DS bis! 
( P5DS-P5DS3-set ) %1  3 lshift P5DS bis! 
( P5DS-P5DS4-set ) %1  4 lshift P5DS bis! 
( P5DS-P5DS5-set ) %1  5 lshift P5DS bis! 
( P5DS-P5DS6-set ) %1  6 lshift P5DS bis! 
( P5DS-P5DS7-set ) %1  7 lshift P5DS bis! 
 
\ P6DS ( Port 6 Drive Strenght ) 
( P6DS-P6DS0-set ) %1  0 lshift P6DS bis! 
( P6DS-P6DS1-set ) %1  1 lshift P6DS bis! 
( P6DS-P6DS2-set ) %1  2 lshift P6DS bis! 
( P6DS-P6DS3-set ) %1  3 lshift P6DS bis! 
( P6DS-P6DS4-set ) %1  4 lshift P6DS bis! 
( P6DS-P6DS5-set ) %1  5 lshift P6DS bis! 
( P6DS-P6DS6-set ) %1  6 lshift P6DS bis! 
( P6DS-P6DS7-set ) %1  7 lshift P6DS bis! 
 
\ P5SEL ( Port 5 Selection ) 
( P5SEL-P5SEL0-set ) %1  0 lshift P5SEL bis! 
( P5SEL-P5SEL1-set ) %1  1 lshift P5SEL bis! 
( P5SEL-P5SEL2-set ) %1  2 lshift P5SEL bis! 
( P5SEL-P5SEL3-set ) %1  3 lshift P5SEL bis! 
( P5SEL-P5SEL4-set ) %1  4 lshift P5SEL bis! 
( P5SEL-P5SEL5-set ) %1  5 lshift P5SEL bis! 
( P5SEL-P5SEL6-set ) %1  6 lshift P5SEL bis! 
( P5SEL-P5SEL7-set ) %1  7 lshift P5SEL bis! 
 
\ P6SEL ( Port 6 Selection ) 
( P6SEL-P6SEL0-set ) %1  0 lshift P6SEL bis! 
( P6SEL-P6SEL1-set ) %1  1 lshift P6SEL bis! 
( P6SEL-P6SEL2-set ) %1  2 lshift P6SEL bis! 
( P6SEL-P6SEL3-set ) %1  3 lshift P6SEL bis! 
( P6SEL-P6SEL4-set ) %1  4 lshift P6SEL bis! 
( P6SEL-P6SEL5-set ) %1  5 lshift P6SEL bis! 
( P6SEL-P6SEL6-set ) %1  6 lshift P6SEL bis! 
( P6SEL-P6SEL7-set ) %1  7 lshift P6SEL bis! 


                     
\ ===================================PORT_7_8 =================================== 
\ P7IN ( Port 7 Input ) 
( P7IN-P7IN0-set ) %1  0 lshift P7IN bis! 
( P7IN-P7IN1-set ) %1  1 lshift P7IN bis! 
( P7IN-P7IN2-set ) %1  2 lshift P7IN bis! 
( P7IN-P7IN3-set ) %1  3 lshift P7IN bis! 
( P7IN-P7IN4-set ) %1  4 lshift P7IN bis! 
( P7IN-P7IN5-set ) %1  5 lshift P7IN bis! 
( P7IN-P7IN6-set ) %1  6 lshift P7IN bis! 
( P7IN-P7IN7-set ) %1  7 lshift P7IN bis! 
 
\ P8IN ( Port 8 Input ) 
( P8IN-P8IN0-set ) %1  0 lshift P8IN bis! 
( P8IN-P8IN1-set ) %1  1 lshift P8IN bis! 
( P8IN-P8IN2-set ) %1  2 lshift P8IN bis! 
( P8IN-P8IN3-set ) %1  3 lshift P8IN bis! 
( P8IN-P8IN4-set ) %1  4 lshift P8IN bis! 
( P8IN-P8IN5-set ) %1  5 lshift P8IN bis! 
( P8IN-P8IN6-set ) %1  6 lshift P8IN bis! 
( P8IN-P8IN7-set ) %1  7 lshift P8IN bis! 
 
\ P7OUT ( Port 7 Output ) 
( P7OUT-P7OUT0-set ) %1  0 lshift P7OUT bis! 
( P7OUT-P7OUT1-set ) %1  1 lshift P7OUT bis! 
( P7OUT-P7OUT2-set ) %1  2 lshift P7OUT bis! 
( P7OUT-P7OUT3-set ) %1  3 lshift P7OUT bis! 
( P7OUT-P7OUT4-set ) %1  4 lshift P7OUT bis! 
( P7OUT-P7OUT5-set ) %1  5 lshift P7OUT bis! 
( P7OUT-P7OUT6-set ) %1  6 lshift P7OUT bis! 
( P7OUT-P7OUT7-set ) %1  7 lshift P7OUT bis! 
 
\ P8OUT ( Port 8 Output ) 
( P8OUT-P8OUT0-set ) %1  0 lshift P8OUT bis! 
( P8OUT-P8OUT1-set ) %1  1 lshift P8OUT bis! 
( P8OUT-P8OUT2-set ) %1  2 lshift P8OUT bis! 
( P8OUT-P8OUT3-set ) %1  3 lshift P8OUT bis! 
( P8OUT-P8OUT4-set ) %1  4 lshift P8OUT bis! 
( P8OUT-P8OUT5-set ) %1  5 lshift P8OUT bis! 
( P8OUT-P8OUT6-set ) %1  6 lshift P8OUT bis! 
( P8OUT-P8OUT7-set ) %1  7 lshift P8OUT bis! 
 
\ P7DIR ( Port 7 Direction ) 
( P7DIR-P7DIR0-set ) %1  0 lshift P7DIR bis! 
( P7DIR-P7DIR1-set ) %1  1 lshift P7DIR bis! 
( P7DIR-P7DIR2-set ) %1  2 lshift P7DIR bis! 
( P7DIR-P7DIR3-set ) %1  3 lshift P7DIR bis! 
( P7DIR-P7DIR4-set ) %1  4 lshift P7DIR bis! 
( P7DIR-P7DIR5-set ) %1  5 lshift P7DIR bis! 
( P7DIR-P7DIR6-set ) %1  6 lshift P7DIR bis! 
( P7DIR-P7DIR7-set ) %1  7 lshift P7DIR bis! 
 
\ P8DIR ( Port 8 Direction ) 
( P8DIR-P8DIR0-set ) %1  0 lshift P8DIR bis! 
( P8DIR-P8DIR1-set ) %1  1 lshift P8DIR bis! 
( P8DIR-P8DIR2-set ) %1  2 lshift P8DIR bis! 
( P8DIR-P8DIR3-set ) %1  3 lshift P8DIR bis! 
( P8DIR-P8DIR4-set ) %1  4 lshift P8DIR bis! 
( P8DIR-P8DIR5-set ) %1  5 lshift P8DIR bis! 
( P8DIR-P8DIR6-set ) %1  6 lshift P8DIR bis! 
( P8DIR-P8DIR7-set ) %1  7 lshift P8DIR bis! 
 
\ P7REN ( Port 7 Resistor Enable ) 
( P7REN-P7REN0-set ) %1  0 lshift P7REN bis! 
( P7REN-P7REN1-set ) %1  1 lshift P7REN bis! 
( P7REN-P7REN2-set ) %1  2 lshift P7REN bis! 
( P7REN-P7REN3-set ) %1  3 lshift P7REN bis! 
( P7REN-P7REN4-set ) %1  4 lshift P7REN bis! 
( P7REN-P7REN5-set ) %1  5 lshift P7REN bis! 
( P7REN-P7REN6-set ) %1  6 lshift P7REN bis! 
( P7REN-P7REN7-set ) %1  7 lshift P7REN bis! 
 
\ P8REN ( Port 8 Resistor Enable ) 
( P8REN-P8REN0-set ) %1  0 lshift P8REN bis! 
( P8REN-P8REN1-set ) %1  1 lshift P8REN bis! 
( P8REN-P8REN2-set ) %1  2 lshift P8REN bis! 
( P8REN-P8REN3-set ) %1  3 lshift P8REN bis! 
( P8REN-P8REN4-set ) %1  4 lshift P8REN bis! 
( P8REN-P8REN5-set ) %1  5 lshift P8REN bis! 
( P8REN-P8REN6-set ) %1  6 lshift P8REN bis! 
( P8REN-P8REN7-set ) %1  7 lshift P8REN bis! 
 
\ P7DS ( Port 7 Drive Strenght ) 
( P7DS-P7DS0-set ) %1  0 lshift P7DS bis! 
( P7DS-P7DS1-set ) %1  1 lshift P7DS bis! 
( P7DS-P7DS2-set ) %1  2 lshift P7DS bis! 
( P7DS-P7DS3-set ) %1  3 lshift P7DS bis! 
( P7DS-P7DS4-set ) %1  4 lshift P7DS bis! 
( P7DS-P7DS5-set ) %1  5 lshift P7DS bis! 
( P7DS-P7DS6-set ) %1  6 lshift P7DS bis! 
( P7DS-P7DS7-set ) %1  7 lshift P7DS bis! 
 
\ P8DS ( Port 8 Drive Strenght ) 
( P8DS-P8DS0-set ) %1  0 lshift P8DS bis! 
( P8DS-P8DS1-set ) %1  1 lshift P8DS bis! 
( P8DS-P8DS2-set ) %1  2 lshift P8DS bis! 
( P8DS-P8DS3-set ) %1  3 lshift P8DS bis! 
( P8DS-P8DS4-set ) %1  4 lshift P8DS bis! 
( P8DS-P8DS5-set ) %1  5 lshift P8DS bis! 
( P8DS-P8DS6-set ) %1  6 lshift P8DS bis! 
( P8DS-P8DS7-set ) %1  7 lshift P8DS bis! 
 
\ P7SEL ( Port 7 Selection ) 
( P7SEL-P7SEL0-set ) %1  0 lshift P7SEL bis! 
( P7SEL-P7SEL1-set ) %1  1 lshift P7SEL bis! 
( P7SEL-P7SEL2-set ) %1  2 lshift P7SEL bis! 
( P7SEL-P7SEL3-set ) %1  3 lshift P7SEL bis! 
( P7SEL-P7SEL4-set ) %1  4 lshift P7SEL bis! 
( P7SEL-P7SEL5-set ) %1  5 lshift P7SEL bis! 
( P7SEL-P7SEL6-set ) %1  6 lshift P7SEL bis! 
( P7SEL-P7SEL7-set ) %1  7 lshift P7SEL bis! 
 
\ P8SEL ( Port 8 Selection ) 
( P8SEL-P8SEL0-set ) %1  0 lshift P8SEL bis! 
( P8SEL-P8SEL1-set ) %1  1 lshift P8SEL bis! 
( P8SEL-P8SEL2-set ) %1  2 lshift P8SEL bis! 
( P8SEL-P8SEL3-set ) %1  3 lshift P8SEL bis! 
( P8SEL-P8SEL4-set ) %1  4 lshift P8SEL bis! 
( P8SEL-P8SEL5-set ) %1  5 lshift P8SEL bis! 
( P8SEL-P8SEL6-set ) %1  6 lshift P8SEL bis! 
( P8SEL-P8SEL7-set ) %1  7 lshift P8SEL bis! 


                     
\ ===================================RTC =================================== 
\ RTCSEC ( Real Time Clock Seconds ) 
( RTCSEC-SECONDS0-set ) %1  0 lshift RTCSEC bis! 
( RTCSEC-SECONDS1-set ) %1  1 lshift RTCSEC bis! 
( RTCSEC-SECONDS2-set ) %1  2 lshift RTCSEC bis! 
( RTCSEC-SECONDS3-set ) %1  3 lshift RTCSEC bis! 
( RTCSEC-SECONDS4-set ) %1  4 lshift RTCSEC bis! 
( RTCSEC-SECONDS5-set ) %1  5 lshift RTCSEC bis! 
( RTCSEC-SECONDS6-set ) %1  6 lshift RTCSEC bis! 
 
\ RTCMIN ( Real Time Clock Minutes ) 
( RTCMIN-MINUTES0-set ) %1  0 lshift RTCMIN bis! 
( RTCMIN-MINUTES1-set ) %1  1 lshift RTCMIN bis! 
( RTCMIN-MINUTES2-set ) %1  2 lshift RTCMIN bis! 
( RTCMIN-MINUTES3-set ) %1  3 lshift RTCMIN bis! 
( RTCMIN-MINUTES4-set ) %1  4 lshift RTCMIN bis! 
( RTCMIN-MINUTES5-set ) %1  5 lshift RTCMIN bis! 
( RTCMIN-MINUTES6-set ) %1  6 lshift RTCMIN bis! 
 
\ RTCHOUR ( Real Time Clock Hour ) 
( RTCHOUR-HOUR0-set ) %1  0 lshift RTCHOUR bis! 
( RTCHOUR-HOUR1-set ) %1  1 lshift RTCHOUR bis! 
( RTCHOUR-HOUR2-set ) %1  2 lshift RTCHOUR bis! 
( RTCHOUR-HOUR3-set ) %1  3 lshift RTCHOUR bis! 
( RTCHOUR-HOUR4-set ) %1  4 lshift RTCHOUR bis! 
( RTCHOUR-HOUR5-set ) %1  5 lshift RTCHOUR bis! 
( RTCHOUR-HOUR6-set ) %1  6 lshift RTCHOUR bis! 
 
\ RTCDOW ( Real Time Clock Day of week ) 
( RTCDOW-DOW0-set ) %1  0 lshift RTCDOW bis! 
( RTCDOW-DOW1-set ) %1  1 lshift RTCDOW bis! 
( RTCDOW-DOW2-set ) %1  2 lshift RTCDOW bis! 
( RTCDOW-DOW3-set ) %1  3 lshift RTCDOW bis! 
( RTCDOW-DOW4-set ) %1  4 lshift RTCDOW bis! 
( RTCDOW-DOW5-set ) %1  5 lshift RTCDOW bis! 
( RTCDOW-DOW6-set ) %1  6 lshift RTCDOW bis! 
 
\ RTCDAY ( Real Time Clock Day ) 
( RTCDAY-DAY0-set ) %1  0 lshift RTCDAY bis! 
( RTCDAY-DAY1-set ) %1  1 lshift RTCDAY bis! 
( RTCDAY-DAY2-set ) %1  2 lshift RTCDAY bis! 
( RTCDAY-DAY3-set ) %1  3 lshift RTCDAY bis! 
( RTCDAY-DAY4-set ) %1  4 lshift RTCDAY bis! 
( RTCDAY-DAY5-set ) %1  5 lshift RTCDAY bis! 
( RTCDAY-DAY6-set ) %1  6 lshift RTCDAY bis! 
 
\ RTCMON ( Real Time Clock Month ) 
( RTCMON-MONTH0-set ) %1  0 lshift RTCMON bis! 
( RTCMON-MONTH1-set ) %1  1 lshift RTCMON bis! 
( RTCMON-MONTH2-set ) %1  2 lshift RTCMON bis! 
( RTCMON-MONTH3-set ) %1  3 lshift RTCMON bis! 
( RTCMON-MONTH4-set ) %1  4 lshift RTCMON bis! 
( RTCMON-MONTH5-set ) %1  5 lshift RTCMON bis! 
( RTCMON-MONTH6-set ) %1  6 lshift RTCMON bis! 
 
\ RTCAMIN ( Real Time Clock Alarm Min ) 
( RTCAMIN-MINUTES0-set ) %1  0 lshift RTCAMIN bis! 
( RTCAMIN-MINUTES1-set ) %1  1 lshift RTCAMIN bis! 
( RTCAMIN-MINUTES2-set ) %1  2 lshift RTCAMIN bis! 
( RTCAMIN-MINUTES3-set ) %1  3 lshift RTCAMIN bis! 
( RTCAMIN-MINUTES4-set ) %1  4 lshift RTCAMIN bis! 
( RTCAMIN-MINUTES5-set ) %1  5 lshift RTCAMIN bis! 
( RTCAMIN-MINUTES6-set ) %1  6 lshift RTCAMIN bis! 
( RTCAMIN-RTCAE-set ) %1  7 lshift RTCAMIN bis! 
 
\ RTCAHOUR ( Real Time Clock Alarm Hour ) 
( RTCAHOUR-HOUR0-set ) %1  0 lshift RTCAHOUR bis! 
( RTCAHOUR-HOUR1-set ) %1  1 lshift RTCAHOUR bis! 
( RTCAHOUR-HOUR2-set ) %1  2 lshift RTCAHOUR bis! 
( RTCAHOUR-HOUR3-set ) %1  3 lshift RTCAHOUR bis! 
( RTCAHOUR-HOUR4-set ) %1  4 lshift RTCAHOUR bis! 
( RTCAHOUR-HOUR5-set ) %1  5 lshift RTCAHOUR bis! 
( RTCAHOUR-HOUR6-set ) %1  6 lshift RTCAHOUR bis! 
( RTCAHOUR-RTCAE-set ) %1  7 lshift RTCAHOUR bis! 
 
\ RTCADOW ( Real Time Clock Alarm Day of week ) 
( RTCADOW-DOW0-set ) %1  0 lshift RTCADOW bis! 
( RTCADOW-DOW1-set ) %1  1 lshift RTCADOW bis! 
( RTCADOW-DOW2-set ) %1  2 lshift RTCADOW bis! 
( RTCADOW-DOW3-set ) %1  3 lshift RTCADOW bis! 
( RTCADOW-DOW4-set ) %1  4 lshift RTCADOW bis! 
( RTCADOW-DOW5-set ) %1  5 lshift RTCADOW bis! 
( RTCADOW-DOW6-set ) %1  6 lshift RTCADOW bis! 
( RTCADOW-RTCAE-set ) %1  7 lshift RTCADOW bis! 
 
\ RTCADAY ( Real Time Clock Alarm Day ) 
( RTCADAY-DAY0-set ) %1  0 lshift RTCADAY bis! 
( RTCADAY-DAY1-set ) %1  1 lshift RTCADAY bis! 
( RTCADAY-DAY2-set ) %1  2 lshift RTCADAY bis! 
( RTCADAY-DAY3-set ) %1  3 lshift RTCADAY bis! 
( RTCADAY-DAY4-set ) %1  4 lshift RTCADAY bis! 
( RTCADAY-DAY5-set ) %1  5 lshift RTCADAY bis! 
( RTCADAY-DAY6-set ) %1  6 lshift RTCADAY bis! 
( RTCADAY-RTCAE-set ) %1  7 lshift RTCADAY bis! 
 
\ RTCCTL01 ( Real Timer Control 0/1 ) 
( RTCCTL01-RTCRDYIFG-set ) %1  0 lshift RTCCTL01 bis! 
( RTCCTL01-RTCAIFG-set ) %1  1 lshift RTCCTL01 bis! 
( RTCCTL01-RTCTEVIFG-set ) %1  2 lshift RTCCTL01 bis! 
( RTCCTL01-RTCRDYIE-set ) %1  4 lshift RTCCTL01 bis! 
( RTCCTL01-RTCAIE-set ) %1  5 lshift RTCCTL01 bis! 
( RTCCTL01-RTCTEVIE-set ) %1  6 lshift RTCCTL01 bis! 
( RTCCTL01-RTCTEV-set ) %xx  8 lshift
    \ %0: RTCTEV_0      ( RTC Time Event: 0 (Min. changed) ) 
    \ %1: RTCTEV_1      ( RTC Time Event: 1 (Hour changed) ) 
    \ %11: RTCTEV_2      ( RTC Time Event: 2 (12:00 changed) ) 
    \ %111: RTCTEV_3      ( RTC Time Event: 3 (00:00 changed) )  RTCCTL01 bis! 
( RTCCTL01-RTCSSEL-set ) %xx  10 lshift
    \ %0: RTCSSEL_0      ( RTC Source Select ACLK ) 
    \ %1: RTCSSEL_1      ( RTC Source Select SMCLK ) 
    \ %11: RTCSSEL_2      ( RTC Source Select RT1PS ) 
    \ %111: RTCSSEL_3      ( RTC Source Select RT1PS )  RTCCTL01 bis! 
( RTCCTL01-RTCRDY-set ) %1  12 lshift RTCCTL01 bis! 
( RTCCTL01-RTCMODE-set ) %1  13 lshift RTCCTL01 bis! 
( RTCCTL01-RTCHOLD-set ) %1  14 lshift RTCCTL01 bis! 
( RTCCTL01-RTCBCD-set ) %1  15 lshift RTCCTL01 bis! 
 
\ RTCCTL23 ( Real Timer Control 2/3 ) 
( RTCCTL23-RTCCAL0-set ) %1  0 lshift RTCCTL23 bis! 
( RTCCTL23-RTCCAL1-set ) %1  1 lshift RTCCTL23 bis! 
( RTCCTL23-RTCCAL2-set ) %1  2 lshift RTCCTL23 bis! 
( RTCCTL23-RTCCAL3-set ) %1  3 lshift RTCCTL23 bis! 
( RTCCTL23-RTCCAL4-set ) %1  4 lshift RTCCTL23 bis! 
( RTCCTL23-RTCCAL5-set ) %1  5 lshift RTCCTL23 bis! 
( RTCCTL23-RTCCALS-set ) %1  7 lshift RTCCTL23 bis! 
( RTCCTL23-RTCCALF-set ) %xx  8 lshift
    \ %0: RTCCALF_0      ( RTC Calibration Frequency: No Output ) 
    \ %1: RTCCALF_1      ( RTC Calibration Frequency: 512 Hz ) 
    \ %11: RTCCALF_2      ( RTC Calibration Frequency: 256 Hz ) 
    \ %111: RTCCALF_3      ( RTC Calibration Frequency: 1 Hz )  RTCCTL23 bis! 
 
\ RTCPS0CTL ( Real Timer Prescale Timer 0 Control ) 
( RTCPS0CTL-RT0PSIFG-set ) %1  0 lshift RTCPS0CTL bis! 
( RTCPS0CTL-RT0PSIE-set ) %1  1 lshift RTCPS0CTL bis! 
( RTCPS0CTL-RT0IP-set ) %xxx  2 lshift
    \ %0: RT0IP_0      ( RTC Prescale Timer 0 Interrupt Interval /2 ) 
    \ %1: RT0IP_1      ( RTC Prescale Timer 0 Interrupt Interval /4 ) 
    \ %11: RT0IP_2      ( RTC Prescale Timer 0 Interrupt Interval /8 ) 
    \ %111: RT0IP_3      ( RTC Prescale Timer 0 Interrupt Interval /16 ) 
    \ %1111: RT0IP_4      ( RTC Prescale Timer 0 Interrupt Interval /32 ) 
    \ %11111: RT0IP_5      ( RTC Prescale Timer 0 Interrupt Interval /64 ) 
    \ %111111: RT0IP_6      ( RTC Prescale Timer 0 Interrupt Interval /128 ) 
    \ %1111111: RT0IP_7      ( RTC Prescale Timer 0 Interrupt Interval /256 )  RTCPS0CTL bis! 
( RTCPS0CTL-RT0PSHOLD-set ) %1  8 lshift RTCPS0CTL bis! 
( RTCPS0CTL-RT0PSDIV-set ) %xxx  11 lshift
    \ %0: RT0PSDIV_0      ( RTC Prescale Timer 0 Clock Divide /2 ) 
    \ %1: RT0PSDIV_1      ( RTC Prescale Timer 0 Clock Divide /4 ) 
    \ %11: RT0PSDIV_2      ( RTC Prescale Timer 0 Clock Divide /8 ) 
    \ %111: RT0PSDIV_3      ( RTC Prescale Timer 0 Clock Divide /16 ) 
    \ %1111: RT0PSDIV_4      ( RTC Prescale Timer 0 Clock Divide /32 ) 
    \ %11111: RT0PSDIV_5      ( RTC Prescale Timer 0 Clock Divide /64 ) 
    \ %111111: RT0PSDIV_6      ( RTC Prescale Timer 0 Clock Divide /128 ) 
    \ %1111111: RT0PSDIV_7      ( RTC Prescale Timer 0 Clock Divide /256 )  RTCPS0CTL bis! 
( RTCPS0CTL-RT0SSEL-set ) %1  14 lshift RTCPS0CTL bis! 
 
\ RTCPS1CTL ( Real Timer Prescale Timer 1 Control ) 
( RTCPS1CTL-RT1PSIFG-set ) %1  0 lshift RTCPS1CTL bis! 
( RTCPS1CTL-RT1PSIE-set ) %1  1 lshift RTCPS1CTL bis! 
( RTCPS1CTL-RT1IP-set ) %xxx  2 lshift
    \ %0: RT1IP_0      ( RTC Prescale Timer 1 Interrupt Interval /2 ) 
    \ %1: RT1IP_1      ( RTC Prescale Timer 1 Interrupt Interval /4 ) 
    \ %11: RT1IP_2      ( RTC Prescale Timer 1 Interrupt Interval /8 ) 
    \ %111: RT1IP_3      ( RTC Prescale Timer 1 Interrupt Interval /16 ) 
    \ %1111: RT1IP_4      ( RTC Prescale Timer 1 Interrupt Interval /32 ) 
    \ %11111: RT1IP_5      ( RTC Prescale Timer 1 Interrupt Interval /64 ) 
    \ %111111: RT1IP_6      ( RTC Prescale Timer 1 Interrupt Interval /128 ) 
    \ %1111111: RT1IP_7      ( RTC Prescale Timer 1 Interrupt Interval /256 )  RTCPS1CTL bis! 
( RTCPS1CTL-RT1PSHOLD-set ) %1  8 lshift RTCPS1CTL bis! 
( RTCPS1CTL-RT1PSDIV-set ) %xxx  11 lshift
    \ %0: RT1PSDIV_0      ( RTC Prescale Timer 1 Clock Divide /2 ) 
    \ %1: RT1PSDIV_1      ( RTC Prescale Timer 1 Clock Divide /4 ) 
    \ %11: RT1PSDIV_2      ( RTC Prescale Timer 1 Clock Divide /8 ) 
    \ %111: RT1PSDIV_3      ( RTC Prescale Timer 1 Clock Divide /16 ) 
    \ %1111: RT1PSDIV_4      ( RTC Prescale Timer 1 Clock Divide /32 ) 
    \ %11111: RT1PSDIV_5      ( RTC Prescale Timer 1 Clock Divide /64 ) 
    \ %111111: RT1PSDIV_6      ( RTC Prescale Timer 1 Clock Divide /128 ) 
    \ %1111111: RT1PSDIV_7      ( RTC Prescale Timer 1 Clock Divide /256 )  RTCPS1CTL bis! 
( RTCPS1CTL-RT1SSEL-set ) %xx  14 lshift
    \ %0: RT1SSEL_0      ( RTC Prescale Timer Source Select ACLK ) 
    \ %1: RT1SSEL_1      ( RTC Prescale Timer Source Select SMCLK ) 
    \ %11: RT1SSEL_2      ( RTC Prescale Timer Source Select RT0PS ) 
    \ %111: RT1SSEL_3      ( RTC Prescale Timer Source Select RT0PS )  RTCPS1CTL bis! 
 
\ RTCPS ( Real Timer Prescale Timer Control ) 
 
\ RTCIV ( Real Time Clock Interrupt Vector ) 
 
\ RTCYEAR ( Real Time Clock Year ) 


                     
\ ===================================USCI_A0_UART_MODE =================================== 
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
 
\ UCA0IE ( USCI A0 Interrupt Enable Register ) 
( UCA0IE-UCRXIE-set ) %1  0 lshift UCA0IE bis! 
( UCA0IE-UCTXIE-set ) %1  1 lshift UCA0IE bis! 
 
\ UCA0IFG ( USCI A0 Interrupt Flags Register ) 
( UCA0IFG-UCRXIFG-set ) %1  0 lshift UCA0IFG bis! 
( UCA0IFG-UCTXIFG-set ) %1  1 lshift UCA0IFG bis! 
 
\ UCA0IV ( USCI A0 Interrupt Vector Register ) 


                     
\ ===================================USCI_A0_SPI_MODE =================================== 
\ UCA0CTL1 ( USCI A0 Control Register 1 ) 
( UCA0CTL1-UCSWRST-set ) %1  0 lshift UCA0CTL1 bis! 
( UCA0CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCA0CTL1 bis! 
 
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
 
\ UCA0IE ( USCI A0 Interrupt Enable Register ) 
( UCA0IE-UCRXIE-set ) %1  0 lshift UCA0IE bis! 
( UCA0IE-UCTXIE-set ) %1  1 lshift UCA0IE bis! 
( UCA0IE-UCSTTIE-set ) %1  2 lshift UCA0IE bis! 
( UCA0IE-UCSTPIE-set ) %1  3 lshift UCA0IE bis! 
( UCA0IE-UCALIE-set ) %1  4 lshift UCA0IE bis! 
( UCA0IE-UCNACKIE-set ) %1  5 lshift UCA0IE bis! 
 
\ UCA0IFG ( USCI A0 Interrupt Flags Register ) 
( UCA0IFG-UCRXIFG-set ) %1  0 lshift UCA0IFG bis! 
( UCA0IFG-UCTXIFG-set ) %1  1 lshift UCA0IFG bis! 
 
\ UCA0IV ( USCI A0 Interrupt Vector Register ) 


                     
\ ===================================USCI_B0_I2C_MODE =================================== 
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
 
\ UCB0BR0 ( USCI B0 Baud Rate 0 ) 
 
\ UCB0BR1 ( USCI B0 Baud Rate 1 ) 
 
\ UCB0STAT ( USCI B0 Status Register ) 
( UCB0STAT-UCBBUSY-set ) %1  4 lshift UCB0STAT bis! 
( UCB0STAT-UCGC-set ) %1  5 lshift UCB0STAT bis! 
( UCB0STAT-UCSCLLOW-set ) %1  6 lshift UCB0STAT bis! 
( UCB0STAT-UCLISTEN-set ) %1  7 lshift UCB0STAT bis! 
 
\ UCB0RXBUF ( USCI B0 Receive Buffer ) 
 
\ UCB0TXBUF ( USCI B0 Transmit Buffer ) 
 
\ UCB0IE ( USCI B0 Interrupt Enable Register ) 
( UCB0IE-UCRXIE-set ) %1  0 lshift UCB0IE bis! 
( UCB0IE-UCTXIE-set ) %1  1 lshift UCB0IE bis! 
( UCB0IE-UCSTTIE-set ) %1  2 lshift UCB0IE bis! 
( UCB0IE-UCSTPIE-set ) %1  3 lshift UCB0IE bis! 
( UCB0IE-UCALIE-set ) %1  4 lshift UCB0IE bis! 
( UCB0IE-UCNACKIE-set ) %1  5 lshift UCB0IE bis! 
 
\ UCB0IFG ( USCI B0 Interrupt Flags Register ) 
( UCB0IFG-UCRXIFG-set ) %1  0 lshift UCB0IFG bis! 
( UCB0IFG-UCTXIFG-set ) %1  1 lshift UCB0IFG bis! 
( UCB0IFG-UCSTTIFG-set ) %1  2 lshift UCB0IFG bis! 
( UCB0IFG-UCSTPIFG-set ) %1  3 lshift UCB0IFG bis! 
( UCB0IFG-UCALIFG-set ) %1  4 lshift UCB0IFG bis! 
( UCB0IFG-UCNACKIFG-set ) %1  5 lshift UCB0IFG bis! 
 
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
 
\ UCB0IV ( USCI B0 Interrupt Vector Register ) 


                     
\ ===================================USCI_B0_SPI_MODE =================================== 
\ UCB0CTL1 ( USCI B0 Control Register 1 ) 
( UCB0CTL1-UCSWRST-set ) %1  0 lshift UCB0CTL1 bis! 
( UCB0CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCB0CTL1 bis! 
 
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
 
\ UCB0BR0 ( USCI B0 Baud Rate 0 ) 
 
\ UCB0BR1 ( USCI B0 Baud Rate 1 ) 
 
\ UCB0STAT ( USCI B0 Status Register ) 
( UCB0STAT-UCBUSY-set ) %1  0 lshift UCB0STAT bis! 
( UCB0STAT-UCOE-set ) %1  5 lshift UCB0STAT bis! 
( UCB0STAT-UCFE-set ) %1  6 lshift UCB0STAT bis! 
( UCB0STAT-UCLISTEN-set ) %1  7 lshift UCB0STAT bis! 
 
\ UCB0RXBUF ( USCI B0 Receive Buffer ) 
 
\ UCB0TXBUF ( USCI B0 Transmit Buffer ) 
 
\ UCB0IE ( USCI B0 Interrupt Enable Register ) 
( UCB0IE-UCRXIE-set ) %1  0 lshift UCB0IE bis! 
( UCB0IE-UCTXIE-set ) %1  1 lshift UCB0IE bis! 
( UCB0IE-UCSTTIE-set ) %1  2 lshift UCB0IE bis! 
( UCB0IE-UCSTPIE-set ) %1  3 lshift UCB0IE bis! 
( UCB0IE-UCALIE-set ) %1  4 lshift UCB0IE bis! 
( UCB0IE-UCNACKIE-set ) %1  5 lshift UCB0IE bis! 
 
\ UCB0IFG ( USCI B0 Interrupt Flags Register ) 
( UCB0IFG-UCRXIFG-set ) %1  0 lshift UCB0IFG bis! 
( UCB0IFG-UCTXIFG-set ) %1  1 lshift UCB0IFG bis! 
 
\ UCB0IV ( USCI B0 Interrupt Vector Register ) 


                     
\ ===================================USCI_A1_UART_MODE =================================== 
\ UCA1CTL1 ( USCI A1 Control Register 1 ) 
( UCA1CTL1-UCSWRST-set ) %1  0 lshift UCA1CTL1 bis! 
( UCA1CTL1-UCTXBRK-set ) %1  1 lshift UCA1CTL1 bis! 
( UCA1CTL1-UCTXADDR-set ) %1  2 lshift UCA1CTL1 bis! 
( UCA1CTL1-UCDORM-set ) %1  3 lshift UCA1CTL1 bis! 
( UCA1CTL1-UCBRKIE-set ) %1  4 lshift UCA1CTL1 bis! 
( UCA1CTL1-UCRXEIE-set ) %1  5 lshift UCA1CTL1 bis! 
( UCA1CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCA1CTL1 bis! 
 
\ UCA1CTL0 ( USCI A1 Control Register 0 ) 
( UCA1CTL0-UCSYNC-set ) %1  0 lshift UCA1CTL0 bis! 
( UCA1CTL0-UCMODE-set ) %xx  1 lshift
    \ %0: UCMODE_0      ( Sync. Mode: USCI Mode: 0 ) 
    \ %1: UCMODE_1      ( Sync. Mode: USCI Mode: 1 ) 
    \ %11: UCMODE_2      ( Sync. Mode: USCI Mode: 2 ) 
    \ %111: UCMODE_3      ( Sync. Mode: USCI Mode: 3 )  UCA1CTL0 bis! 
( UCA1CTL0-UCSPB-set ) %1  3 lshift UCA1CTL0 bis! 
( UCA1CTL0-UC7BIT-set ) %1  4 lshift UCA1CTL0 bis! 
( UCA1CTL0-UCMSB-set ) %1  5 lshift UCA1CTL0 bis! 
( UCA1CTL0-UCPAR-set ) %1  6 lshift UCA1CTL0 bis! 
( UCA1CTL0-UCPEN-set ) %1  7 lshift UCA1CTL0 bis! 
 
\ UCA1BR0 ( USCI A1 Baud Rate 0 ) 
 
\ UCA1BR1 ( USCI A1 Baud Rate 1 ) 
 
\ UCA1MCTL ( USCI A1 Modulation Control ) 
( UCA1MCTL-UCOS16-set ) %1  0 lshift UCA1MCTL bis! 
( UCA1MCTL-UCBRS-set ) %xxx  1 lshift
    \ %0: UCBRS_0      ( USCI Second Stage Modulation: 0 ) 
    \ %1: UCBRS_1      ( USCI Second Stage Modulation: 1 ) 
    \ %11: UCBRS_2      ( USCI Second Stage Modulation: 2 ) 
    \ %111: UCBRS_3      ( USCI Second Stage Modulation: 3 ) 
    \ %1111: UCBRS_4      ( USCI Second Stage Modulation: 4 ) 
    \ %11111: UCBRS_5      ( USCI Second Stage Modulation: 5 ) 
    \ %111111: UCBRS_6      ( USCI Second Stage Modulation: 6 ) 
    \ %1111111: UCBRS_7      ( USCI Second Stage Modulation: 7 )  UCA1MCTL bis! 
( UCA1MCTL-UCBRF-set ) %xxxx  4 lshift
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
    \ %111111111111111: UCBRF_15      ( USCI First Stage Modulation: F )  UCA1MCTL bis! 
 
\ UCA1STAT ( USCI A1 Status Register ) 
( UCA1STAT-UCBUSY-set ) %1  0 lshift UCA1STAT bis! 
( UCA1STAT-UCADDR-set ) %1  1 lshift UCA1STAT bis! 
( UCA1STAT-UCRXERR-set ) %1  2 lshift UCA1STAT bis! 
( UCA1STAT-UCBRK-set ) %1  3 lshift UCA1STAT bis! 
( UCA1STAT-UCPE-set ) %1  4 lshift UCA1STAT bis! 
( UCA1STAT-UCOE-set ) %1  5 lshift UCA1STAT bis! 
( UCA1STAT-UCFE-set ) %1  6 lshift UCA1STAT bis! 
( UCA1STAT-UCLISTEN-set ) %1  7 lshift UCA1STAT bis! 
 
\ UCA1RXBUF ( USCI A1 Receive Buffer ) 
 
\ UCA1TXBUF ( USCI A1 Transmit Buffer ) 
 
\ UCA1ABCTL ( USCI A1 LIN Control ) 
( UCA1ABCTL-UCABDEN-set ) %1  0 lshift UCA1ABCTL bis! 
( UCA1ABCTL-UCBTOE-set ) %1  2 lshift UCA1ABCTL bis! 
( UCA1ABCTL-UCSTOE-set ) %1  3 lshift UCA1ABCTL bis! 
( UCA1ABCTL-UCDELIM0-set ) %1  4 lshift UCA1ABCTL bis! 
( UCA1ABCTL-UCDELIM1-set ) %1  5 lshift UCA1ABCTL bis! 
 
\ UCA1IRTCTL ( USCI A1 IrDA Transmit Control ) 
( UCA1IRTCTL-UCIREN-set ) %1  0 lshift UCA1IRTCTL bis! 
( UCA1IRTCTL-UCIRTXCLK-set ) %1  1 lshift UCA1IRTCTL bis! 
( UCA1IRTCTL-UCIRTXPL0-set ) %1  2 lshift UCA1IRTCTL bis! 
( UCA1IRTCTL-UCIRTXPL1-set ) %1  3 lshift UCA1IRTCTL bis! 
( UCA1IRTCTL-UCIRTXPL2-set ) %1  4 lshift UCA1IRTCTL bis! 
( UCA1IRTCTL-UCIRTXPL3-set ) %1  5 lshift UCA1IRTCTL bis! 
( UCA1IRTCTL-UCIRTXPL4-set ) %1  6 lshift UCA1IRTCTL bis! 
( UCA1IRTCTL-UCIRTXPL5-set ) %1  7 lshift UCA1IRTCTL bis! 
 
\ UCA1IRRCTL ( USCI A1 IrDA Receive Control ) 
( UCA1IRRCTL-UCIRRXFE-set ) %1  0 lshift UCA1IRRCTL bis! 
( UCA1IRRCTL-UCIRRXPL-set ) %1  1 lshift UCA1IRRCTL bis! 
( UCA1IRRCTL-UCIRRXFL0-set ) %1  2 lshift UCA1IRRCTL bis! 
( UCA1IRRCTL-UCIRRXFL1-set ) %1  3 lshift UCA1IRRCTL bis! 
( UCA1IRRCTL-UCIRRXFL2-set ) %1  4 lshift UCA1IRRCTL bis! 
( UCA1IRRCTL-UCIRRXFL3-set ) %1  5 lshift UCA1IRRCTL bis! 
( UCA1IRRCTL-UCIRRXFL4-set ) %1  6 lshift UCA1IRRCTL bis! 
( UCA1IRRCTL-UCIRRXFL5-set ) %1  7 lshift UCA1IRRCTL bis! 
 
\ UCA1IE ( USCI A1 Interrupt Enable Register ) 
( UCA1IE-UCRXIE-set ) %1  0 lshift UCA1IE bis! 
( UCA1IE-UCTXIE-set ) %1  1 lshift UCA1IE bis! 
 
\ UCA1IFG ( USCI A1 Interrupt Flags Register ) 
( UCA1IFG-UCRXIFG-set ) %1  0 lshift UCA1IFG bis! 
( UCA1IFG-UCTXIFG-set ) %1  1 lshift UCA1IFG bis! 
 
\ UCA1IV ( USCI A1 Interrupt Vector Register ) 


                     
\ ===================================USCI_A1_SPI_MODE =================================== 
\ UCA1CTL1 ( USCI A1 Control Register 1 ) 
( UCA1CTL1-UCSWRST-set ) %1  0 lshift UCA1CTL1 bis! 
( UCA1CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCA1CTL1 bis! 
 
\ UCA1CTL0 ( USCI A1 Control Register 0 ) 
( UCA1CTL0-UCSYNC-set ) %1  0 lshift UCA1CTL0 bis! 
( UCA1CTL0-UCMODE-set ) %xx  1 lshift
    \ %0: UCMODE_0      ( Sync. Mode: USCI Mode: 0 ) 
    \ %1: UCMODE_1      ( Sync. Mode: USCI Mode: 1 ) 
    \ %11: UCMODE_2      ( Sync. Mode: USCI Mode: 2 ) 
    \ %111: UCMODE_3      ( Sync. Mode: USCI Mode: 3 )  UCA1CTL0 bis! 
( UCA1CTL0-UCMST-set ) %1  3 lshift UCA1CTL0 bis! 
( UCA1CTL0-UC7BIT-set ) %1  4 lshift UCA1CTL0 bis! 
( UCA1CTL0-UCMSB-set ) %1  5 lshift UCA1CTL0 bis! 
( UCA1CTL0-UCCKPL-set ) %1  6 lshift UCA1CTL0 bis! 
( UCA1CTL0-UCCKPH-set ) %1  7 lshift UCA1CTL0 bis! 
 
\ UCA1BR0 ( USCI A1 Baud Rate 0 ) 
 
\ UCA1BR1 ( USCI A1 Baud Rate 1 ) 
 
\ UCA1MCTL ( USCI A1 Modulation Control ) 
 
\ UCA1STAT ( USCI A1 Status Register ) 
( UCA1STAT-UCBUSY-set ) %1  0 lshift UCA1STAT bis! 
( UCA1STAT-UCOE-set ) %1  5 lshift UCA1STAT bis! 
( UCA1STAT-UCFE-set ) %1  6 lshift UCA1STAT bis! 
( UCA1STAT-UCLISTEN-set ) %1  7 lshift UCA1STAT bis! 
 
\ UCA1RXBUF ( USCI A1 Receive Buffer ) 
 
\ UCA1TXBUF ( USCI A1 Transmit Buffer ) 
 
\ UCA1IE ( USCI A1 Interrupt Enable Register ) 
( UCA1IE-UCRXIE-set ) %1  0 lshift UCA1IE bis! 
( UCA1IE-UCTXIE-set ) %1  1 lshift UCA1IE bis! 
( UCA1IE-UCSTTIE-set ) %1  2 lshift UCA1IE bis! 
( UCA1IE-UCSTPIE-set ) %1  3 lshift UCA1IE bis! 
( UCA1IE-UCALIE-set ) %1  4 lshift UCA1IE bis! 
( UCA1IE-UCNACKIE-set ) %1  5 lshift UCA1IE bis! 
 
\ UCA1IFG ( USCI A1 Interrupt Flags Register ) 
( UCA1IFG-UCRXIFG-set ) %1  0 lshift UCA1IFG bis! 
( UCA1IFG-UCTXIFG-set ) %1  1 lshift UCA1IFG bis! 
 
\ UCA1IV ( USCI A1 Interrupt Vector Register ) 


                     
\ ===================================USCI_B1_I2C_MODE =================================== 
\ UCB1CTL1 ( USCI B1 Control Register 1 ) 
( UCB1CTL1-UCSWRST-set ) %1  0 lshift UCB1CTL1 bis! 
( UCB1CTL1-UCTXSTT-set ) %1  1 lshift UCB1CTL1 bis! 
( UCB1CTL1-UCTXSTP-set ) %1  2 lshift UCB1CTL1 bis! 
( UCB1CTL1-UCTXNACK-set ) %1  3 lshift UCB1CTL1 bis! 
( UCB1CTL1-UCTR-set ) %1  4 lshift UCB1CTL1 bis! 
( UCB1CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCB1CTL1 bis! 
 
\ UCB1CTL0 ( USCI B1 Control Register 0 ) 
( UCB1CTL0-UCSYNC-set ) %1  0 lshift UCB1CTL0 bis! 
( UCB1CTL0-UCMODE-set ) %xx  1 lshift
    \ %0: UCMODE_0      ( Sync. Mode: USCI Mode: 0 ) 
    \ %1: UCMODE_1      ( Sync. Mode: USCI Mode: 1 ) 
    \ %11: UCMODE_2      ( Sync. Mode: USCI Mode: 2 ) 
    \ %111: UCMODE_3      ( Sync. Mode: USCI Mode: 3 )  UCB1CTL0 bis! 
( UCB1CTL0-UCMST-set ) %1  3 lshift UCB1CTL0 bis! 
( UCB1CTL0-UCMM-set ) %1  5 lshift UCB1CTL0 bis! 
( UCB1CTL0-UCSLA10-set ) %1  6 lshift UCB1CTL0 bis! 
( UCB1CTL0-UCA10-set ) %1  7 lshift UCB1CTL0 bis! 
 
\ UCB1BR0 ( USCI B1 Baud Rate 0 ) 
 
\ UCB1BR1 ( USCI B1 Baud Rate 1 ) 
 
\ UCB1STAT ( USCI B1 Status Register ) 
( UCB1STAT-UCBBUSY-set ) %1  4 lshift UCB1STAT bis! 
( UCB1STAT-UCGC-set ) %1  5 lshift UCB1STAT bis! 
( UCB1STAT-UCSCLLOW-set ) %1  6 lshift UCB1STAT bis! 
( UCB1STAT-UCLISTEN-set ) %1  7 lshift UCB1STAT bis! 
 
\ UCB1RXBUF ( USCI B1 Receive Buffer ) 
 
\ UCB1TXBUF ( USCI B1 Transmit Buffer ) 
 
\ UCB1IE ( USCI B1 Interrupt Enable Register ) 
( UCB1IE-UCRXIE-set ) %1  0 lshift UCB1IE bis! 
( UCB1IE-UCTXIE-set ) %1  1 lshift UCB1IE bis! 
( UCB1IE-UCSTTIE-set ) %1  2 lshift UCB1IE bis! 
( UCB1IE-UCSTPIE-set ) %1  3 lshift UCB1IE bis! 
( UCB1IE-UCALIE-set ) %1  4 lshift UCB1IE bis! 
( UCB1IE-UCNACKIE-set ) %1  5 lshift UCB1IE bis! 
 
\ UCB1IFG ( USCI B1 Interrupt Flags Register ) 
( UCB1IFG-UCRXIFG-set ) %1  0 lshift UCB1IFG bis! 
( UCB1IFG-UCTXIFG-set ) %1  1 lshift UCB1IFG bis! 
( UCB1IFG-UCSTTIFG-set ) %1  2 lshift UCB1IFG bis! 
( UCB1IFG-UCSTPIFG-set ) %1  3 lshift UCB1IFG bis! 
( UCB1IFG-UCALIFG-set ) %1  4 lshift UCB1IFG bis! 
( UCB1IFG-UCNACKIFG-set ) %1  5 lshift UCB1IFG bis! 
 
\ UCB1I2COA ( USCI B1 I2C Own Address ) 
( UCB1I2COA-UCOA0-set ) %1  0 lshift UCB1I2COA bis! 
( UCB1I2COA-UCOA1-set ) %1  1 lshift UCB1I2COA bis! 
( UCB1I2COA-UCOA2-set ) %1  2 lshift UCB1I2COA bis! 
( UCB1I2COA-UCOA3-set ) %1  3 lshift UCB1I2COA bis! 
( UCB1I2COA-UCOA4-set ) %1  4 lshift UCB1I2COA bis! 
( UCB1I2COA-UCOA5-set ) %1  5 lshift UCB1I2COA bis! 
( UCB1I2COA-UCOA6-set ) %1  6 lshift UCB1I2COA bis! 
( UCB1I2COA-UCOA7-set ) %1  7 lshift UCB1I2COA bis! 
( UCB1I2COA-UCOA8-set ) %1  8 lshift UCB1I2COA bis! 
( UCB1I2COA-UCOA9-set ) %1  9 lshift UCB1I2COA bis! 
( UCB1I2COA-UCGCEN-set ) %1  15 lshift UCB1I2COA bis! 
 
\ UCB1I2CSA ( USCI B1 I2C Slave Address ) 
( UCB1I2CSA-UCSA0-set ) %1  0 lshift UCB1I2CSA bis! 
( UCB1I2CSA-UCSA1-set ) %1  1 lshift UCB1I2CSA bis! 
( UCB1I2CSA-UCSA2-set ) %1  2 lshift UCB1I2CSA bis! 
( UCB1I2CSA-UCSA3-set ) %1  3 lshift UCB1I2CSA bis! 
( UCB1I2CSA-UCSA4-set ) %1  4 lshift UCB1I2CSA bis! 
( UCB1I2CSA-UCSA5-set ) %1  5 lshift UCB1I2CSA bis! 
( UCB1I2CSA-UCSA6-set ) %1  6 lshift UCB1I2CSA bis! 
( UCB1I2CSA-UCSA7-set ) %1  7 lshift UCB1I2CSA bis! 
( UCB1I2CSA-UCSA8-set ) %1  8 lshift UCB1I2CSA bis! 
( UCB1I2CSA-UCSA9-set ) %1  9 lshift UCB1I2CSA bis! 
 
\ UCB1IV ( USCI B1 Interrupt Vector Register ) 


                     
\ ===================================USCI_B1_SPI_MODE =================================== 
\ UCB1CTL1 ( USCI B1 Control Register 1 ) 
( UCB1CTL1-UCSWRST-set ) %1  0 lshift UCB1CTL1 bis! 
( UCB1CTL1-UCSSEL-set ) %xx  6 lshift
    \ %0: UCSSEL_0      ( USCI 0 Clock Source: 0 ) 
    \ %1: UCSSEL_1      ( USCI 0 Clock Source: 1 ) 
    \ %11: UCSSEL_2      ( USCI 0 Clock Source: 2 ) 
    \ %111: UCSSEL_3      ( USCI 0 Clock Source: 3 )  UCB1CTL1 bis! 
 
\ UCB1CTL0 ( USCI B1 Control Register 0 ) 
( UCB1CTL0-UCSYNC-set ) %1  0 lshift UCB1CTL0 bis! 
( UCB1CTL0-UCMODE-set ) %xx  1 lshift
    \ %0: UCMODE_0      ( Sync. Mode: USCI Mode: 0 ) 
    \ %1: UCMODE_1      ( Sync. Mode: USCI Mode: 1 ) 
    \ %11: UCMODE_2      ( Sync. Mode: USCI Mode: 2 ) 
    \ %111: UCMODE_3      ( Sync. Mode: USCI Mode: 3 )  UCB1CTL0 bis! 
( UCB1CTL0-UCMST-set ) %1  3 lshift UCB1CTL0 bis! 
( UCB1CTL0-UC7BIT-set ) %1  4 lshift UCB1CTL0 bis! 
( UCB1CTL0-UCMSB-set ) %1  5 lshift UCB1CTL0 bis! 
( UCB1CTL0-UCCKPL-set ) %1  6 lshift UCB1CTL0 bis! 
( UCB1CTL0-UCCKPH-set ) %1  7 lshift UCB1CTL0 bis! 
 
\ UCB1BR0 ( USCI B1 Baud Rate 0 ) 
 
\ UCB1BR1 ( USCI B1 Baud Rate 1 ) 
 
\ UCB1STAT ( USCI B1 Status Register ) 
( UCB1STAT-UCBUSY-set ) %1  0 lshift UCB1STAT bis! 
( UCB1STAT-UCOE-set ) %1  5 lshift UCB1STAT bis! 
( UCB1STAT-UCFE-set ) %1  6 lshift UCB1STAT bis! 
( UCB1STAT-UCLISTEN-set ) %1  7 lshift UCB1STAT bis! 
 
\ UCB1RXBUF ( USCI B1 Receive Buffer ) 
 
\ UCB1TXBUF ( USCI B1 Transmit Buffer ) 
 
\ UCB1IE ( USCI B1 Interrupt Enable Register ) 
( UCB1IE-UCRXIE-set ) %1  0 lshift UCB1IE bis! 
( UCB1IE-UCTXIE-set ) %1  1 lshift UCB1IE bis! 
( UCB1IE-UCSTTIE-set ) %1  2 lshift UCB1IE bis! 
( UCB1IE-UCSTPIE-set ) %1  3 lshift UCB1IE bis! 
( UCB1IE-UCALIE-set ) %1  4 lshift UCB1IE bis! 
( UCB1IE-UCNACKIE-set ) %1  5 lshift UCB1IE bis! 
 
\ UCB1IFG ( USCI B1 Interrupt Flags Register ) 
( UCB1IFG-UCRXIFG-set ) %1  0 lshift UCB1IFG bis! 
( UCB1IFG-UCTXIFG-set ) %1  1 lshift UCB1IFG bis! 
 
\ UCB1IV ( USCI B1 Interrupt Vector Register ) 


                     
\ ===================================ADC12 =================================== 
\ ADC12MCTL0 ( ADC12 Memory Control 0 ) 
( ADC12MCTL0-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL0 bis! 
( ADC12MCTL0-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL0 bis! 
( ADC12MCTL0-ADC12EOS-set ) %1  7 lshift ADC12MCTL0 bis! 
 
\ ADC12MCTL1 ( ADC12 Memory Control 1 ) 
( ADC12MCTL1-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL1 bis! 
( ADC12MCTL1-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL1 bis! 
( ADC12MCTL1-ADC12EOS-set ) %1  7 lshift ADC12MCTL1 bis! 
 
\ ADC12MCTL2 ( ADC12 Memory Control 2 ) 
( ADC12MCTL2-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL2 bis! 
( ADC12MCTL2-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL2 bis! 
( ADC12MCTL2-ADC12EOS-set ) %1  7 lshift ADC12MCTL2 bis! 
 
\ ADC12MCTL3 ( ADC12 Memory Control 3 ) 
( ADC12MCTL3-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL3 bis! 
( ADC12MCTL3-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL3 bis! 
( ADC12MCTL3-ADC12EOS-set ) %1  7 lshift ADC12MCTL3 bis! 
 
\ ADC12MCTL4 ( ADC12 Memory Control 4 ) 
( ADC12MCTL4-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL4 bis! 
( ADC12MCTL4-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL4 bis! 
( ADC12MCTL4-ADC12EOS-set ) %1  7 lshift ADC12MCTL4 bis! 
 
\ ADC12MCTL5 ( ADC12 Memory Control 5 ) 
( ADC12MCTL5-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL5 bis! 
( ADC12MCTL5-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL5 bis! 
( ADC12MCTL5-ADC12EOS-set ) %1  7 lshift ADC12MCTL5 bis! 
 
\ ADC12MCTL6 ( ADC12 Memory Control 6 ) 
( ADC12MCTL6-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL6 bis! 
( ADC12MCTL6-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL6 bis! 
( ADC12MCTL6-ADC12EOS-set ) %1  7 lshift ADC12MCTL6 bis! 
 
\ ADC12MCTL7 ( ADC12 Memory Control 7 ) 
( ADC12MCTL7-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL7 bis! 
( ADC12MCTL7-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL7 bis! 
( ADC12MCTL7-ADC12EOS-set ) %1  7 lshift ADC12MCTL7 bis! 
 
\ ADC12MCTL8 ( ADC12 Memory Control 8 ) 
( ADC12MCTL8-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL8 bis! 
( ADC12MCTL8-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL8 bis! 
( ADC12MCTL8-ADC12EOS-set ) %1  7 lshift ADC12MCTL8 bis! 
 
\ ADC12MCTL9 ( ADC12 Memory Control 9 ) 
( ADC12MCTL9-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL9 bis! 
( ADC12MCTL9-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL9 bis! 
( ADC12MCTL9-ADC12EOS-set ) %1  7 lshift ADC12MCTL9 bis! 
 
\ ADC12MCTL10 ( ADC12 Memory Control 10 ) 
( ADC12MCTL10-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL10 bis! 
( ADC12MCTL10-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL10 bis! 
( ADC12MCTL10-ADC12EOS-set ) %1  7 lshift ADC12MCTL10 bis! 
 
\ ADC12MCTL11 ( ADC12 Memory Control 11 ) 
( ADC12MCTL11-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL11 bis! 
( ADC12MCTL11-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL11 bis! 
( ADC12MCTL11-ADC12EOS-set ) %1  7 lshift ADC12MCTL11 bis! 
 
\ ADC12MCTL12 ( ADC12 Memory Control 12 ) 
( ADC12MCTL12-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL12 bis! 
( ADC12MCTL12-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL12 bis! 
( ADC12MCTL12-ADC12EOS-set ) %1  7 lshift ADC12MCTL12 bis! 
 
\ ADC12MCTL13 ( ADC12 Memory Control 13 ) 
( ADC12MCTL13-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL13 bis! 
( ADC12MCTL13-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL13 bis! 
( ADC12MCTL13-ADC12EOS-set ) %1  7 lshift ADC12MCTL13 bis! 
 
\ ADC12MCTL14 ( ADC12 Memory Control 14 ) 
( ADC12MCTL14-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL14 bis! 
( ADC12MCTL14-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL14 bis! 
( ADC12MCTL14-ADC12EOS-set ) %1  7 lshift ADC12MCTL14 bis! 
 
\ ADC12MCTL15 ( ADC12 Memory Control 15 ) 
( ADC12MCTL15-ADC12INCH-set ) %xxxx  0 lshift
    \ %0: ADC12INCH_0      ( ADC12 Input Channel 0 ) 
    \ %1: ADC12INCH_1      ( ADC12 Input Channel 1 ) 
    \ %11: ADC12INCH_2      ( ADC12 Input Channel 2 ) 
    \ %111: ADC12INCH_3      ( ADC12 Input Channel 3 ) 
    \ %1111: ADC12INCH_4      ( ADC12 Input Channel 4 ) 
    \ %11111: ADC12INCH_5      ( ADC12 Input Channel 5 ) 
    \ %111111: ADC12INCH_6      ( ADC12 Input Channel 6 ) 
    \ %1111111: ADC12INCH_7      ( ADC12 Input Channel 7 ) 
    \ %11111111: ADC12INCH_8      ( ADC12 Input Channel 8 ) 
    \ %111111111: ADC12INCH_9      ( ADC12 Input Channel 9 ) 
    \ %1111111111: ADC12INCH_10      ( ADC12 Input Channel 10 ) 
    \ %11111111111: ADC12INCH_11      ( ADC12 Input Channel 11 ) 
    \ %111111111111: ADC12INCH_12      ( ADC12 Input Channel 12 ) 
    \ %1111111111111: ADC12INCH_13      ( ADC12 Input Channel 13 ) 
    \ %11111111111111: ADC12INCH_14      ( ADC12 Input Channel 14 ) 
    \ %111111111111111: ADC12INCH_15      ( ADC12 Input Channel 15 )  ADC12MCTL15 bis! 
( ADC12MCTL15-ADC12SREF-set ) %xxx  4 lshift
    \ %0: ADC12SREF_0      ( ADC12 Select Reference 0 ) 
    \ %1: ADC12SREF_1      ( ADC12 Select Reference 1 ) 
    \ %11: ADC12SREF_2      ( ADC12 Select Reference 2 ) 
    \ %111: ADC12SREF_3      ( ADC12 Select Reference 3 ) 
    \ %1111: ADC12SREF_4      ( ADC12 Select Reference 4 ) 
    \ %11111: ADC12SREF_5      ( ADC12 Select Reference 5 ) 
    \ %111111: ADC12SREF_6      ( ADC12 Select Reference 6 ) 
    \ %1111111: ADC12SREF_7      ( ADC12 Select Reference 7 )  ADC12MCTL15 bis! 
( ADC12MCTL15-ADC12EOS-set ) %1  7 lshift ADC12MCTL15 bis! 
 
\ ADC12CTL0 ( ADC12+ Control 0 ) 
( ADC12CTL0-ADC12SC-set ) %1  0 lshift ADC12CTL0 bis! 
( ADC12CTL0-ADC12ENC-set ) %1  1 lshift ADC12CTL0 bis! 
( ADC12CTL0-ADC12TOVIE-set ) %1  2 lshift ADC12CTL0 bis! 
( ADC12CTL0-ADC12OVIE-set ) %1  3 lshift ADC12CTL0 bis! 
( ADC12CTL0-ADC12ON-set ) %1  4 lshift ADC12CTL0 bis! 
( ADC12CTL0-ADC12REFON-set ) %1  5 lshift ADC12CTL0 bis! 
( ADC12CTL0-ADC12REF2_5V-set ) %1  6 lshift ADC12CTL0 bis! 
( ADC12CTL0-ADC12MSC-set ) %1  7 lshift ADC12CTL0 bis! 
( ADC12CTL0-ADC12SHT0-set ) %xxxx  8 lshift
    \ %0: ADC12SHT0_0      ( ADC12 Sample Hold 0 Select Bit: 0 ) 
    \ %1: ADC12SHT0_1      ( ADC12 Sample Hold 0 Select Bit: 1 ) 
    \ %11: ADC12SHT0_2      ( ADC12 Sample Hold 0 Select Bit: 2 ) 
    \ %111: ADC12SHT0_3      ( ADC12 Sample Hold 0 Select Bit: 3 ) 
    \ %1111: ADC12SHT0_4      ( ADC12 Sample Hold 0 Select Bit: 4 ) 
    \ %11111: ADC12SHT0_5      ( ADC12 Sample Hold 0 Select Bit: 5 ) 
    \ %111111: ADC12SHT0_6      ( ADC12 Sample Hold 0 Select Bit: 6 ) 
    \ %1111111: ADC12SHT0_7      ( ADC12 Sample Hold 0 Select Bit: 7 ) 
    \ %11111111: ADC12SHT0_8      ( ADC12 Sample Hold 0 Select Bit: 8 ) 
    \ %111111111: ADC12SHT0_9      ( ADC12 Sample Hold 0 Select Bit: 9 ) 
    \ %1111111111: ADC12SHT0_10      ( ADC12 Sample Hold 0 Select Bit: 10 ) 
    \ %11111111111: ADC12SHT0_11      ( ADC12 Sample Hold 0 Select Bit: 11 ) 
    \ %111111111111: ADC12SHT0_12      ( ADC12 Sample Hold 0 Select Bit: 12 ) 
    \ %1111111111111: ADC12SHT0_13      ( ADC12 Sample Hold 0 Select Bit: 13 ) 
    \ %11111111111111: ADC12SHT0_14      ( ADC12 Sample Hold 0 Select Bit: 14 ) 
    \ %111111111111111: ADC12SHT0_15      ( ADC12 Sample Hold 0 Select Bit: 15 )  ADC12CTL0 bis! 
( ADC12CTL0-ADC12SHT1-set ) %xxxx  12 lshift
    \ %0: ADC12SHT1_0      ( ADC12 Sample Hold 1 Select Bit: 0 ) 
    \ %1: ADC12SHT1_1      ( ADC12 Sample Hold 1 Select Bit: 1 ) 
    \ %11: ADC12SHT1_2      ( ADC12 Sample Hold 1 Select Bit: 2 ) 
    \ %111: ADC12SHT1_3      ( ADC12 Sample Hold 1 Select Bit: 3 ) 
    \ %1111: ADC12SHT1_4      ( ADC12 Sample Hold 1 Select Bit: 4 ) 
    \ %11111: ADC12SHT1_5      ( ADC12 Sample Hold 1 Select Bit: 5 ) 
    \ %111111: ADC12SHT1_6      ( ADC12 Sample Hold 1 Select Bit: 6 ) 
    \ %1111111: ADC12SHT1_7      ( ADC12 Sample Hold 1 Select Bit: 7 ) 
    \ %11111111: ADC12SHT1_8      ( ADC12 Sample Hold 1 Select Bit: 8 ) 
    \ %111111111: ADC12SHT1_9      ( ADC12 Sample Hold 1 Select Bit: 9 ) 
    \ %1111111111: ADC12SHT1_10      ( ADC12 Sample Hold 1 Select Bit: 10 ) 
    \ %11111111111: ADC12SHT1_11      ( ADC12 Sample Hold 1 Select Bit: 11 ) 
    \ %111111111111: ADC12SHT1_12      ( ADC12 Sample Hold 1 Select Bit: 12 ) 
    \ %1111111111111: ADC12SHT1_13      ( ADC12 Sample Hold 1 Select Bit: 13 ) 
    \ %11111111111111: ADC12SHT1_14      ( ADC12 Sample Hold 1 Select Bit: 14 ) 
    \ %111111111111111: ADC12SHT1_15      ( ADC12 Sample Hold 1 Select Bit: 15 )  ADC12CTL0 bis! 
 
\ ADC12CTL1 ( ADC12+ Control 1 ) 
( ADC12CTL1-ADC12BUSY-set ) %1  0 lshift ADC12CTL1 bis! 
( ADC12CTL1-ADC12CONSEQ-set ) %xx  1 lshift
    \ %0: ADC12CONSEQ_0      ( ADC12 Conversion Sequence Select: 0 ) 
    \ %1: ADC12CONSEQ_1      ( ADC12 Conversion Sequence Select: 1 ) 
    \ %11: ADC12CONSEQ_2      ( ADC12 Conversion Sequence Select: 2 ) 
    \ %111: ADC12CONSEQ_3      ( ADC12 Conversion Sequence Select: 3 )  ADC12CTL1 bis! 
( ADC12CTL1-ADC12SSEL-set ) %xx  3 lshift
    \ %0: ADC12SSEL_0      ( ADC12 Clock Source Select: 0 ) 
    \ %1: ADC12SSEL_1      ( ADC12 Clock Source Select: 1 ) 
    \ %11: ADC12SSEL_2      ( ADC12 Clock Source Select: 2 ) 
    \ %111: ADC12SSEL_3      ( ADC12 Clock Source Select: 3 )  ADC12CTL1 bis! 
( ADC12CTL1-ADC12DIV-set ) %xxx  5 lshift
    \ %0: ADC12DIV_0      ( ADC12 Clock Divider Select: 0 ) 
    \ %1: ADC12DIV_1      ( ADC12 Clock Divider Select: 1 ) 
    \ %11: ADC12DIV_2      ( ADC12 Clock Divider Select: 2 ) 
    \ %111: ADC12DIV_3      ( ADC12 Clock Divider Select: 3 ) 
    \ %1111: ADC12DIV_4      ( ADC12 Clock Divider Select: 4 ) 
    \ %11111: ADC12DIV_5      ( ADC12 Clock Divider Select: 5 ) 
    \ %111111: ADC12DIV_6      ( ADC12 Clock Divider Select: 6 ) 
    \ %1111111: ADC12DIV_7      ( ADC12 Clock Divider Select: 7 )  ADC12CTL1 bis! 
( ADC12CTL1-ADC12ISSH-set ) %1  8 lshift ADC12CTL1 bis! 
( ADC12CTL1-ADC12SHP-set ) %1  9 lshift ADC12CTL1 bis! 
( ADC12CTL1-ADC12SHS-set ) %xx  10 lshift
    \ %0: ADC12SHS_0      ( ADC12 Sample/Hold Source: 0 ) 
    \ %1: ADC12SHS_1      ( ADC12 Sample/Hold Source: 1 ) 
    \ %11: ADC12SHS_2      ( ADC12 Sample/Hold Source: 2 ) 
    \ %111: ADC12SHS_3      ( ADC12 Sample/Hold Source: 3 )  ADC12CTL1 bis! 
( ADC12CTL1-ADC12CSTARTADD-set ) %xxxx  12 lshift
    \ %0: ADC12CSTARTADD_0      ( ADC12 Conversion Start Address: 0 ) 
    \ %1: ADC12CSTARTADD_1      ( ADC12 Conversion Start Address: 1 ) 
    \ %11: ADC12CSTARTADD_2      ( ADC12 Conversion Start Address: 2 ) 
    \ %111: ADC12CSTARTADD_3      ( ADC12 Conversion Start Address: 3 ) 
    \ %1111: ADC12CSTARTADD_4      ( ADC12 Conversion Start Address: 4 ) 
    \ %11111: ADC12CSTARTADD_5      ( ADC12 Conversion Start Address: 5 ) 
    \ %111111: ADC12CSTARTADD_6      ( ADC12 Conversion Start Address: 6 ) 
    \ %1111111: ADC12CSTARTADD_7      ( ADC12 Conversion Start Address: 7 ) 
    \ %11111111: ADC12CSTARTADD_8      ( ADC12 Conversion Start Address: 8 ) 
    \ %111111111: ADC12CSTARTADD_9      ( ADC12 Conversion Start Address: 9 ) 
    \ %1111111111: ADC12CSTARTADD_10      ( ADC12 Conversion Start Address: 10 ) 
    \ %11111111111: ADC12CSTARTADD_11      ( ADC12 Conversion Start Address: 11 ) 
    \ %111111111111: ADC12CSTARTADD_12      ( ADC12 Conversion Start Address: 12 ) 
    \ %1111111111111: ADC12CSTARTADD_13      ( ADC12 Conversion Start Address: 13 ) 
    \ %11111111111111: ADC12CSTARTADD_14      ( ADC12 Conversion Start Address: 14 ) 
    \ %111111111111111: ADC12CSTARTADD_15      ( ADC12 Conversion Start Address: 15 )  ADC12CTL1 bis! 
 
\ ADC12CTL2 ( ADC12+ Control 2 ) 
( ADC12CTL2-ADC12REFBURST-set ) %1  0 lshift ADC12CTL2 bis! 
( ADC12CTL2-ADC12REFOUT-set ) %1  1 lshift ADC12CTL2 bis! 
( ADC12CTL2-ADC12SR-set ) %1  2 lshift ADC12CTL2 bis! 
( ADC12CTL2-ADC12DF-set ) %1  3 lshift ADC12CTL2 bis! 
( ADC12CTL2-ADC12RES-set ) %xx  4 lshift
    \ %0: ADC12RES_0      ( ADC12+ Resolution : 8 Bit ) 
    \ %1: ADC12RES_1      ( ADC12+ Resolution : 10 Bit ) 
    \ %11: ADC12RES_2      ( ADC12+ Resolution : 12 Bit ) 
    \ %111: ADC12RES_3      ( ADC12+ Resolution : reserved )  ADC12CTL2 bis! 
( ADC12CTL2-ADC12TCOFF-set ) %1  7 lshift ADC12CTL2 bis! 
( ADC12CTL2-ADC12PDIV-set ) %1  8 lshift ADC12CTL2 bis! 
 
\ ADC12IFG ( ADC12+ Interrupt Flag ) 
( ADC12IFG-ADC12IFG0-set ) %1  0 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG1-set ) %1  1 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG2-set ) %1  2 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG3-set ) %1  3 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG4-set ) %1  4 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG5-set ) %1  5 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG6-set ) %1  6 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG7-set ) %1  7 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG8-set ) %1  8 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG9-set ) %1  9 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG10-set ) %1  10 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG11-set ) %1  11 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG12-set ) %1  12 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG13-set ) %1  13 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG14-set ) %1  14 lshift ADC12IFG bis! 
( ADC12IFG-ADC12IFG15-set ) %1  15 lshift ADC12IFG bis! 
 
\ ADC12IE ( ADC12+ Interrupt Enable ) 
( ADC12IE-ADC12IE0-set ) %1  0 lshift ADC12IE bis! 
( ADC12IE-ADC12IE1-set ) %1  1 lshift ADC12IE bis! 
( ADC12IE-ADC12IE2-set ) %1  2 lshift ADC12IE bis! 
( ADC12IE-ADC12IE3-set ) %1  3 lshift ADC12IE bis! 
( ADC12IE-ADC12IE4-set ) %1  4 lshift ADC12IE bis! 
( ADC12IE-ADC12IE5-set ) %1  5 lshift ADC12IE bis! 
( ADC12IE-ADC12IE6-set ) %1  6 lshift ADC12IE bis! 
( ADC12IE-ADC12IE7-set ) %1  7 lshift ADC12IE bis! 
( ADC12IE-ADC12IE8-set ) %1  8 lshift ADC12IE bis! 
( ADC12IE-ADC12IE9-set ) %1  9 lshift ADC12IE bis! 
( ADC12IE-ADC12IE10-set ) %1  10 lshift ADC12IE bis! 
( ADC12IE-ADC12IE11-set ) %1  11 lshift ADC12IE bis! 
( ADC12IE-ADC12IE12-set ) %1  12 lshift ADC12IE bis! 
( ADC12IE-ADC12IE13-set ) %1  13 lshift ADC12IE bis! 
( ADC12IE-ADC12IE14-set ) %1  14 lshift ADC12IE bis! 
( ADC12IE-ADC12IE15-set ) %1  15 lshift ADC12IE bis! 
 
\ ADC12IV ( ADC12+ Interrupt Vector Word ) 
 
\ ADC12MEM0 ( ADC12 Conversion Memory 0 ) 
 
\ ADC12MEM1 ( ADC12 Conversion Memory 1 ) 
 
\ ADC12MEM2 ( ADC12 Conversion Memory 2 ) 
 
\ ADC12MEM3 ( ADC12 Conversion Memory 3 ) 
 
\ ADC12MEM4 ( ADC12 Conversion Memory 4 ) 
 
\ ADC12MEM5 ( ADC12 Conversion Memory 5 ) 
 
\ ADC12MEM6 ( ADC12 Conversion Memory 6 ) 
 
\ ADC12MEM7 ( ADC12 Conversion Memory 7 ) 
 
\ ADC12MEM8 ( ADC12 Conversion Memory 8 ) 
 
\ ADC12MEM9 ( ADC12 Conversion Memory 9 ) 
 
\ ADC12MEM10 ( ADC12 Conversion Memory 10 ) 
 
\ ADC12MEM11 ( ADC12 Conversion Memory 11 ) 
 
\ ADC12MEM12 ( ADC12 Conversion Memory 12 ) 
 
\ ADC12MEM13 ( ADC12 Conversion Memory 13 ) 
 
\ ADC12MEM14 ( ADC12 Conversion Memory 14 ) 
 
\ ADC12MEM15 ( ADC12 Conversion Memory 15 ) 


                     
\ ===================================USB_CONTROL =================================== 
\ USBIEPCNF_0 ( USB Input endpoint_0: Configuration ) 
( USBIEPCNF_0-USBIIE-set ) %1  2 lshift USBIEPCNF_0 bis! 
( USBIEPCNF_0-STALL-set ) %1  3 lshift USBIEPCNF_0 bis! 
( USBIEPCNF_0-TOGGLE-set ) %1  5 lshift USBIEPCNF_0 bis! 
( USBIEPCNF_0-UBME-set ) %1  7 lshift USBIEPCNF_0 bis! 
 
\ USBIEPCNT_0 ( USB Input endpoint_0: Byte Count ) 
 
\ USBOEPCNF_0 ( USB Output endpoint_0: Configuration ) 
( USBOEPCNF_0-USBIIE-set ) %1  2 lshift USBOEPCNF_0 bis! 
( USBOEPCNF_0-STALL-set ) %1  3 lshift USBOEPCNF_0 bis! 
( USBOEPCNF_0-TOGGLE-set ) %1  5 lshift USBOEPCNF_0 bis! 
( USBOEPCNF_0-UBME-set ) %1  7 lshift USBOEPCNF_0 bis! 
 
\ USBOEPCNT_0 ( USB Output endpoint_0: byte count ) 
 
\ USBIEPIE ( USB Input endpoint interrupt enable flags ) 
 
\ USBOEPIE ( USB Output endpoint interrupt enable flags ) 
 
\ USBIEPIFG ( USB Input endpoint interrupt flags ) 
 
\ USBOEPIFG ( USB Output endpoint interrupt flags ) 
 
\ USBCTL ( USB control register ) 
( USBCTL-DIR-set ) %1  0 lshift USBCTL bis! 
( USBCTL-FRSTE-set ) %1  4 lshift USBCTL bis! 
( USBCTL-RWUP-set ) %1  5 lshift USBCTL bis! 
( USBCTL-FEN-set ) %1  6 lshift USBCTL bis! 
 
\ USBIE ( USB interrupt enable register ) 
( USBIE-STPOWIE-set ) %1  0 lshift USBIE bis! 
( USBIE-SETUPIE-set ) %1  2 lshift USBIE bis! 
( USBIE-RESRIE-set ) %1  5 lshift USBIE bis! 
( USBIE-SUSRIE-set ) %1  6 lshift USBIE bis! 
( USBIE-RSTRIE-set ) %1  7 lshift USBIE bis! 
 
\ USBIFG ( USB interrupt flag register ) 
( USBIFG-STPOWIFG-set ) %1  0 lshift USBIFG bis! 
( USBIFG-SETUPIFG-set ) %1  2 lshift USBIFG bis! 
( USBIFG-RESRIFG-set ) %1  5 lshift USBIFG bis! 
( USBIFG-SUSRIFG-set ) %1  6 lshift USBIFG bis! 
( USBIFG-RSTRIFG-set ) %1  7 lshift USBIFG bis! 
 
\ USBFUNADR ( USB Function address register ) 
 
\ USBKEYID ( USB Controller key register ) 
 
\ USBCNF ( USB Module  configuration register ) 
( USBCNF-USB_EN-set ) %1  0 lshift USBCNF bis! 
( USBCNF-PUR_EN-set ) %1  1 lshift USBCNF bis! 
( USBCNF-PUR_IN-set ) %1  2 lshift USBCNF bis! 
( USBCNF-BLKRDY-set ) %1  3 lshift USBCNF bis! 
( USBCNF-FNTEN-set ) %1  4 lshift USBCNF bis! 
 
\ USBPHYCTL ( USB PHY control register ) 
( USBPHYCTL-PUOUT0-set ) %1  0 lshift USBPHYCTL bis! 
( USBPHYCTL-PUOUT1-set ) %1  1 lshift USBPHYCTL bis! 
( USBPHYCTL-PUIN0-set ) %1  2 lshift USBPHYCTL bis! 
( USBPHYCTL-PUIN1-set ) %1  3 lshift USBPHYCTL bis! 
( USBPHYCTL-PUOPE-set ) %1  5 lshift USBPHYCTL bis! 
( USBPHYCTL-PUSEL-set ) %1  7 lshift USBPHYCTL bis! 
( USBPHYCTL-PUIPE-set ) %1  8 lshift USBPHYCTL bis! 
 
\ USBPWRCTL ( USB Power control register ) 
( USBPWRCTL-VUOVLIFG-set ) %1  0 lshift USBPWRCTL bis! 
( USBPWRCTL-VBONIFG-set ) %1  1 lshift USBPWRCTL bis! 
( USBPWRCTL-VBOFFIFG-set ) %1  2 lshift USBPWRCTL bis! 
( USBPWRCTL-USBBGVBV-set ) %1  3 lshift USBPWRCTL bis! 
( USBPWRCTL-USBDETEN-set ) %1  4 lshift USBPWRCTL bis! 
( USBPWRCTL-OVLAOFF-set ) %1  5 lshift USBPWRCTL bis! 
( USBPWRCTL-SLDOAON-set ) %1  6 lshift USBPWRCTL bis! 
( USBPWRCTL-VUOVLIE-set ) %1  8 lshift USBPWRCTL bis! 
( USBPWRCTL-VBONIE-set ) %1  9 lshift USBPWRCTL bis! 
( USBPWRCTL-VBOFFIE-set ) %1  10 lshift USBPWRCTL bis! 
( USBPWRCTL-VUSBEN-set ) %1  11 lshift USBPWRCTL bis! 
( USBPWRCTL-SLDOEN-set ) %1  12 lshift USBPWRCTL bis! 
 
\ USBPLLCTL ( USB PLL control register ) 
( USBPLLCTL-UCLKSEL-set ) %xx  6 lshift
    \ %0: UCLKSEL_0      ( USB - Module Clock Select: 0 ) 
    \ %1: UCLKSEL_1      ( USB - Module Clock Select: 1 ) 
    \ %11: UCLKSEL_2      ( USB - Module Clock Select: 2 ) 
    \ %111: UCLKSEL_3      ( USB - Module Clock Select: 3 (Reserved) )  USBPLLCTL bis! 
( USBPLLCTL-UPLLEN-set ) %1  8 lshift USBPLLCTL bis! 
( USBPLLCTL-UPFDEN-set ) %1  9 lshift USBPLLCTL bis! 
 
\ USBPLLDIVB ( USB PLL Clock Divider Buffer control register ) 
( USBPLLDIVB-UPMB0-set ) %1  0 lshift USBPLLDIVB bis! 
( USBPLLDIVB-UPMB1-set ) %1  1 lshift USBPLLDIVB bis! 
( USBPLLDIVB-UPMB2-set ) %1  2 lshift USBPLLDIVB bis! 
( USBPLLDIVB-UPMB3-set ) %1  3 lshift USBPLLDIVB bis! 
( USBPLLDIVB-UPMB4-set ) %1  4 lshift USBPLLDIVB bis! 
( USBPLLDIVB-UPMB5-set ) %1  5 lshift USBPLLDIVB bis! 
( USBPLLDIVB-UPQB0-set ) %1  8 lshift USBPLLDIVB bis! 
( USBPLLDIVB-UPQB1-set ) %1  9 lshift USBPLLDIVB bis! 
( USBPLLDIVB-UPQB2-set ) %1  10 lshift USBPLLDIVB bis! 
 
\ USBPLLIR ( USB PLL Interrupt control register ) 
( USBPLLIR-USBOOLIFG-set ) %1  0 lshift USBPLLIR bis! 
( USBPLLIR-USBLOSIFG-set ) %1  1 lshift USBPLLIR bis! 
( USBPLLIR-USBOORIFG-set ) %1  2 lshift USBPLLIR bis! 
( USBPLLIR-USBOOLIE-set ) %1  8 lshift USBPLLIR bis! 
( USBPLLIR-USBLOSIE-set ) %1  9 lshift USBPLLIR bis! 
( USBPLLIR-USBOORIE-set ) %1  10 lshift USBPLLIR bis! 
 
\ USBVECINT ( USB Vector interrupt register ) 
 
\ USBMAINT ( USB maintenance register ) 
( USBMAINT-UTIFG-set ) %1  0 lshift USBMAINT bis! 
( USBMAINT-UTIE-set ) %1  1 lshift USBMAINT bis! 
( USBMAINT-TSGEN-set ) %1  8 lshift USBMAINT bis! 
( USBMAINT-TSESEL-set ) %xx  9 lshift
    \ %0: TSESEL_0      ( USB - Time Stamp Event Select: 0 ) 
    \ %1: TSESEL_1      ( USB - Time Stamp Event Select: 1 ) 
    \ %11: TSESEL_2      ( USB - Time Stamp Event Select: 2 ) 
    \ %111: TSESEL_3      ( USB - Time Stamp Event Select: 3 )  USBMAINT bis! 
( USBMAINT-TSE3-set ) %1  11 lshift USBMAINT bis! 
( USBMAINT-UTSEL-set ) %xxx  13 lshift
    \ %0: UTSEL_0      ( USB - Timer Select: 0 ) 
    \ %1: UTSEL_1      ( USB - Timer Select: 1 ) 
    \ %11: UTSEL_2      ( USB - Timer Select: 2 ) 
    \ %111: UTSEL_3      ( USB - Timer Select: 3 ) 
    \ %1111: UTSEL_4      ( USB - Timer Select: 4 ) 
    \ %11111: UTSEL_5      ( USB - Timer Select: 5 ) 
    \ %111111: UTSEL_6      ( USB - Timer Select: 6 ) 
    \ %1111111: UTSEL_7      ( USB - Timer Select: 7 )  USBMAINT bis! 
 
\ USBTSREG ( USB Time Stamp register ) 
 
\ USBFN ( USB Frame number ) 


                     
\ ===================================USB_OPERATION =================================== 
\ USBSTABUFF ( Start of buffer space ) 
 
\ USBTOPBUFF ( Top of buffer space ) 
 
\ USBOEP0BUF ( Output endpoint_0 buffer ) 
 
\ USBIEP0BUF ( Input endpoint_0 buffer ) 
 
\ USBSUBLK ( Setup Packet Block ) 
 
\ USBOEPCNF_1 ( Output Endpoint_1: Configuration ) 
( USBOEPCNF_1-USBIIE-set ) %1  2 lshift USBOEPCNF_1 bis! 
( USBOEPCNF_1-STALL-set ) %1  3 lshift USBOEPCNF_1 bis! 
( USBOEPCNF_1-DBUF-set ) %1  4 lshift USBOEPCNF_1 bis! 
( USBOEPCNF_1-TOGGLE-set ) %1  5 lshift USBOEPCNF_1 bis! 
( USBOEPCNF_1-UBME-set ) %1  7 lshift USBOEPCNF_1 bis! 
 
\ USBOEPBBAX_1 ( Output Endpoint_1: X-buffer base addr. ) 
 
\ USBOEPBCTX_1 ( Output Endpoint_1: X-byte count ) 
 
\ USBOEPBBAY_1 ( Output Endpoint_1: Y-buffer base addr. ) 
 
\ USBOEPBCTY_1 ( Output Endpoint_1: Y-byte count ) 
 
\ USBOEPSIZXY_1 ( Output Endpoint_1: X/Y-buffer size ) 
 
\ USBOEPCNF_2 ( Output Endpoint_2: Configuration ) 
( USBOEPCNF_2-USBIIE-set ) %1  2 lshift USBOEPCNF_2 bis! 
( USBOEPCNF_2-STALL-set ) %1  3 lshift USBOEPCNF_2 bis! 
( USBOEPCNF_2-DBUF-set ) %1  4 lshift USBOEPCNF_2 bis! 
( USBOEPCNF_2-TOGGLE-set ) %1  5 lshift USBOEPCNF_2 bis! 
( USBOEPCNF_2-UBME-set ) %1  7 lshift USBOEPCNF_2 bis! 
 
\ USBOEPBBAX_2 ( Output Endpoint_2: X-buffer base addr. ) 
 
\ USBOEPBCTX_2 ( Output Endpoint_2: X-byte count ) 
 
\ USBOEPBBAY_2 ( Output Endpoint_2: Y-buffer base addr. ) 
 
\ USBOEPBCTY_2 ( Output Endpoint_2: Y-byte count ) 
 
\ USBOEPSIZXY_2 ( Output Endpoint_2: X/Y-buffer size ) 
 
\ USBOEPCNF_3 ( Output Endpoint_3: Configuration ) 
( USBOEPCNF_3-USBIIE-set ) %1  2 lshift USBOEPCNF_3 bis! 
( USBOEPCNF_3-STALL-set ) %1  3 lshift USBOEPCNF_3 bis! 
( USBOEPCNF_3-DBUF-set ) %1  4 lshift USBOEPCNF_3 bis! 
( USBOEPCNF_3-TOGGLE-set ) %1  5 lshift USBOEPCNF_3 bis! 
( USBOEPCNF_3-UBME-set ) %1  7 lshift USBOEPCNF_3 bis! 
 
\ USBOEPBBAX_3 ( Output Endpoint_3: X-buffer base addr. ) 
 
\ USBOEPBCTX_3 ( Output Endpoint_3: X-byte count ) 
 
\ USBOEPBBAY_3 ( Output Endpoint_3: Y-buffer base addr. ) 
 
\ USBOEPBCTY_3 ( Output Endpoint_3: Y-byte count ) 
 
\ USBOEPSIZXY_3 ( Output Endpoint_3: X/Y-buffer size ) 
 
\ USBOEPCNF_4 ( Output Endpoint_4: Configuration ) 
( USBOEPCNF_4-USBIIE-set ) %1  2 lshift USBOEPCNF_4 bis! 
( USBOEPCNF_4-STALL-set ) %1  3 lshift USBOEPCNF_4 bis! 
( USBOEPCNF_4-DBUF-set ) %1  4 lshift USBOEPCNF_4 bis! 
( USBOEPCNF_4-TOGGLE-set ) %1  5 lshift USBOEPCNF_4 bis! 
( USBOEPCNF_4-UBME-set ) %1  7 lshift USBOEPCNF_4 bis! 
 
\ USBOEPBBAX_4 ( Output Endpoint_4: X-buffer base addr. ) 
 
\ USBOEPBCTX_4 ( Output Endpoint_4: X-byte count ) 
 
\ USBOEPBBAY_4 ( Output Endpoint_4: Y-buffer base addr. ) 
 
\ USBOEPBCTY_4 ( Output Endpoint_4: Y-byte count ) 
 
\ USBOEPSIZXY_4 ( Output Endpoint_4: X/Y-buffer size ) 
 
\ USBOEPCNF_5 ( Output Endpoint_5: Configuration ) 
( USBOEPCNF_5-USBIIE-set ) %1  2 lshift USBOEPCNF_5 bis! 
( USBOEPCNF_5-STALL-set ) %1  3 lshift USBOEPCNF_5 bis! 
( USBOEPCNF_5-DBUF-set ) %1  4 lshift USBOEPCNF_5 bis! 
( USBOEPCNF_5-TOGGLE-set ) %1  5 lshift USBOEPCNF_5 bis! 
( USBOEPCNF_5-UBME-set ) %1  7 lshift USBOEPCNF_5 bis! 
 
\ USBOEPBBAX_5 ( Output Endpoint_5: X-buffer base addr. ) 
 
\ USBOEPBCTX_5 ( Output Endpoint_5: X-byte count ) 
 
\ USBOEPBBAY_5 ( Output Endpoint_5: Y-buffer base addr. ) 
 
\ USBOEPBCTY_5 ( Output Endpoint_5: Y-byte count ) 
 
\ USBOEPSIZXY_5 ( Output Endpoint_5: X/Y-buffer size ) 
 
\ USBOEPCNF_6 ( Output Endpoint_6: Configuration ) 
( USBOEPCNF_6-USBIIE-set ) %1  2 lshift USBOEPCNF_6 bis! 
( USBOEPCNF_6-STALL-set ) %1  3 lshift USBOEPCNF_6 bis! 
( USBOEPCNF_6-DBUF-set ) %1  4 lshift USBOEPCNF_6 bis! 
( USBOEPCNF_6-TOGGLE-set ) %1  5 lshift USBOEPCNF_6 bis! 
( USBOEPCNF_6-UBME-set ) %1  7 lshift USBOEPCNF_6 bis! 
 
\ USBOEPBBAX_6 ( Output Endpoint_6: X-buffer base addr. ) 
 
\ USBOEPBCTX_6 ( Output Endpoint_6: X-byte count ) 
 
\ USBOEPBBAY_6 ( Output Endpoint_6: Y-buffer base addr. ) 
 
\ USBOEPBCTY_6 ( Output Endpoint_6: Y-byte count ) 
 
\ USBOEPSIZXY_6 ( Output Endpoint_6: X/Y-buffer size ) 
 
\ USBOEPCNF_7 ( Output Endpoint_7: Configuration ) 
( USBOEPCNF_7-USBIIE-set ) %1  2 lshift USBOEPCNF_7 bis! 
( USBOEPCNF_7-STALL-set ) %1  3 lshift USBOEPCNF_7 bis! 
( USBOEPCNF_7-DBUF-set ) %1  4 lshift USBOEPCNF_7 bis! 
( USBOEPCNF_7-TOGGLE-set ) %1  5 lshift USBOEPCNF_7 bis! 
( USBOEPCNF_7-UBME-set ) %1  7 lshift USBOEPCNF_7 bis! 
 
\ USBOEPBBAX_7 ( Output Endpoint_7: X-buffer base addr. ) 
 
\ USBOEPBCTX_7 ( Output Endpoint_7: X-byte count ) 
 
\ USBOEPBBAY_7 ( Output Endpoint_7: Y-buffer base addr. ) 
 
\ USBOEPBCTY_7 ( Output Endpoint_7: Y-byte count ) 
 
\ USBOEPSIZXY_7 ( Output Endpoint_7: X/Y-buffer size ) 
 
\ USBIEPCNF_1 ( Input Endpoint_1: Configuration ) 
( USBIEPCNF_1-USBIIE-set ) %1  2 lshift USBIEPCNF_1 bis! 
( USBIEPCNF_1-STALL-set ) %1  3 lshift USBIEPCNF_1 bis! 
( USBIEPCNF_1-DBUF-set ) %1  4 lshift USBIEPCNF_1 bis! 
( USBIEPCNF_1-TOGGLE-set ) %1  5 lshift USBIEPCNF_1 bis! 
( USBIEPCNF_1-UBME-set ) %1  7 lshift USBIEPCNF_1 bis! 
 
\ USBIEPBBAX_1 ( Input Endpoint_1: X-buffer base addr. ) 
 
\ USBIEPBCTX_1 ( Input Endpoint_1: X-byte count ) 
 
\ USBIEPBBAY_1 ( Input Endpoint_1: Y-buffer base addr. ) 
 
\ USBIEPBCTY_1 ( Input Endpoint_1: Y-byte count ) 
 
\ USBIEPSIZXY_1 ( Input Endpoint_1: X/Y-buffer size ) 
 
\ USBIEPCNF_2 ( Input Endpoint_2: Configuration ) 
( USBIEPCNF_2-USBIIE-set ) %1  2 lshift USBIEPCNF_2 bis! 
( USBIEPCNF_2-STALL-set ) %1  3 lshift USBIEPCNF_2 bis! 
( USBIEPCNF_2-DBUF-set ) %1  4 lshift USBIEPCNF_2 bis! 
( USBIEPCNF_2-TOGGLE-set ) %1  5 lshift USBIEPCNF_2 bis! 
( USBIEPCNF_2-UBME-set ) %1  7 lshift USBIEPCNF_2 bis! 
 
\ USBIEPBBAX_2 ( Input Endpoint_2: X-buffer base addr. ) 
 
\ USBIEPBCTX_2 ( Input Endpoint_2: X-byte count ) 
 
\ USBIEPBBAY_2 ( Input Endpoint_2: Y-buffer base addr. ) 
 
\ USBIEPBCTY_2 ( Input Endpoint_2: Y-byte count ) 
 
\ USBIEPSIZXY_2 ( Input Endpoint_2: X/Y-buffer size ) 
 
\ USBIEPCNF_3 ( Input Endpoint_3: Configuration ) 
( USBIEPCNF_3-USBIIE-set ) %1  2 lshift USBIEPCNF_3 bis! 
( USBIEPCNF_3-STALL-set ) %1  3 lshift USBIEPCNF_3 bis! 
( USBIEPCNF_3-DBUF-set ) %1  4 lshift USBIEPCNF_3 bis! 
( USBIEPCNF_3-TOGGLE-set ) %1  5 lshift USBIEPCNF_3 bis! 
( USBIEPCNF_3-UBME-set ) %1  7 lshift USBIEPCNF_3 bis! 
 
\ USBIEPBBAX_3 ( Input Endpoint_3: X-buffer base addr. ) 
 
\ USBIEPBCTX_3 ( Input Endpoint_3: X-byte count ) 
 
\ USBIEPBBAY_3 ( Input Endpoint_3: Y-buffer base addr. ) 
 
\ USBIEPBCTY_3 ( Input Endpoint_3: Y-byte count ) 
 
\ USBIEPSIZXY_3 ( Input Endpoint_3: X/Y-buffer size ) 
 
\ USBIEPCNF_4 ( Input Endpoint_4: Configuration ) 
( USBIEPCNF_4-USBIIE-set ) %1  2 lshift USBIEPCNF_4 bis! 
( USBIEPCNF_4-STALL-set ) %1  3 lshift USBIEPCNF_4 bis! 
( USBIEPCNF_4-DBUF-set ) %1  4 lshift USBIEPCNF_4 bis! 
( USBIEPCNF_4-TOGGLE-set ) %1  5 lshift USBIEPCNF_4 bis! 
( USBIEPCNF_4-UBME-set ) %1  7 lshift USBIEPCNF_4 bis! 
 
\ USBIEPBBAX_4 ( Input Endpoint_4: X-buffer base addr. ) 
 
\ USBIEPBCTX_4 ( Input Endpoint_4: X-byte count ) 
 
\ USBIEPBBAY_4 ( Input Endpoint_4: Y-buffer base addr. ) 
 
\ USBIEPBCTY_4 ( Input Endpoint_4: Y-byte count ) 
 
\ USBIEPSIZXY_4 ( Input Endpoint_4: X/Y-buffer size ) 
 
\ USBIEPCNF_5 ( Input Endpoint_5: Configuration ) 
( USBIEPCNF_5-USBIIE-set ) %1  2 lshift USBIEPCNF_5 bis! 
( USBIEPCNF_5-STALL-set ) %1  3 lshift USBIEPCNF_5 bis! 
( USBIEPCNF_5-DBUF-set ) %1  4 lshift USBIEPCNF_5 bis! 
( USBIEPCNF_5-TOGGLE-set ) %1  5 lshift USBIEPCNF_5 bis! 
( USBIEPCNF_5-UBME-set ) %1  7 lshift USBIEPCNF_5 bis! 
 
\ USBIEPBBAX_5 ( Input Endpoint_5: X-buffer base addr. ) 
 
\ USBIEPBCTX_5 ( Input Endpoint_5: X-byte count ) 
 
\ USBIEPBBAY_5 ( Input Endpoint_5: Y-buffer base addr. ) 
 
\ USBIEPBCTY_5 ( Input Endpoint_5: Y-byte count ) 
 
\ USBIEPSIZXY_5 ( Input Endpoint_5: X/Y-buffer size ) 
 
\ USBIEPCNF_6 ( Input Endpoint_6: Configuration ) 
( USBIEPCNF_6-USBIIE-set ) %1  2 lshift USBIEPCNF_6 bis! 
( USBIEPCNF_6-STALL-set ) %1  3 lshift USBIEPCNF_6 bis! 
( USBIEPCNF_6-DBUF-set ) %1  4 lshift USBIEPCNF_6 bis! 
( USBIEPCNF_6-TOGGLE-set ) %1  5 lshift USBIEPCNF_6 bis! 
( USBIEPCNF_6-UBME-set ) %1  7 lshift USBIEPCNF_6 bis! 
 
\ USBIEPBBAX_6 ( Input Endpoint_6: X-buffer base addr. ) 
 
\ USBIEPBCTX_6 ( Input Endpoint_6: X-byte count ) 
 
\ USBIEPBBAY_6 ( Input Endpoint_6: Y-buffer base addr. ) 
 
\ USBIEPBCTY_6 ( Input Endpoint_6: Y-byte count ) 
 
\ USBIEPSIZXY_6 ( Input Endpoint_6: X/Y-buffer size ) 
 
\ USBIEPCNF_7 ( Input Endpoint_7: Configuration ) 
( USBIEPCNF_7-USBIIE-set ) %1  2 lshift USBIEPCNF_7 bis! 
( USBIEPCNF_7-STALL-set ) %1  3 lshift USBIEPCNF_7 bis! 
( USBIEPCNF_7-DBUF-set ) %1  4 lshift USBIEPCNF_7 bis! 
( USBIEPCNF_7-TOGGLE-set ) %1  5 lshift USBIEPCNF_7 bis! 
( USBIEPCNF_7-UBME-set ) %1  7 lshift USBIEPCNF_7 bis! 
 
\ USBIEPBBAX_7 ( Input Endpoint_7: X-buffer base addr. ) 
 
\ USBIEPBCTX_7 ( Input Endpoint_7: X-byte count ) 
 
\ USBIEPBBAY_7 ( Input Endpoint_7: Y-buffer base addr. ) 
 
\ USBIEPBCTY_7 ( Input Endpoint_7: Y-byte count ) 
 
\ USBIEPSIZXY_7 ( Input Endpoint_7: X/Y-buffer size ) 


                     
\ ===================================SFR =================================== 
\ SFRIE1 ( Interrupt Enable 1 ) 
( SFRIE1-WDTIE-set ) %1  0 lshift SFRIE1 bis! 
( SFRIE1-OFIE-set ) %1  1 lshift SFRIE1 bis! 
( SFRIE1-VMAIE-set ) %1  3 lshift SFRIE1 bis! 
( SFRIE1-NMIIE-set ) %1  4 lshift SFRIE1 bis! 
( SFRIE1-ACCVIE-set ) %1  5 lshift SFRIE1 bis! 
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
( PMMCTL0-PMMCOREV-set ) %xx  0 lshift
    \ %0: PMMCOREV_0      ( PMM Core Voltage 0 (1.35V) ) 
    \ %1: PMMCOREV_1      ( PMM Core Voltage 1 (1.55V) ) 
    \ %11: PMMCOREV_2      ( PMM Core Voltage 2 (1.75V) ) 
    \ %111: PMMCOREV_3      ( PMM Core Voltage 3 (1.85V) )  PMMCTL0 bis! 
( PMMCTL0-PMMSWBOR-set ) %1  2 lshift PMMCTL0 bis! 
( PMMCTL0-PMMSWPOR-set ) %1  3 lshift PMMCTL0 bis! 
( PMMCTL0-PMMREGOFF-set ) %1  4 lshift PMMCTL0 bis! 
( PMMCTL0-PMMHPMRE-set ) %1  7 lshift PMMCTL0 bis! 
 
\ PMMCTL1 ( PMM Control 1 ) 
( PMMCTL1-PMMREFMD-set ) %1  0 lshift PMMCTL1 bis! 
( PMMCTL1-PMMCMD0-set ) %1  4 lshift PMMCTL1 bis! 
( PMMCTL1-PMMCMD1-set ) %1  5 lshift PMMCTL1 bis! 
 
\ SVSMHCTL ( SVS and SVM high side control register ) 
( SVSMHCTL-SVSMHRRL-set ) %xxx  0 lshift
    \ %0: SVSMHRRL_0      ( SVS and SVM high side Reset Release Voltage Level 0 ) 
    \ %1: SVSMHRRL_1      ( SVS and SVM high side Reset Release Voltage Level 1 ) 
    \ %11: SVSMHRRL_2      ( SVS and SVM high side Reset Release Voltage Level 2 ) 
    \ %111: SVSMHRRL_3      ( SVS and SVM high side Reset Release Voltage Level 3 ) 
    \ %1111: SVSMHRRL_4      ( SVS and SVM high side Reset Release Voltage Level 4 ) 
    \ %11111: SVSMHRRL_5      ( SVS and SVM high side Reset Release Voltage Level 5 ) 
    \ %111111: SVSMHRRL_6      ( SVS and SVM high side Reset Release Voltage Level 6 ) 
    \ %1111111: SVSMHRRL_7      ( SVS and SVM high side Reset Release Voltage Level 7 )  SVSMHCTL bis! 
( SVSMHCTL-SVSMHDLYST-set ) %1  3 lshift SVSMHCTL bis! 
( SVSMHCTL-SVSHMD-set ) %1  4 lshift SVSMHCTL bis! 
( SVSMHCTL-SVSMHEVM-set ) %1  6 lshift SVSMHCTL bis! 
( SVSMHCTL-SVSMHACE-set ) %1  7 lshift SVSMHCTL bis! 
( SVSMHCTL-SVSHRVL-set ) %xx  8 lshift
    \ %0: SVSHRVL_0      ( SVS high side Reset Release Voltage Level 0 ) 
    \ %1: SVSHRVL_1      ( SVS high side Reset Release Voltage Level 1 ) 
    \ %11: SVSHRVL_2      ( SVS high side Reset Release Voltage Level 2 ) 
    \ %111: SVSHRVL_3      ( SVS high side Reset Release Voltage Level 3 )  SVSMHCTL bis! 
( SVSMHCTL-SVSHE-set ) %1  10 lshift SVSMHCTL bis! 
( SVSMHCTL-SVSHFP-set ) %1  11 lshift SVSMHCTL bis! 
( SVSMHCTL-SVMHOVPE-set ) %1  12 lshift SVSMHCTL bis! 
( SVSMHCTL-SVMHE-set ) %1  14 lshift SVSMHCTL bis! 
( SVSMHCTL-SVMHFP-set ) %1  15 lshift SVSMHCTL bis! 
 
\ SVSMLCTL ( SVS and SVM low side control register ) 
( SVSMLCTL-SVSMLRRL-set ) %xxx  0 lshift
    \ %0: SVSMLRRL_0      ( SVS and SVM low side Reset Release Voltage Level 0 ) 
    \ %1: SVSMLRRL_1      ( SVS and SVM low side Reset Release Voltage Level 1 ) 
    \ %11: SVSMLRRL_2      ( SVS and SVM low side Reset Release Voltage Level 2 ) 
    \ %111: SVSMLRRL_3      ( SVS and SVM low side Reset Release Voltage Level 3 ) 
    \ %1111: SVSMLRRL_4      ( SVS and SVM low side Reset Release Voltage Level 4 ) 
    \ %11111: SVSMLRRL_5      ( SVS and SVM low side Reset Release Voltage Level 5 ) 
    \ %111111: SVSMLRRL_6      ( SVS and SVM low side Reset Release Voltage Level 6 ) 
    \ %1111111: SVSMLRRL_7      ( SVS and SVM low side Reset Release Voltage Level 7 )  SVSMLCTL bis! 
( SVSMLCTL-SVSMLDLYST-set ) %1  3 lshift SVSMLCTL bis! 
( SVSMLCTL-SVSLMD-set ) %1  4 lshift SVSMLCTL bis! 
( SVSMLCTL-SVSMLEVM-set ) %1  6 lshift SVSMLCTL bis! 
( SVSMLCTL-SVSMLACE-set ) %1  7 lshift SVSMLCTL bis! 
( SVSMLCTL-SVSLRVL-set ) %xx  8 lshift
    \ %0: SVSLRVL_0      ( SVS low side Reset Release Voltage Level 0 ) 
    \ %1: SVSLRVL_1      ( SVS low side Reset Release Voltage Level 1 ) 
    \ %11: SVSLRVL_2      ( SVS low side Reset Release Voltage Level 2 ) 
    \ %111: SVSLRVL_3      ( SVS low side Reset Release Voltage Level 3 )  SVSMLCTL bis! 
( SVSMLCTL-SVSLE-set ) %1  10 lshift SVSMLCTL bis! 
( SVSMLCTL-SVSLFP-set ) %1  11 lshift SVSMLCTL bis! 
( SVSMLCTL-SVMLOVPE-set ) %1  12 lshift SVSMLCTL bis! 
( SVSMLCTL-SVMLE-set ) %1  14 lshift SVSMLCTL bis! 
( SVSMLCTL-SVMLFP-set ) %1  15 lshift SVSMLCTL bis! 
 
\ SVSMIO ( SVSIN and SVSOUT control register ) 
( SVSMIO-SVMLOE-set ) %1  3 lshift SVSMIO bis! 
( SVSMIO-SVMLVLROE-set ) %1  4 lshift SVSMIO bis! 
( SVSMIO-SVMOUTPOL-set ) %1  5 lshift SVSMIO bis! 
( SVSMIO-SVMHOE-set ) %1  11 lshift SVSMIO bis! 
( SVSMIO-SVMHVLROE-set ) %1  12 lshift SVSMIO bis! 
 
\ PMMIFG ( PMM Interrupt Flag ) 
( PMMIFG-SVSMLDLYIFG-set ) %1  0 lshift PMMIFG bis! 
( PMMIFG-SVMLIFG-set ) %1  1 lshift PMMIFG bis! 
( PMMIFG-SVMLVLRIFG-set ) %1  2 lshift PMMIFG bis! 
( PMMIFG-SVSMHDLYIFG-set ) %1  4 lshift PMMIFG bis! 
( PMMIFG-SVMHIFG-set ) %1  5 lshift PMMIFG bis! 
( PMMIFG-SVMHVLRIFG-set ) %1  6 lshift PMMIFG bis! 
( PMMIFG-PMMBORIFG-set ) %1  8 lshift PMMIFG bis! 
( PMMIFG-PMMRSTIFG-set ) %1  9 lshift PMMIFG bis! 
( PMMIFG-PMMPORIFG-set ) %1  10 lshift PMMIFG bis! 
( PMMIFG-SVSHIFG-set ) %1  12 lshift PMMIFG bis! 
( PMMIFG-SVSLIFG-set ) %1  13 lshift PMMIFG bis! 
( PMMIFG-PMMLPM5IFG-set ) %1  15 lshift PMMIFG bis! 
 
\ PMMRIE ( PMM and RESET Interrupt Enable ) 
( PMMRIE-SVSMLDLYIE-set ) %1  0 lshift PMMRIE bis! 
( PMMRIE-SVMLIE-set ) %1  1 lshift PMMRIE bis! 
( PMMRIE-SVMLVLRIE-set ) %1  2 lshift PMMRIE bis! 
( PMMRIE-SVSMHDLYIE-set ) %1  4 lshift PMMRIE bis! 
( PMMRIE-SVMHIE-set ) %1  5 lshift PMMRIE bis! 
( PMMRIE-SVMHVLRIE-set ) %1  6 lshift PMMRIE bis! 
( PMMRIE-SVSLPE-set ) %1  8 lshift PMMRIE bis! 
( PMMRIE-SVMLVLRPE-set ) %1  9 lshift PMMRIE bis! 
( PMMRIE-SVSHPE-set ) %1  12 lshift PMMRIE bis! 
( PMMRIE-SVMHVLRPE-set ) %1  13 lshift PMMRIE bis! 
 
\ PM5CTL0 ( PMM Power Mode 5 Control Register 0 ) 
( PM5CTL0-LOCKLPM5-set ) %1  0 lshift PM5CTL0 bis! 


                     
\ ===================================FLASH =================================== 
\ FCTL1 ( FLASH Control 1 ) 
( FCTL1-ERASE-set ) %1  1 lshift FCTL1 bis! 
( FCTL1-MERAS-set ) %1  2 lshift FCTL1 bis! 
( FCTL1-SWRT-set ) %1  5 lshift FCTL1 bis! 
( FCTL1-WRT-set ) %1  6 lshift FCTL1 bis! 
( FCTL1-BLKWRT-set ) %1  7 lshift FCTL1 bis! 
 
\ FCTL3 ( FLASH Control 3 ) 
( FCTL3-BUSY-set ) %1  0 lshift FCTL3 bis! 
( FCTL3-KEYV-set ) %1  1 lshift FCTL3 bis! 
( FCTL3-ACCVIFG-set ) %1  2 lshift FCTL3 bis! 
( FCTL3-WAIT-set ) %1  3 lshift FCTL3 bis! 
( FCTL3-LOCK-set ) %1  4 lshift FCTL3 bis! 
( FCTL3-EMEX-set ) %1  5 lshift FCTL3 bis! 
( FCTL3-LOCKA-set ) %1  6 lshift FCTL3 bis! 
 
\ FCTL4 ( FLASH Control 4 ) 
( FCTL4-VPE-set ) %1  0 lshift FCTL4 bis! 
( FCTL4-MGR0-set ) %1  4 lshift FCTL4 bis! 
( FCTL4-MGR1-set ) %1  5 lshift FCTL4 bis! 
( FCTL4-LOCKINFO-set ) %1  7 lshift FCTL4 bis! 


                     
\ ===================================CRC16 =================================== 
\ CRCDI ( CRC Data In Register ) 
 
\ CRCDIRB ( CRC data in reverse byte Register ) 
 
\ CRCINIRES ( CRC Initialisation Register and Result Register ) 
 
\ CRCRESR ( CRC reverse result Register ) 


                     
\ ===================================RC =================================== 
\ RCCTL0 ( Ram Controller Control Register ) 
( RCCTL0-RCRS0OFF-set ) %1  0 lshift RCCTL0 bis! 
( RCCTL0-RCRS1OFF-set ) %1  1 lshift RCCTL0 bis! 
( RCCTL0-RCRS2OFF-set ) %1  2 lshift RCCTL0 bis! 
( RCCTL0-RCRS3OFF-set ) %1  3 lshift RCCTL0 bis! 
( RCCTL0-RCRS7OFF-set ) %1  7 lshift RCCTL0 bis! 


                     
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


                     
\ ===================================UCS =================================== 
\ UCSCTL0 ( UCS Control Register 0 ) 
( UCSCTL0-MOD0-set ) %1  3 lshift UCSCTL0 bis! 
( UCSCTL0-MOD1-set ) %1  4 lshift UCSCTL0 bis! 
( UCSCTL0-MOD2-set ) %1  5 lshift UCSCTL0 bis! 
( UCSCTL0-MOD3-set ) %1  6 lshift UCSCTL0 bis! 
( UCSCTL0-MOD4-set ) %1  7 lshift UCSCTL0 bis! 
( UCSCTL0-DCO0-set ) %1  8 lshift UCSCTL0 bis! 
( UCSCTL0-DCO1-set ) %1  9 lshift UCSCTL0 bis! 
( UCSCTL0-DCO2-set ) %1  10 lshift UCSCTL0 bis! 
( UCSCTL0-DCO3-set ) %1  11 lshift UCSCTL0 bis! 
( UCSCTL0-DCO4-set ) %1  12 lshift UCSCTL0 bis! 
 
\ UCSCTL1 ( UCS Control Register 1 ) 
( UCSCTL1-DISMOD-set ) %1  0 lshift UCSCTL1 bis! 
( UCSCTL1-DCORSEL-set ) %xxx  4 lshift
    \ %0: DCORSEL_0      ( DCO RSEL 0 ) 
    \ %1: DCORSEL_1      ( DCO RSEL 1 ) 
    \ %11: DCORSEL_2      ( DCO RSEL 2 ) 
    \ %111: DCORSEL_3      ( DCO RSEL 3 ) 
    \ %1111: DCORSEL_4      ( DCO RSEL 4 ) 
    \ %11111: DCORSEL_5      ( DCO RSEL 5 ) 
    \ %111111: DCORSEL_6      ( DCO RSEL 6 ) 
    \ %1111111: DCORSEL_7      ( DCO RSEL 7 )  UCSCTL1 bis! 
 
\ UCSCTL2 ( UCS Control Register 2 ) 
( UCSCTL2-FLLN0-set ) %1  0 lshift UCSCTL2 bis! 
( UCSCTL2-FLLN1-set ) %1  1 lshift UCSCTL2 bis! 
( UCSCTL2-FLLN2-set ) %1  2 lshift UCSCTL2 bis! 
( UCSCTL2-FLLN3-set ) %1  3 lshift UCSCTL2 bis! 
( UCSCTL2-FLLN4-set ) %1  4 lshift UCSCTL2 bis! 
( UCSCTL2-FLLN5-set ) %1  5 lshift UCSCTL2 bis! 
( UCSCTL2-FLLN6-set ) %1  6 lshift UCSCTL2 bis! 
( UCSCTL2-FLLN7-set ) %1  7 lshift UCSCTL2 bis! 
( UCSCTL2-FLLN8-set ) %1  8 lshift UCSCTL2 bis! 
( UCSCTL2-FLLN9-set ) %1  9 lshift UCSCTL2 bis! 
( UCSCTL2-FLLD-set ) %xxx  12 lshift
    \ %0: FLLD_0      ( Multiply Selected Loop Freq. 1 ) 
    \ %1: FLLD_1      ( Multiply Selected Loop Freq. 2 ) 
    \ %11: FLLD_2      ( Multiply Selected Loop Freq. 4 ) 
    \ %111: FLLD_3      ( Multiply Selected Loop Freq. 8 ) 
    \ %1111: FLLD_4      ( Multiply Selected Loop Freq. 16 ) 
    \ %11111: FLLD_5      ( Multiply Selected Loop Freq. 32 ) 
    \ %111111: FLLD_6      ( Multiply Selected Loop Freq. 32 ) 
    \ %1111111: FLLD_7      ( Multiply Selected Loop Freq. 32 )  UCSCTL2 bis! 
 
\ UCSCTL3 ( UCS Control Register 3 ) 
( UCSCTL3-FLLREFDIV-set ) %xxx  0 lshift
    \ %0: FLLREFDIV_0      ( Reference Divider: f(LFCLK)/1 ) 
    \ %1: FLLREFDIV_1      ( Reference Divider: f(LFCLK)/2 ) 
    \ %11: FLLREFDIV_2      ( Reference Divider: f(LFCLK)/4 ) 
    \ %111: FLLREFDIV_3      ( Reference Divider: f(LFCLK)/8 ) 
    \ %1111: FLLREFDIV_4      ( Reference Divider: f(LFCLK)/12 ) 
    \ %11111: FLLREFDIV_5      ( Reference Divider: f(LFCLK)/16 ) 
    \ %111111: FLLREFDIV_6      ( Reference Divider: f(LFCLK)/16 ) 
    \ %1111111: FLLREFDIV_7      ( Reference Divider: f(LFCLK)/16 )  UCSCTL3 bis! 
( UCSCTL3-SELREF-set ) %xxx  4 lshift
    \ %0: SELREF_0      ( FLL Reference Clock Select 0 ) 
    \ %1: SELREF_1      ( FLL Reference Clock Select 1 ) 
    \ %11: SELREF_2      ( FLL Reference Clock Select 2 ) 
    \ %111: SELREF_3      ( FLL Reference Clock Select 3 ) 
    \ %1111: SELREF_4      ( FLL Reference Clock Select 4 ) 
    \ %11111: SELREF_5      ( FLL Reference Clock Select 5 ) 
    \ %111111: SELREF_6      ( FLL Reference Clock Select 6 ) 
    \ %1111111: SELREF_7      ( FLL Reference Clock Select 7 )  UCSCTL3 bis! 
 
\ UCSCTL4 ( UCS Control Register 4 ) 
( UCSCTL4-SELM-set ) %xxx  0 lshift
    \ %0: SELM_0      ( MCLK Source Select 0 ) 
    \ %1: SELM_1      ( MCLK Source Select 1 ) 
    \ %11: SELM_2      ( MCLK Source Select 2 ) 
    \ %111: SELM_3      ( MCLK Source Select 3 ) 
    \ %1111: SELM_4      ( MCLK Source Select 4 ) 
    \ %11111: SELM_5      ( MCLK Source Select 5 ) 
    \ %111111: SELM_6      ( MCLK Source Select 6 ) 
    \ %1111111: SELM_7      ( MCLK Source Select 7 )  UCSCTL4 bis! 
( UCSCTL4-SELS-set ) %xxx  4 lshift
    \ %0: SELS_0      ( SMCLK Source Select 0 ) 
    \ %1: SELS_1      ( SMCLK Source Select 1 ) 
    \ %11: SELS_2      ( SMCLK Source Select 2 ) 
    \ %111: SELS_3      ( SMCLK Source Select 3 ) 
    \ %1111: SELS_4      ( SMCLK Source Select 4 ) 
    \ %11111: SELS_5      ( SMCLK Source Select 5 ) 
    \ %111111: SELS_6      ( SMCLK Source Select 6 ) 
    \ %1111111: SELS_7      ( SMCLK Source Select 7 )  UCSCTL4 bis! 
( UCSCTL4-SELA-set ) %xxx  8 lshift
    \ %0: SELA_0      ( ACLK Source Select 0 ) 
    \ %1: SELA_1      ( ACLK Source Select 1 ) 
    \ %11: SELA_2      ( ACLK Source Select 2 ) 
    \ %111: SELA_3      ( ACLK Source Select 3 ) 
    \ %1111: SELA_4      ( ACLK Source Select 4 ) 
    \ %11111: SELA_5      ( ACLK Source Select 5 ) 
    \ %111111: SELA_6      ( ACLK Source Select 6 ) 
    \ %1111111: SELA_7      ( ACLK Source Select 7 )  UCSCTL4 bis! 
 
\ UCSCTL5 ( UCS Control Register 5 ) 
( UCSCTL5-DIVM-set ) %xxx  0 lshift
    \ %0: DIVM_0      ( MCLK Source Divider 0 ) 
    \ %1: DIVM_1      ( MCLK Source Divider 1 ) 
    \ %11: DIVM_2      ( MCLK Source Divider 2 ) 
    \ %111: DIVM_3      ( MCLK Source Divider 3 ) 
    \ %1111: DIVM_4      ( MCLK Source Divider 4 ) 
    \ %11111: DIVM_5      ( MCLK Source Divider 5 ) 
    \ %111111: DIVM_6      ( MCLK Source Divider 6 ) 
    \ %1111111: DIVM_7      ( MCLK Source Divider 7 )  UCSCTL5 bis! 
( UCSCTL5-DIVS-set ) %xxx  4 lshift
    \ %0: DIVS_0      ( SMCLK Source Divider 0 ) 
    \ %1: DIVS_1      ( SMCLK Source Divider 1 ) 
    \ %11: DIVS_2      ( SMCLK Source Divider 2 ) 
    \ %111: DIVS_3      ( SMCLK Source Divider 3 ) 
    \ %1111: DIVS_4      ( SMCLK Source Divider 4 ) 
    \ %11111: DIVS_5      ( SMCLK Source Divider 5 ) 
    \ %111111: DIVS_6      ( SMCLK Source Divider 6 ) 
    \ %1111111: DIVS_7      ( SMCLK Source Divider 7 )  UCSCTL5 bis! 
( UCSCTL5-DIVA-set ) %xxx  8 lshift
    \ %0: DIVA_0      ( ACLK Source Divider 0 ) 
    \ %1: DIVA_1      ( ACLK Source Divider 1 ) 
    \ %11: DIVA_2      ( ACLK Source Divider 2 ) 
    \ %111: DIVA_3      ( ACLK Source Divider 3 ) 
    \ %1111: DIVA_4      ( ACLK Source Divider 4 ) 
    \ %11111: DIVA_5      ( ACLK Source Divider 5 ) 
    \ %111111: DIVA_6      ( ACLK Source Divider 6 ) 
    \ %1111111: DIVA_7      ( ACLK Source Divider 7 )  UCSCTL5 bis! 
( UCSCTL5-DIVPA-set ) %xxx  12 lshift
    \ %0: DIVPA_0      ( ACLK from Pin Source Divider 0 ) 
    \ %1: DIVPA_1      ( ACLK from Pin Source Divider 1 ) 
    \ %11: DIVPA_2      ( ACLK from Pin Source Divider 2 ) 
    \ %111: DIVPA_3      ( ACLK from Pin Source Divider 3 ) 
    \ %1111: DIVPA_4      ( ACLK from Pin Source Divider 4 ) 
    \ %11111: DIVPA_5      ( ACLK from Pin Source Divider 5 ) 
    \ %111111: DIVPA_6      ( ACLK from Pin Source Divider 6 ) 
    \ %1111111: DIVPA_7      ( ACLK from Pin Source Divider 7 )  UCSCTL5 bis! 
 
\ UCSCTL6 ( UCS Control Register 6 ) 
( UCSCTL6-XT1OFF-set ) %1  0 lshift UCSCTL6 bis! 
( UCSCTL6-SMCLKOFF-set ) %1  1 lshift UCSCTL6 bis! 
( UCSCTL6-XCAP-set ) %xx  2 lshift
    \ %0: XCAP_0      ( XIN/XOUT Cap 0 ) 
    \ %1: XCAP_1      ( XIN/XOUT Cap 1 ) 
    \ %11: XCAP_2      ( XIN/XOUT Cap 2 ) 
    \ %111: XCAP_3      ( XIN/XOUT Cap 3 )  UCSCTL6 bis! 
( UCSCTL6-XT1BYPASS-set ) %1  4 lshift UCSCTL6 bis! 
( UCSCTL6-XTS-set ) %1  5 lshift UCSCTL6 bis! 
( UCSCTL6-XT1DRIVE-set ) %xx  6 lshift
    \ %0: XT1DRIVE_0      ( XT1 Drive Level mode: 0 ) 
    \ %1: XT1DRIVE_1      ( XT1 Drive Level mode: 1 ) 
    \ %11: XT1DRIVE_2      ( XT1 Drive Level mode: 2 ) 
    \ %111: XT1DRIVE_3      ( XT1 Drive Level mode: 3 )  UCSCTL6 bis! 
( UCSCTL6-XT2OFF-set ) %1  8 lshift UCSCTL6 bis! 
( UCSCTL6-XT2BYPASS-set ) %1  12 lshift UCSCTL6 bis! 
( UCSCTL6-XT2DRIVE-set ) %xx  14 lshift
    \ %0: XT2DRIVE_0      ( XT2 Drive Level mode: 0 ) 
    \ %1: XT2DRIVE_1      ( XT2 Drive Level mode: 1 ) 
    \ %11: XT2DRIVE_2      ( XT2 Drive Level mode: 2 ) 
    \ %111: XT2DRIVE_3      ( XT2 Drive Level mode: 3 )  UCSCTL6 bis! 
 
\ UCSCTL7 ( UCS Control Register 7 ) 
( UCSCTL7-DCOFFG-set ) %1  0 lshift UCSCTL7 bis! 
( UCSCTL7-XT1LFOFFG-set ) %1  1 lshift UCSCTL7 bis! 
( UCSCTL7-XT2OFFG-set ) %1  3 lshift UCSCTL7 bis! 
 
\ UCSCTL8 ( UCS Control Register 8 ) 
( UCSCTL8-ACLKREQEN-set ) %1  0 lshift UCSCTL8 bis! 
( UCSCTL8-MCLKREQEN-set ) %1  1 lshift UCSCTL8 bis! 
( UCSCTL8-SMCLKREQEN-set ) %1  2 lshift UCSCTL8 bis! 
( UCSCTL8-MODOSCREQEN-set ) %1  3 lshift UCSCTL8 bis! 


                     
\ ===================================SYS =================================== 
\ SYSCTL ( System control ) 
( SYSCTL-SYSRIVECT-set ) %1  0 lshift SYSCTL bis! 
( SYSCTL-SYSPMMPE-set ) %1  2 lshift SYSCTL bis! 
( SYSCTL-SYSBSLIND-set ) %1  4 lshift SYSCTL bis! 
( SYSCTL-SYSJTAGPIN-set ) %1  5 lshift SYSCTL bis! 
 
\ SYSBSLC ( Boot strap configuration area ) 
( SYSBSLC-SYSBSLSIZE0-set ) %1  0 lshift SYSBSLC bis! 
( SYSBSLC-SYSBSLSIZE1-set ) %1  1 lshift SYSBSLC bis! 
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


                     
\ ===================================SHARED_REFERENCE =================================== 
\ REFCTL0 ( REF Shared Reference control register 0 ) 
( REFCTL0-REFON-set ) %1  0 lshift REFCTL0 bis! 
( REFCTL0-REFOUT-set ) %1  1 lshift REFCTL0 bis! 
( REFCTL0-REFTCOFF-set ) %1  3 lshift REFCTL0 bis! 
( REFCTL0-REFVSEL-set ) %xx  4 lshift
    \ %0: REFVSEL_0      ( REF Reference Voltage Level Select 1.5V ) 
    \ %1: REFVSEL_1      ( REF Reference Voltage Level Select 2.0V ) 
    \ %11: REFVSEL_2      ( REF Reference Voltage Level Select 2.5V ) 
    \ %111: REFVSEL_3      ( REF Reference Voltage Level Select 2.5V )  REFCTL0 bis! 
( REFCTL0-REFMSTR-set ) %1  7 lshift REFCTL0 bis! 
( REFCTL0-REFGENACT-set ) %1  8 lshift REFCTL0 bis! 
( REFCTL0-REFBGACT-set ) %1  9 lshift REFCTL0 bis! 
( REFCTL0-REFGENBUSY-set ) %1  10 lshift REFCTL0 bis! 
( REFCTL0-BGMODE-set ) %1  11 lshift REFCTL0 bis! 


                     
\ ===================================PORT_MAPPING_CONTROL =================================== 
\ PMAPKEYID ( Port Mapping Key register ) 
 
\ PMAPCTL ( Port Mapping control register ) 
( PMAPCTL-PMAPLOCKED-set ) %1  0 lshift PMAPCTL bis! 
( PMAPCTL-PMAPRECFG-set ) %1  1 lshift PMAPCTL bis! 


                     
\ ===================================PORT_J =================================== 
\ PJIN ( Port J Input ) 
( PJIN-PJIN0-set ) %1  0 lshift PJIN bis! 
( PJIN-PJIN1-set ) %1  1 lshift PJIN bis! 
( PJIN-PJIN2-set ) %1  2 lshift PJIN bis! 
( PJIN-PJIN3-set ) %1  3 lshift PJIN bis! 
 
\ PJOUT ( Port J Output ) 
( PJOUT-PJOUT0-set ) %1  0 lshift PJOUT bis! 
( PJOUT-PJOUT1-set ) %1  1 lshift PJOUT bis! 
( PJOUT-PJOUT2-set ) %1  2 lshift PJOUT bis! 
( PJOUT-PJOUT3-set ) %1  3 lshift PJOUT bis! 
 
\ PJDIR ( Port J Direction ) 
( PJDIR-PJDIR0-set ) %1  0 lshift PJDIR bis! 
( PJDIR-PJDIR1-set ) %1  1 lshift PJDIR bis! 
( PJDIR-PJDIR2-set ) %1  2 lshift PJDIR bis! 
( PJDIR-PJDIR3-set ) %1  3 lshift PJDIR bis! 
 
\ PJREN ( Port J Resistor Enable ) 
( PJREN-PJREN0-set ) %1  0 lshift PJREN bis! 
( PJREN-PJREN1-set ) %1  1 lshift PJREN bis! 
( PJREN-PJREN2-set ) %1  2 lshift PJREN bis! 
( PJREN-PJREN3-set ) %1  3 lshift PJREN bis! 
 
\ PJDS ( Port J Drive Strenght ) 
( PJDS-PJDS0-set ) %1  0 lshift PJDS bis! 
( PJDS-PJDS1-set ) %1  1 lshift PJDS bis! 
( PJDS-PJDS2-set ) %1  2 lshift PJDS bis! 
( PJDS-PJDS3-set ) %1  3 lshift PJDS bis! 


                     
\ ===================================TIMER_0_A5 =================================== 
\ TA0CTL ( Timer0_A5 Control ) 
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
 
\ TA0CCTL0 ( Timer0_A5 Capture/Compare Control 0 ) 
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
 
\ TA0CCTL1 ( Timer0_A5 Capture/Compare Control 1 ) 
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
 
\ TA0CCTL2 ( Timer0_A5 Capture/Compare Control 2 ) 
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
 
\ TA0CCTL3 ( Timer0_A5 Capture/Compare Control 3 ) 
( TA0CCTL3-CCIFG-set ) %1  0 lshift TA0CCTL3 bis! 
( TA0CCTL3-COV-set ) %1  1 lshift TA0CCTL3 bis! 
( TA0CCTL3-OUT-set ) %1  2 lshift TA0CCTL3 bis! 
( TA0CCTL3-CCI-set ) %1  3 lshift TA0CCTL3 bis! 
( TA0CCTL3-CCIE-set ) %1  4 lshift TA0CCTL3 bis! 
( TA0CCTL3-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA0CCTL3 bis! 
( TA0CCTL3-CAP-set ) %1  8 lshift TA0CCTL3 bis! 
( TA0CCTL3-SCCI-set ) %1  10 lshift TA0CCTL3 bis! 
( TA0CCTL3-SCS-set ) %1  11 lshift TA0CCTL3 bis! 
( TA0CCTL3-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA0CCTL3 bis! 
( TA0CCTL3-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA0CCTL3 bis! 
 
\ TA0CCTL4 ( Timer0_A5 Capture/Compare Control 4 ) 
( TA0CCTL4-CCIFG-set ) %1  0 lshift TA0CCTL4 bis! 
( TA0CCTL4-COV-set ) %1  1 lshift TA0CCTL4 bis! 
( TA0CCTL4-OUT-set ) %1  2 lshift TA0CCTL4 bis! 
( TA0CCTL4-CCI-set ) %1  3 lshift TA0CCTL4 bis! 
( TA0CCTL4-CCIE-set ) %1  4 lshift TA0CCTL4 bis! 
( TA0CCTL4-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA0CCTL4 bis! 
( TA0CCTL4-CAP-set ) %1  8 lshift TA0CCTL4 bis! 
( TA0CCTL4-SCCI-set ) %1  10 lshift TA0CCTL4 bis! 
( TA0CCTL4-SCS-set ) %1  11 lshift TA0CCTL4 bis! 
( TA0CCTL4-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA0CCTL4 bis! 
( TA0CCTL4-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA0CCTL4 bis! 
 
\ TA0R ( Timer0_A5 ) 
 
\ TA0CCR0 ( Timer0_A5 Capture/Compare 0 ) 
 
\ TA0CCR1 ( Timer0_A5 Capture/Compare 1 ) 
 
\ TA0CCR2 ( Timer0_A5 Capture/Compare 2 ) 
 
\ TA0CCR3 ( Timer0_A5 Capture/Compare 3 ) 
 
\ TA0CCR4 ( Timer0_A5 Capture/Compare 4 ) 
 
\ TA0EX0 ( Timer0_A5 Expansion Register 0 ) 
( TA0EX0-TAIDEX-set ) %xxx  0 lshift
    \ %0: TAIDEX_0      ( Timer A Input divider expansion : /1 ) 
    \ %1: TAIDEX_1      ( Timer A Input divider expansion : /2 ) 
    \ %11: TAIDEX_2      ( Timer A Input divider expansion : /3 ) 
    \ %111: TAIDEX_3      ( Timer A Input divider expansion : /4 ) 
    \ %1111: TAIDEX_4      ( Timer A Input divider expansion : /5 ) 
    \ %11111: TAIDEX_5      ( Timer A Input divider expansion : /6 ) 
    \ %111111: TAIDEX_6      ( Timer A Input divider expansion : /7 ) 
    \ %1111111: TAIDEX_7      ( Timer A Input divider expansion : /8 )  TA0EX0 bis! 
 
\ TA0IV ( Timer0_A5 Interrupt Vector Word ) 


                     
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


                     
\ ===================================TIMER_0_B7 =================================== 
\ TB0CTL ( Timer0_B7 Control ) 
( TB0CTL-TBIFG-set ) %1  0 lshift TB0CTL bis! 
( TB0CTL-TBIE-set ) %1  1 lshift TB0CTL bis! 
( TB0CTL-TBCLR-set ) %1  2 lshift TB0CTL bis! 
( TB0CTL-MC-set ) %xx  4 lshift
    \ %0: MC_0      ( Timer A mode control: 0 - Stop ) 
    \ %1: MC_1      ( Timer A mode control: 1 - Up to CCR0 ) 
    \ %11: MC_2      ( Timer A mode control: 2 - Continuous up ) 
    \ %111: MC_3      ( Timer A mode control: 3 - Up/Down )  TB0CTL bis! 
( TB0CTL-ID-set ) %xx  6 lshift
    \ %0: ID_0      ( Timer A input divider: 0 - /1 ) 
    \ %1: ID_1      ( Timer A input divider: 1 - /2 ) 
    \ %11: ID_2      ( Timer A input divider: 2 - /4 ) 
    \ %111: ID_3      ( Timer A input divider: 3 - /8 )  TB0CTL bis! 
( TB0CTL-TBSSEL-set ) %xx  8 lshift
    \ %0: TBSSEL_0      ( Clock Source: TBCLK ) 
    \ %1: TBSSEL_1      ( Clock Source: ACLK ) 
    \ %11: TBSSEL_2      ( Clock Source: SMCLK ) 
    \ %111: TBSSEL_3      ( Clock Source: INCLK )  TB0CTL bis! 
( TB0CTL-CNTL-set ) %xx  11 lshift
    \ %0: CNTL_0      ( Counter lenght: 16 bit ) 
    \ %1: CNTL_1      ( Counter lenght: 12 bit ) 
    \ %11: CNTL_2      ( Counter lenght: 10 bit ) 
    \ %111: CNTL_3      ( Counter lenght:  8 bit )  TB0CTL bis! 
( TB0CTL-TBCLGRP-set ) %xx  13 lshift
    \ %0: TBCLGRP_0      ( Timer0_B7 Group: 0 - individually ) 
    \ %1: TBCLGRP_1      ( Timer0_B7 Group: 1 - 3 groups (1-2 ) 
    \ %11: TBCLGRP_2      ( Timer0_B7 Group: 2 - 2 groups (1-3 ) 
    \ %111: TBCLGRP_3      ( Timer0_B7 Group: 3 - 1 group (all) )  TB0CTL bis! 
 
\ TB0CCTL0 ( Timer0_B7 Capture/Compare Control 0 ) 
( TB0CCTL0-CCIFG-set ) %1  0 lshift TB0CCTL0 bis! 
( TB0CCTL0-COV-set ) %1  1 lshift TB0CCTL0 bis! 
( TB0CCTL0-OUT-set ) %1  2 lshift TB0CCTL0 bis! 
( TB0CCTL0-CCI-set ) %1  3 lshift TB0CCTL0 bis! 
( TB0CCTL0-CCIE-set ) %1  4 lshift TB0CCTL0 bis! 
( TB0CCTL0-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TB0CCTL0 bis! 
( TB0CCTL0-CAP-set ) %1  8 lshift TB0CCTL0 bis! 
( TB0CCTL0-CLLD-set ) %xx  9 lshift
    \ %0: CLLD_0      ( Compare latch load sourec : 0 - immediate ) 
    \ %1: CLLD_1      ( Compare latch load sourec : 1 - TBR counts to 0 ) 
    \ %11: CLLD_2      ( Compare latch load sourec : 2 - up/down ) 
    \ %111: CLLD_3      ( Compare latch load sourec : 3 - TBR counts to TBCTL0 )  TB0CCTL0 bis! 
( TB0CCTL0-SCS-set ) %1  11 lshift TB0CCTL0 bis! 
( TB0CCTL0-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TB0CCTL0 bis! 
( TB0CCTL0-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TB0CCTL0 bis! 
 
\ TB0CCTL1 ( Timer0_B7 Capture/Compare Control 1 ) 
( TB0CCTL1-CCIFG-set ) %1  0 lshift TB0CCTL1 bis! 
( TB0CCTL1-COV-set ) %1  1 lshift TB0CCTL1 bis! 
( TB0CCTL1-OUT-set ) %1  2 lshift TB0CCTL1 bis! 
( TB0CCTL1-CCI-set ) %1  3 lshift TB0CCTL1 bis! 
( TB0CCTL1-CCIE-set ) %1  4 lshift TB0CCTL1 bis! 
( TB0CCTL1-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TB0CCTL1 bis! 
( TB0CCTL1-CAP-set ) %1  8 lshift TB0CCTL1 bis! 
( TB0CCTL1-CLLD-set ) %xx  9 lshift
    \ %0: CLLD_0      ( Compare latch load sourec : 0 - immediate ) 
    \ %1: CLLD_1      ( Compare latch load sourec : 1 - TBR counts to 0 ) 
    \ %11: CLLD_2      ( Compare latch load sourec : 2 - up/down ) 
    \ %111: CLLD_3      ( Compare latch load sourec : 3 - TBR counts to TBCTL0 )  TB0CCTL1 bis! 
( TB0CCTL1-SCS-set ) %1  11 lshift TB0CCTL1 bis! 
( TB0CCTL1-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TB0CCTL1 bis! 
( TB0CCTL1-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TB0CCTL1 bis! 
 
\ TB0CCTL2 ( Timer0_B7 Capture/Compare Control 2 ) 
( TB0CCTL2-CCIFG-set ) %1  0 lshift TB0CCTL2 bis! 
( TB0CCTL2-COV-set ) %1  1 lshift TB0CCTL2 bis! 
( TB0CCTL2-OUT-set ) %1  2 lshift TB0CCTL2 bis! 
( TB0CCTL2-CCI-set ) %1  3 lshift TB0CCTL2 bis! 
( TB0CCTL2-CCIE-set ) %1  4 lshift TB0CCTL2 bis! 
( TB0CCTL2-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TB0CCTL2 bis! 
( TB0CCTL2-CAP-set ) %1  8 lshift TB0CCTL2 bis! 
( TB0CCTL2-CLLD-set ) %xx  9 lshift
    \ %0: CLLD_0      ( Compare latch load sourec : 0 - immediate ) 
    \ %1: CLLD_1      ( Compare latch load sourec : 1 - TBR counts to 0 ) 
    \ %11: CLLD_2      ( Compare latch load sourec : 2 - up/down ) 
    \ %111: CLLD_3      ( Compare latch load sourec : 3 - TBR counts to TBCTL0 )  TB0CCTL2 bis! 
( TB0CCTL2-SCS-set ) %1  11 lshift TB0CCTL2 bis! 
( TB0CCTL2-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TB0CCTL2 bis! 
( TB0CCTL2-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TB0CCTL2 bis! 
 
\ TB0CCTL3 ( Timer0_B7 Capture/Compare Control 3 ) 
( TB0CCTL3-CCIFG-set ) %1  0 lshift TB0CCTL3 bis! 
( TB0CCTL3-COV-set ) %1  1 lshift TB0CCTL3 bis! 
( TB0CCTL3-OUT-set ) %1  2 lshift TB0CCTL3 bis! 
( TB0CCTL3-CCI-set ) %1  3 lshift TB0CCTL3 bis! 
( TB0CCTL3-CCIE-set ) %1  4 lshift TB0CCTL3 bis! 
( TB0CCTL3-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TB0CCTL3 bis! 
( TB0CCTL3-CAP-set ) %1  8 lshift TB0CCTL3 bis! 
( TB0CCTL3-CLLD-set ) %xx  9 lshift
    \ %0: CLLD_0      ( Compare latch load sourec : 0 - immediate ) 
    \ %1: CLLD_1      ( Compare latch load sourec : 1 - TBR counts to 0 ) 
    \ %11: CLLD_2      ( Compare latch load sourec : 2 - up/down ) 
    \ %111: CLLD_3      ( Compare latch load sourec : 3 - TBR counts to TBCTL0 )  TB0CCTL3 bis! 
( TB0CCTL3-SCS-set ) %1  11 lshift TB0CCTL3 bis! 
( TB0CCTL3-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TB0CCTL3 bis! 
( TB0CCTL3-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TB0CCTL3 bis! 
 
\ TB0CCTL4 ( Timer0_B7 Capture/Compare Control 4 ) 
( TB0CCTL4-CCIFG-set ) %1  0 lshift TB0CCTL4 bis! 
( TB0CCTL4-COV-set ) %1  1 lshift TB0CCTL4 bis! 
( TB0CCTL4-OUT-set ) %1  2 lshift TB0CCTL4 bis! 
( TB0CCTL4-CCI-set ) %1  3 lshift TB0CCTL4 bis! 
( TB0CCTL4-CCIE-set ) %1  4 lshift TB0CCTL4 bis! 
( TB0CCTL4-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TB0CCTL4 bis! 
( TB0CCTL4-CAP-set ) %1  8 lshift TB0CCTL4 bis! 
( TB0CCTL4-CLLD-set ) %xx  9 lshift
    \ %0: CLLD_0      ( Compare latch load sourec : 0 - immediate ) 
    \ %1: CLLD_1      ( Compare latch load sourec : 1 - TBR counts to 0 ) 
    \ %11: CLLD_2      ( Compare latch load sourec : 2 - up/down ) 
    \ %111: CLLD_3      ( Compare latch load sourec : 3 - TBR counts to TBCTL0 )  TB0CCTL4 bis! 
( TB0CCTL4-SCS-set ) %1  11 lshift TB0CCTL4 bis! 
( TB0CCTL4-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TB0CCTL4 bis! 
( TB0CCTL4-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TB0CCTL4 bis! 
 
\ TB0CCTL5 ( Timer0_B7 Capture/Compare Control 5 ) 
( TB0CCTL5-CCIFG-set ) %1  0 lshift TB0CCTL5 bis! 
( TB0CCTL5-COV-set ) %1  1 lshift TB0CCTL5 bis! 
( TB0CCTL5-OUT-set ) %1  2 lshift TB0CCTL5 bis! 
( TB0CCTL5-CCI-set ) %1  3 lshift TB0CCTL5 bis! 
( TB0CCTL5-CCIE-set ) %1  4 lshift TB0CCTL5 bis! 
( TB0CCTL5-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TB0CCTL5 bis! 
( TB0CCTL5-CAP-set ) %1  8 lshift TB0CCTL5 bis! 
( TB0CCTL5-CLLD-set ) %xx  9 lshift
    \ %0: CLLD_0      ( Compare latch load sourec : 0 - immediate ) 
    \ %1: CLLD_1      ( Compare latch load sourec : 1 - TBR counts to 0 ) 
    \ %11: CLLD_2      ( Compare latch load sourec : 2 - up/down ) 
    \ %111: CLLD_3      ( Compare latch load sourec : 3 - TBR counts to TBCTL0 )  TB0CCTL5 bis! 
( TB0CCTL5-SCS-set ) %1  11 lshift TB0CCTL5 bis! 
( TB0CCTL5-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TB0CCTL5 bis! 
( TB0CCTL5-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TB0CCTL5 bis! 
 
\ TB0CCTL6 ( Timer0_B7 Capture/Compare Control 6 ) 
( TB0CCTL6-CCIFG-set ) %1  0 lshift TB0CCTL6 bis! 
( TB0CCTL6-COV-set ) %1  1 lshift TB0CCTL6 bis! 
( TB0CCTL6-OUT-set ) %1  2 lshift TB0CCTL6 bis! 
( TB0CCTL6-CCI-set ) %1  3 lshift TB0CCTL6 bis! 
( TB0CCTL6-CCIE-set ) %1  4 lshift TB0CCTL6 bis! 
( TB0CCTL6-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TB0CCTL6 bis! 
( TB0CCTL6-CAP-set ) %1  8 lshift TB0CCTL6 bis! 
( TB0CCTL6-CLLD-set ) %xx  9 lshift
    \ %0: CLLD_0      ( Compare latch load sourec : 0 - immediate ) 
    \ %1: CLLD_1      ( Compare latch load sourec : 1 - TBR counts to 0 ) 
    \ %11: CLLD_2      ( Compare latch load sourec : 2 - up/down ) 
    \ %111: CLLD_3      ( Compare latch load sourec : 3 - TBR counts to TBCTL0 )  TB0CCTL6 bis! 
( TB0CCTL6-SCS-set ) %1  11 lshift TB0CCTL6 bis! 
( TB0CCTL6-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TB0CCTL6 bis! 
( TB0CCTL6-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TB0CCTL6 bis! 
 
\ TB0R ( Timer0_B7 ) 
 
\ TB0CCR0 ( Timer0_B7 Capture/Compare 0 ) 
 
\ TB0CCR1 ( Timer0_B7 Capture/Compare 1 ) 
 
\ TB0CCR2 ( Timer0_B7 Capture/Compare 2 ) 
 
\ TB0CCR3 ( Timer0_B7 Capture/Compare 3 ) 
 
\ TB0CCR4 ( Timer0_B7 Capture/Compare 4 ) 
 
\ TB0CCR5 ( Timer0_B7 Capture/Compare 5 ) 
 
\ TB0CCR6 ( Timer0_B7 Capture/Compare 6 ) 
 
\ TB0EX0 ( Timer0_B7 Expansion Register 0 ) 
( TB0EX0-TBIDEX-set ) %xxx  0 lshift
    \ %0: TBIDEX_0      ( Timer0_B7 Input divider expansion : /1 ) 
    \ %1: TBIDEX_1      ( Timer0_B7 Input divider expansion : /2 ) 
    \ %11: TBIDEX_2      ( Timer0_B7 Input divider expansion : /3 ) 
    \ %111: TBIDEX_3      ( Timer0_B7 Input divider expansion : /4 ) 
    \ %1111: TBIDEX_4      ( Timer0_B7 Input divider expansion : /5 ) 
    \ %11111: TBIDEX_5      ( Timer0_B7 Input divider expansion : /6 ) 
    \ %111111: TBIDEX_6      ( Timer0_B7 Input divider expansion : /7 ) 
    \ %1111111: TBIDEX_7      ( Timer0_B7 Input divider expansion : /8 )  TB0EX0 bis! 
 
\ TB0IV ( Timer0_B7 Interrupt Vector Word ) 


                     
\ ===================================TIMER_2_A3 =================================== 
\ TA2CTL ( Timer2_A3 Control ) 
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
 
\ TA2CCTL0 ( Timer2_A3 Capture/Compare Control 0 ) 
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
 
\ TA2CCTL1 ( Timer2_A3 Capture/Compare Control 1 ) 
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
 
\ TA2CCTL2 ( Timer2_A3 Capture/Compare Control 2 ) 
( TA2CCTL2-CCIFG-set ) %1  0 lshift TA2CCTL2 bis! 
( TA2CCTL2-COV-set ) %1  1 lshift TA2CCTL2 bis! 
( TA2CCTL2-OUT-set ) %1  2 lshift TA2CCTL2 bis! 
( TA2CCTL2-CCI-set ) %1  3 lshift TA2CCTL2 bis! 
( TA2CCTL2-CCIE-set ) %1  4 lshift TA2CCTL2 bis! 
( TA2CCTL2-OUTMOD-set ) %xxx  5 lshift
    \ %0: OUTMOD_0      ( PWM output mode: 0 - output only ) 
    \ %1: OUTMOD_1      ( PWM output mode: 1 - set ) 
    \ %11: OUTMOD_2      ( PWM output mode: 2 - PWM toggle/reset ) 
    \ %111: OUTMOD_3      ( PWM output mode: 3 - PWM set/reset ) 
    \ %1111: OUTMOD_4      ( PWM output mode: 4 - toggle ) 
    \ %11111: OUTMOD_5      ( PWM output mode: 5 - Reset ) 
    \ %111111: OUTMOD_6      ( PWM output mode: 6 - PWM toggle/set ) 
    \ %1111111: OUTMOD_7      ( PWM output mode: 7 - PWM reset/set )  TA2CCTL2 bis! 
( TA2CCTL2-CAP-set ) %1  8 lshift TA2CCTL2 bis! 
( TA2CCTL2-SCCI-set ) %1  10 lshift TA2CCTL2 bis! 
( TA2CCTL2-SCS-set ) %1  11 lshift TA2CCTL2 bis! 
( TA2CCTL2-CCIS-set ) %xx  12 lshift
    \ %0: CCIS_0      ( Capture input select: 0 - CCIxA ) 
    \ %1: CCIS_1      ( Capture input select: 1 - CCIxB ) 
    \ %11: CCIS_2      ( Capture input select: 2 - GND ) 
    \ %111: CCIS_3      ( Capture input select: 3 - Vcc )  TA2CCTL2 bis! 
( TA2CCTL2-CM-set ) %xx  14 lshift
    \ %0: CM_0      ( Capture mode: 0 - disabled ) 
    \ %1: CM_1      ( Capture mode: 1 - pos. edge ) 
    \ %11: CM_2      ( Capture mode: 1 - neg. edge ) 
    \ %111: CM_3      ( Capture mode: 1 - both edges )  TA2CCTL2 bis! 
 
\ TA2R ( Timer2_A3 ) 
 
\ TA2CCR0 ( Timer2_A3 Capture/Compare 0 ) 
 
\ TA2CCR1 ( Timer2_A3 Capture/Compare 1 ) 
 
\ TA2CCR2 ( Timer2_A3 Capture/Compare 2 ) 
 
\ TA2EX0 ( Timer2_A3 Expansion Register 0 ) 
( TA2EX0-TAIDEX-set ) %xxx  0 lshift
    \ %0: TAIDEX_0      ( Timer A Input divider expansion : /1 ) 
    \ %1: TAIDEX_1      ( Timer A Input divider expansion : /2 ) 
    \ %11: TAIDEX_2      ( Timer A Input divider expansion : /3 ) 
    \ %111: TAIDEX_3      ( Timer A Input divider expansion : /4 ) 
    \ %1111: TAIDEX_4      ( Timer A Input divider expansion : /5 ) 
    \ %11111: TAIDEX_5      ( Timer A Input divider expansion : /6 ) 
    \ %111111: TAIDEX_6      ( Timer A Input divider expansion : /7 ) 
    \ %1111111: TAIDEX_7      ( Timer A Input divider expansion : /8 )  TA2EX0 bis! 
 
\ TA2IV ( Timer2_A3 Interrupt Vector Word ) 


                     
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


                     
\ ===================================DMA =================================== 
\ DMACTL0 ( DMA Module Control 0 ) 
( DMACTL0-DMA0TSEL-set ) %xxxxx  0 lshift
    \ %0: DMA0TSEL_0      ( DMA channel 0 transfer select 0:  DMA_REQ (sw) ) 
    \ %1: DMA0TSEL_1      ( DMA channel 0 transfer select 1:  Timer0_A (TA0CCR0.IFG) ) 
    \ %11: DMA0TSEL_2      ( DMA channel 0 transfer select 2:  Timer0_A (TA0CCR2.IFG) ) 
    \ %111: DMA0TSEL_3      ( DMA channel 0 transfer select 3:  Timer1_A (TA1CCR0.IFG) ) 
    \ %1111: DMA0TSEL_4      ( DMA channel 0 transfer select 4:  Timer1_A (TA1CCR2.IFG) ) 
    \ %11111: DMA0TSEL_5      ( DMA channel 0 transfer select 5:  Timer2_A (TA2CCR0.IFG) ) 
    \ %111111: DMA0TSEL_6      ( DMA channel 0 transfer select 6:  Timer2_A (TA2CCR2.IFG) ) 
    \ %1111111: DMA0TSEL_7      ( DMA channel 0 transfer select 7:  TimerB (TB0CCR0.IFG) ) 
    \ %11111111: DMA0TSEL_8      ( DMA channel 0 transfer select 8:  TimerB (TB0CCR2.IFG) ) 
    \ %111111111: DMA0TSEL_9      ( DMA channel 0 transfer select 9:  Reserved ) 
    \ %1111111111: DMA0TSEL_10      ( DMA channel 0 transfer select 10: Reserved ) 
    \ %11111111111: DMA0TSEL_11      ( DMA channel 0 transfer select 11: Reserved ) 
    \ %111111111111: DMA0TSEL_12      ( DMA channel 0 transfer select 12: Reserved ) 
    \ %1111111111111: DMA0TSEL_13      ( DMA channel 0 transfer select 13: Reserved ) 
    \ %11111111111111: DMA0TSEL_14      ( DMA channel 0 transfer select 14: Reserved ) 
    \ %111111111111111: DMA0TSEL_15      ( DMA channel 0 transfer select 15: Reserved ) 
    \ %1111111111111111: DMA0TSEL_16      ( DMA channel 0 transfer select 16: USCIA0 receive ) 
    \ %: DMA0TSEL_17      ( DMA channel 0 transfer select 17: USCIA0 transmit ) 
    \ %: DMA0TSEL_18      ( DMA channel 0 transfer select 18: USCIB0 receive ) 
    \ %: DMA0TSEL_19      ( DMA channel 0 transfer select 19: USCIB0 transmit ) 
    \ %11111111111111111111: DMA0TSEL_20      ( DMA channel 0 transfer select 20: USCIA1 receive ) 
    \ %: DMA0TSEL_21      ( DMA channel 0 transfer select 21: USCIA1 transmit ) 
    \ %: DMA0TSEL_22      ( DMA channel 0 transfer select 22: USCIB1 receive ) 
    \ %: DMA0TSEL_23      ( DMA channel 0 transfer select 23: USCIB1 transmit ) 
    \ %111111111111111111111111: DMA0TSEL_24      ( DMA channel 0 transfer select 24: ADC12IFGx ) 
    \ %: DMA0TSEL_25      ( DMA channel 0 transfer select 25: Reserved ) 
    \ %: DMA0TSEL_26      ( DMA channel 0 transfer select 26: Reserved ) 
    \ %: DMA0TSEL_27      ( DMA channel 0 transfer select 27: USB FNRXD ) 
    \ %1111111111111111111111111111: DMA0TSEL_28      ( DMA channel 0 transfer select 28: USB ready ) 
    \ %: DMA0TSEL_29      ( DMA channel 0 transfer select 29: Multiplier ready ) 
    \ %: DMA0TSEL_30      ( DMA channel 0 transfer select 30: previous DMA channel DMA2IFG ) 
    \ %: DMA0TSEL_31      ( DMA channel 0 transfer select 31: ext. Trigger (DMAE0) )  DMACTL0 bis! 
( DMACTL0-DMA1TSEL-set ) %xxxxx  8 lshift
    \ %0: DMA1TSEL_0      ( DMA channel 1 transfer select 0:  DMA_REQ (sw) ) 
    \ %1: DMA1TSEL_1      ( DMA channel 1 transfer select 1:  Timer0_A (TA0CCR0.IFG) ) 
    \ %11: DMA1TSEL_2      ( DMA channel 1 transfer select 2:  Timer0_A (TA0CCR2.IFG) ) 
    \ %111: DMA1TSEL_3      ( DMA channel 1 transfer select 3:  Timer1_A (TA1CCR0.IFG) ) 
    \ %1111: DMA1TSEL_4      ( DMA channel 1 transfer select 4:  Timer1_A (TA1CCR2.IFG) ) 
    \ %11111: DMA1TSEL_5      ( DMA channel 1 transfer select 5:  Timer2_A (TA2CCR0.IFG) ) 
    \ %111111: DMA1TSEL_6      ( DMA channel 1 transfer select 6:  Timer2_A (TA2CCR2.IFG) ) 
    \ %1111111: DMA1TSEL_7      ( DMA channel 1 transfer select 7:  TimerB (TB0CCR0.IFG) ) 
    \ %11111111: DMA1TSEL_8      ( DMA channel 1 transfer select 8:  TimerB (TB0CCR2.IFG) ) 
    \ %111111111: DMA1TSEL_9      ( DMA channel 1 transfer select 9:  Reserved ) 
    \ %1111111111: DMA1TSEL_10      ( DMA channel 1 transfer select 10: Reserved ) 
    \ %11111111111: DMA1TSEL_11      ( DMA channel 1 transfer select 11: Reserved ) 
    \ %111111111111: DMA1TSEL_12      ( DMA channel 1 transfer select 12: Reserved ) 
    \ %1111111111111: DMA1TSEL_13      ( DMA channel 1 transfer select 13: Reserved ) 
    \ %11111111111111: DMA1TSEL_14      ( DMA channel 1 transfer select 14: Reserved ) 
    \ %111111111111111: DMA1TSEL_15      ( DMA channel 1 transfer select 15: Reserved ) 
    \ %1111111111111111: DMA1TSEL_16      ( DMA channel 1 transfer select 16: USCIA0 receive ) 
    \ %: DMA1TSEL_17      ( DMA channel 1 transfer select 17: USCIA0 transmit ) 
    \ %: DMA1TSEL_18      ( DMA channel 1 transfer select 18: USCIB0 receive ) 
    \ %: DMA1TSEL_19      ( DMA channel 1 transfer select 19: USCIB0 transmit ) 
    \ %11111111111111111111: DMA1TSEL_20      ( DMA channel 1 transfer select 20: USCIA1 receive ) 
    \ %: DMA1TSEL_21      ( DMA channel 1 transfer select 21: USCIA1 transmit ) 
    \ %: DMA1TSEL_22      ( DMA channel 1 transfer select 22: USCIB1 receive ) 
    \ %: DMA1TSEL_23      ( DMA channel 1 transfer select 23: USCIB1 transmit ) 
    \ %111111111111111111111111: DMA1TSEL_24      ( DMA channel 1 transfer select 24: ADC12IFGx ) 
    \ %: DMA1TSEL_25      ( DMA channel 1 transfer select 25: Reserved ) 
    \ %: DMA1TSEL_26      ( DMA channel 1 transfer select 26: Reserved ) 
    \ %: DMA1TSEL_27      ( DMA channel 1 transfer select 27: USB FNRXD ) 
    \ %1111111111111111111111111111: DMA1TSEL_28      ( DMA channel 1 transfer select 28: USB ready ) 
    \ %: DMA1TSEL_29      ( DMA channel 1 transfer select 29: Multiplier ready ) 
    \ %: DMA1TSEL_30      ( DMA channel 1 transfer select 30: previous DMA channel DMA0IFG ) 
    \ %: DMA1TSEL_31      ( DMA channel 1 transfer select 31: ext. Trigger (DMAE0) )  DMACTL0 bis! 
 
\ DMACTL1 ( DMA Module Control 1 ) 
( DMACTL1-DMA2TSEL-set ) %xxxxx  0 lshift
    \ %0: DMA2TSEL_0      ( DMA channel 2 transfer select 0:  DMA_REQ (sw) ) 
    \ %1: DMA2TSEL_1      ( DMA channel 2 transfer select 1:  Timer0_A (TA0CCR0.IFG) ) 
    \ %11: DMA2TSEL_2      ( DMA channel 2 transfer select 2:  Timer0_A (TA0CCR2.IFG) ) 
    \ %111: DMA2TSEL_3      ( DMA channel 2 transfer select 3:  Timer1_A (TA1CCR0.IFG) ) 
    \ %1111: DMA2TSEL_4      ( DMA channel 2 transfer select 4:  Timer1_A (TA1CCR2.IFG) ) 
    \ %11111: DMA2TSEL_5      ( DMA channel 2 transfer select 5:  Timer2_A (TA2CCR0.IFG) ) 
    \ %111111: DMA2TSEL_6      ( DMA channel 2 transfer select 6:  Timer2_A (TA2CCR2.IFG) ) 
    \ %1111111: DMA2TSEL_7      ( DMA channel 2 transfer select 7:  TimerB (TB0CCR0.IFG) ) 
    \ %11111111: DMA2TSEL_8      ( DMA channel 2 transfer select 8:  TimerB (TB0CCR2.IFG) ) 
    \ %111111111: DMA2TSEL_9      ( DMA channel 2 transfer select 9:  Reserved ) 
    \ %1111111111: DMA2TSEL_10      ( DMA channel 2 transfer select 10: Reserved ) 
    \ %11111111111: DMA2TSEL_11      ( DMA channel 2 transfer select 11: Reserved ) 
    \ %111111111111: DMA2TSEL_12      ( DMA channel 2 transfer select 12: Reserved ) 
    \ %1111111111111: DMA2TSEL_13      ( DMA channel 2 transfer select 13: Reserved ) 
    \ %11111111111111: DMA2TSEL_14      ( DMA channel 2 transfer select 14: Reserved ) 
    \ %111111111111111: DMA2TSEL_15      ( DMA channel 2 transfer select 15: Reserved ) 
    \ %1111111111111111: DMA2TSEL_16      ( DMA channel 2 transfer select 16: USCIA0 receive ) 
    \ %: DMA2TSEL_17      ( DMA channel 2 transfer select 17: USCIA0 transmit ) 
    \ %: DMA2TSEL_18      ( DMA channel 2 transfer select 18: USCIB0 receive ) 
    \ %: DMA2TSEL_19      ( DMA channel 2 transfer select 19: USCIB0 transmit ) 
    \ %11111111111111111111: DMA2TSEL_20      ( DMA channel 2 transfer select 20: USCIA1 receive ) 
    \ %: DMA2TSEL_21      ( DMA channel 2 transfer select 21: USCIA1 transmit ) 
    \ %: DMA2TSEL_22      ( DMA channel 2 transfer select 22: USCIB1 receive ) 
    \ %: DMA2TSEL_23      ( DMA channel 2 transfer select 23: USCIB1 transmit ) 
    \ %111111111111111111111111: DMA2TSEL_24      ( DMA channel 2 transfer select 24: ADC12IFGx ) 
    \ %: DMA2TSEL_25      ( DMA channel 2 transfer select 25: Reserved ) 
    \ %: DMA2TSEL_26      ( DMA channel 2 transfer select 26: Reserved ) 
    \ %: DMA2TSEL_27      ( DMA channel 2 transfer select 27: USB FNRXD ) 
    \ %1111111111111111111111111111: DMA2TSEL_28      ( DMA channel 2 transfer select 28: USB ready ) 
    \ %: DMA2TSEL_29      ( DMA channel 2 transfer select 29: Multiplier ready ) 
    \ %: DMA2TSEL_30      ( DMA channel 2 transfer select 30: previous DMA channel DMA1IFG ) 
    \ %: DMA2TSEL_31      ( DMA channel 2 transfer select 31: ext. Trigger (DMAE0) )  DMACTL1 bis! 
 
\ DMACTL2 ( DMA Module Control 2 ) 
 
\ DMACTL3 ( DMA Module Control 3 ) 
 
\ DMACTL4 ( DMA Module Control 4 ) 
( DMACTL4-ENNMI-set ) %1  0 lshift DMACTL4 bis! 
( DMACTL4-ROUNDROBIN-set ) %1  1 lshift DMACTL4 bis! 
( DMACTL4-DMARMWDIS-set ) %1  2 lshift DMACTL4 bis! 
 
\ DMAIV ( DMA Interrupt Vector Word ) 
 
\ DMA0CTL ( DMA Channel 0 Control ) 
( DMA0CTL-DMAREQ-set ) %1  0 lshift DMA0CTL bis! 
( DMA0CTL-DMAABORT-set ) %1  1 lshift DMA0CTL bis! 
( DMA0CTL-DMAIE-set ) %1  2 lshift DMA0CTL bis! 
( DMA0CTL-DMAIFG-set ) %1  3 lshift DMA0CTL bis! 
( DMA0CTL-DMAEN-set ) %1  4 lshift DMA0CTL bis! 
( DMA0CTL-DMALEVEL-set ) %1  5 lshift DMA0CTL bis! 
( DMA0CTL-DMASRCBYTE-set ) %1  6 lshift DMA0CTL bis! 
( DMA0CTL-DMADSTBYTE-set ) %1  7 lshift DMA0CTL bis! 
( DMA0CTL-DMASRCINCR-set ) %xx  8 lshift
    \ %0: DMASRCINCR_0      ( DMA source increment 0: source address unchanged ) 
    \ %1: DMASRCINCR_1      ( DMA source increment 1: source address unchanged ) 
    \ %11: DMASRCINCR_2      ( DMA source increment 2: source address decremented ) 
    \ %111: DMASRCINCR_3      ( DMA source increment 3: source address incremented )  DMA0CTL bis! 
( DMA0CTL-DMADSTINCR-set ) %xx  10 lshift
    \ %0: DMADSTINCR_0      ( DMA destination increment 0: destination address unchanged ) 
    \ %1: DMADSTINCR_1      ( DMA destination increment 1: destination address unchanged ) 
    \ %11: DMADSTINCR_2      ( DMA destination increment 2: destination address decremented ) 
    \ %111: DMADSTINCR_3      ( DMA destination increment 3: destination address incremented )  DMA0CTL bis! 
( DMA0CTL-DMADT-set ) %xxx  12 lshift
    \ %0: DMADT_0      ( DMA transfer mode 0: Single transfer ) 
    \ %1: DMADT_1      ( DMA transfer mode 1: Block transfer ) 
    \ %11: DMADT_2      ( DMA transfer mode 2: Burst-Block transfer ) 
    \ %111: DMADT_3      ( DMA transfer mode 3: Burst-Block transfer ) 
    \ %1111: DMADT_4      ( DMA transfer mode 4: Repeated Single transfer ) 
    \ %11111: DMADT_5      ( DMA transfer mode 5: Repeated Block transfer ) 
    \ %111111: DMADT_6      ( DMA transfer mode 6: Repeated Burst-Block transfer ) 
    \ %1111111: DMADT_7      ( DMA transfer mode 7: Repeated Burst-Block transfer )  DMA0CTL bis! 
 
\ DMA0SZ ( DMA Channel 0 Transfer Size ) 
 
\ DMA1CTL ( DMA Channel 1 Control ) 
( DMA1CTL-DMAREQ-set ) %1  0 lshift DMA1CTL bis! 
( DMA1CTL-DMAABORT-set ) %1  1 lshift DMA1CTL bis! 
( DMA1CTL-DMAIE-set ) %1  2 lshift DMA1CTL bis! 
( DMA1CTL-DMAIFG-set ) %1  3 lshift DMA1CTL bis! 
( DMA1CTL-DMAEN-set ) %1  4 lshift DMA1CTL bis! 
( DMA1CTL-DMALEVEL-set ) %1  5 lshift DMA1CTL bis! 
( DMA1CTL-DMASRCBYTE-set ) %1  6 lshift DMA1CTL bis! 
( DMA1CTL-DMADSTBYTE-set ) %1  7 lshift DMA1CTL bis! 
( DMA1CTL-DMASRCINCR-set ) %xx  8 lshift
    \ %0: DMASRCINCR_0      ( DMA source increment 0: source address unchanged ) 
    \ %1: DMASRCINCR_1      ( DMA source increment 1: source address unchanged ) 
    \ %11: DMASRCINCR_2      ( DMA source increment 2: source address decremented ) 
    \ %111: DMASRCINCR_3      ( DMA source increment 3: source address incremented )  DMA1CTL bis! 
( DMA1CTL-DMADSTINCR-set ) %xx  10 lshift
    \ %0: DMADSTINCR_0      ( DMA destination increment 0: destination address unchanged ) 
    \ %1: DMADSTINCR_1      ( DMA destination increment 1: destination address unchanged ) 
    \ %11: DMADSTINCR_2      ( DMA destination increment 2: destination address decremented ) 
    \ %111: DMADSTINCR_3      ( DMA destination increment 3: destination address incremented )  DMA1CTL bis! 
( DMA1CTL-DMADT-set ) %xxx  12 lshift
    \ %0: DMADT_0      ( DMA transfer mode 0: Single transfer ) 
    \ %1: DMADT_1      ( DMA transfer mode 1: Block transfer ) 
    \ %11: DMADT_2      ( DMA transfer mode 2: Burst-Block transfer ) 
    \ %111: DMADT_3      ( DMA transfer mode 3: Burst-Block transfer ) 
    \ %1111: DMADT_4      ( DMA transfer mode 4: Repeated Single transfer ) 
    \ %11111: DMADT_5      ( DMA transfer mode 5: Repeated Block transfer ) 
    \ %111111: DMADT_6      ( DMA transfer mode 6: Repeated Burst-Block transfer ) 
    \ %1111111: DMADT_7      ( DMA transfer mode 7: Repeated Burst-Block transfer )  DMA1CTL bis! 
 
\ DMA1SZ ( DMA Channel 1 Transfer Size ) 
 
\ DMA2CTL ( DMA Channel 2 Control ) 
( DMA2CTL-DMAREQ-set ) %1  0 lshift DMA2CTL bis! 
( DMA2CTL-DMAABORT-set ) %1  1 lshift DMA2CTL bis! 
( DMA2CTL-DMAIE-set ) %1  2 lshift DMA2CTL bis! 
( DMA2CTL-DMAIFG-set ) %1  3 lshift DMA2CTL bis! 
( DMA2CTL-DMAEN-set ) %1  4 lshift DMA2CTL bis! 
( DMA2CTL-DMALEVEL-set ) %1  5 lshift DMA2CTL bis! 
( DMA2CTL-DMASRCBYTE-set ) %1  6 lshift DMA2CTL bis! 
( DMA2CTL-DMADSTBYTE-set ) %1  7 lshift DMA2CTL bis! 
( DMA2CTL-DMASRCINCR-set ) %xx  8 lshift
    \ %0: DMASRCINCR_0      ( DMA source increment 0: source address unchanged ) 
    \ %1: DMASRCINCR_1      ( DMA source increment 1: source address unchanged ) 
    \ %11: DMASRCINCR_2      ( DMA source increment 2: source address decremented ) 
    \ %111: DMASRCINCR_3      ( DMA source increment 3: source address incremented )  DMA2CTL bis! 
( DMA2CTL-DMADSTINCR-set ) %xx  10 lshift
    \ %0: DMADSTINCR_0      ( DMA destination increment 0: destination address unchanged ) 
    \ %1: DMADSTINCR_1      ( DMA destination increment 1: destination address unchanged ) 
    \ %11: DMADSTINCR_2      ( DMA destination increment 2: destination address decremented ) 
    \ %111: DMADSTINCR_3      ( DMA destination increment 3: destination address incremented )  DMA2CTL bis! 
( DMA2CTL-DMADT-set ) %xxx  12 lshift
    \ %0: DMADT_0      ( DMA transfer mode 0: Single transfer ) 
    \ %1: DMADT_1      ( DMA transfer mode 1: Block transfer ) 
    \ %11: DMADT_2      ( DMA transfer mode 2: Burst-Block transfer ) 
    \ %111: DMADT_3      ( DMA transfer mode 3: Burst-Block transfer ) 
    \ %1111: DMADT_4      ( DMA transfer mode 4: Repeated Single transfer ) 
    \ %11111: DMADT_5      ( DMA transfer mode 5: Repeated Block transfer ) 
    \ %111111: DMADT_6      ( DMA transfer mode 6: Repeated Burst-Block transfer ) 
    \ %1111111: DMADT_7      ( DMA transfer mode 7: Repeated Burst-Block transfer )  DMA2CTL bis! 
 
\ DMA2SZ ( DMA Channel 2 Transfer Size ) 
 
\ DMA0SA ( DMA Channel 0 Source Address ) 
 
\ DMA0DA ( DMA Channel 0 Destination Address ) 
 
\ DMA1SA ( DMA Channel 1 Source Address ) 
 
\ DMA1DA ( DMA Channel 1 Destination Address ) 
 
\ DMA2SA ( DMA Channel 2 Source Address ) 
 
\ DMA2DA ( DMA Channel 2 Destination Address ) 


                     
\ ===================================COMPARATOR_B =================================== 
\ CBCTL0 ( Comparator B Control Register 0 ) 
( CBCTL0-CBIPSEL-set ) %xxxx  0 lshift
    \ %0: CBIPSEL_0      ( Comp. B V+ terminal Input Select: Channel 0 ) 
    \ %1: CBIPSEL_1      ( Comp. B V+ terminal Input Select: Channel 1 ) 
    \ %11: CBIPSEL_2      ( Comp. B V+ terminal Input Select: Channel 2 ) 
    \ %111: CBIPSEL_3      ( Comp. B V+ terminal Input Select: Channel 3 ) 
    \ %1111: CBIPSEL_4      ( Comp. B V+ terminal Input Select: Channel 4 ) 
    \ %11111: CBIPSEL_5      ( Comp. B V+ terminal Input Select: Channel 5 ) 
    \ %111111: CBIPSEL_6      ( Comp. B V+ terminal Input Select: Channel 6 ) 
    \ %1111111: CBIPSEL_7      ( Comp. B V+ terminal Input Select: Channel 7 ) 
    \ %11111111: CBIPSEL_8      ( Comp. B V+ terminal Input Select: Channel 8 ) 
    \ %111111111: CBIPSEL_9      ( Comp. B V+ terminal Input Select: Channel 9 ) 
    \ %1111111111: CBIPSEL_10      ( Comp. B V+ terminal Input Select: Channel 10 ) 
    \ %11111111111: CBIPSEL_11      ( Comp. B V+ terminal Input Select: Channel 11 ) 
    \ %111111111111: CBIPSEL_12      ( Comp. B V+ terminal Input Select: Channel 12 ) 
    \ %1111111111111: CBIPSEL_13      ( Comp. B V+ terminal Input Select: Channel 13 ) 
    \ %11111111111111: CBIPSEL_14      ( Comp. B V+ terminal Input Select: Channel 14 ) 
    \ %111111111111111: CBIPSEL_15      ( Comp. B V+ terminal Input Select: Channel 15 )  CBCTL0 bis! 
( CBCTL0-CBIPEN-set ) %1  7 lshift CBCTL0 bis! 
( CBCTL0-CBIMSEL-set ) %xxxx  8 lshift
    \ %0: CBIMSEL_0      ( Comp. B V- Terminal Input Select: Channel 0 ) 
    \ %1: CBIMSEL_1      ( Comp. B V- Terminal Input Select: Channel 1 ) 
    \ %11: CBIMSEL_2      ( Comp. B V- Terminal Input Select: Channel 2 ) 
    \ %111: CBIMSEL_3      ( Comp. B V- Terminal Input Select: Channel 3 ) 
    \ %1111: CBIMSEL_4      ( Comp. B V- Terminal Input Select: Channel 4 ) 
    \ %11111: CBIMSEL_5      ( Comp. B V- Terminal Input Select: Channel 5 ) 
    \ %111111: CBIMSEL_6      ( Comp. B V- Terminal Input Select: Channel 6 ) 
    \ %1111111: CBIMSEL_7      ( Comp. B V- Terminal Input Select: Channel 7 ) 
    \ %11111111: CBIMSEL_8      ( Comp. B V- terminal Input Select: Channel 8 ) 
    \ %111111111: CBIMSEL_9      ( Comp. B V- terminal Input Select: Channel 9 ) 
    \ %1111111111: CBIMSEL_10      ( Comp. B V- terminal Input Select: Channel 10 ) 
    \ %11111111111: CBIMSEL_11      ( Comp. B V- terminal Input Select: Channel 11 ) 
    \ %111111111111: CBIMSEL_12      ( Comp. B V- terminal Input Select: Channel 12 ) 
    \ %1111111111111: CBIMSEL_13      ( Comp. B V- terminal Input Select: Channel 13 ) 
    \ %11111111111111: CBIMSEL_14      ( Comp. B V- terminal Input Select: Channel 14 ) 
    \ %111111111111111: CBIMSEL_15      ( Comp. B V- terminal Input Select: Channel 15 )  CBCTL0 bis! 
( CBCTL0-CBIMEN-set ) %1  15 lshift CBCTL0 bis! 
 
\ CBCTL1 ( Comparator B Control Register 1 ) 
( CBCTL1-CBOUT-set ) %1  0 lshift CBCTL1 bis! 
( CBCTL1-CBOUTPOL-set ) %1  1 lshift CBCTL1 bis! 
( CBCTL1-CBF-set ) %1  2 lshift CBCTL1 bis! 
( CBCTL1-CBIES-set ) %1  3 lshift CBCTL1 bis! 
( CBCTL1-CBSHORT-set ) %1  4 lshift CBCTL1 bis! 
( CBCTL1-CBEX-set ) %1  5 lshift CBCTL1 bis! 
( CBCTL1-CBFDLY-set ) %xx  6 lshift
    \ %0: CBFDLY_0      ( Comp. B Filter delay 0 : 450ns ) 
    \ %1: CBFDLY_1      ( Comp. B Filter delay 1 : 900ns ) 
    \ %11: CBFDLY_2      ( Comp. B Filter delay 2 : 1800ns ) 
    \ %111: CBFDLY_3      ( Comp. B Filter delay 3 : 3600ns )  CBCTL1 bis! 
( CBCTL1-CBPWRMD-set ) %xx  8 lshift
    \ %0: CBPWRMD_0      ( Comp. B Power Mode 0 : High speed ) 
    \ %1: CBPWRMD_1      ( Comp. B Power Mode 1 : Normal ) 
    \ %11: CBPWRMD_2      ( Comp. B Power Mode 2 : Ultra-Low ) 
    \ %111: CBPWRMD_3      ( Comp. B Power Mode 3 : Reserved )  CBCTL1 bis! 
( CBCTL1-CBON-set ) %1  10 lshift CBCTL1 bis! 
( CBCTL1-CBMRVL-set ) %1  11 lshift CBCTL1 bis! 
( CBCTL1-CBMRVS-set ) %1  12 lshift CBCTL1 bis! 
 
\ CBCTL2 ( Comparator B Control Register 2 ) 
( CBCTL2-CBREF0-set ) %xxxxx  0 lshift
    \ %0: CBREF0_0      ( Comp. B Int. Ref.0 Select 0 : 1/32 ) 
    \ %1: CBREF0_1      ( Comp. B Int. Ref.0 Select 1 : 2/32 ) 
    \ %11: CBREF0_2      ( Comp. B Int. Ref.0 Select 2 : 3/32 ) 
    \ %111: CBREF0_3      ( Comp. B Int. Ref.0 Select 3 : 4/32 ) 
    \ %1111: CBREF0_4      ( Comp. B Int. Ref.0 Select 4 : 5/32 ) 
    \ %11111: CBREF0_5      ( Comp. B Int. Ref.0 Select 5 : 6/32 ) 
    \ %111111: CBREF0_6      ( Comp. B Int. Ref.0 Select 6 : 7/32 ) 
    \ %1111111: CBREF0_7      ( Comp. B Int. Ref.0 Select 7 : 8/32 ) 
    \ %11111111: CBREF0_8      ( Comp. B Int. Ref.0 Select 0 : 9/32 ) 
    \ %111111111: CBREF0_9      ( Comp. B Int. Ref.0 Select 1 : 10/32 ) 
    \ %1111111111: CBREF0_10      ( Comp. B Int. Ref.0 Select 2 : 11/32 ) 
    \ %11111111111: CBREF0_11      ( Comp. B Int. Ref.0 Select 3 : 12/32 ) 
    \ %111111111111: CBREF0_12      ( Comp. B Int. Ref.0 Select 4 : 13/32 ) 
    \ %1111111111111: CBREF0_13      ( Comp. B Int. Ref.0 Select 5 : 14/32 ) 
    \ %11111111111111: CBREF0_14      ( Comp. B Int. Ref.0 Select 6 : 15/32 ) 
    \ %111111111111111: CBREF0_15      ( Comp. B Int. Ref.0 Select 7 : 16/32 ) 
    \ %1111111111111111: CBREF0_16      ( Comp. B Int. Ref.0 Select 0 : 17/32 ) 
    \ %: CBREF0_17      ( Comp. B Int. Ref.0 Select 1 : 18/32 ) 
    \ %: CBREF0_18      ( Comp. B Int. Ref.0 Select 2 : 19/32 ) 
    \ %: CBREF0_19      ( Comp. B Int. Ref.0 Select 3 : 20/32 ) 
    \ %11111111111111111111: CBREF0_20      ( Comp. B Int. Ref.0 Select 4 : 21/32 ) 
    \ %: CBREF0_21      ( Comp. B Int. Ref.0 Select 5 : 22/32 ) 
    \ %: CBREF0_22      ( Comp. B Int. Ref.0 Select 6 : 23/32 ) 
    \ %: CBREF0_23      ( Comp. B Int. Ref.0 Select 7 : 24/32 ) 
    \ %111111111111111111111111: CBREF0_24      ( Comp. B Int. Ref.0 Select 0 : 25/32 ) 
    \ %: CBREF0_25      ( Comp. B Int. Ref.0 Select 1 : 26/32 ) 
    \ %: CBREF0_26      ( Comp. B Int. Ref.0 Select 2 : 27/32 ) 
    \ %: CBREF0_27      ( Comp. B Int. Ref.0 Select 3 : 28/32 ) 
    \ %1111111111111111111111111111: CBREF0_28      ( Comp. B Int. Ref.0 Select 4 : 29/32 ) 
    \ %: CBREF0_29      ( Comp. B Int. Ref.0 Select 5 : 30/32 ) 
    \ %: CBREF0_30      ( Comp. B Int. Ref.0 Select 6 : 31/32 ) 
    \ %: CBREF0_31      ( Comp. B Int. Ref.0 Select 7 : 32/32 )  CBCTL2 bis! 
( CBCTL2-CBRSEL-set ) %1  5 lshift CBCTL2 bis! 
( CBCTL2-CBRS-set ) %xx  6 lshift
    \ %0: CBRS_0      ( Comp. B Reference Source 0 : Off ) 
    \ %1: CBRS_1      ( Comp. B Reference Source 1 : Vcc ) 
    \ %11: CBRS_2      ( Comp. B Reference Source 2 : Shared Ref. ) 
    \ %111: CBRS_3      ( Comp. B Reference Source 3 : Shared Ref. / Off )  CBCTL2 bis! 
( CBCTL2-CBREF1-set ) %xxxxx  8 lshift
    \ %0: CBREF1_0      ( Comp. B Int. Ref.1 Select 0 : 1/32 ) 
    \ %1: CBREF1_1      ( Comp. B Int. Ref.1 Select 1 : 2/32 ) 
    \ %11: CBREF1_2      ( Comp. B Int. Ref.1 Select 2 : 3/32 ) 
    \ %111: CBREF1_3      ( Comp. B Int. Ref.1 Select 3 : 4/32 ) 
    \ %1111: CBREF1_4      ( Comp. B Int. Ref.1 Select 4 : 5/32 ) 
    \ %11111: CBREF1_5      ( Comp. B Int. Ref.1 Select 5 : 6/32 ) 
    \ %111111: CBREF1_6      ( Comp. B Int. Ref.1 Select 6 : 7/32 ) 
    \ %1111111: CBREF1_7      ( Comp. B Int. Ref.1 Select 7 : 8/32 ) 
    \ %11111111: CBREF1_8      ( Comp. B Int. Ref.1 Select 0 : 9/32 ) 
    \ %111111111: CBREF1_9      ( Comp. B Int. Ref.1 Select 1 : 10/32 ) 
    \ %1111111111: CBREF1_10      ( Comp. B Int. Ref.1 Select 2 : 11/32 ) 
    \ %11111111111: CBREF1_11      ( Comp. B Int. Ref.1 Select 3 : 12/32 ) 
    \ %111111111111: CBREF1_12      ( Comp. B Int. Ref.1 Select 4 : 13/32 ) 
    \ %1111111111111: CBREF1_13      ( Comp. B Int. Ref.1 Select 5 : 14/32 ) 
    \ %11111111111111: CBREF1_14      ( Comp. B Int. Ref.1 Select 6 : 15/32 ) 
    \ %111111111111111: CBREF1_15      ( Comp. B Int. Ref.1 Select 7 : 16/32 ) 
    \ %1111111111111111: CBREF1_16      ( Comp. B Int. Ref.1 Select 0 : 17/32 ) 
    \ %: CBREF1_17      ( Comp. B Int. Ref.1 Select 1 : 18/32 ) 
    \ %: CBREF1_18      ( Comp. B Int. Ref.1 Select 2 : 19/32 ) 
    \ %: CBREF1_19      ( Comp. B Int. Ref.1 Select 3 : 20/32 ) 
    \ %11111111111111111111: CBREF1_20      ( Comp. B Int. Ref.1 Select 4 : 21/32 ) 
    \ %: CBREF1_21      ( Comp. B Int. Ref.1 Select 5 : 22/32 ) 
    \ %: CBREF1_22      ( Comp. B Int. Ref.1 Select 6 : 23/32 ) 
    \ %: CBREF1_23      ( Comp. B Int. Ref.1 Select 7 : 24/32 ) 
    \ %111111111111111111111111: CBREF1_24      ( Comp. B Int. Ref.1 Select 0 : 25/32 ) 
    \ %: CBREF1_25      ( Comp. B Int. Ref.1 Select 1 : 26/32 ) 
    \ %: CBREF1_26      ( Comp. B Int. Ref.1 Select 2 : 27/32 ) 
    \ %: CBREF1_27      ( Comp. B Int. Ref.1 Select 3 : 28/32 ) 
    \ %1111111111111111111111111111: CBREF1_28      ( Comp. B Int. Ref.1 Select 4 : 29/32 ) 
    \ %: CBREF1_29      ( Comp. B Int. Ref.1 Select 5 : 30/32 ) 
    \ %: CBREF1_30      ( Comp. B Int. Ref.1 Select 6 : 31/32 ) 
    \ %: CBREF1_31      ( Comp. B Int. Ref.1 Select 7 : 32/32 )  CBCTL2 bis! 
( CBCTL2-CBREFL-set ) %xx  13 lshift
    \ %0: CBREFL_0      ( Comp. B Reference voltage level 0 : None ) 
    \ %1: CBREFL_1      ( Comp. B Reference voltage level 1 : 1.5V ) 
    \ %11: CBREFL_2      ( Comp. B Reference voltage level 2 : 2.0V ) 
    \ %111: CBREFL_3      ( Comp. B Reference voltage level 3 : 2.5V )  CBCTL2 bis! 
( CBCTL2-CBREFACC-set ) %1  15 lshift CBCTL2 bis! 
 
\ CBCTL3 ( Comparator B Control Register 3 ) 
( CBCTL3-CBPD0-set ) %1  0 lshift CBCTL3 bis! 
( CBCTL3-CBPD1-set ) %1  1 lshift CBCTL3 bis! 
( CBCTL3-CBPD2-set ) %1  2 lshift CBCTL3 bis! 
( CBCTL3-CBPD3-set ) %1  3 lshift CBCTL3 bis! 
( CBCTL3-CBPD4-set ) %1  4 lshift CBCTL3 bis! 
( CBCTL3-CBPD5-set ) %1  5 lshift CBCTL3 bis! 
( CBCTL3-CBPD6-set ) %1  6 lshift CBCTL3 bis! 
( CBCTL3-CBPD7-set ) %1  7 lshift CBCTL3 bis! 
( CBCTL3-CBPD8-set ) %1  8 lshift CBCTL3 bis! 
( CBCTL3-CBPD9-set ) %1  9 lshift CBCTL3 bis! 
( CBCTL3-CBPD10-set ) %1  10 lshift CBCTL3 bis! 
( CBCTL3-CBPD11-set ) %1  11 lshift CBCTL3 bis! 
( CBCTL3-CBPD12-set ) %1  12 lshift CBCTL3 bis! 
( CBCTL3-CBPD13-set ) %1  13 lshift CBCTL3 bis! 
( CBCTL3-CBPD14-set ) %1  14 lshift CBCTL3 bis! 
( CBCTL3-CBPD15-set ) %1  15 lshift CBCTL3 bis! 
 
\ CBINT ( Comparator B Interrupt Register ) 
( CBINT-CBIFG-set ) %1  0 lshift CBINT bis! 
( CBINT-CBIIFG-set ) %1  1 lshift CBINT bis! 
( CBINT-CBIE-set ) %1  8 lshift CBINT bis! 
( CBINT-CBIIE-set ) %1  9 lshift CBINT bis! 
 
\ CBIV ( Comparator B Interrupt Vector Word ) 


                     
\ ===================================_INTERRUPTS ===================================
\ RTC $FFD2 RTC
\ PORT2 $FFD4 Port 2
\ TIMER2_A1 $FFD6 Timer2_A5 CC1-4, TA
\ TIMER2_A0 $FFD8 Timer2_A5 CC0
\ USCI_B1 $FFDA USCI B1 Receive/Transmit
\ USCI_A1 $FFDC USCI A1 Receive/Transmit
\ PORT1 $FFDE Port 1
\ TIMER1_A1 $FFE0 Timer1_A3 CC1-2, TA1
\ TIMER1_A0 $FFE2 Timer1_A3 CC0
\ DMA $FFE4 DMA
\ USB_UBM $FFE6 USB Timer / cable event / USB reset
\ TIMER0_A1 $FFE8 Timer0_A5 CC1-4, TA
\ TIMER0_A0 $FFEA Timer0_A5 CC0
\ ADC12 $FFEC ADC
\ USCI_B0 $FFEE USCI B0 Receive/Transmit
\ USCI_A0 $FFF0 USCI A0 Receive/Transmit
\ WDT $FFF2 Watchdog Timer
\ TIMER0_B1 $FFF4 Timer0_B7 CC1-6, TB
\ TIMER0_B0 $FFF6 Timer0_B7 CC0
\ COMP_B $FFF8 Comparator B
\ UNMI $FFFA User Non-maskable
\ SYSNMI $FFFC System Non-maskable

                    
