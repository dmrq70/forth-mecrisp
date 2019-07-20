
## Power consumption

Without external crystal, i.e. ACLK clocked from the internal REFOCLK (32768kHz), the lowest
I could get was 17uA. The only way to go to 1-2uA range was lpm4 with ACLK off (and then
of course it doesn't wake up by a timer).

I'm getting faults from the external crystal (?).
