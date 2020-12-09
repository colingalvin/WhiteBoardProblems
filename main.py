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

#fizzbuzz()
reverse_string()