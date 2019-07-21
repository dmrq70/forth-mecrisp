: lp-blink ( -- )
  led-off 2.1MHz 1000 systick-hz
  lptim-init
  only-msi
  begin  stop10s led iox!  again ;

: lp-blips ( -- )
  led-off                 \ led off
  2.1MHz 1000 systick-hz  \ slow down the clock, adjust systick accordingly
  lptim-init              \ initialise the low-power timer
  only-msi
  begin
    led-on sleep led-off  \ a very short 1ms LED blip, but still visible
    stop10s               \ enter stop mode for approx 10 seconds
  again ;

: highz-gpio
  IMODE-ADC PA0  io-mode!
  IMODE-ADC PA1  io-mode!
  IMODE-ADC PA2  io-mode!
  IMODE-ADC PA3  io-mode!
  IMODE-ADC PA4  io-mode!
  IMODE-ADC PA5  io-mode!
  IMODE-ADC PA6  io-mode!
  IMODE-ADC PA7  io-mode!
  IMODE-ADC PA8  io-mode!
  IMODE-ADC PA9  io-mode!
  IMODE-ADC PA10 io-mode!
  IMODE-ADC PA11 io-mode!
  IMODE-ADC PA12 io-mode!
  IMODE-ADC PA13 io-mode!
  IMODE-ADC PA14 io-mode!
\ IMODE-ADC PA15 io-mode!   \ LED
  IMODE-ADC PB0  io-mode!
  IMODE-ADC PB1  io-mode!
  IMODE-ADC PB2  io-mode!
  IMODE-ADC PB3  io-mode!
  IMODE-ADC PB4  io-mode!
  IMODE-ADC PB5  io-mode!
  IMODE-ADC PB6  io-mode!
  IMODE-ADC PB7  io-mode!
  IMODE-ADC PB8  io-mode!
  IMODE-ADC PB9  io-mode!
  IMODE-ADC PB10 io-mode!
  IMODE-ADC PB11 io-mode!
  IMODE-ADC PB12 io-mode!
  IMODE-ADC PB13 io-mode!
  IMODE-ADC PB14 io-mode!
  IMODE-ADC PB15 io-mode!
  IMODE-ADC PD0  io-mode!
  IMODE-ADC PD1  io-mode!
  IMODE-ADC PC13 io-mode!
  IMODE-ADC PC14 io-mode!
  IMODE-ADC PC15 io-mode! ;

