import java.util.Scanner;
import java.lang.StringBuilder;

public class Main {
    public static void main(String[] args) {
        // FizzBuzz();
        // ReverseString();
        CapitalizeFirstLetters();
    }

    public static void FizzBuzz() {
        for (int i = 0; i <= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                System.out.println("fizzbuzz");
            } else if (i % 3 == 0) {
                System.out.println("fizz");
            } else if (i % 5 == 0) {
                System.out.println("buzz");
            } else {
                System.out.println(i);
            }
        }
    }

    public static void ReverseString() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please enter a word or phrase: ");
        String userInput = scanner.nextLine();
        StringBuilder reverseUserInput = new StringBuilder();
        for (int i = 0; i < userInput.length(); i++) {
            reverseUserInput.append(userInput.charAt(userInput.length() - 1 - i));
        }
        System.out.print("Your reversed input is " + reverseUserInput);
    }

    public static void CapitalizeFirstLetters() {
        System.out.print("Enter words to be capitalized: ");
        Scanner scanner = new Scanner(System.in);
        String userInput = scanner.nextLine();
        StringBuilder capitalizedUserInput = new StringBuilder();
        for (int i = 0; i < userInput.length(); i++) {
            if (i == 0 || userInput.charAt(i - 1) == ' ') {
                capitalizedUserInput.append(String.valueOf(userInput.charAt(i)).toUpperCase());
            } else {
                capitalizedUserInput.append(userInput.charAt(i));
            }
        }
        System.out.print("Your capitalized input is " + capitalizedUserInput);
    }
}