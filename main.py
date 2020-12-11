def fizzbuzz():
    x = range(100)
    for n in x:
        if n % 3 == 0 and n % 5 == 0:
            print("fizzbuzz")
        elif n % 3 == 0:
            print("fizz")
        elif n % 5 == 0:
            print("buzz")
        else:
            print(n)

def reverse_string():
    user_input = input("Please enter a word or phrase: ")
    print(f"Your reversed word or phrase is: {user_input[::-1]}")

def capitalize_first_letters():
    user_input = input("Enter words to be capitalized: ")
    capitalized_user_input = ""
    #forgot to include enumerate
    for i, char in enumerate(user_input):
        if i == 0 or user_input[i-1] == " ":
            capitalized_user_input += char.upper()
        else:
            capitalized_user_input += char
    print(f"Your capitalized input is {capitalized_user_input}")

def compress_string():
    user_input = input("Enter a string of characters to be compressed: ")
    compressed_user_input = ""
    counter = 1
    for i, char in enumerate(user_input):
        if i == 0:
            if char != user_input[i+1]:
                compressed_user_input += f"{counter}{char}"
        elif char == user_input[i-1]:
            counter += 1
        elif i > 1:
            compressed_user_input += f"{counter}{user_input[i-1]}"
            counter = 1
        if i == len(user_input) - 1:
            compressed_user_input += f"{counter}{char}"
    print(f"Your compressed input is: {compressed_user_input}")

#fizzbuzz()
#reverse_string()
#capitalize_first_letters()
compress_string()