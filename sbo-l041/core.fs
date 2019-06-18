\ core libraries

<<<board>>>
compiletoflash
( core start: ) here dup hex.

( core end, size: ) here dup hex. swap - .
cornerstone <<<core>>>
compiletoram
