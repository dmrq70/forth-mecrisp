\ read out the BME280 sensor
\ from jcw's embello
\ modified by flabbergast:
\  - for bit-banged i2c driver
\  - computations rewritten for 16bit
\ needs i2c
\ = 2428 bytes flash

\ $76 constant BME.ADDR

: bme-waddr ( -- ) \ start transaction, send write address
  i2c-start $76 shl >i2c drop ;

: bme-raddr ( -- ) \ start transaction, send read address
  i2c-start $76 shl 1+ >i2c drop ;

: bme-reset ( -- ) \ software reset of the bme280
  bme-waddr
  $E0 >i2c drop  $B6 >i2c drop i2c-stop ;

\ : bme-init ( -- nak ) \ init the bme280 into continuous mode
\   i2c-init bme-reset
\   bme-waddr
\   $F2 >i2c     %1 >i2c or
\   $F4 >i2c or  %100111 >i2c or
\   $F5 >i2c or  %10100000 >i2c or
\   i2c-stop ;

: bme-init-sleep ( -- nak ) \ init the bme280 into sleep mode
  i2c-init bme-reset
  bme-waddr
  $F2 >i2c     %1 >i2c or        \ 1x oversampling of humidity
  $F4 >i2c or  %100101 >i2c or   \ forced mode (takes 1 meas), 1x oversampling of tmp and pressure
  $F5 >i2c or  %10100000 >i2c or \ filter off, 1sec interval (unused)
  i2c-stop ;

: bme-sleep ( -- ) \ force bme280 to sleep
  bme-waddr
  $F4 >i2c drop  %100100 >i2c drop  i2c-stop ;

: bme-convert ( -- ms ) \ perform a one-shot forced reading, return ms before data is ready
  bme-waddr
  $F4 >i2c drop  %100101 >i2c drop \ forced mode (takes 1 meas), 1x oversampling of tmp and pressure
  i2c-stop
  10 ;

\ ID is $56,$57 or $58 for BMP, $60 for BME
\ : bme-id ( -- id ) bme-waddr $d0 >i2c drop bme-raddr 1 i2c> i2c-stop ;

  32 buffer: params  \ calibration data
   8 buffer: values  \ last reading
0. 2variable tfine   \ used for p & h compensation

: bme-i2c+ ( addr nak -- addr+1 ) i2c> over c! 1+ ;

: bme-rd ( addr n reg -- addr+n )
  bme-waddr  >i2c drop
  bme-raddr
  1- 0 ?do  0 bme-i2c+  loop
  1 bme-i2c+
  i2c-stop ;

: bme-calib ( -- )
  params
  24 $88 bme-rd
   1 $A1 bme-rd
   7 $E1 bme-rd
  drop ;

: bme-data ( -- )  \ get a sensor reading from the BME280
  values  8 $F7 bme-rd drop ;

: bme-u8 ( off -- val ) params + c@ ;
: bme-16 ( off -- val ) dup bme-u8 swap 1+ bme-u8 8 lshift or ;
: bme-v-u20be ( off -- dval )
  values + dup c@  4 rshift swap
           dup c@ 12 lshift swap 1+
           dup c@  4 lshift swap 1+
               c@  4 rshift  or or swap ;
: bme-v-u16 ( off -- val )
  values + dup c@ 8 lshift swap 1+ c@ or ;

\ : bme-hpt ( -- rawh rawp rawt ) \ orig: but we don't need full values
\   values 6 + dup c@ 8 lshift swap 1+ c@ or  0 bme-u20be  3 bme-u20be ;
: bme-hpt ( -- rawh drawp rawt>>4 )
  6 bme-v-u16  0 bme-v-u20be  3 bme-v-u16 ;

: darshift ( d1 u -- d2 ) 0 do d2/ loop ; \ double arith right shift
: drshift ( d1 u -- d2 ) 0 do dshr loop ; \ double right shift
: *>> ( n1 n2 u -- d ) >r m* r> darshift ;  \ (n1 * n2) >> u
: d*>> ( d1 d2 u -- d ) >r udm* 2drop r> darshift ;  \ (d1 * d2) >> u
: u*>> ( n1 n2 u -- d ) >r um* r> drshift ;  \ (u1 * u2) >> u

