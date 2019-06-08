: lp-blink ( -- )  only-msi  begin  stop10s led iox!  again ;

rf-init rf-sleep
led-off 2.1MHz 1000 systick-hz
lptim-init lp-blink
