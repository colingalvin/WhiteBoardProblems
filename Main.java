import java.util.Scanner;
import java.lang.StringBuilder;

public class Main {
    public static void main(String[] args) {
        // FizzBuzz();
        ReverseString();
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
        System.out.print((String.format("Your reversed input is " + reverseUserInput)));
    }
}