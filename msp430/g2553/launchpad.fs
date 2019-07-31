\ MSP430G2553 Launchpad-specific words

compiletoflash

: init init
  8 $21 cbis! \ High  (P1OUT)
  8 $27 cbis! \ Pullup for button  (P1REN)
  1 64 or $21 cbic! \ LEDs off  (P1OUT)
  1 64 or $22 cbis! \ LEDs are outputs  (P1DIR)
  \ P1.6 is output: if not, launchpad power consumption goes up by 20uA
;

compiletoram
