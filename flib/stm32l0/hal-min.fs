\ base definitions for STM32L053
\ adapted from mecrisp-stellaris 2.2.1a (GPL3)
\ needs io.fs

: chipid ( -- u1 u2 u3 3 )  \ unique chip ID as N values on the stack
  $1FF80050 @ $1FF80054 @ $1FF80064 @ 3 ;
: hwid ( -- u )  \ a "fairly unique" hardware ID as single 32-bit int
  chipid 1 do xor loop ;
: flash-kb ( -- u )  \ return size of flash memory in KB
  $1FF8007C h@ ;
: flash-pagesize ( addr - u )  \ return size of flash page at given address
  drop 128 ;

16000000  variable clock-hz  \ the system clock is 16 MHz after reset

4096      variable us/cycle*2^16
: us/cycl-factor 65536 1000000 um* clock-hz @ um/mod us/cycle*2^16 ! drop ;

: baud ( u -- u )  \ calculate baud rate divider, based on current clock rate
  clock-hz @ swap / ;

: hsi-on ( -- )  \ turn on internal 16 MHz clock, needed by ADC
  0 bit $40021000 bis!               \ set HSI16ON  (RCC-CR)
  begin 2 bit $40021000 bit@ until   \ wait for HSI16RDYF  (RCC-CR)
;

: hsi-wakeup ( -- )  \ wake up using the 16 MHz clock
  15 bit $4002100C bis! ;  \   (RCC-CFGR)

: only-msi ( -- )  \ turn off HSI16, this disables the console UART
  8 bit $40021000 ! ; \  (RCC-CR)

: 65KHz ( -- )  \ set main clock to 65 KHz, assuming it was set to 2.1 MHz
  %111 13 lshift $40021004 bic!  65536 clock-hz !  \  (RCC-ICSCR)
  us/cycl-factor ;

: 2.1MHz ( -- )  \ set the main clock to 2.1 MHz (MSI)
  $40021004 dup @  %111 13 lshift bic  %101 13 lshift or  swap !  \ range 5  (RCC-ICSCR)
  8 bit $40021000 bis!               \ set MSION  (RCC-CR)
  begin 9 bit $40021000 bit@ until   \ wait for MSIRDY  (RCC-CR)
  %00 $4002100C !                    \ revert to MSI @ 2.1 MHz, no PLL   (RCC-CFGR)
  $101 $40021000 !                   \ turn off HSE, and PLL  (RCC-CR)
  2097000 clock-hz ! 
  us/cycl-factor ;

: 16MHz ( -- )  \ set the main clock to 16 MHz (HSI)
  hsi-on
  %01 $4002100C !                    \ revert to HSI16, no PLL   (RCC-CFGR)
  1 $40021000 !                      \ turn off MSI, HSE, and PLL  (RCC-CR)
  0 bit $40022000 bic!               \ Set the flash latency to 0 WS  (FLASH-ACR)
  16000000 clock-hz ! 
  us/cycl-factor ;

: 32MHz ( -- )  \ set the main clock to 32 MHz, using the PLL
  hsi-on
  %01 $4002100C !                             \ revert to HSI16, no PLL, no prescalers   (RCC-CFGR)
  1 $40021000 !                               \ turn off MSI, HSE, and PLL  (RCC-CR)
  \ brute force already set to zero two lines above!
  $4002100C dup @ %1111 4 lshift bic swap !   \ RCC_CFGR_HPRE_NODIV   (RCC-CFGR)
  24 bit $40021000 bic!                       \ clear RCC_CR_PLLON  (RCC-CR)
  begin 25 bit $40021000 bit@ not until       \ wait for PLLRDY to clear  (RCC-CR)
  0 bit $40022000 bis!                        \ Set the flash latency to 1 WS  (FLASH-ACR)
  16 bit $4002100C bic!                       \ set PLL src HSI16   (RCC-CFGR)
  $4002100C dup @ %1111 18 lshift bic %0001 18 lshift or swap ! \ set PLL mulitplier 4   (RCC-CFGR)
  $4002100C dup @ %11 22 lshift bic %01 22 lshift or swap !     \ set PLL divisor 2   (RCC-CFGR)
  24 bit $40021000 bis!                       \ set RCC_CR_PLLON  (RCC-CR)
  begin 25 bit $40021000 bit@ until           \ wait for PLLRDY  (RCC-CR)
  $4002100C dup @ %11 or swap !               \ set system clk source PLL   (RCC-CFGR)
  32000000 clock-hz ! 
  us/cycl-factor ;

0 variable ticks

: ++ticks ( -- ) 1 ticks +! ;  \ for use as systick irq handler

: systick-hz ( u -- )  \ enable systick interrupt at given frequency
  ['] ++ticks irq-systick !
  clock-hz @ swap /  1- $E000E014 !  7 $E000E010 ! ;
: systick-hz? ( -- u ) \ derive current systick frequency from clock
  clock-hz @  $E000E014 @ 1+  / ;

: micros ( -- u )  \ return elapsed microseconds, this wraps after some 2000s
  \ get current ticks and systick, spinloops if ticks changed while we looked
  begin ticks @ $E000E018 @ over ticks @ <> while 2drop repeat
  \ ticks @ $E000E018 @
  $E000E014 @ 1+ swap -  \ convert down-counter to remaining
  us/cycle*2^16 @ * 16 rshift
  swap 1000 * + ;

: millis ( -- u )  \ return elapsed milliseconds, this wraps after 49 days
  ticks @ ;

: us ( n -- )  \ microsecond delay using a busy loop, this won't switch tasks
  3 -  \ adjust for approximate overhead of this code itself
  micros +  begin dup micros - 0< until  drop ;

: ms ( n -- )  \ millisecond delay, multi-tasker aware (may switch tasks!)
  millis +  begin millis over - 0< while pause repeat  drop ;

\ : j0 micros 1000000 0 do 1 us loop micros swap - . ;
\ : j1 micros 1000000 0 do 5 us loop micros swap - . ;
\ : j2 micros 1000000 0 do 10 us loop micros swap - . ;
\ : j3 micros 1000000 0 do 20 us loop micros swap - . ;
\ : jn j0 j1 j2 j3 ;  \ sample results: 4065044 5988036 10542166 20833317

\ emulate c, which is not available in hardware on some chips.
\ copied from Mecrisp's common/charcomma.txt
0 variable c,collection

: c, ( c -- )  \ emulate c, with h,
  c,collection @ ?dup if $FF and swap 8 lshift or h,
                         0 c,collection !
                      else $100 or c,collection ! then ;

: calign ( -- )  \ must be called to flush after odd number of c, calls
  c,collection @ if 0 c, then ;

: list ( -- )  \ list all words in dictionary, short form
  cr dictionarystart begin
    dup 6 + ctype space
  dictionarynext until drop ;
