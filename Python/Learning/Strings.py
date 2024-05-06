a="hello, World"
# String Slicing
print(a[2:5])
print(a[:5])
print(a[5:])
print(a[-12:-7])
print(a[-20:-1])
# String Slicing

#String methods
print(f"{a.capitalize()},{a}") #capitilizes the first letter of the string
print(f"{a.casefold()}|{a}")#lowercases the entire string
print(f"{a.center(1)}|{a}")#returns a ccentered string
print(f"{a.count("l")}|{a}")#returns the number of occurences of a specified value in a string
print(f"{a.encode("UTF-16")}")#returns the encoded string
print(f"{a.endswith("ld")}")#returns a boolean based on if it ends with the specified sequence
print(a.__len__())