\ rf69 driver constants

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

   %00000 constant RF:M_SLEEP
   %00100 constant RF:M_STDBY
   %01000 constant RF:M_FS
   %01100 constant RF:M_TX
   %10000 constant RF:M_RX

      $C2 constant RF:START_TX
      $42 constant RF:STOP_TX
      $80 constant RF:RCCALSTART

%10000000 constant RF:IRQ1_MRDY
%01000000 constant RF:IRQ1_RXRDY
%00001000 constant RF:IRQ1_RSSI
%00000100 constant RF:IRQ1_TIMEOUT
%00000001 constant RF:IRQ1_SYNC

%01000000 constant RF:IRQ2_FIFO_NE
%00001000 constant RF:IRQ2_SENT
%00000100 constant RF:IRQ2_RECVD
%00000010 constant RF:IRQ2_CRCOK

