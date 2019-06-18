\ support for fow-power sleep / extras
\ from jcw's embello

     RCC $48 + constant RCC-APB1SMENR
     RCC $50 + constant RCC-CSR

$40007C00 constant LPTIM1
   LPTIM1 $00 + constant LPTIM-ISR
   LPTIM1 $04 + constant LPTIM-ICR
   LPTIM1 $08 + constant LPTIM-IER
   LPTIM1 $0C + constant LPTIM-CFGR
   LPTIM1 $10 + constant LPTIM-CR
   LPTIM1 $14 + constant LPTIM-CMP
   LPTIM1 $18 + constant LPTIM-ARR
   LPTIM1 $1C + constant LPTIM-CNT

$40007000 constant PWR
      PWR $0 + constant PWR-CR
      PWR $4 + constant PWR-CSR

$40010400 constant EXTI
     EXTI $00 + constant EXTI-IMR
     EXTI $04 + constant EXTI-EMR
\    EXTI $08 + constant EXTI-RTSR
\    EXTI $0C + constant EXTI-FTSR
\    EXTI $10 + constant EXTI-SWIER
     EXTI $14 + constant EXTI-PR

\ see https://developer.arm.com/docs/dui0662/latest/4-cortex-m0-peripherals/
\                       43-system-control-block/436-system-control-register
$E000ED10 constant SCR


: lptim? ( -- )  \ dump the low-power timer registers
  LPTIM1
  cr  ." ISR " dup @ h.2 space 4 +
      ." ICR " dup @ h.2 space 4 +
      ." IER " dup @ h.2 space 4 +
     ." CFGR " dup @ hex.      4 +
       ." CR " dup @ h.2 space 4 +
      ." CMP " dup @ h.4 space 4 +
      ." ARR " dup @ h.4 space 4 +
      ." CNT " dup @ h.4 space drop ;

: stop100ms ( -- )  \ sleep in low-power for 100 ms
  3700   stop-freq ;
: stop1s    ( -- )  \ sleep in low-power for 1 sec
  37000  stop-freq ;
: stop10s   ( -- )  \ sleep in low-power for 10 sec
  370000 stop-freq ;

\ : lp-blink ( -- )  only-msi  begin  stop1s led iox!  again ;
\
\ rf-init rf-sleep
\ led-off 2.1MHz 1000 systick-hz
\ lptim-init lp-blink
