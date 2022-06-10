import java.util.Scanner;

// Problem: We have unknown number of students who took a quiz
// and need to calculate class average
public class ClassAverageUnknown {
    public static void main(String[] args) {
        int total = 0;
        int gradeCounter = 0;
        Scanner input = new Scanner(System.in);

        // Get input
        System.out.println("Enter a grade to continue or -1 to quit");
        int grade = input.nextInt();

        // loop until sentinel value read from user is -1
        while (grade != -1) { // if grade is not -1 then user entered a grade
            total = total + grade;
            gradeCounter = gradeCounter + 1;

            // ask again
            System.out.println("Enter another grade to continue or -1 to quit");
            grade = input.nextInt();
        }

        // print result and handle not entering any grades
        if (gradeCounter == 0) {
            System.out.println("No grades were entered");
        } else {
            // int doesn't have decimal digits
            // use cast to convert the result from int to double to preserve decimals
            // cast = (double) = converts to double
            double average = (double)total / gradeCounter; // double because we want to show decimal digits
            System.out.printf("Total of the %d grades is %d%n", gradeCounter, total);
            // use %.2f to print numbers with decimals e.g. 19.56
            System.out.printf("Class average is %.2f%n", average);
        }
        input.close();
    }
}
