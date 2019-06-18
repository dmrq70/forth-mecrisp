\ hex output and dump utilities
\ from jcw's embello
\ adapted from mecrisp 2.0.2 (GPL3)

: u.4 ( u -- ) 0 <# # # # # #> type ;
: u.2 ( u -- ) 0 <# # # #> type ;

: h.4 ( u -- ) base @ hex swap  u.4  base ! ;
: h.2 ( u -- ) base @ hex swap  u.2  base ! ;

\ adapted from mecrisp-stellaris 2.2.1a (GPL3)

: dump16 ( addr -- )  \ print 16 bytes memory
  $F bic
  dup hex. 2 spaces

  dup #16 + over do
    i c@ h.2 space  \ Print data with 2 digits
    i $F and 7 = if 2 spaces then
  loop

  2 spaces

  dup 16 + swap do
        i c@ $20 u>= i c@ $7F u< and if i c@ else [char] . then emit
        i $F and 7 = if space then
      loop

  cr
;

: dump ( addr len -- )  \ print a memory region
  cr
  over $F and if #16 + then  \ one more line if not aligned on 16
  begin
    swap ( len addr )
    dup dump16
    #16 + ( len addr+16 )
    swap #16 - ( addr+16 len-16 )
    dup 0 <=
  until
  2drop
;
