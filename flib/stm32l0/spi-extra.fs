\ hardware SPI driver / convenience functions / more-byte-API

$40013000 constant SPI1
     SPI1 $00 + constant SPI1-CR1
     SPI1 $04 + constant SPI1-CR2
     SPI1 $08 + constant SPI1-SR
     SPI1 $0C + constant SPI1-DR
\    SPI1 $10 + constant SPI1-CRCPR
\    SPI1 $14 + constant SPI1-RXCRCR
\    SPI1 $18 + constant SPI1-TXCRCR


: spi? ( -- )
  SPI1
  cr ."     CR1 " dup @ hex. 4 +
     ."     CR2 " dup @ hex. 4 +
     ."      SR " dup @ hex. 4 +
     ."      DR " dup @ hex. 4 +
  cr ."   CRCPR " dup @ hex. 4 +
     ."  RXCRCR " dup @ hex. 4 +
     ."  TXCRCR " dup @ hex. drop ;

\ ===== faster SPI for devices that use 2-byte cycles for register+data

\ calculate SPI1-DR from SPI1-CR
: spi1>dr ( spi1-sr -- spi1-dr ) 4 + inline ;
\ wait for tx ready
: spi-txrdy ( spi1-sr -- spi1-sr ) begin dup @ 2 and until inline ;
\ wait for rx ready
: spi-rxrdy ( spi1-sr -- spi1-sr ) begin dup @ 1 and until inline ;
\ wait for rx ready and drop rx byte
: spi-rxdrop ( spi1-sr -- spi1-sr ) begin dup @ 1 and until dup spi1>dr @ drop inline ;
\ push byte into SPI1-DR
: spi-push ( c spi1-sr -- spi1-sr ) swap over spi1>dr ! inline ;
\ push zero into SPI1-DR
: spi-push0 ( spi1-sr -- spi1-sr ) 0 over spi1>dr ! inline ;

: >spi2 ( c reg -- ) \ write register
  +spi SPI1-SR ( c reg spi1-sr )
  spi-push spi-rxdrop
  spi-push spi-rxrdy
  spi1>dr @ drop
  -spi
  ;

: spi2> ( reg -- c ) \ read register
  +spi SPI1-SR ( reg spi1-sr )
  spi-push spi-rxdrop ( spi1-sr )
  spi-push0 spi-rxrdy ( spi1-sr )
  spi1>dr @ ( c )
  -spi
  ;

: >spiN ( addr len reg -- ) \ write len bytes to reg
  +spi
  SPI1-SR spi-push ( addr len spi1-sr )
  swap 0 ?do
    over c@ ( addr spi1-sr c )
    swap spi-rxdrop ( addr c spi1-sr )
    spi-push ( addr spi1-sr )
    swap 1+ swap ( addr+1 spi1-sr )
  loop
  nip spi-rxdrop drop -spi
  ;

: spiN> ( addr len reg -- ) \ read len bytes from reg
  +spi
  SPI1-SR spi-push spi-rxdrop ( addr len spi1-sr )
  swap 0 ?do ( addr spi1-sr )
    spi-push0
    spi-rxrdy
    dup spi1>dr @ ( addr spi1-sr c )
    rot dup 1+ ( spi1-sr c addr addr+1 )
    -rot c! ( spi1-sr addr+1 )
    swap
  loop
  2drop -spi
  ;

