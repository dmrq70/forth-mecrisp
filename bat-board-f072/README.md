This code runs on the bat board (rev2), by flabbergast.

* default I2C: B7/SDA, B6/SCL (tricky to change, at one point
  it's hardcoded into jcw's driver)
* default SPI: PB8/ssel, PB5/MOSI, PB4/MISO, PB3/SCLK (this is enough
  for a RFM69)
* also defined:
  * LED = PA15, active: set/high
  * BTN = PA1, pressed: true

