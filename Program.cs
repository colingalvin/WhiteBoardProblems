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
            CapitalizeFirstLetters();
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
    }
}