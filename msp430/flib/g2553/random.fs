: random ( -- u ) 
 ( Generiert Zufallszahlen mit dem Rauschen vom Temperatursensor am ADC )
 ( Random numbers with noise of temperature sensor on ADC )
   0
   16 0 do
     shl
    10 analog 1 and
    xor
  loop
;

