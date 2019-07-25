;
;    Mecrisp - A native code Forth implementation for MSP430 microcontrollers
;    Copyright (C) 2011  Matthias Koch
;
;    This program is free software: you can redistribute it and/or modify
;    it under the terms of the GNU General Public License as published by
;    the Free Software Foundation, either version 3 of the License, or
;    (at your option) any later version.
;
;    This program is distributed in the hope that it will be useful,
;    but WITHOUT ANY WARRANTY; without even the implied warranty of
;    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
;    GNU General Public License for more details.
;
;    You should have received a copy of the GNU General Public License
;    along with this program.  If not, see <http://www.gnu.org/licenses/>.
;

; Main file for Mecrisp for MSP430FR2476.

;------------------------------------------------------------------------------
; Base Definitions
;------------------------------------------------------------------------------
  cpu msp430
  include "../common/mspregister.asm"
  include "../common/datastack.asm"

;------------------------------------------------------------------------------
; Memory map
;------------------------------------------------------------------------------

RamAnfang   equ  2000h ; Start of RAM
RamEnde     equ  4000h ; End of RAM, 8 kB
FlashAnfang equ 08000h ; Start of Flash, 32 kb, Flash end always is $FFFF.

  org 0D400h          ; Start of Forth kernel. Needs to be on a 512 byte boundary !

;------------------------------------------------------------------------------
; Prepare Dictionary
;------------------------------------------------------------------------------

  include "../common/forth-core.asm"  ; Include everything of Mecrisp

;------------------------------------------------------------------------------
; Include chip specific terminal & interrupt hooks code
;------------------------------------------------------------------------------

  include "terminal.asm"
  include "fram.asm"
  include "interrupts.asm"

;------------------------------------------------------------------------------
Reset: ; Main entry point. Chip specific initialisations go here.
;------------------------------------------------------------------------------

  mov #5A80h, &WDTCTL ; Watchdog off

  include "../common/catchflashpointers.asm" ; Setup stacks and catch dictionary pointers

  ; Now it is time to initialize hardware. (Porting: Change this !)

  ; Backchannel UART communication over
  ; P1.4: USCI0 TXD
  ; P1.5: USCI0 RXD
  ; with 115200 Baud and 8 MHz clock

  ;------------------------------------------------------------------------------
  ; Init Clock

  bis.w #40h, r2
  mov.w #10h, &186h
  mov.w #150h, &180h
  mov.w #6h, &182h
  mov.w #0F4h, &184h
  nop
  nop
  nop
  bic.w #40h, r2

- bit.w #300h, &18Eh
  jc -

  ; This is just some Forth code which I disassembled and inserted here:

  ; : disable-fll ( -- ) [ $D032 , $0040 , ] inline ; \ Set   SCG0  Opcode bis #40, r2
  ; : enable-fll  ( -- ) [ $C032 , $0040 , ] inline ;  \ Clear SCG0  Opcode bic #40, r2

  ; disable-fll
  ; 1 4 lshift CSCTL3 ! \ Select REFOCLK as FLL reference
  ; $0150      CSCTL0 ! \ A good DCO guess for quickly reaching target frequency
  ; 3 1 lshift CSCTL1 ! \ DCO Range around 8 MHz
  ; 244        CSCTL2 ! \ REFOCLK * 244 = 32768 Hz * 244 = 7 995 392 Hz
  ; nop                 \ Wait a little bit
  ; enable-fll
  ; begin $0300 CSCTL7 bit@ not until \ Wait for FLL to lock

  ;------------------------------------------------------------------------------
  ; Init IO

  bic   #LOCKLPM5, &PM5CTL0         ; Unlock I/O pins
  mov.b #32+16, &P1SEL0             ; Configure UART pins

  ;------------------------------------------------------------------------------
  ; Init serial communication

  mov #UCSWRST, &UCA0CTLW0          ; **Put state machine in reset**
  bis #UCSSEL__SMCLK, &UCA0CTLW0    ; SMCLK

  mov #4, &UCA0BRW                  ; 8 MHz 115200 Baud
  mov #05551h, &UCA0MCTLW           ; Modulation UCBRSx=55h, UCBRFx=5, UCOS16

  bic #UCSWRST, &UCA0CTLW0          ; **Initialize USCI state machine**
  ;------------------------------------------------------------------------------

  welcome " for MSP430FR2476 by Matthias Koch"

  ; Initialisation is complete. Ready to fly ! Prepare to enter Forth:

  include "../common/boot.asm"
;------------------------------------------------------------------------------

;------------------------------------------------------------------------------
;           Interrupt vectors of FR2476
;------------------------------------------------------------------------------

 org 0FF80h ; Protection Signatures

  .word   0FFFFh  ; JTAG-Signature 1
  .word   0FFFFh  ; JTAG-Signature 2
  .word   0FFFFh  ; BSL-Signature 1
  .word   0FFFFh  ; BSL-Signature 2

 org 0FFCAh ; Interrupt table with hooks

  ; some are not included because of the space for code
  .word   irq_vektor_comp      ; 37: 0FFCA  eCOMP0
  .word   null_handler         ; 38: 0FFCC  Port 6
  .word   null_handler         ; 39: 0FFCE  Port 5
  .word   null_handler         ; 40: 0FFD0  Port 4
  .word   null_handler         ; 41: 0FFD2  Port 3
  .word   irq_vektor_port2     ; 42: 0FFD4  Port 2
  .word   irq_vektor_port1     ; 43: 0FFD6  Port 1
  .word   irq_vektor_adc       ; 44: 0FFD8  ADC
  .word   null_handler         ; 45: 0FFDA  USCIB1
  .word   irq_vektor_uscib0    ; 46: 0FFDC  USCIB0
  .word   irq_vektor_uscia1    ; 47: 0FFDE  USCIA1
  .word   irq_vektor_uscia0    ; 48: 0FFE0  USCIA0
  .word   irq_vektor_watchdog  ; 49: 0FFE2  Watchdog
  .word   irq_vektor_rtc       ; 50: 0FFE4  RTC
  .word   null_handler         ; 51: 0FFE6  Timer 0 (B7) CCR1-CCR6 TBIV
  .word   null_handler         ; 52: 0FFE8  Timer 0 (B7) CCR0
  .word   null_handler         ; 53: 0FFEA  Timer 3 CCR1, TAIV
  .word   null_handler         ; 54: 0FFEC  Timer 3 CCR0
  .word   null_handler         ; 55: 0FFEE  Timer 2 CCR1, TAIV
  .word   null_handler         ; 56: 0FFF0  Timer 2 CCR0
  .word   null_handler         ; 57: 0FFF2  Timer 1 CCR1, CCR2, TAIV
  .word   irq_vektor_timerb0   ; 58: 0FFF4  Timer 1 CCR0
  .word   irq_vektor_timera1   ; 59: 0FFF6  Timer 0 CCR1, CCR2, TAIV
  .word   irq_vektor_timera0   ; 60: 0FFF8  Timer 0 CCR0
  .word   null_handler         ; 61: 0FFFA  User NMI. Unused.
  .word   null_handler         ; 62: 0FFFC  System NMI. Unused.
  .word   Reset                ; 63: 0FFFE  Main entry point

end
