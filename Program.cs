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
            CompressString();
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
                    //forgot to include .ToString()
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
                    // Need to separate this logic into another if statement so that the program
                    // does not check for an index that is out of range with userInput[i + 1]
                    if (userInput[i] != userInput[i + 1])
                    {
                        compressedUserInput.Append($"{counter}{userInput[i]}");
                    }
                }
                else if (userInput[i] == userInput[i - 1])
                {
                    counter++;
                }
                // Creates exception to not double-return a unique first character
                else if (i > 1)
                {
                    // Formatting for StringBuilder
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
    }
}