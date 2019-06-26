\ support for fow-power sleep
\ from jcw's embello

: lptim-init ( -- )  \ enable the low-power timer
  0 bit $40021050 bis!              \ set LSION  (RCC-CSR)
  begin 1 bit $40021050 bit@ until  \ wait for LSIRDY  (RCC-CSR)
  %01 18 lshift $4002104C bis!      \ use LSI clock  (RCC-CCIPR)
  31 bit $40021038 bis!             \ enable LPTIM1  (RCC-APB1ENR)
  31 bit $40021048 bis!             \ also enable in sleep mode  (RCC-APB1SMENR)
  %111 9 lshift  !  $40007C0C       \ 128 prescaler  (LPTIM-CFGR)
  0 bit $40007C10 bis!              \ set ENABLE  (LPTIM-CR)
  \ the following settings prepare for sleep mode
  28 bit $40021038 bis!             \ set PWREN  (RCC-APB1ENR)
  %1000000101 $40007000 bis!        \ set ULP, CWUF, and LPSDSR  (PWR-CR)
;

: wfe ( -- )  \ WFE Opcode, enters sleep mode
  [ $BF20 h, ] inline ;

: stop-freq ( u -- )  \ enter stop mode, will resume when LPTIMER fires
  64 + 128 / $40007C18 !                \ round and set LPTIMER count  (LPTIM-ARR)
  1 bit $40007C10 bis!                  \ set SNGSTRT  (LPTIM-CR)
  1 bit $40007C08 bis!                  \ set ARRMIE  (LPTIM-IER)
  2 bit $E000ED10 bis!                  \ set SLEEPDEEP  (SCR)
  begin wfe 1 bit $40007C00 bit@ until  \ wait for ARRM  (LPTIM-ISR)
  1 bit $40007C04 bis!                  \ clear ARRM  (LPTIM-ICR)
  2 bit $E000ED10 bic!                  \ clear SLEEPDEEP  (SCR)
;

