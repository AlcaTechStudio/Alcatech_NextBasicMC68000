imports "\system\genesis_header.asm" ' Header de uma ROM de mega Drive Padrão (deve ficar sempre no topo)


std_init()   'Inicializa o VDP
print_init() 'Carrega a fonte para a VRAM

print("  Por enquanto ta tudo tranquilo  o.O  ")

Do 'main


Loop ' Laço infinito


Imports "\system\genesis_std.nbs" ' Biblioteca contendo funções standard do Mega Drive
Imports "\system\print_lib.nbs"   ' Inclui a funcao Print
Imports "\system\DMA_Queue.nbs"   ' Fila de DMA
Imports "\system\trig.nbs"        ' Trigonometria para matematica de ponto Fixo