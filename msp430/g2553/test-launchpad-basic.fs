\ MSP430G2553 Launchpad-specific words

include basis-g2553.fs

compiletoflash

: init init
  8 $21 cbis! \ High  (P1OUT)
  8 $27 cbis! \ Pullup for button  (P1REN)
  %11110001 $21 cbic! \ all free P1 pins low (P1OUT)
  %11110001 $22 cbis! \ all free P1 pins are outputs  (P1DIR)
  %00111111 $29 cbic! \ all free P2 pins low (P2OUT)
  %00111111 $2A cbis! \ all free P2 pins are outputs  (P2DIR)
;

: blink \ all free pins
  begin
    %11110001 $21 cbis!
    %00111111 $29 cbis!
    700 ms
    %11110001 $21 cbic!
    %00111111 $29 cbic!
    700 ms
  key? until ;

: button?
  8 $20 cbit@
  ;

: button
  begin
  1 $21 button? if cbic! else cbis! then
  20 ms
  key? until ;
    

compiletoram
