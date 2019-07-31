The 'lowpower' version needs an external 32768Hz crystal between P2.6 and P2.7 (pins 19 and 18 on MSP430G2553) - because the delays in this one are done with low power sleep, and waking up needs a timer, which needs this external source.

The 'xt1' versions also need an external 32768Hz crystal on the correct pins; this time with loading caps as well.

The current `.hex` files are all with mecrisp-2.0.6a.
