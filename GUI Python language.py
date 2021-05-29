import tkinter as tk
from tkinter import font
from typing import Text
from turtle import*

root=tk.Tk()
canvas = tk.Canvas(root, width=100, height=100)
canvas.grid(columnspan=3)


def language_file():
    a=input("Unesi naredbu: ")
    if a == "print":
        b=input("Unesi nešto unutar tvoje naredbe: ")
        print(b)
    if a=="input":
        c=input("Unesi broj: ")
        print(c)
        if c=="int":
            d=int(input("Unesi broj: "))
            print(d)
    if a == "Help":
        print("int = input number","exit = exit","For GUI change type 'GUI change' + 'what you want to change': ")
    if a == "Exit":
        exit()
    if a == "GUI change":
       print("Error...!")
    if a == "Math":
        x=float(input("Unesi prvi broj: "))
        op=input("Unesi operatora: ")
        y=float(input("Unesi drugi broj: "))
        if op=="+":
                print(x + y)
        elif op== "-":
            print(x - y)
        elif op=="*":
            print(x * y)
        elif op=="/":
            print(x / y)
        elif op=="*2":
            zz=x*x
            zzz=y*y
            print(zz,zzz,"Rješenje. Dva na kvadrat prvog i drugog broja.")
    if a == "turtle":
        fd(100)
        lt(90)
        fd(100)
        lt(90)
    if a == "while":
        while True:
            print("GUI Python... .")
    ex=input("Type eXit for final exit: ")
    if ex == "eXit":
        print("Bye, bywe! Thank you on use... Made by ringwormGO")
        exit()
    if ex == "bAck to print":
        b=input("Unesi nešto unutar tvoje naredbe: ")
        print(b)
        ex=input("Type eXit for final exit: ")
        if ex == "eXit":
            print("Bye, bywe! Thank you on use... Made by ringwormGO")
            exit()


browse_text = tk.StringVar()
browse_btn = tk.Button(root, textvariable=browse_text, command=lambda:language_file(), font="Consolas", fg="black", height=20, width=40)
browse_text.set("Type command")
browse_btn.grid(column=1, row=2)

canvas = tk.Canvas(root, width=100, height=100)
canvas.grid(columnspan=3)

root=tk.mainloop()