\ rf69 driver; RX part
\ needs spi
\ needs rf69-tx.fs
\ generate constant-free source with:
\ python replace-constants.py rf69-rx.fs rf69-constants.fs
\ = 480 bytes flash

   0 variable rf.last  \ flag used to fetch RSSI only once per packet
   0 variable rf.rssi  \ RSSI signal strength of last reception
  66 buffer:  rf.buf   \ buffer with last received packet data

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
