: rtc@ ( -- c c c c c c c )
  $68 i2c-addr 0 >i2c 7 i2c-xfer
  i2c> i2c> i2c> i2c> i2c> i2c> i2c> ;

: rtc! ( c c c c c c c -- nak )
  $68 i2c-addr 0
  >i2c >i2c >i2c >i2c >i2c >i2c >i2c >i2c
  0 i2c-xfer ;

: bin>bcd ( c -- c )
   #10 u/mod #4 lshift or ;

: set-time ( year month date day hour min sec -- )
  >r >r >r >r >r >r
  $00 swap     \ 11 = 4.096 KHz output 00 = no output
  bin>bcd      \ Year 0-99
  r> bin>bcd   \ Month
  r> bin>bcd   \ Date
  r>           \ Day 1-7
  r> bin>bcd   \ Hours
  r> bin>bcd   \ Minutes
  r> bin>bcd   \ Seconds
  rtc!
;

