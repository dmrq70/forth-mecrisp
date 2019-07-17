# MSP430 Notes


## Power consumption on MSP430G2553

With my minimal g2553 circuit, I was getting 50-500uA consumption, while
on a Launchpad, same chip, was doing around 1.5uA. (This is Mecrisp lowpower,
with some basic init; btw without the init it was taking about 30uA.)

Turns out it's all about the pins setup. They seem to need to be tied to
something, floating really ups the consumption. Just making them all outputs
on my bare board got the consumption to the expected 1.5uA.

