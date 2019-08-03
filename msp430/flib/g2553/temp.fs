\ Measure temperature on analog channel 10.
: temp.
  0
  0.  200 0 do 10 adc-1.5 0 d+ loop 200 um/mod nip  \ Average 200 measurements with 1.5V reference because of strong noise.
  0,41263 f* 280,28 d- 2 f.n ." °C "                 \ Calculate uncalibrated temperature...
;

