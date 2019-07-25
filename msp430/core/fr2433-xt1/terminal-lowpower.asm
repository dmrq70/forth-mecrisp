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

; Serial terminal routines for MSP430FR2433: lower power with lpm0 sleep

;------------------------------------------------------------------------------
; Registers and Constants
;------------------------------------------------------------------------------

PM5CTL0  equ 0130h
LOCKLPM5 equ 1

WDTCTL   equ 01CCh

P1SEL0   equ 020Ah
P2SEL0   equ 020Bh

;------------------------------------------------------------------------------
; UART

UCA0_Base equ 0500h

UCA0CTLW0 equ UCA0_Base
UCA0CTLW1 equ UCA0_Base +  2
UCA0BRW   equ UCA0_Base +  6
UCA0MCTLW equ UCA0_Base +  8
UCA0RXBUF equ UCA0_Base + 0Ch
UCA0TXBUF equ UCA0_Base + 0Eh
UCA0IE    equ UCA0_Base + 1Ah
UCA0IFG   equ UCA0_Base + 1Ch

UCSWRST equ 1
UCSSEL__SMCLK equ 80h

UCBRF_1  equ 010h
UCBRF_5  equ 050h
UCBRF_8  equ 080h
UCBRF_13 equ 0D0h

UCRXIFG equ 1
UCTXIFG equ 2

;------------------------------------------------------------------------------
  Wortbirne Flag_visible, "serial-key?" ; ( -- Flag ) Check for key press
;------------------------------------------------------------------------------
serial_qkey:
  pushda #0
  bit.w #UCRXIFG, &UCA0IFG
  jz +
  mov #-1, @r4
+ ret

;------------------------------------------------------------------------------
  Wortbirne Flag_visible, "serial-key" ; ( -- c ) Fetch key
;------------------------------------------------------------------------------
serial_key:
  mov #UCRXIFG, r7
  call #terminal_schlafroutine
  decd r4
  clr @r4
  mov.b &UCA0RXBUF, @r4
  ret

;------------------------------------------------------------------------------
  Wortbirne Flag_visible, "serial-emit?" ; ( -- Flag ) Ready to emit
;------------------------------------------------------------------------------
serial_qemit:
  pushda #0
  bit.w #UCTXIFG, &UCA0IFG
  jz +
  mov #-1, @r4
+ ret

;------------------------------------------------------------------------------
  Wortbirne Flag_visible, "serial-emit" ; ( c -- ) Emit character
;------------------------------------------------------------------------------
serial_emit:
  mov #UCTXIFG, r7
  call #terminal_schlafroutine
  mov.b @r4, &UCA0TXBUF
  drop
  ret

;------------------------------------------------------------------------------
terminal_schlafroutine:
  push sr
  dint
  nop
  bis.w r7, &UCA0IE  ; Enable interrupt source for incoming characters

- bit.w r7, &UCA0IFG ; Check
  jnz +
    bit #gie, @sp ; if interrupts have been enabled before ?
    jnc -         ; If not, simply poll for a character.

    bis #lpm0|gie, sr ; If yes, switch off CPU to sleep mode and wait for interrupt.
    ; Can *not* use lpm3 for this: USCI is clocked from SMCLK, which is off in lpm3.
    ; The system wakes up from lpm3 on RX, but the received char in UCA0RXBUF is wrong.
    ; Did not find a way to clock it from XT1 (even is possible, it would force
    ;   9600 baud). So the best we can do like this is lpm0.
Schnuffelstelle_Terminal:
    jmp -

+ bic.w r7, &UCA0IE  ; Deactivate interrupt source for incoming characters again.
  nop
  reti

;------------------------------------------------------------------------------
irq_wecken_term:
  cmp #Schnuffelstelle_Terminal, 2(sp)
  jne +
    bic #lpm0+gie, 0(sp)
+ reti
