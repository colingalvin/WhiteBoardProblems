using System;
using System.Text;

namespace MyWhiteBoardProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz();
            //ReverseString();
            //CapitalizeFirstLetters();
            //CompressString();
            //Palindrome();
            //HappyNumber();
            //PrimeNumber();
            //Fibonacci();
            //TargetNumber();
        }

        public static void FizzBuzz()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void ReverseString()
        {
            Console.Write("Please enter a word or phrase: ");
            string userInput = Console.ReadLine();
            StringBuilder reversedUserInput = new StringBuilder();
            for (int i = 1; i <= userInput.Length; i++)
            {
                reversedUserInput.Append(userInput[userInput.Length - i]);
            }
            Console.WriteLine($"Your reversed word or phrase is: {reversedUserInput}");
        }

        public static void CapitalizeFirstLetters()
        {
            Console.Write("Enter words to be capitalized: ");
            string userInput = Console.ReadLine();
            StringBuilder capitalizedUserInput = new StringBuilder();
            for (int i = 0; i < userInput.Length; i++)
            {
                if (i == 0 || userInput[i - 1] == ' ')
                {
                    capitalizedUserInput.Append(userInput[i].ToString().ToUpper());
                }
                else
                {
                    capitalizedUserInput.Append(userInput[i]);
                }
            }
            Console.WriteLine($"Your capitalized input is: {capitalizedUserInput}");
        }

        public static void CompressString()
        {
            Console.Write("Enter a string of characters to be compressed: ");
            string userInput = Console.ReadLine();
            StringBuilder compressedUserInput = new StringBuilder();
            int counter = 1;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (i == 0)
                {
                    if (userInput[i] != userInput[i + 1])
                    {
                        compressedUserInput.Append($"{counter}{userInput[i]}");
                    }
                }
                else if (userInput[i] == userInput[i - 1])
                {
                    counter++;
                }
                else if (i > 1)
                {
                    compressedUserInput.Append($"{counter}{userInput[i - 1]}");
                    counter = 1;
                }
                if (i == userInput.Length - 1)
                {
                    compressedUserInput.Append($"{counter}{userInput[i]}");
                }
            }
            Console.WriteLine($"Your compressed input is {compressedUserInput.ToString()}");
        }

        public static void Palindrome()
        {
            Console.Write("Enter a word or phrase to check if it is a palindrome: ");
            string userInput = Console.ReadLine();
            StringBuilder simplifiedInput = new StringBuilder();
            StringBuilder reversedSimplifiedInput = new StringBuilder();
            for (int i = 0; i < userInput.Length; i++)
            {
                if (Char.IsLetterOrDigit(userInput[i]))
                {
                    simplifiedInput.Append(Char.ToLower(userInput[i]));
                    reversedSimplifiedInput.Insert(0, Char.ToLower(userInput[i]));
                }
            }
            // Make sure to only check string value of StringBuilder object
            if (simplifiedInput.ToString() == reversedSimplifiedInput.ToString())
            {
                Console.WriteLine("This is a palindrome");
            }
            else
            {
                Console.WriteLine("This is not a palindrome");
            }
        }

        public static void HappyNumber()
        {
            Console.Write("Enter a number to check of it is a happy number: ");
            string userInput = Console.ReadLine();
            string currentNumber = userInput;
            int counter = 0;
            do
            {
                double newNumber = 0;
                for (int i = 0; i < currentNumber.Length; i++)
                {
                    newNumber += Math.Pow(Convert.ToDouble(currentNumber[i].ToString()), 2);
                }
                currentNumber = newNumber.ToString();
                counter++;
            }
            while (currentNumber != "1" && counter < 1000);
            if (counter == 1000 || currentNumber != "1")
            {
                Console.Write($"After 1,000 iterations, {userInput} has not been shown to be a happy number");
            }
            else
            {
                Console.Write($"{userInput} is a happy number!");
            }
        }

        public static void PrimeNumber()
        {
            Console.Write("Enter a positive integer to check if it is prime: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= userInput; i++)
            {
                if (userInput % i == 0)
                {
                    counter++;
                }
            }
            if (counter <= 2)
            {
                Console.Write($"{userInput} is a prime number!");
            }
            else
            {
                Console.Write($"{userInput} is not a prime number :(");
            }
        }

        public static void Fibonacci()
        {
            Console.WriteLine("The first 20 numbers of the Fibonacci sequence are:");
            int i = 1;
            int j = 0; // Previous number
            int k = 0; // Second previous number
            for (int counter = 0; counter < 20; counter++)
            {
                Console.WriteLine(i);
                k = j;
                j = i;
                i = j + k;
            }
        }

        public static void TargetNumber()
        {
            Console.Write("Enter a string of numbers separated by one space: ");
            string userNumbers = Console.ReadLine();
            Console.Write("Enter a target sum: ");
            string userTarget = Console.ReadLine();
            string[] numbersArray = userNumbers.Split(' ');
            int sum;
            bool solutionFound = false;
            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                for (int j = 1; j < numbersArray.Length; j++)
                {
                    sum = Convert.ToInt32(numbersArray[i]) + Convert.ToInt32(numbersArray[j]);
                    if (sum == Convert.ToInt32(userTarget))
                    {
                        Console.Write($"Indices {i} ({numbersArray[i]}) and {j} ({numbersArray[j]}) yield the target {userTarget}");
                        solutionFound = true;
                        continue;
                    }
                }
            }
            if (!solutionFound)
            {
                Console.Write("There was no solution found for the given numbers and target");
            }
        }
    }
}