
print("Welcome!!")
print("Version 1.0 doesn't needs any plug-in, but for 2.0 you need to install plug.-in.")

search = input("Type whatever you want to search. See help page for supprot web-pages: ")
if search == "youtube":
    print("Link is", "http://youtube.com/")
elif search == "dailymotion":
    print("Link is", "https://www.dailymotion.com/us")
elif search == "bing":
    print("Link is", "https://www.bing.com/")
elif search == "google":
    print("Link is", "https://www.google.com/")
elif search == "duckduckgo":
    print("Link is", "https://duckduckgo.com/")
else:
    print("Error...!! See Help page and try again.")
    exit()