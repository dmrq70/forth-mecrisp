\ generated from template: ./replace_constants.py -i rf69-tx.template rf69-constants.fs
\ rf69 driver; TX part
\ needs spi
\ = 1092 bytes flash

   0 variable rf.mode    \ last set chip mode

  42 variable rf.group   \ network group (1..250)
  61 variable rf.nodeid  \ node ID of this node (1..63)

create rf:init  \ initialise the radio, each 16-bit word is <reg#,val>
hex
  0200 , \ packet mode, fsk
  0302 , 048A , \ bit rate 49,261 hz
  0505 , 06C3 , \ 90.3kHzFdev -> modulation index = 2
  07D9 , 0813 , 0900 , \ 868.3MHz frequency ( freq[Hz] * 2^19 / 32*10^6, MSB )
  0B20 , \ low M
  1942 , 1A42 , \ RxBw 125khz, AFCBw 125khz
  1E0C , \ AFC auto-clear, auto-on
  2607 , \ disable clkout
  29C4 , \ RSSI thres -98dB
  2B40 , \ RSSI timeout after 128 bytes
  2D05 , \ Preamble 5 bytes
  2E90 , \ sync size 3 bytes
  2FAA , \ sync1: 0xAA -- this is really the last preamble byte
  302D , \ sync2: 0x2D -- actual sync byte
  312A , \ sync3: network group
  37D0 , \ drop pkt if CRC fails \ 37D8 h, \ deliver even if CRC fails
  3842 , \ max 62 byte payload
  3C8F , \ fifo thres
  3D12 , \ PacketConfig2, interpkt = 1, autorxrestart on
  6F20 , \ Test DAGC
  7102 , \ RegTestAfc
  0 ,  \ sentinel
decimal align

\ r/w access to the RF registers
: rf!@ ( b reg -- b ) +spi >spi >spi> -spi ;
: rf! ( b reg -- ) $80 or rf!@ drop ;
: rf@ ( reg -- b ) 0 swap rf!@ ;

: rf-h! ( h -- ) dup $FF and swap 8 rshift rf! ;

: rf!mode ( b -- )  \ set the radio mode, and store a copy in a variable
  dup rf.mode !
  $01 ( RF:OP ) rf@  $E3 and  or $01 rf!
  begin  $27 ( RF:IRQ1 ) rf@  %10000000 ( RF:IRQ1_MRDY ) and  until ;

: rf-config! ( addr -- ) \ load many registers from <reg,value> array, zero-terminated
  %00100 ( RF:M_STDBY ) rf!mode \ some regs don't program in sleep mode, go figure...
  begin  dup @  ?dup while  rf-h!  2+ repeat drop
  ;

: rf-group ( u -- ) $31 ( RF:SYN3 ) rf! ;  \ set the net group (1..250)

: rf-check ( b -- )  \ check that the register can be accessed over SPI
  begin  dup $2F ( RF:SYN1 ) rf!  $2F ( RF:SYN1 ) rf@  over = until
  drop ;

: rf-ini ( group -- )  \ internal init of the RFM69 radio module
  spi-init
  $AA rf-check  $55 rf-check  \ will hang if there is no radio!
  rf:init rf-config!
  rf-group ;

: rf-parity ( -- u )  \ calculate group parity bits
  $31 ( RF:SYN3 ) rf@ dup 4 lshift xor dup 2 lshift xor $C0 and ;

: rf-n@spi ( addr len -- )  \ read N bytes from the FIFO
  0 do  $00 ( RF:FIFO ) rf@ over c! 1+  loop drop ;
: rf-n!spi ( addr len -- )  \ write N bytes to the FIFO
  0 do  dup c@ $00 ( RF:FIFO ) rf! 1+  loop drop ;

\ this is the intended public API for the RF69 driver

: rf-power ( n -- )  \ change TX power level (0..31)
  $11 ( RF:PA ) rf@ $E0 and or $11 ( RF:PA ) rf! ;

: rf-sleep ( -- ) %00000 ( RF:M_SLEEP ) rf!mode ;  \ put radio module to sleep

: rf-encrypt ( addr -- ) \ load 16 bytes as AES password, enable encryption
  $3E ( RF:AES ) 16 + $3E ( RF:AES ) do  \ loop by register addr
    dup c@ dup i rf!  \ write one, leave ( addr b )
    if 1+ then  \ if b <> 0, advance addr
    loop drop
  $3D ( RF:PCONF2 ) rf@ 1 or  $3D ( RF:PCONF2 ) rf! ;

: rf-deencrypt ( -- ) \ clear encryption
  $3D ( RF:PCONF2 ) rf@ $FE and  $3D ( RF:PCONF2 ) rf! ;

: rf-send ( addr count hdr -- )  \ send out one packet
  %00100 ( RF:M_STDBY ) rf!mode
  over 2+ $00 ( RF:FIFO ) rf!
  dup rf-parity or $00 ( RF:FIFO ) rf!
  $C0 and rf.nodeid @ or $00 ( RF:FIFO ) rf!
  ( addr count ) rf-n!spi
  %01100 ( RF:M_TX ) rf!mode
  begin $28 ( RF:IRQ2 ) rf@ %00001000 ( RF:IRQ2_SENT ) and until
  %00100 ( RF:M_STDBY ) rf!mode ;

: rf-init ( -- )  \ init RFM69 with current rf.group
  rf.group @ rf-ini ;

