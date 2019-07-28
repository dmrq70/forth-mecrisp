## Power consumption

Without external crystal, i.e. ACLK and FLL clocked from the internal REFOCLK
(32.768kHz), the lowest I could get was 17uA. The only way to go to 1-2uA range
was lpm4 with all clocks off (and then of course it doesn't wake up by a
timer). (I found it in the datasheet eventually, REFO on this chip takes
15-16uA. This seems to be pretty much the same across the whole FR range,
with the exception of the newer and bigger ones (e.g. FR2476) - some of them
have 'low power' setting for REFO, and in some REFO eats only 1uA.)

2019-07-24: Finally made it work with the external 32.768kHz crystal; there are
some comments (and a lot of rubbish) in `test-pwr.fs`. 
