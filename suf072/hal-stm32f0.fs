\ base definitions for STM32F072 (STRIPPED-DOWN version for USB driver use!)
\ adapted from jcw's embello for STM32F103
\ adapted from mecrisp-stellaris 2.2.1a (GPL3)

: chipid ( -- u1 u2 u3 3 )  \ unique chip ID as N values on the stack
  $1FFFF7AC @ $1FFFF7B0 @ $1FFFF7B4 @ 3 ;
: hwid ( -- u )  \ a "fairly unique" hardware ID as single 32-bit int
  chipid 1 do xor loop ;
: flash-kb ( -- u )  \ return size of flash memory in KB
  $1FFFF7CC h@ ;
: flash-pagesize ( addr - u )  \ return size of flash page at given address
  drop 2048 ; \ f07x f09x ;  f03x f04x have 1024

: bit ( u -- u )  \ turn a bit position into a single-bit mask
  1 swap lshift  1-foldable ;

$40021000 constant RCC
     RCC $00 + constant RCC-CR
     RCC $04 + constant RCC-CFGR
     RCC $14 + constant RCC-AHBENR
     RCC $18 + constant RCC-APB2ENR
     RCC $1C + constant RCC-APB1ENR
     RCC $30 + constant RCC-CFGR3
     RCC $34 + constant RCC-CR2

$40022000 constant FLASH
    FLASH $0 + constant FLASH-ACR

$40006C00 constant CRS
    CRS $00 + constant CRS-CR
    CRS $04 + constant CRS-CFGR


\ : 48MHz ( -- )  \ set the main clock to 48MHz (HSI -> PLL)
\     0 bit RCC-CR bis!                \ switch on HSI
\     begin 1 bit RCC-CR bit@ until    \ wait for HSIRDY
\     %11 RCC-CFGR bic!                \ HSI as system clock (HSI:%00 HSI48:%11)
\     RCC-CFGR @
\         %1111111 4 lshift bic        \ clear HPRE PPRE (no div AHB & APB clocks)
\         RCC-CFGR !                   \ write back RCC-CFGR
\     4 bit FLASH-ACR bis!             \ enable prefetch buffer (PRFTBE)
\     0 bit FLASH-ACR bis!             \ one wait state for flash
\     RCC-CFGR @                       \ 8MHz * 12 / 2 = 48MHz
\         %1111011 15 lshift bic       \ prepare setting PLLMUL and PLLSRC
\         %1000 18 lshift or RCC-CFGR ! \ PLL x 12   \ HSI/2 PLLSRC = 00   \ write back
\ 
\     24 bit RCC-CR bis!               \ enable PLL
\     begin 25 bit RCC-CR bit@ until   \ wait for PLLRDY
\     %10 RCC-CFGR bis!                \ PLL as system clock
\     %11 RCC-CFGR3 bis!               \ set HSI as USART1 source (so we don't lose prompt)
\ ;

: 48MHz-after-reset ( -- )  \ set the main clock to 48MHz (HSI->PLL) assuming we're out of RESET
  %10001 flash-acr bis!
  %1000 18 lshift rcc-cfgr !
  24 bit rcc-cr bis!
  begin 25 bit rcc-cr bit@ until
  %10 rcc-cfgr bis!
  %11 rcc-cfgr3 bis!  \ USART1 clocked from HSI
;

: usb-clk ( -- )  \ enable autotrim and clock to USB
    16 bit RCC-CR2 bis!                \ switch on HSI48
    begin 17 bit RCC-CR2 bit@ until    \ wait for HSI48RDY

    27 bit RCC-APB1ENR bis!            \ enable CRS
    CRS-CFGR @  %11 28 lshift bic      \ prepare setting SYNCSRC
        %10 28 lshift or CRS-CFGR !    \ set USB SOF, write back
    6 bit 5 bit or  CRS-CR bis!        \ set AUTOTRIMEN and CEN

    7 bit RCC-CFGR3 bic!               \ HSI48 is USB clock source

    23 bit RCC-APB1ENR bis!            \ USBEN
;



\ emulate c, which is not available in hardware on some chips.
\ copied from Mecrisp's common/charcomma.txt
0 variable c,collection

: c, ( c -- )  \ emulate c, with h,
  c,collection @ ?dup if $FF and swap 8 lshift or h,
                         0 c,collection !
                      else $100 or c,collection ! then ;

: calign ( -- )  \ must be called to flush after odd number of c, calls
  c,collection @ if 0 c, then ;

: cornerstone ( "name" -- )  \ define a flash memory cornerstone
  <builds begin here dup flash-pagesize 1- and while 0 h, repeat
  does>   begin dup  dup flash-pagesize 1- and while 2+   repeat  cr
  eraseflashfrom ;
