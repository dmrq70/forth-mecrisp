\ MSP430FR2476 Launchpad-specific words

include ../flib/fr24xx/adc-regs.fs
include ../flib/fr24xx/pmm-regs.fs
include ../flib/fr24xx/analog.fs
include ../flib/fr24xx/sys-regs.fs

1 variable vcc

: init init
  %00001000 P2OUT cbis! \ High
  %00001000 P2REN cbis! \ Pullup for button P2.3
  %00000001 P4OUT cbis! \ High
  %00000001 P4REN cbis! \ Pullup for button P4.0
  %00000001 P1OUT cbic! \ LED P1.0 off
  %00000001 P1DIR cbis! \ LED is output
  %00000011 P5OUT cbic! \ green red RGB LED off
  %00000011 P5DIR cbis! \ LEDs are outputs
  %10000000 P4OUT cbic! \ blue RGB LED off
  %10000000 P4DIR cbis! \ LED is output
  adc-init
  ref1.5-enable
  adc-vcc vcc !         \ store current VCC
  2 SYSCFG2 bis!        \ enable A1 (P1.1) as analog input
  2 P1SEL0 bis!
  2 P1SEL1 bis!
  ;

: temp ( -- t10 ) \ read temp from onboard TMP235
  1 analog  vcc @  1024 */  500 -
  ;

