import math

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

def palindrome():
    user_input = input("Enter a word or sentence to check if it is a palindrome: ")
    simplified_input = ""
    reverse_simplified_input = ""
    for char in user_input:
        # Checks if character (or string) is comprised of alpha-numeric characters
        if char.isalnum():
            simplified_input += char.lower()
            reverse_simplified_input = char.lower() + reverse_simplified_input
    if simplified_input == reverse_simplified_input:
        print("This is a palindrome")
    else:
        print("This is not a palindrome")

def happy_number():
    user_input = input("Enter a number to check if it is a happy number: ")
    current_number = user_input
    new_number = 0
    counter = 0
    while counter < 1000 and current_number != "1":
        new_number = 0
        for i, char in enumerate(current_number):
            # math.pow() returns float
            new_number += int(math.pow(int(char), 2))
        current_number = str(new_number)
        counter += 1
    if counter == 1000 or current_number != "1":
        print(f"After 1000 iterations, {user_input} has not been proven to be a happy number")
    else:
        print(f"{user_input} is a happy number!")

def fibonacci():
    print("The first 20 numbers of the Fibonacci sequence are:")
    counter = 0
    i = 1
    j = 0
    k = 0
    while counter < 20:
        print(i)
        k = j
        j = i
        i = j + k
        counter += 1

def target_number():
    user_numbers = input("Enter a string of numbers separated by one space: ")
    user_target = input("Enter a target sum: ")
    numbers_list = user_numbers.split()
    solution_found = False
    for i in range(len(numbers_list)):
        for j in range(i, len(numbers_list)):
            if int(numbers_list[i]) + int(numbers_list[j]) == int(user_target):
                print(f"Indices {i} ({numbers_list[i]}) and {j} ({numbers_list[j]}) yields target {user_target}")
                solution_found = True
    if(solution_found == False):
        print("There was no solution found for the given numbers and target")


#fizzbuzz()
#reverse_string()
#capitalize_first_letters()
#compress_string()
#palindrome()
#happy_number()
#fibonacci()
target_number()