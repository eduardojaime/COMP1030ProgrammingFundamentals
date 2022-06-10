import java.util.Scanner;

// Problem: We have ten students who took a quiz, and need to calculate class average
public class ClassAverage {
    public static void main(String[] args) {
        // declare and initialize variables
        int total = 0;
        int gradeCounter = 1;

        // prompt user for input
        Scanner input = new Scanner(System.in);

        // process step use counter-controller iteration
        // while (gradeCounter < 11) (11 not included)
        while (gradeCounter <= 10) // loop 10 times, (10 is included)
        {
            System.out.println("Enter a grade");
            int grade = input.nextInt(); // prompt for input
            total = total + grade;// add grade to total
            gradeCounter = gradeCounter + 1; // increment counter
        }

        // output step
        // calculate average
        int average = total /10;
        // print result
        // %d is for digit (integer)
        System.out.printf("Total of all grades %d%n", total);
        System.out.printf("Class Average is %d%n", average);
        input.close();
    }
}
