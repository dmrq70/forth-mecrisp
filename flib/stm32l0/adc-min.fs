\ simple one-shot ADC
\ from jcw's embello

: adc-calib ( -- )  \ perform an ADC calibration cycle
  31 bit $40012408 bis!  \ set ADCAL  (ADC-CR)
  begin 31 bit $40012408 bit@ 0= until  \ wait until ADCAL is clear  (ADC-CR)
;

: adc-once ( -- u )  \ read ADC value once
  2 bit $40012408 bis!  \ set ADSTART to start ADC  (ADC-CR)
  begin 2 bit $40012400 bit@ until  \ wait until EOC set  (ADC-ISR)
  $40012440 @ ;  \  (ADC-DR)

: adc-init ( -- )  \ initialise ADC
\ FIXME can't call this twice, recalibration will hang!
  9 bit $40021034 bis!  \ set ADCEN  (RCC-APB2ENR)
  adc-calib  1 $40012408 !   \ perform calibration, then set ADEN to enable ADC  (ADC-CR)
  adc-once drop ;

: adc-deinit ( -- )  \ de-initialise ADC
  1 bit $40012408 bis! 9 bit $40021034 bic! ;  \   (ADC-CR) (RCC-APB2ENR)

: adc ( pin -- u )  \ read ADC value 2x to avoid chip erratum
\ IMODE-ADC over io-mode!
  io# bit $40012428 !  adc-once drop adc-once ;  \  (ADC-CHSELR)

: adc-vcc ( -- mv )  \ measure current Vcc
  22 bit $40012708 bis!  $40012414 @  %111 $40012414 !  \  (ADC-CCR) (ADC-SMPR) (ADC-SMPR)
  $1FF80078 h@ 3000 * 17 adc /
  swap  22 bit $40012708 bic!  $40012414 ! ;  \  (ADC-CCR) (ADC-SMPR)

