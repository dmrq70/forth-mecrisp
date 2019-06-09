This code runs on the JeeNode Zero revision 4.

## Low power

On regular power-up, the boards takes about 6mA.  The LED takes about 1.5mA,
lowering from 16MHz to 2.1MHz saves also about 1.5mA. (All on 5V through the
regulator.)

Trying low power sleep (waking up on LPTIMER), with the "factory" firmware,
tested with `flib/stm32l0/sleep-extra.fs` code, I got cca 9-10uA consumption in
sleep, with 5V source through the regulator (this is 15uA on 3.3V). However
powering the regulator with 3.3V and sleep gives about 22uA consumption.
Powering with 3.3V directly to the "battery" pin asks for the 12-15uA of power
(seems to be a tad higher with TX/RX pins connected) - so the regulator has
very very low ground power, and doesn't seem to mind back-powering too much.
Overall, this is pretty sweet.

