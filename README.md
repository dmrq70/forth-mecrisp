Forth code for Mecrisp (Stellaris)
==================================

It is intended for my home environmental sensor collection, and miscellaneous hobbyist devices.
Primarily for [jeenode zero], but for a few of my own boards/variations as well.

Most of the code actually comes from Jean-Claude Wippler's [embello] collection. I've kept the
structure from that repo, so to go back over embello, it is possible to just copy the files into
`explore/1608-forth` directory. There are naturally some changes to some of jcw's code, so
your mileage may vary. I decided not to fork the [embello] repo, because it contains too
much more than just the forth code, and I find it overwhelming.

Since my goal is to have some long-running sensors reporting over RFM69 radios, the focus
is on the `rf69` driver, sensor code (usually over I2C, but sometimes over SPI), and
sleep code.

Also, I bought some STM32L041 chips (TSSOP-20 package), and these buggers only have 32k flash.
So, I found myself minimizing code dependencies (maybe having min/extra sources).


Motivation
----------

I have a bunch of sensors based on 8bit ATMEL/Arduino. While programming in C comes with a lot
of convenience (for me), I found that having to keep track of libraries, megabytes of IDE, 
code-compile-upload-test cycle, etc.. is cumbersome (again, for me). Also, using it for STM32
ARM chips comes with its own gripes (well, it did when I started with STM32 ARM
MCUs, cca 2015). The immediacy of [Mecrisp Stellaris] and the closeness to bare metal holds an
immense appeal (once more, for me).
Just a bunch of text files, immediate interactive testing, no compiler needed. Smashing!

One more thing: the joys of backward compatibility in my setup. I want the RFM69 code to be
able to interoperate with my existing atmega/attiny sensors and the gateway. Fortunately jcw
has already written an amazingly clean/minimal rf69 driver usable in Arduino; just a few
tweaks to radio setup were needed to be able to talk to [jeenode zero] "factory" firmware.
That code is [here][my-jee-sensors]; in particular my gateway is an atmega328p
on pocket beagle - described [here][pb-cape].




[jeenode zero]: https://www.digitalsmarties.net/products/jeenode-zero
[embello]: https://git.jeelabs.org/jcw/embello
[folie]: https://git.jeelabs.org/jcw/folie
[Mecrisp Stellaris]: https://mecrisp.sourceforge.net
[my-jee-sensors]: https://git.drak.xyz/flabbergast/jee-sensors
[pb-cape]: https://flabbergast.drak.xyz/posts/pb-rfmcape
