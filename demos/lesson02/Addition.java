
// Program that adds two numbers and displays the total sum
// Use Scanner object to interact with the console/terminal
import java.util.Scanner;

public class Addition {

    public static void main(String[] arg) {
        // Create a scanner object based on the Scanner class
        Scanner input = new Scanner(System.in); // pass Input stream as parameter for creating Scanner objects
        // 1) Input
        // Ask for data
        System.out.print("Enter first integer:");
        // collect data
        // calls nextInt() to retrieve a numeric value from user input and store it in the variable
        int number1 = input.nextInt(); 
        // Ask for second number
        System.out.print("Enter second integer:");
        int number2 = input.nextInt();
        // 2) Process
        int sum = number1 + number2; // addition using +
        // 3) Output
        System.out.printf("Sum is %d%n", sum);
    }
}
