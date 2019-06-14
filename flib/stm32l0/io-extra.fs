\ I/O pin primitives / convenience functions

$50000000 constant GPIO-BASE
      $00 constant GPIO.MODER   \ Reset 0 Port Mode Register
                                \   00=Input  01=Output  10=Alternate  11=Analog
      $04 constant GPIO.OTYPER  \ Reset 0 Port Output type register
                                \   (0) Push/Pull vs. (1) Open Drain
      $08 constant GPIO.OSPEEDR \ Reset 0 Output Speed Register
                                \   00=2 MHz  01=25 MHz  10=50 MHz  11=100 MHz
      $0C constant GPIO.PUPDR   \ Reset 0 Pullup / Pulldown 
                                \   00=none  01=Pullup  10=Pulldown
      $10 constant GPIO.IDR     \ RO      Input Data Register
      $14 constant GPIO.ODR     \ Reset 0 Output Data Register
      $18 constant GPIO.BSRR    \ WO      Bit set/reset register
      $20 constant GPIO.AFRL    \ Reset 0 Alternate function  low register
      $24 constant GPIO.AFRH    \ Reset 0 Alternate function high register

: io. ( pin -- )  \ display readable GPIO registers associated with a pin
  cr
   ." PIN " dup io#  dup .  10 < if space then
  ." PORT " dup io-port [char] A + emit
  io-base
    ."   MODER " dup @ hex. 4 +
  ."    OTYPER " dup @ h.4  4 +
  ."   OSPEEDR " dup @ hex. 4 +
      ."  PUPD " dup @ hex. 4 +
  cr 14 spaces
       ."  IDR " dup @ h.4  4 +
       ."  ODR " dup @ h.4  12 +
    ."    AFRL " dup @ hex. 4 +
       ." AFRH " dup @ hex. drop ;