\ not completely precise but does the job
: tcalc ( rawt>>4 -- t100 )
  ( T1: ) 0 bme-16 - dup 
  ( T2: ) 2 bme-16 10 *>> rot
  dup 12 *>> drop ( 16bit ) ( T3: ) 4 bme-16 14 *>> d+
  2dup tfine 2! \ really should be signed 19 bits max
  ( 5 * ) 2dup d2* d2* d+
  8 darshift drop ( 16bit )
  ;

: pcalc ( drawp -- dp1 )
  tfine 2@ d2/ 64000. d-                             ( drawp dvar1 )
  2dup d2/ d2/ drop dup 11 *>> drop ( P6: ) 16 bme-16 m* d2/ d2/ ( drawp dvar1 dvar2 )
  2over d2/ drop ( P5: ) 14 bme-16 m* d+             ( drawp dvar1 dvar2 )
  ( P4: ) 0 ( 16<< ) 12 bme-16 d+ 2swap              ( drawp dvar2 dvar1 )
  2dup d2/ d2/ drop dup 13 *>> drop ( P3: ) 10 bme-16 3 *>> ( drawp dvar2 dvar1 dx )
  2swap drop ( P2: ) 8 bme-16 1 *>> d+ 18 darshift   ( drawp dvar2 dvar1 )
  drop 32768 + ( P1: ) 6 bme-16 15 u*>>              ( drawp dvar2 dvar1 )
  2dup d0= not if                                    ( drawp dvar2 dvar1 )
    2rot 1048576. 2swap d- 2rot 12 darshift d- 3125. udm* 2drop ( dvar1 dp )
    2dup d0< if 2swap dshl else dshl 2swap then ud/mod 2nip ( dp )
    2dup 3 darshift drop dup 13 *>> drop ( P9: ) 22 bme-16 12 *>> ( dp dvar1 )
    2over d2/ d2/ drop ( P8: ) 20 bme-16 13 *>>      ( dp dvar1 dvar2 )
    ( P7: ) 18 bme-16 s>d d+ d+ 4 darshift d+        ( dp )
  else 2nip 2nip then ;

: hcalc ( rawh -- h100 )
  tfine 2@ 76800. d- 2>r
  ( >d ) 0 swap dshr dshr \ 14 lshift
  ( H4: ) 28 bme-u8 8 lshift 4 arshift 29 bme-u8 $F and or
  ( >d ) 0 swap dshl dshl dshl dshl d-  \ 20 lshift -
  ( H5: ) 29 bme-16 4 rshift s>d
  2r@ udm* 2drop d- 16384. d+ 15 darshift
  ( H6: ) 31 bme-u8 8 lshift 8 arshift s>d
  2r@ 10 d*>>
  ( H3: ) 27 bme-u8 s>d
  2r> 11 d*>> 32768. d+ 10 d*>> 2097152. d+
  ( H2: ) 25 bme-16 s>d
  udm* 2drop 8192. d+ 14 darshift udm* 2drop
  2dup 15 darshift 2dup 7 d*>>
  ( H1: ) 24 bme-u8 s>d 4 d*>> d-  
  2dup d0< if 2drop 0 0 then \ no dmax
  2dup 419430400. d> if 2drop 419430400. then \ no dmin
  12 darshift
  100. udm* 2drop  512. d+ 10 darshift  \ convert 1/1024's to 1/100's, w/ rounding
  drop ( d>s )
;

: bme-calc ( -- h dp t )  \ convert reading to calibrated values
  bme-hpt tcalc >r pcalc rot hcalc -rot r> ;

\ bme-init .
\ bme-calib params 32 dump
\ bme-data bme-calc . d. .

\ bme-init-sleep .
\ bme-calib
\ bme-convert ms bme-data
\ bme-calc . d. .
