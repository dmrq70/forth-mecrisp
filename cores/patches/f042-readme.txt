To build, get the mecrisp stellaris tarball, unpack, go to
`mecrisp-stellaris-yyy/mecrisp-stellaris-source`. Copy
`stm32f042f6` to something else in the same directory, e.g.
`suf042` (`cp -a stm32f042f6 suf042`). Go into the new directory.
Apply the two patches from here:
```
patch -p1 < /path/to/f042-0001-spezial.patch
patch -p1 < /path/to/f042-0002-term-pa2pa3.patch
```
Now build (`make`).

The first patch makes it so that `init` can be overridden
(if it is UART is not initialised automatically). Second,
if a new mecrisp core image is flashed, it will automatically
erase the rest of flash (this is useful if things move in the
core, because if they do, the new core tries to run old words,
and most likely it will automatically produce a hard fault).

The second patch moves the standard UART console from PA9/PA10
to PA2/PA3. On the TSSOP-20 packaged F042, PA9/PA10 is multi-
plexed with PA11/PA12 USB lines, so USB would clobber UART
completely. After USB is up it doesn't matter, but it was useful
for me for debugging USB itself.

Anyway.

Note: the first patch expect *non*-RA version. If RA is wanted,
change $4000 to $5000 at two places (`memmap` and inside
`mecrisp-*.s`, the placement of initial flash erase).

The reason for this is space: RA takes 5kB, USB takes 6kB.
With both, there is only 6kB left for programs.
