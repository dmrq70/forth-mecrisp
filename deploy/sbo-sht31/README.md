# deploy-sht31

Runs on the [deploy sensor board] (one of the variants of the board I sometimes
refer to here as _sbo_), with SHT31-D sensor wired up to it. (I got
[this one](https://www.tindie.com/products/closedcube/sht31-d-digital-humidity-temperature-sensor/)
from Tindie - comes with a protective filter cover, which is really handy since
this sensor is intended for the outdoors.) Takes readings and sends them
over. Consumes 2.5uA in sleep.

I use [this platformio/arduino sketch](https://git.drak.xyz/flabbergast/jee-sensors/src/branch/master/gateway)
for the [rfm69 board on pocket beagle](https://flabbergast.drak.xyz/posts/pb-rfmcape/)
as gateway.


## Notes

* Runs the same startup code as the dev board variant (see `sbo-l041`).


[deploy sensor board]: https://flabbergast.drak.xyz/posts/sbo-box/

