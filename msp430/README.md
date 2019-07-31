# MSP430

This stuff is supposed to run on [mecrisp] forth on MSP430 chips. Mainly
the _classic_ MSP430G2553, but I've also experimented with the newer
MSP430FR2433 and MSP430FR2476 (there is a Launchpad for both of these).

It is not very well organised, so you'll just need to find your way about it.
I've not "deployed" any actual sensor using this, so ... ymmv.

My main concern (because sensors) is power consumption. So some pros and cons.

### msp430g2553

This is an amazing one. There is a DIP version of this chip, and with
Matthias Koch's venerated `lowpower` version of [mecrisp] it runs _prompt_
on less than 2uA (requires external 32768 crystal but no caps). The biggest
downside is space: it's got only 16kB of flash (of which 11kB takes mecrisp),
and 512 bytes of RAM (of which about 200 is available for the program). It is
mostly enough for a deployed sensor though (just), but development is a bit
painful (can't really `compiletoram`, so lots of flash writes). Also the prompt
is only 9600 baud.

### msp430fr2433

The first con is that it only comes in QFN or smaller packages, so it is
a pain to build own boards. But it is very small (physically).
The cool feature about this one is FRAM instead of flash - no penalty
in writing to it any time. This particular one has 16kB of it, so again
only 4.5kB space for programs; but it has 4kB of RAM, which is quite
enough for development and testing.

For me the biggest downside of this one is the clock system and the power
consequences. There is an internal REFO 32768Hz clock which kicks in
when there is no external crystal, and consumes 15uA of power come what may.
(So `lpm3` is about 16uA, `lpm4` goes down to 1.5-2uA but only external
interrupts for wakeup.) The external crystal requires caps, and even with it
it is quite a pain to make the MCU use it and switch off REFO. Possible though.
This makes `lpm3` pretty nice, just like on g2553. However I couldn't quite
make the prompt lowpower (like on g2553), because I didn't find a way to
make the UART use the external crystal (XT1) for timing. So it gets shut down
on `lpm3`, and while it does wake up on RX, the data is garbled. Maybe
with lower baud rate?

### msp430fr2476

Same as fr2433, except 64kB FRAM (only 32kB is below `$FFFF` though, so
mecrisp only actively uses that), and 8 kB RAM. Also REFO only uses 1uA here,
so one can get reasonably low power in `lpm3` without any components - about 3uA.
Comes also in QFP-48 package, so hand solderable.
The main downside here is the _price_.

## Structure

The `g2553` and `fr2433` directories contain material which is only for the
respective chips. `drivers` have some a bit higher level drivers which should
be applicable more generally, as long as the base words are available.

I mostly replaced constants with their values (space is tight); but in some
I left the constants in. There is a simple python script in `templates`
which takes one of these, and a bunch of files where the constants are defined,
and produces code with the constants replaced.

The `core` directory contains mecrisp hex files, to be flashed onto the chip.
The `-xt1` versions require an external 32768Hz crystal to work.
The subdirectories contain mecrisp sources which produce the ones which
are not part of the standard [mecrisp] distribution. To build, get a [mecrisp]
tarball, unpack, and copy these source dirs to `mecrisp-source`, go inside,
and then `assemble` will build the `hex`. This of course requires the `asl`
assembler; on Arch Linux the package is `mas` in AUR.

(The FR2433 mecrisp actually runs on the FR2476 straight without modifications,
but the memory sizes are wrong, and some irq names are wrong.)


# Random notes

## Power consumption on MSP430G2553

With my minimal g2553 circuit, I was getting 50-500uA consumption, while
on a Launchpad, same chip, was doing around 1.5uA. (This is Mecrisp lowpower,
with some basic init; btw without the init it was taking about 30uA.)

Turns out it's all about the pins setup. They seem to need to be tied to
something, floating really ups the consumption. Just making them all outputs
on my bare board got the consumption to the expected 1.5uA.


[mecrisp]: https://mecrisp.sourceforge.net
