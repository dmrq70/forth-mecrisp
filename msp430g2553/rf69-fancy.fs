\ rf69 driver; this file contains both tx and rx parts (splittable)

\ rf69 driver (tx part)
\ needs spi
\ (very slightly modified version of a pretty smart jcw's driver: https://git.jeelabs.org/jcw/embello)
\ = 1484 bytes in flash
\ this is the 'tx half' of the fancy version of the driver, which supports
\   automatic frequency adjustments based on AFC of received packets
\   note: MSP430 is 16bit, so rf.freq is a double number!

compiletoflash

\       $00 constant RF:FIFO
\       $01 constant RF:OP
\       $07 constant RF:FRF
\       $11 constant RF:PA
\       $18 constant RF:LNA
\       $1F constant RF:AFC
\       $24 constant RF:RSSI
\       $27 constant RF:IRQ1
\       $28 constant RF:IRQ2
\       $2F constant RF:SYN1
\       $31 constant RF:SYN3
\       $39 constant RF:ADDR
\       $3A constant RF:BCAST
\       $3C constant RF:THRESH
\       $3D constant RF:PCONF2
\       $3E constant RF:AES

\ 0 2 lshift constant RF:M_SLEEP
\ 1 2 lshift constant RF:M_STDBY
\ 2 2 lshift constant RF:M_FS
\ 3 2 lshift constant RF:M_TX
\ 4 2 lshift constant RF:M_RX

\       $C2 constant RF:START_TX
\       $42 constant RF:STOP_TX
\       $80 constant RF:RCCALSTART

\     7 bit constant RF:IRQ1_MRDY
\     6 bit constant RF:IRQ1_RXRDY
\     3 bit constant RF:IRQ1_RSSI
\     2 bit constant RF:IRQ1_TIMEOUT
\     0 bit constant RF:IRQ1_SYNC

\     6 bit constant RF:IRQ2_FIFO_NE
\     3 bit constant RF:IRQ2_SENT
\     2 bit constant RF:IRQ2_RECVD
\     1 bit constant RF:IRQ2_CRCOK

   0 variable rf.mode  \ last set chip mode
   0 variable rf.last  \ flag used to fetch RSSI only once per packet
   0 variable rf.rssi  \ RSSI signal strength of last reception
   0 variable rf.lna   \ Low Noise Amplifier setting (set by AGC)
   0 variable rf.afc   \ Auto Frequency Control offset
  66 buffer:  rf.buf   \ buffer with last received packet data

8683. 2variable rf.freq  \ frequency (auto-scaled to 100..999 MHz)
  42 variable rf.group   \ network group (1..250)
  61 variable rf.nodeid  \ node ID of this node (1..63)

create rf:init  \ initialise the radio, each 16-bit word is <reg#,val>
hex
  0200 , \ packet mode, fsk
  0302 , 048A , \ bit rate 49,261 hz
  0505 , 06C3 , \ 90.3kHzFdev -> modulation index = 2
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
  $01 rf@  $E3 and  or $01 rf!  \  (RF:OP)
  begin  $27 rf@  %10000000 and  until ;  \  (RF:IRQ1_MRDY @ RF:IRQ1)

: rf-config! ( addr -- ) \ load many registers from <reg,value> array, zero-terminated
  %00100 rf!mode \ some regs don't program in sleep mode, go figure...  \  (RF:M_STDBY)
  begin  dup @  ?dup while  rf-h!  2+ repeat drop
  ;

: rf-freq ( ud -- )  \ set the frequency, supports any input precision
  begin 2dup 100000000. d< while 10. udm* 2drop repeat
  ( f ) dshl dshl  15625. ud/mod 2nip  dshl dshl dshl dshl dshl dshl \ avoid / use u/ instead
  ( u,u )  $07 rf!  \  (RF:FRF)
  ( u ) dup 8 rshift  $07 1+ rf!  \  (RF:FRF)
  ( u )  $07 2+ rf!  \  (RF:FRF)
  ;

: rf-group ( u -- ) $31 rf! ;  \ set the net group (1..250)  \  (RF:SYN3)

: rf-check ( b -- )  \ check that the register can be accessed over SPI
  begin  dup $2F rf!  $2F rf@  over = until  \  (RF:SYN1)
  drop ;

: rf-ini ( group d.freq -- )  \ internal init of the RFM69 radio module
  spi-init
  $AA rf-check  $55 rf-check  \ will hang if there is no radio!
  rf:init rf-config!
  rf-freq rf-group ;

: rf-parity ( -- u )  \ calculate group parity bits
  $31 rf@ dup 4 lshift xor dup 2 lshift xor $C0 and ;  \  (RF:SYN3)

: rf-n@spi ( addr len -- )  \ read N bytes from the FIFO
  0 do  $00 rf@ over c! 1+  loop drop ;  \ (RF:FIFO)
: rf-n!spi ( addr len -- )  \ write N bytes to the FIFO
  0 do  dup c@ $00 rf! 1+  loop drop ;  \ (RF:FIFO)

\ this is the intended public API for the RF69 driver

: rf-power ( n -- )  \ change TX power level (0..31)
  $11 rf@ $E0 and or $11 rf! ;  \  (RF:PA)

: rf-sleep ( -- ) %00000 rf!mode ;  \ put radio module to sleep  \  (RF:M_SLEEP)

: rf-encrypt ( addr -- ) \ load 16 bytes as AES password, enable encryption
  $3E 16 + $3E do  \ loop by register addr  \  (RF:AES)
    dup c@ dup i rf!  \ write one, leave ( addr b )
    if 1+ then  \ if b <> 0, advance addr
    loop drop
  $3D rf@ 1 or  $3D rf! ;  \  (RF:PCONF2)

: rf-deencrypt ( -- ) \ clear encryption
  $3D rf@ $FE and  $3D rf! ;  \  (RF:PCONF2)

: rf-send ( addr count hdr -- )  \ send out one packet
  %00100 rf!mode  \  (RF:M_STDBY)
  over 2+ $00 rf!  \ (RF:FIFO)
  dup rf-parity or $00 rf!  \ (RF:FIFO)
  $C0 and rf.nodeid @ or $00 rf!  \ (RF:FIFO)
  ( addr count ) rf-n!spi
  %01100 rf!mode  \  (RF:M_TX)
  begin $28 rf@ %1000 and until  \  (RF:IRQ2_SENT @ RF:IRQ2)
  %00100 rf!mode ;  \  (RF:M_STDBY)

: rf-init ( -- )  \ init RFM69 with current rf.group and rf.freq values
  rf.group @ rf.freq 2@ rf-ini ;

: rf-info ( -- )  \ display reception parameters as hex string
  rf.freq 2@ drop hex. rf.group @ h.2 rf.rssi @ h.2 rf.lna @ h.2 rf.afc @ hex. ;


\ rf69 driver (rx part)
\ needs rf69-tx.fs
\ (very slightly modified version of a pretty smart jcw's driver: https://git.jeelabs.org/jcw/embello)
\ 706 bytes flash
\ this is the 'rx half' of the fancy version of the driver

: rf-correct ( -- ) \ correct the freq based on the AFC measurement of the last packet (rf.freq in Hz!)
  rf.afc @ 61 m*                             \ AFC correction applied in Hz
  d2/ d2/                                    \ apply 1/4 of measured offset as correction
  -5000. 2over d> if 2drop -5000. then       \ don't apply more than |5kHz| (dmix/dmax don't exist)
  5000. 2over d< if 2drop 5000. then
  rf.freq 2@ d+ 2dup rf.freq 2! rf-freq      \ apply correction
  ;

\ rf-rssi checks whether the rssi bit is set in IRQ1 reg and sets the LED to match.
\ It also checks whether there is an rssi timeout and restarts the receiver if so.
: rf-rssi ( -- )
  $27 rf@  \  (RF:IRQ1)
  \ dup %1000 and 3 rshift 1 swap - LED io!  \  (RF:IRQ1_RSSI)
  dup %100 and if  \  (RF:IRQ1_TIMEOUT)
      %01000 rf!mode  \  (RF:M_FS)
    then
  drop ;

\ rf-timeout checks whether there is an rssi timeout and restarts the receiver if so.
: rf-timeout ( -- )
  $27 rf@ %100 and if  \  (RF:IRQ1_TIMEOUT @ RF:IRQ1)
    %01000 rf!mode  \  (RF:M_FS)
  then ;

\ rf-status fetches the IRQ1 reg, checks whether rx_sync is set and was not set
\ in rf.last. If so, it saves rssi, lna, and afc values; and then updates rf.last.
\ rf.last ensures that the info is grabbed only once per packet.
: rf-status ( -- )  \ update status values on sync match
  $27 rf@  %1 and  rf.last @ <> if  \  (RF:IRQ1_SYNC @ RF:IRQ1)
    rf.last  %1 over xor!  @ if  \  (RF:IRQ1_SYNC)
      $24 rf@  rf.rssi !  \  (RF:RSSI)
      $18 rf@  3 rshift  7 and  rf.lna !  \  (RF:LNA)
      $1F rf@  8 lshift  $1F 1+ rf@  or rf.afc !  \  (RF:AFC)
    then
  then ;

\ this is the intended public API for the RF69 driver

: rf-recv ( -- b )  \ check whether a packet has been received, return #bytes
  rf.mode @ %10000 <> if  \  (RF:M_RX)
    0 rf.rssi !  0 rf.afc !
    %10000 rf!mode  \  (RF:M_RX)
  else rf-rssi rf-status then
  $28 rf@  %10 and if  \  (RF:IRQ2_CRCOK @ RF:IRQ2)
    $00 rf@ 66 min \ fetch length and limit  \ (RF:FIFO)
    rf.buf over rf-n@spi
  else 0 then ;

: rf-ack? ( ms -- b ) \ waits ms milliseconds for an ACK and returns #bytes recv'd
  0 rf.rssi !  0 rf.afc !
  %10000 rf!mode  \  (RF:M_RX)
  0 do
    rf-status \ capture rssi, afc etc.
    $28 rf@  %10 and if  \  (RF:IRQ2_CRCOK @ RF:IRQ2)
      $00 rf@ 66 min \ fetch length and limit  \ (RF:FIFO)
      rf.buf over rf-n@spi
      unloop exit
    then
    1 ms
  loop
  %00100 rf!mode \ kill RX  \  (RF:M_STDBY)
  0 ;

compiletoram
