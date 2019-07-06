: setup-led 1 30 lshift $48000000 bis! ; \ PA15 LED output (assuming reset state of PA15)
: led-on 1 15 lshift $48000018 bis! ;
: led-off 1 31 lshift $48000018 bis! ;

