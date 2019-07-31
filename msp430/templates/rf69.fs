\ rf69 driver; this file contains both tx and rx parts (splittable)
\   - slightly modified version of a pretty smart jcw's driver:
\       https://git.jeelabs.org/jcw/embello
\   - mainly some 32 vs 16 bit fixes
\   - frequency is hardcoded and non-correctable
\   - for the names of registers and bits see the fancy driver
\ needs spi
\ generate constant-free source with:
\ python replace-constants.py rf69.fs rf69-constants.fs
\ = 1762 bytes in flash

\ TX part

   0 variable rf.mode  \ last set chip mode
   0 variable rf.last  \ flag used to fetch RSSI only once per packet
   0 variable rf.rssi  \ RSSI signal strength of last reception
  66 buffer:  rf.buf   \ buffer with last received packet data

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
  RF:OP rf@  $E3 and  or $01 rf!
  begin  RF:IRQ1 rf@  RF:IRQ1_MRDY and  until ;

: rf-config! ( addr -- ) \ load many registers from <reg,value> array, zero-terminated
  RF:M_STDBY rf!mode \ some regs don't program in sleep mode, go figure...
  begin  dup @  ?dup while  rf-h!  2+ repeat drop
  ;

: rf-group ( u -- ) RF:SYN3 rf! ;  \ set the net group (1..250)

: rf-check ( b -- )  \ check that the register can be accessed over SPI
  begin  dup RF:SYN1 rf!  RF:SYN1 rf@  over = until
  drop ;

: rf-ini ( group -- )  \ internal init of the RFM69 radio module
  spi-init
  $AA rf-check  $55 rf-check  \ will hang if there is no radio!
  rf:init rf-config!
  rf-group ;

: rf-parity ( -- u )  \ calculate group parity bits
  RF:SYN3 rf@ dup 4 lshift xor dup 2 lshift xor $C0 and ;

: rf-n@spi ( addr len -- )  \ read N bytes from the FIFO
  0 do  RF:FIFO rf@ over c! 1+  loop drop ;
: rf-n!spi ( addr len -- )  \ write N bytes to the FIFO
  0 do  dup c@ RF:FIFO rf! 1+  loop drop ;

\ this is the intended public API for the RF69 driver

: rf-power ( n -- )  \ change TX power level (0..31)
  RF:PA rf@ $E0 and or RF:PA rf! ;

: rf-sleep ( -- ) RF:M_SLEEP rf!mode ;  \ put radio module to sleep

: rf-encrypt ( addr -- ) \ load 16 bytes as AES password, enable encryption
  RF:AES 16 + RF:AES do  \ loop by register addr
    dup c@ dup i rf!  \ write one, leave ( addr b )
    if 1+ then  \ if b <> 0, advance addr
    loop drop
  RF:PCONF2 rf@ 1 or  RF:PCONF2 rf! ;

: rf-deencrypt ( -- ) \ clear encryption
  RF:PCONF2 rf@ $FE and  RF:PCONF2 rf! ;

: rf-send ( addr count hdr -- )  \ send out one packet
  RF:M_STDBY rf!mode
  over 2+ RF:FIFO rf!
  dup rf-parity or RF:FIFO rf!
  $C0 and rf.nodeid @ or RF:FIFO rf!
  ( addr count ) rf-n!spi
  RF:M_TX rf!mode
  begin RF:IRQ2 rf@ RF:IRQ2_SENT and until
  RF:M_STDBY rf!mode ;

: rf-init ( -- )  \ init RFM69 with current rf.group
  rf.group @ rf-ini ;

: rf-info ( -- )  \ display reception parameters as hex string
  rf.group @ h.2 rf.rssi @ h.2 ;


\ RX part

\ rf-timeout checks whether there is an rssi timeout and restarts the receiver if so.
: rf-timeout ( -- )
  RF:IRQ1 rf@ RF:IRQ1_TIMEOUT and if
    RF:M_FS rf!mode
  then ;

\ rf-status fetches the IRQ1 reg, checks whether rx_sync is set and was not set
\ in rf.last. If so, it saves rssi value; and then updates rf.last.
\ rf.last ensures that the info is grabbed only once per packet.
: rf-status ( -- )  \ update status values on sync match
  RF:IRQ1 rf@  RF:IRQ1_SYNC and  rf.last @ <> if
    rf.last  RF:IRQ1_SYNC over xor!  @ if
      RF:RSSI rf@  rf.rssi !
    then
  then ;

\ this is the intended public API for the RF69 driver

: rf-recv ( -- b )  \ check whether a packet has been received, return #bytes
  rf.mode @ RF:M_RX <> if
    0 rf.rssi !
    RF:M_RX rf!mode
  else rf-timeout rf-status then
  RF:IRQ2 rf@  RF:IRQ2_CRCOK and if
    RF:FIFO rf@ 66 min \ fetch length and limit
    rf.buf over rf-n@spi
  else 0 then ;

: rf-ack? ( ms -- b ) \ waits ms milliseconds for an ACK and returns #bytes recv'd
  0 rf.rssi !
  RF:M_RX rf!mode
  0 do
    rf-status \ capture rssi, etc.
    RF:IRQ2 rf@  RF:IRQ2_CRCOK and if
      RF:FIFO rf@ 66 min \ fetch length and limit
      rf.buf over rf-n@spi
      unloop exit
    then
    1 ms
  loop
  RF:M_STDBY rf!mode \ kill RX
  0 ;
