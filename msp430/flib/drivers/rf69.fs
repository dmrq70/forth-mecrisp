\ rf69 driver; this file includes both tx and rx parts
\   - slightly modified version of a pretty smart jcw's driver:
\       https://git.jeelabs.org/jcw/embello
\   - mainly some 32 vs 16 bit fixes
\   - frequency is hardcoded and non-correctable
\   - for the names of registers and bits see the fancy driver
\ needs spi
\ = 1572 bytes flash

include rf69-tx.fs
include rf69-rx.fs
