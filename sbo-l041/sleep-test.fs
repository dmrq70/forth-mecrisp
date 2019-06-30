\ the dependencies are sleep-extra -> hal-extra -> io-extra
\ include ../flib/stm32l0/sleep-extra.fs

\ this doesn't seem to make much of difference in power consumption,
\ definitely less than 1uA
: usart2-disable ( -- )
  2 bit $40004400 bic!             \ clear TE (USART2-CR1)
  begin 6 bit $4000441C bit@ until \ wait for TC (USART2-ISR)
  3 bit 0 bit or $40004400 bic!    \ clear RE and UE (USART2-CR1)
  IMODE-HIGH PA2 io-mode!
  IMODE-HIGH PA3 io-mode!
  17 bit $40021038 bic!            \ disable USART2 clock (RCC-APB1ENR)
  ;

: extra-ioports-disable ( -- )
  1 bit $4002102C bic!             \ disable PORTB clock (RCC-IOPENR)
  ;

: lp-blink ( -- ) usart2-disable  led-on 10 ms led-off  only-msi  begin  stop10s led iox!  again ;

rf-init rf-sleep
led-off 2.1MHz 1000 systick-hz
lptim-init extra-ioports-disable
\ lp-blink
