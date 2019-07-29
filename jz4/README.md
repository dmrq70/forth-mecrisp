This code runs on the JeeNode Zero revision 4.

## Low power

On regular power-up, the boards takes about 6mA.  The LED takes about 1.5mA,
lowering from 16MHz to 2.1MHz saves also about 1.5mA. (All on 5V through the
regulator.)

Trying low power sleep (waking up on LPTIMER), with the "factory" firmware,
tested with `flib/stm32l0/sleep-extra.fs` code, I got cca 11-12uA consumption in
sleep, with 5V source through the regulator. However powering the regulator
with 3.3V and sleep gives about 22uA consumption.  Powering with 3.3V directly
to the "battery" pin asks for the 12-15uA of power (seems to be a tad higher
with TX/RX pins connected).

There is a [blog post](https://jeelabs.org/article/1652b/) in which jcw
measures power consumption. Roughly the same numbers as here, except the
very low power stuff is reported lower: 6.5uA with the setup as above
and 3uA with GPIOs in Hi-Z. Well. (Switching GPIO to Hi-Z mode does save
about 3uA.)
He reports that the regulator takes 0.5uA, and the radio in sleep 0.1uA.

Hm. I think most of the extra consumption I see on my jz4 is actually consumed
by the regulator: Directly powering an L041 (on my sbo board) with no regulator
in sight gives about 2uA consumption in sleep on 3.3V; powering my bat board
with L052 through a different regulator (NCV8170) with 5V yields about 4uA in
sleep.

I mean 11-12uA through the regulator is not too bad, but this needs
either LiPo or 3 AA or something like that. For a direct supply to `vdd`
(like a CR2032 coin cell or 2 AA), the best course of action would be
to cut a trace somewher between the regulator and `vdd`. This is hard
to undo. Or just accept 15uA consumption, this is still fine for a year
on a CR2032.


## Credits

Most of the code here comes, one way or another, from jcw's [embello] repo.

[embello]: https://git.jeelabs.org/jcw/embello
