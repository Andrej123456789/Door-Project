
mov ah , 0x0e

mov al, 'H'
int 0x10

mov al, 'e'
int 0x10

mov al, 'l'
int 0x10

mov al, 'l'
int 0x10

mov al, 'o'
int 0x10

mov al, '!'
int 0x10

mov al, ''
int 0x10

mov al, 'M'
int 0x10

mov al, 'a'
int 0x10

mov al, 'd'
int 0x10

mov al, 'e'
int 0x10

mov al, ''
int 0x10

mov al, 'b'
int 0x10

mov al, 'y'
int 0x10

mov al, ''
int 0x10

mov al, 'A'
int 0x10

mov al, 'n'
int 0x10

mov al, 'd'
int 0x10

mov al, 'r'
int 0x10

mov al, 'e'
int 0x10

mov al, 'j'
int 0x10

mov al, '.'
int 0x10

jmp $



times 510-($-$$) db 0

dw 0xaa55