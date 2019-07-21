This code runs on the [bat board], with L052 MCU.

* default I2C: B7/SDA, B6/SCL (tricky to change, at one point
  it's hardcoded into jcw's driver)
* default SPI: PB8/ssel, PB5/MOSI, PB4/MISO, PB3/SCLK
* also defined:
  * LED = PA15, active: set/high
  * BTN = PA1, pressed: true

## Power consumption notes

Tried running `ex/sleep-test.fs` `lp-blips` powered through
the voltage regulator with 5V, and the consumption was about 4uA. This
is really good; the regulator seems to really take only about 1.5-2uA.


[bat board]: https://flabbergast.drak.xyz/bat-board
