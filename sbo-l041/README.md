This code is for my "sensor board"; effectively just a TSSOP-20 packaged
STM32L041 with RFM69CW radio.

It runs on both [the dev version](https://flabbergast.drak.xyz/posts/sbo/)
and the [sensor deploy version](https://flabbergast.drak.xyz/posts/sbo-box/) -
they've got the same schematic, just the PCBs are different.

The space is quite tight (32kB flash), of which 16kB is taken up by Mecrisp
Stellaris core. So I tried to minimize the includes, so various convenience
functions (usually printing out statuses) are missing (by default, of course
they can be added on top, by including `*-extra.fs` parts of the drivers).

By default, `board.fs` (`<<<board>>>` cornerstone) includes spi+rf69+i2c
drivers, leaves cca 6kB flash left.

* default I2C: PA9/scl PA10/sda
* default SPI: PB5/MOSI, PB4/MISO, PB3/SCLK
* RFM69 ssel is PA4
* also defined:
  * LED = PA1, active low
  * BTN = PB1, pressed: -1

## Low power

On regular power-up, the boards takes about 5.5mA.  The LED takes about 1.5mA,
lowering from 16MHz to 2.1MHz saves also about 1.5mA. (All on 5V through the
regulator.)

Trying low power sleep (waking up on LPTIMER), with the "factory" firmware,
with `ex/sleep-test.fs`, running `lp-blips`.

* Powered by 5V through the regulator: 7-8uA.
* Powered by 3.3V through the regulator: 7-8uA (the regulator is supposed to have
  problems with this).
* Powered directly by regulated 3.3V with regulator disconnected from the vdd
  net: 2uA. (!)
* Powered directly by regulated 3.3V with regulator *not* disconnected from the
  vdd net (so effectively back-powering the regulator): 9-10uA.

