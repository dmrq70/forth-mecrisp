\ base definitions for STM32L052 / extras
\ from jcw's embello
\ needs io-extra.fs

$40010000 constant SYSCFG

$40013800 constant USART1
   USART1 $C + constant USART1-BRR

$40022000 constant FLASH
   FLASH $00 + constant FLASH-ACR

$40021000 constant RCC
     RCC $00 + constant RCC-CR
     RCC $04 + constant RCC-ICSCR
     RCC $0C + constant RCC-CFGR
     RCC $28 + constant RCC-APB1RSTR
     RCC $30 + constant RCC-AHBENR
     RCC $34 + constant RCC-APB2ENR
     RCC $38 + constant RCC-APB1ENR
     RCC $4C + constant RCC-CCIPR



\ [ifndef] IO-PORTS  3 constant IO-PORTS  [then]  \ A..C

: io.all ( -- )  \ display all the readable GPIO registers
  3 0 do i 0 io io. loop ; \ (IO-PORTS)

