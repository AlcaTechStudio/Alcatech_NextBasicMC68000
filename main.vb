imports "\system\genesis_header.asm" ' Header de uma ROM de mega Drive Padrão (deve ficar sempre no topo)

#const gravidade = 100

#if gravidade > 30 Then 
 teste = 1
#Else
 teste = 10
#End If

teste = _char("M")

std_init()
print_init()

'[...] O que for colocado aqui sera executado apenas uma vez

y=200

set_sprite_size(0,0,0)
set_sprite_gfx(0,1,0)

'dim teste as signed fixed = -2.01

'print_signed_fixed(teste) : println("")
'print_signed_fixed(_signed(teste \ 2.0)) : println("")

print_hex(&hFF632)
enable_global_int()

Do 'main
'teste += teste
 
 x+=teste
 'x+= ret_fix()
' _asm_block #__
' move.w _global_teste,D0
' asr.w  #7,D0
' add.w D0,_global_x
'__# _asm_block_end  


set_sprite_position(0,x,y)
update_sprite_table()

flag_vb=1
while(flag_vb) : wend
Loop ' Laço infinito

sub isr_vblank()
flag_vb=0
end sub

function ret_fix() as signed fixed
  
  return teste

end function

Imports "\system\genesis_std.nbs" ' Biblioteca contendo funções standard do Mega Drive
imports "\system\print_lib.nbs"
