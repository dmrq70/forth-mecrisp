\ rf69 driver
\ from jcw's embello
\ modified radio settings to match the ones I'm using on AVR devices
\   - jcw's are interoperable to some extent: the packets get through
\     but not very reliably
\ uses spi

       $00 constant RF:FIFO
       $01 constant RF:OP
       $07 constant RF:FRF
       $11 constant RF:PA
       $18 constant RF:LNA
       $1F constant RF:AFC
       $24 constant RF:RSSI
       $27 constant RF:IRQ1
       $28 constant RF:IRQ2
       $2F constant RF:SYN1
       $31 constant RF:SYN3
       $39 constant RF:ADDR
       $3A constant RF:BCAST
       $3C constant RF:THRESH
       $3D constant RF:PCONF2
       $3E constant RF:AES

0 2 lshift constant RF:M_SLEEP
1 2 lshift constant RF:M_STDBY
2 2 lshift constant RF:M_FS
3 2 lshift constant RF:M_TX
4 2 lshift constant RF:M_RX

       $C2 constant RF:START_TX
       $42 constant RF:STOP_TX
       $80 constant RF:RCCALSTART

     7 bit constant RF:IRQ1_MRDY
     6 bit constant RF:IRQ1_RXRDY
     3 bit constant RF:IRQ1_RSSI
     2 bit constant RF:IRQ1_TIMEOUT
     0 bit constant RF:IRQ1_SYNC

     6 bit constant RF:IRQ2_FIFO_NE
     3 bit constant RF:IRQ2_SENT
     2 bit constant RF:IRQ2_RECVD
     1 bit constant RF:IRQ2_CRCOK

   0 variable rf.mode  \ last set chip mode
   0 variable rf.last  \ flag used to fetch RSSI only once per packet
   0 variable rf.rssi  \ RSSI signal strength of last reception
   0 variable rf.lna   \ Low Noise Amplifier setting (set by AGC)
   0 variable rf.afc   \ Auto Frequency Control offset
  66 buffer:  rf.buf   \ buffer with last received packet data

8683 variable rf.freq    \ frequency (auto-scaled to 100..999 MHz)
  42 variable rf.group   \ network group (1..250)
  61 variable rf.nodeid  \ node ID of this node (1..63)

create rf:init  \ initialise the radio, each 16-bit word is <reg#,val>
hex
  0200 h, \ packet mode, fsk
  0302 h, 048A h, \ bit rate 49,261 hz
  0502 h, 06E1 h, \ 45 kHz Fdev
  0B20 h, \ low M
  194A h, 1A42 h, \ RxBw 100khz, AFCBw 125khz
  1E0C h, \ AFC auto-clear, auto-on
  2607 h, \ disable clkout
  29A0 h, \ RSSI thres -80dB
  2B40 h, \ RSSI timeout after 128 bytes
  2D05 h, \ Preamble 5 bytes
  2E90 h, \ sync size 3 bytes
  2FAA h, \ sync1: 0xAA -- this is really the last preamble byte
  302D h, \ sync2: 0x2D -- actual sync byte
  312A h, \ sync3: network group
  37D0 h, \ drop pkt if CRC fails \ 37D8 h, \ deliver even if CRC fails
  3842 h, \ max 62 byte payload
  3C8F h, \ fifo thres
  3D12 h, \ PacketConfig2, interpkt = 1, autorxrestart on
  6F20 h, \ Test DAGC
  7102 h, \ RegTestAfc
  0 h,  \ sentinel
decimal align

\ r/w access to the RF registers
: rf!@ ( b reg -- b ) +spi >spi >spi> -spi ;
: rf! ( b reg -- ) $80 or rf!@ drop ;
: rf@ ( reg -- b ) 0 swap rf!@ ;

: rf-h! ( h -- ) dup $FF and swap 8 rshift rf! ;

: rf!mode ( b -- )  \ set the radio mode, and store a copy in a variable
  dup rf.mode !
  RF:OP rf@  $E3 and  or RF:OP rf!
  begin  RF:IRQ1 rf@  RF:IRQ1_MRDY and  until ;

: rf-config! ( addr -- ) \ load many registers from <reg,value> array, zero-terminated
  RF:M_STDBY rf!mode \ some regs don't program in sleep mode, go figure...
  begin  dup h@  ?dup while  rf-h!  2+ repeat drop
  ;

