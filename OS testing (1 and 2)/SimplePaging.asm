
PageTableEntry equ 0x0000

SetUpIdentityPaging:
	mov edi, PageTableEntry
	mov cr3, edi
	mov qword [edi], 0x2003
	add edi, 0x1000
	mov qword [edi], 0x3003
	add edi, 0x1003



	mov ebx, 0x00000003
	mov ecx, 512

	.SetEntry:
		mov qword [edi], ebx
		add ebx, 0x1000
		add edi, 8
		loop .SetEntry

	mov eax, cr4
	or eax, 1 << 5
	mov cr4, eax

	mov ecx, 0xC0000000
	rdmsr
	or eax, 1 << 8
	wrmsr

	mov eax, cr0
	or eax, 1 << 31
	mov cr0, eax

	ret