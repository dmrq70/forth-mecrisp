\ generated from template: ./replace-constants.py rf69-rx.template rf69-constants.fs
\ rf69 driver; RX part
\ needs spi
\ needs rf69-tx.fs
\ = 480 bytes flash

   0 variable rf.last  \ flag used to fetch RSSI only once per packet
   0 variable rf.rssi  \ RSSI signal strength of last reception
  66 buffer:  rf.buf   \ buffer with last received packet data

\ rf-timeout checks whether there is an rssi timeout and restarts the receiver if so.
: rf-timeout ( -- )
  $27 rf@ %00000100 and if \ (%00000100:RF:IRQ1_TIMEOUT) \ ($27:RF:IRQ1)
    %01000 rf!mode \ (%01000:RF:M_FS)
  then ;

\ rf-status fetches the IRQ1 reg, checks whether rx_sync is set and was not set
\ in rf.last. If so, it saves rssi value; and then updates rf.last.
\ rf.last ensures that the info is grabbed only once per packet.
: rf-status ( -- )  \ update status values on sync match
  $27 rf@  %00000001 and  rf.last @ <> if \ (%00000001:RF:IRQ1_SYNC) \ ($27:RF:IRQ1)
    rf.last  %00000001 over xor!  @ if \ (%00000001:RF:IRQ1_SYNC)
      $24 rf@  rf.rssi ! \ ($24:RF:RSSI)
    then
  then ;

\ this is the intended public API for the RF69 driver

: rf-recv ( -- b )  \ check whether a packet has been received, return #bytes
  rf.mode @ %10000 <> if \ (%10000:RF:M_RX)
    0 rf.rssi !
    %10000 rf!mode \ (%10000:RF:M_RX)
  else rf-timeout rf-status then
  $28 rf@  %00000010 and if \ (%00000010:RF:IRQ2_CRCOK) \ ($28:RF:IRQ2)
    $00 rf@ 66 min \ fetch length and limit \ ($00:RF:FIFO)
    rf.buf over rf-n@spi
  else 0 then ;

: rf-ack? ( ms -- b ) \ waits ms milliseconds for an ACK and returns #bytes recv'd
  0 rf.rssi !
  %10000 rf!mode \ (%10000:RF:M_RX)
  0 do
    rf-status \ capture rssi, etc.
    $28 rf@  %00000010 and if \ (%00000010:RF:IRQ2_CRCOK) \ ($28:RF:IRQ2)
      $00 rf@ 66 min \ fetch length and limit \ ($00:RF:FIFO)
      rf.buf over rf-n@spi
      unloop exit
    then
    1 ms
  loop
  %00100 rf!mode \ kill RX \ (%00100:RF:M_STDBY)
  0 ;
