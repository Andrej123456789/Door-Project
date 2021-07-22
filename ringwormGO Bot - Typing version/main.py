import os
import time
import random
from tkinter import *
from typing import Sized
from utils import *

Welcome()


def Submit():
    textbox_text = entry.get()
    #print(textbox_text)

    if textbox_text == "quit":
       quit()

    if textbox_text == "sleep":
        time.sleep(5)
        print("Sleep completed!!")

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

def Save():
    textarea = text.get("1.0", END)

    print("Save to main folder.")

    f = open("textarea.txt", "a")
    f.write(textarea)

def Settings():
    print("")

#GUI

window = Tk()
window.title("ringwormGO Inteligent Bot")

entry = Entry(window,
                font=("Arial", 20))
entry.pack(side=LEFT)

text = Text(window,
            font=("Arial", 10))
text.pack()

submit_button = Button(window, text="Submit textbox command", command=Submit)
submit_button.pack(side=LEFT)

save_button = Button(window, text="Save text area into txt document", command=Save)
save_button.pack(side=BOTTOM)

window.mainloop()