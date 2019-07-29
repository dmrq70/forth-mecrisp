\ base definitions for STM32F042 (STRIPPED-DOWN version for USB driver use!)
\ adapted from jcw's embello for STM32F103
\ adapted from mecrisp-stellaris 2.2.1a (GPL3)

: chipid ( -- u1 u2 u3 3 )  \ unique chip ID as N values on the stack
  $1FFFF7AC @ $1FFFF7B0 @ $1FFFF7B4 @ 3 ;
: hwid ( -- u )  \ a "fairly unique" hardware ID as single 32-bit int
  chipid 1 do xor loop ;
: flash-kb ( -- u )  \ return size of flash memory in KB
  $1FFFF7CC h@ ;
: flash-pagesize ( addr - u )  \ return size of flash page at given address
  drop 1024 ;

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

: 48MHz-after-reset ( -- )  \ set the main clock to 48MHz (HSI->PLL) assuming we're out of RESET
  %10001 flash-acr bis!
  %1010 18 lshift rcc-cfgr !
  24 bit rcc-cr bis!
  begin 25 bit rcc-cr bit@ until
  %10 rcc-cfgr bis!
  $1a1 $4000440C !  \ change USART2_BRR to match 48MHz
;

: usb-clk ( -- )  \ enable HSI48, autotrim and set USB clock source
    16 bit RCC-CR2 bis!                \ switch on HSI48
    begin 17 bit RCC-CR2 bit@ until    \ wait for HSI48RDY

    27 bit RCC-APB1ENR bis!            \ enable CRS
    CRS-CFGR @  %11 28 lshift bic      \ prepare setting SYNCSRC
        %10 28 lshift or CRS-CFGR !    \ set USB SOF, write back
    6 bit 5 bit or  CRS-CR bis!        \ set AUTOTRIMEN and CEN
    \ will only start actually working after we start getting SOF

    7 bit RCC-CFGR3 bic!               \ HSI48 is USB clock source
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
