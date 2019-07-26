\ basic analog for FR24xx

: adc-init ( -- ) \ initialise ADC
  1 1 lshift  ADCCTL0  bic!  \ ADCENC disable
  1 4 lshift  %0010 8 lshift  or  ADCCTL0 !  \ ADCON | ADHSHTx (16ADCcycles)
  1 9 lshift  ADCCTL1  bis!  \ ADCSHP
  %01 4 lshift  ADCCTL2 bis!  \ ADCRES (10bit)
  \ %000 4 lshift  ADCMCTL0  !  \  ADCSREFx (AVCC)
  ;

: ref1.5-enable ( -- ) \ enable 1.5V internal reference
  PMM-PASSWORD PMMCTL0 1+ c! \ enable PMM regs access
  1 PMMCTL2 bis! \ INTREFEN
  PMM-PASSWORD 1+ PMMCTL0 1+ c! \ disable PMM regs access
  ;

: analog ( n -- w ) \ do a single shot ADC of channel n
  1 1 lshift  ADCCTL0  bic!  \ ADCENC disable
  %1111  ADCMCTL0  bic!  \ clear channel select
  ADCMCTL0 bis!  \ select channel
  3 ADCCTL0  bis!  \ ADCENC|ADCSC
  begin 1 ADCCTL1 bit@ not until  \ ADCBUSY
  ADCMEM0 @ ;

: adc-vcc ( -- mV ) \ get VCC voltage
  1024 1500  13 analog  */  ;

\ for pins, need to enable ADC on them with ADCPCTLx in SYSCFG2
