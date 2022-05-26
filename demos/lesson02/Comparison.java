// Program that compares integers using if statements and relational/equality operatiors
import java.util.Scanner;

public class Comparison {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        // 1) Input - take two numbers from the console
        System.out.print("Enter first integer:");
        int number1 = input.nextInt();
        System.out.print("Enter second integer:");
        int number2 = input.nextInt();

        // 2 & 3) Process + Output
        if (number1 == number2) {
            // %d == %d%n is a format string
            // %d means I'm expecting a number
            // %s means I'm expecting a string
            // %n means newline
            // System.out.println(number1 + " == " + number2);
            System.out.printf("%d == %d%n", number1, number2);
        }
        if (number1 != number2) {
            System.out.printf("%d != %d%n", number1, number2);
        }
        if (number1 < number2) {
            System.out.printf("%d < %d%n", number1, number2);            
        }
        if (number1 > number2) {            
            System.out.printf("%d > %d%n", number1, number2);
        }
    }
}
