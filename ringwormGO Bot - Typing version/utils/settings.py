import os
import time
import random
from tkinter import *



def Welcome():
    welcome = print("Welcome!!")
    messgae = print("Please read/run How to use bot.py")

def FlipTheCoin():
    time.sleep(5)

    randomlist = []
    for i in range(1, 6):
        n = random.randint(1, 6)
    randomlist.append(n)
    print(randomlist)

    print()

def Sleep():
    time.sleep(5)

def Stalno100():
    number =1
    while number <= 100 :
        print(number)
        number+=1

def Credits():
    print("Python - YouTube tutorials - Tkinter module in Python")

def Help():
    commands = {
        "help" : "Display help",
        "flip the coin" : "Show random number (1-6) to show on coin",
        "while 100" : "Type 1, 2, 3, 4, ... until 100"
    }
    print(commands)

def Returner(value):
    value = int(input("Type number: "))
    return value

def Counter():
    value2 = 10

    while value2 >= 0:
        print(value2)
        value2 = -1
        time.sleep(1)

def Chat():
    ilegal = ["?", "!", "%", "$", "#"]

    while True:
        user = input(">>> ")

        if user == "Hello":
            print("Hello, too!!")

        elif user == "illegal":
            for x in ilegal:
                print(x)

        elif user == "What's your name":
            print("What's your name?")
            name = input(">>>> ")
            print("Hey, "  + name + ". My name is " + name + ", too.")

        elif user == "battery":
            print("Install psutil module and download our Python OS 2.0")

        elif user == "Calc":
            number1 = float(input("Type number: "))
            op = input("Operator: ")
            number2 = float(input("Type number: "))

            if op == "+":
                print(number1 + number2)
            elif op == "-":
                print(number1-number2)
            elif op == "*":
                print(number1 * number2)
            elif op == "/":
                print(number1 / number2)

        elif user == "whle":
            for_while = input(">>>> ")
            for_while_number = int(input("How many times: "))
            print(for_while * for_while_number)

        elif user == "color 0a":
            os.system('color 0a')

        elif user == "flip the coin":
            FlipTheCoin()
            continue

        elif user == "quit":
            print("Goodbye!!")
            print("See you later!!")
            quit()