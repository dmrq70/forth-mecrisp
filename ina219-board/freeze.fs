\ frozen application, this runs tests and wipes to a clean slate if they pass

include g6s-base/always.fs
include g6s-base/board.fs
include g6s-base/core.fs

compiletoflash
include ina.fs

