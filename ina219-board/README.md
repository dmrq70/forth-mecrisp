# power measurement board

A chinese clone of Maple Mini (with STM32F103CBT6) with an Adafruit
INA219 breakout (also a chinese clone I think), to have a ready-made
current measurement board. Put together on a stripboard.

## Credits

All code except ina219.fs comes from jcw's [embello].

[embello]: https://git.jeelabs.org/jcw/embello

## Connectors

 - two screw connectors on the INA219 board which the current is
   supposed to go through
 - male pin headers for the whole INA219 connectors (gnd, 3v3, sda, scl,
   v+, v-)
 - power supply male header pins (gnd, 3v3, 5v)
 - 'ser plus' connector (ftdi + reset + isp)

## Firmware

Running on top of 'suf' firmware, i.e. output (by default) through the
usb/serial.

Th built-in STM32 serial bootloader works through the ser plus
interface. Activate by tying boot0 to gnd (either pressing the button
while reset or use the ser plus connector pin with rst).
Then the chip can be flashed with
[stm32flash](https://sourceforge.net/p/stm32flash/wiki/Home/)

## Internal connections/pinouts

 - INA219 board: 3v3 gnd scl sda V- V+
 - Ser plus: rst tx rx 5v boot0 gnd
 - corresponding maple mini pins:
   - scl:16:PB6
   - sda:15:PB7
   - tx:26:PA9
   - rx:25:PA10
   - boot0:but
 - boot1 tied to gnd (so that the built-in serial bootloader works)

