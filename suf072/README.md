## Mecrisp over native USB on F072

This is a modification of Jean-Claude Wippler's "Serial USB driver for Forth" -
see [his blog post](http://jeelabs.org/2016/06/standalone-usb-firmware/).
He has done a really amazing job of getting this running in the first place; in
his case for F103-based devices.
I have modified it so that it runs on F072; the primary target for me is the
[bat board] with STM32F072CxT6.

The assumption is that it runs on a clean Mecrisp Stellaris image, ideally with
jcw's 'spezial' modification (there are binaries available in this repo in
`cores`). (The only consequence of using the standard Mecrisp Stellaris is that
USARTx does get initialised; it doesn't on 'spezial'.)

So, getting this on the board requires:
1. Get a clean Mecrisp Stellaris on the board (using F072's built-in
   bootloader, either USART or DFU).
2. Connect to the default USART console Mecrisp, and send over
   `usbbase-bat-f072.fs` (with [folie], otherwise you'll need to manually
   resolve the `include`s).
3. At this point, when you `reset` the board, no USART console shows up, and
   the device should enumerate as an USB ACM device, over which you should be
   able to talk to Mecrisp.

This is a bit tedious, so instead you can just upload
`mecrisp-2.5.0-bat128-f072usb.bin` (or ...`bat064`... if you have 64kB F072)
from this directory - it is the result of the above process, with Mecrisp
Stellaris 2.5.0 core with 'spezial' patch. This can be done either over USART,
or over USB with `dfu-util` - the latter is convenient in that no USB-to-serial
converter is necessary at all, since everything happens over USB.


## Version for F042

There is also a version for STM32F042 here; the assumption is the TSSOP-20
package (so STM32F042F6P6, like [this
board](https://flabbergast.drak.xyz/posts/arm-breakouts/#stm32f042fxp6)). Just
a few differences:

* Hal needs to remap PA11/PA12 over PA9/PA10 for USB to work.
* Expects non-RA mecrisp stellaris (space is tight).
* `USART2` can not be clocked from HSI, so changing the main clock on these
  requires changing `BRR` (baud rate) to keep a serial console.
* The actual USB driver is exactly the same.


### Notes

See also the details about all this (for F103) in jcw's original
[README](https://git.jeelabs.org/jcw/embello/src/branch/master/explore/1608-forth/suf/README.md).

In particular, `eraseflash` will keep the USB driver/console in, but `$5000 eraseflashfrom`
erases the USB driver and goes bat to a clean Mecrisp (USART console only). The USB
driver takes up 6kB of flash. Note that a clean Mecrisp runs the prompt on a particular
USART (that was determined when Mecrisp Stellaris was compiled). My images run with TX/RX
on PA9/PA10, USART1, 115200 baud.

Finally, clean Mecrisp Stellaris doesn't mess with the clock, so the chip runs on 16MHz,
clocked from HSI oscillator (high-speed internal). To get USB running, the driver switches
to 48MHz (clocked from HSI, multiplied by PLL). The USB is clocked from HSI48 which is being
automatically trimmed to the precision required by the USB through "clock recovery system",
timed from SOF USB packets.

---

There were a few snags porting from F103 to F072; the main difference
is the addressing of the 'packet memory' between F1 and F0x2 chips, and fixing
a couple of omissions in the original driver.



[bat board]: https://flabbergast.drak.xyz/bat-board
[folie]: https://git.jeelabs.org/jcw/folie
