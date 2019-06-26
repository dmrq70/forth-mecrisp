: pwm-init ( Interval -- ) \ Init PWM on green LED
  64 p1dir cbis! \ Output
  64 p1sel cbis! \ Timer special function

  \ Configure Timer-A

       $172 ! \ PWM Interval in cycles
  $E0  $164 ! \ CCR1 Set/Reset
  0    $174 ! \ CCR1 PWM Duty Cycle
  $210 $160 ! \ SMCLK/1, upmode
;

: pwm ( Duty-Cycle -- ) $174 ! ; \ Sets duty cycle

