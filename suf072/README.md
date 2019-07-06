## Mecrisp over native USB on F072

This is a modification of Jean-Claude Wippler's "Serial USB driver for Forth" -
see [his blog post](http://jeelabs.org/2016/06/standalone-usb-firmware/).
He has done a really amazing job of getting this running in the first place; in
his case for F103-based devices.
I have modified it so that it runs on F072; the primary target for me is the
[bat board] (with STM32F072CxT6). (There were a few snags, the main difference
is the addressing of the 'packet memory' between F1 and F0x2 chips, and fixing
a couple of omissions in the original driver.)

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
`mecrisp-2.5.0-bat-f072usb.bin` from this directory - it is the result of the above
process, with Mecrisp Stellaris 2.5.0 core with 'spezial' patch. This can be
done either over USART, or over USB with `dfu-util` - the latter is convenient
in that no USB-to-serial converter is necessary at all, since everything
happens over USB.

### Notes

See also the details about all this (for F103) in jcw's original
[README](https://git.jeelabs.org/jcw/embello/src/branch/master/explore/1608-forth/suf/README.md).

In particular, `eraseflash` will keep the USB driver/console in, but `$5000 eraseflashfrom`
erases the USB driver and goes bat to a clean Mecrisp (USART console only). The USB
driver takes up 6kB of flash.

(To get a `bin` from `hex`, do `srec_cat -Output uot.bin -Binary uot.hex -Intel`.)


[bat board]: https://flabbergast.drak.xyz/bat-board
[folie]: https://git.jeelabs.org/jcw/folie

