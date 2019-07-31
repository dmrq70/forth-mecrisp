\ MSP430FR2433 Launchpad-specific words

compiletoflash

: init init
  %10001000 P2OUT cbis! \ High
  %10001000 P2REN cbis! \ Pullups for buttons
        %11 P1OUT cbic! \ LEDs off
        %11 P1DIR cbis! \ LEDs are outputs
  ;

compiletoram