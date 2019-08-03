\ on_top_of basis-fr2476.fs

<<basis>>

compiletoflash

include ../flib/mecrisp/dump.txt
include ../flib/mecrisp/insight.txt

cornerstone <<insight>>

include launchpad.fs

cornerstone <<launchpad>>

include ../flib/fr2476/i2c-bb-base.fs
include ../flib/drivers/i2c-bb.fs

compiletoram
