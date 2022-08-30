import java.util.Scanner;

public class Analysis {
    public static void main(String[] args) {
        // declare and initialize variables
        int passes = 0;
        int failures = 0;
        int studentCounter = 1;
        Scanner input = new Scanner(System.in);

        while (studentCounter <= 10) { // loop ten times
            // ask for input
            System.out.println("Enter a result (1 for pass, 2 for fail)");
            int result = input.nextInt();

            // increment counters accordingly pass or fail
            if (result == 1) {
                passes = passes + 1; // incrementing count of people who passed the test
            } else {
                failures = failures + 1;
            }

            // increment control variable
            studentCounter = studentCounter + 1;
        }

        // print results
        System.out.printf("Passed: %d%nFailed: %d%n", passes, failures);
        // print bonus accordingly
        if (passes > 8) {
            System.out.println("Give that instructor a bonus!");
        }
    }
}
