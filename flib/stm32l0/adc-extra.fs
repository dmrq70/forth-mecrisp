\ simple one-shot ADC / extras

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

