import os
import time
import random
from utils import *

print("Non GUI version!!")

#WELCOME
welcome = Welcome()

def Submit():
    textbox_text = input("Type command: ")

    if textbox_text == "quit":
       quit()

    if textbox_text == "sleep":
        time.sleep(5)
        print("Sleep finished.")

    if textbox_text == "save text now":
        f = open("NonGUIText.txt", "a")
        f.write(" ")
        f.write(textbox_text)

    if textbox_text == "while 100":
        Stalno100()

    if textbox_text == "get random number":
        number = random.random()
        print(number)

    if textbox_text == "flip the coin":
        FlipTheCoin()

    if textbox_text == "credits":
        Credits()

    if textbox_text == "help":
        Help()
    elif textbox_text == "about":
        print("v1.0.0 - Typing version")
    elif textbox_text == "counter":
        Counter()
    elif textbox_text == "chat":
        Chat()
    else:
        print("Error!!")


    f = open("NonGUIText.txt", "a")
    f.write(" ")
    f.write(textbox_text)

Submit()
os.system('pause')