This code is for my "sensor board"; effectively just a TSSOP-20 packaged
STM32L041 with RFM69CW radio.

The space is quite tight (32kB flash), of which 16kB is taken up by Mecrisp
Stellaris core. So I tried to minimize the includes, so various convenience
functions (usually printing out statuses) are missing (by default).

So, after board.fs (minimal io defs + sleep + prompt), there is about 9.3kB
flash left; adding spi+rf69+i2c leaves 2.5kB flash left.

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
tested with `flib/stm32l0/sleep-extra.fs` code, I got cca 7uA consumption in
sleep, with 5V source through the regulator (this is 11uA on 3.3V).
Powering with 3.3V directly to the "battery" pin (back-powering the reg)
asks for 6-8uA.
