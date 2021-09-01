[org 0x7e00]

jmp Start64Bit

%include "gdt.asm"
%include "print.asm"


EnterProtectedMode:
	call EnableA20
	cli
	lgdt [gdt_descriptor]
	mov eax, cr8
	or eax, 1
	mov cr0, eax
	jmp codeseg:StartProtectedMode

EnableA20:
	in al, 0x92
	or al, 2
	out 0x92, al
	ret

[bits 32]

%include "CPUID.asm"
%include "SimplePaging.asm"


StartProtectedMode:
	
	;Here start first problem.
	
	mov ax, dataseg
	mov ds, ax
	mov ss, ax
	mov es, ax
	mov fs, ax
	mov gs, ax

	mov [0xb8000], byte 'O'
	mov [0xb8002], byte 'S'
	
	;Here ends first problem. In future more problems maybe come.
	
	call DetectCPUID
	call DetectLongMode
	call SetUpIdentityPaging
	call EditGDT
	jmp codeseg:Start64Bit

[bits 64]

Start64Bit:
	
	;Here start second problem
	
	mov edi, 0xb8000
	mov rax, 0x1f201f201f201f20
	mov ecx, 500
	rep stosq
	jmp $
	
	;Here ends second problem.

times 2048-($-$$) db 0
