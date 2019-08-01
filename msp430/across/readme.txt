# Well ...

I can't seem to make `create` nor `<builds does>` do what I expect it to do.


## Useful across commands

This is meant for `mecrisp-across` flashed on the TiVa board,
with some target MSP430G* tethered to it (PA4->RESET, PA5->TEST).

To play with the target chip interactively, start with:
```
true hostterminal? !   \ Enable "terminal emulation" for target
new                    \ Start anew with everything
+jtag                  \ Attach to target (prints chip #)
target                 \ Switch to target mode
```
Here comes the program that's supposed to run on the target.

Some of the peripherals (like pins) should work "interactively" (!!!),
and with the "terminal emulation" enabled, so will the printing
commands (like `emit`).

After all is processed, need to switch back to `across` and compile:
```
host              \ Switch to host mode

$FFFE vector main \ Vektortabelle füllen und Einsprungpunkte definieren
crosscompile      \ Zeit für die Crosscompilation !
```
(Note `main` above should be a word defined in the target mode.)
Then either run the program on the target:
```
flashtarget       \ Flash!
-jtag             \ Detach
run               \ Run program
```
Or print various things:
```
\ t-listing
\ t-listing-file radio.list

\ disimage
\ disimage-file radio.asm

\ hexdump
\ hexdump-file radio.hex
```
The `-file` versions work only on `across-linux` of course and create files -
so useful for the `compile` script.

More in `across`'s `README`, or here:
https://mecrisp-across-folkdoc.sourceforge.io/index.html

## From mecrisp to across

Documented quirks:

* no `."`
* `create` must be ended with `endcreate`, and there is no `align`
* some words missing, e.g. `min`, `max`

Undocumented quirks:

* what the eff is `create` doing?

## scripts

`./compile stuff.txt` runs stellaris in `qemu-arm`. The expectation is
that `stuff.txt` will produce some files (like `.hex` or something).

`./clean` deletes `hex`es, `list`s and `asm`s.

