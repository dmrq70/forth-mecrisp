compiletoram eint multitask

\ rf-gw.fs
\ by flabbergast
\ behave like a "RF12Demo jeenode gateway sketch":
\  - background task that will print received RFM69 packets in the same format
\    as that arduino sketch
\  - the sending mechanism is different though: here the full mecrisp prompt
\    runs, and sending messages is with "n1 ... to-n gw-send"
\ needs multi rf69

\ --- receiver part ---

: enckey s" beleampanchineto" drop ;

: rf-gw-info ( n -- )
  ." OK " rf.buf 1+ c@ u.
  2- 0 do
    \ [ rf.buf 2 + literal, ] i + c@ u. \ not worth doing literal, compiles better without
    rf.buf 2 + i + c@ u.
  loop
  ."    (RX_RSSI:-" rf.rssi @ 2 / u.2 ." dB) (TO:" rf.buf c@ $3f and u.2 ." ) "
  ." (timestamp:" ticks @ 0 <# #s #> type ." )" cr
  ;

task: rflistentask

: rflistentask& ( -- )
  rflistentask background
    107 rf.group !
    rf-init
    26 rf-power
    enckey rf-encrypt
    0 rf.last !
    begin
      rf-recv ?dup if
        rf-gw-info
      then
      stop
    again ;

: tick-wake ( -- )
  1 ticks +!
  rflistentask wake ;

\ 1000 systick-hz \ already run from board.fs

\ --- sender part ---

63 buffer: gw.sendbuf

: gw-send ( n1 n2 ... to-n -- )
  depth 1- tuck   1- 0 swap do ( ... d to-n -- )
    rot gw.sendbuf i + c!
  -1 +loop
  gw.sendbuf -rot
  dint
  rf-send
  eint
  ;


\ --- run! ---
100 systick-hz  \ only every 10 ms (changes meaning of 'ticks @')
rflistentask&
' tick-wake irq-systick !

\ When I tried this with 1000 systick-hz (i.e. every ms), it didn't quite work
\ as expected. The receive task was always fine, but the boot task (the fprth prompt)
\ froze quite often (non-responsive, but received packets display fine).
\ Usually it was during gw-send, but not every time, and sometimes during other stuff.
\ Didn't manage to find out where and why. (BTW 'tasks' was always showing both active,
\ so I guess the receive task could have been taking too long? - But similar stuff
\ was happening with just a "blink" task, but much less often.)

