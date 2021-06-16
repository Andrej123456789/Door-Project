
nasm Bootloader.asm -f bin -o Bootloader.bin
nasm ExtendedProgram.asm -f bin -o ExtendedProgram.bin

copy /b Bootloader.bin+ExtendedProgram.bin Bootloader.flp

pause