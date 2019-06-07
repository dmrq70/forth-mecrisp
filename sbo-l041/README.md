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

