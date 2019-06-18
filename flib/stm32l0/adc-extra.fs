\ simple one-shot ADC / extras
\ from jcw's embello

$40012400 constant ADC1
    ADC1 $000 + constant ADC-ISR
    ADC1 $004 + constant ADC-IER
    ADC1 $008 + constant ADC-CR
    ADC1 $00C + constant ADC-CFGR1
    ADC1 $010 + constant ADC-CFGR2
    ADC1 $014 + constant ADC-SMPR
    ADC1 $020 + constant ADC-TR
    ADC1 $028 + constant ADC-CHSELR
    ADC1 $040 + constant ADC-DR
    ADC1 $0B4 + constant ADC-CALFACT
    ADC1 $308 + constant ADC-CCR


: adc? ( -- )
  ADC1
  cr ."     ISR " dup @ hex. 4 +
     ."     IER " dup @ hex. 4 +
  cr ."      CR " dup @ hex. 4 +
  cr ."   CFGR1 " dup @ hex. 4 +
     ."   CFGR2 " dup @ hex. 4 +
  cr ."    SMPR " dup @ hex. $C +
     ."      TR " dup @ hex. 8 +
  cr ."  CHSELR " dup @ hex. $18 +
     ."      DR " dup @ hex. $74 +
  cr ." CALFACT " dup @ hex. $254 +
     ."     CCR " dup @ hex. drop ;

: adc-temp ( -- degc )  \ measure chip temperature
  23 bit ADC-CCR bis!  ADC-SMPR @  %111 ADC-SMPR !
  18 adc  swap  23 bit ADC-CCR bic!  ADC-SMPR !
  adc-vcc 3000 */ $1FF8007A h@ - 100 $1FF8007E h@ $1FF8007A h@ - */ 30 + ;