: rf-freq ( u -- )  \ set the frequency, supports any input precision
  begin dup 100000000 < while 10 * repeat
  ( f ) 2 lshift  32000000 11 rshift u/mod nip  \ avoid / use u/ instead
  ( u ) dup 10 rshift  RF:FRF rf!
  ( u ) dup 2 rshift  RF:FRF 1+ rf!
  ( u ) 6 lshift RF:FRF 2+ rf!
  ;

: rf-group ( u -- ) RF:SYN3 rf! ;  \ set the net group (1..250)

: rf-check ( b -- )  \ check that the register can be accessed over SPI
  begin  dup RF:SYN1 rf!  RF:SYN1 rf@  over = until
  drop ;

: rf-ini ( group freq -- )  \ internal init of the RFM69 radio module
  spi-init
  $AA rf-check  $55 rf-check  \ will hang if there is no radio!
  rf:init rf-config!
  rf-freq rf-group ;

\ rf-rssi checks whether the rssi bit is set in IRQ1 reg and sets the LED to match.
\ It also checks whether there is an rssi timeout and restarts the receiver if so.
: rf-rssi ( -- )
  RF:IRQ1 rf@
  dup RF:IRQ1_RSSI and 3 rshift 1 swap - LED io!
  dup RF:IRQ1_TIMEOUT and if
      RF:M_FS rf!mode
    then
  drop ;

\ rf-timeout checks whether there is an rssi timeout and restarts the receiver if so.
: rf-timeout ( -- )
  RF:IRQ1 rf@ RF:IRQ1_TIMEOUT and if
    RF:M_FS rf!mode
  then ;

\ rf-status fetches the IRQ1 reg, checks whether rx_sync is set and was not set
\ in rf.last. If so, it saves rssi, lna, and afc values; and then updates rf.last.
\ rf.last ensures that the info is grabbed only once per packet.
: rf-status ( -- )  \ update status values on sync match
  RF:IRQ1 rf@  RF:IRQ1_SYNC and  rf.last @ <> if
    rf.last  RF:IRQ1_SYNC over xor!  @ if
      RF:RSSI rf@  rf.rssi !
      RF:LNA rf@  3 rshift  7 and  rf.lna !
      RF:AFC rf@  8 lshift  RF:AFC 1+ rf@  or rf.afc !
    then
  then ;

: rf-n@spi ( addr len -- )  \ read N bytes from the FIFO
  0 do  RF:FIFO rf@ over c! 1+  loop drop ;
: rf-n!spi ( addr len -- )  \ write N bytes to the FIFO
  0 do  dup c@ RF:FIFO rf! 1+  loop drop ;

: rf-parity ( -- u )  \ calculate group parity bits
  RF:SYN3 rf@ dup 4 lshift xor dup 2 lshift xor $C0 and ;

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

: rf-recv ( -- b )  \ check whether a packet has been received, return #bytes
  rf.mode @ RF:M_RX <> if
    0 rf.rssi !  0 rf.afc !
    RF:M_RX rf!mode
  else rf-rssi rf-status then
  RF:IRQ2 rf@  RF:IRQ2_CRCOK and if
    RF:FIFO rf@ 66 min \ fetch length and limit
    rf.buf over rf-n@spi
  else 0 then ;

: rf-ack? ( ms -- b ) \ waits ms milliseconds for an ACK and returns #bytes recv'd
  0 rf.rssi !  0 rf.afc !
  RF:M_RX rf!mode
  0 do
    rf-status \ capture rssi, afc etc.
    RF:IRQ2 rf@  RF:IRQ2_CRCOK and if
      RF:FIFO rf@ 66 min \ fetch length and limit
      rf.buf over rf-n@spi
      unloop exit
    then
    1 ms
  loop
  RF:M_STDBY rf!mode \ kill RX
  0 ;

: rf-send ( addr count hdr -- )  \ send out one packet
  RF:M_STDBY rf!mode
  over 2+ RF:FIFO rf!
  dup rf-parity or RF:FIFO rf!
  $C0 and rf.nodeid @ or RF:FIFO rf!
  ( addr count ) rf-n!spi
  RF:M_TX rf!mode
  begin RF:IRQ2 rf@ RF:IRQ2_SENT and until
  RF:M_STDBY rf!mode ;

: rf-init ( -- )  \ init RFM69 with current rf.group and rf.freq values
  rf.group @ rf.freq @ rf-ini ;

: rf-info ( -- )  \ display reception parameters as hex string
  rf.freq @ h.4 rf.group @ h.2 rf.rssi @ h.2 rf.lna @ h.2 rf.afc @ h.4 ;

