
gdb --args ./game/sbox
handle SIG34 nostop noprint pass

run
continue

bt
info reg
x/10i $rip
thread apply all bt
