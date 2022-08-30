import java.util.Scanner;

public class LetterGrades {
    public static void main(String[] args) {
        // declare and initialize counter variables and scanner object
        int total = 0;
        int gradeCounter = 0;
        int aCount = 0;
        int bCount = 0;
        int cCount = 0;
        int dCount = 0;
        int fCount = 0;

        Scanner input = new Scanner(System.in);

        System.out.printf("%s%n%s%n  %s%n  %s%n",
                "Enter the integer grades in the range of 0-100",
                "Type end of file indicator to terminate input",
                "On Linux/MacOS enter CTRL+d then press enter",
                "On Windows enter CTRL+Z then press enter");

        // loop unitl user enters end-of-file indicator
        while (input.hasNext()) {
            // for every iteration
            // read input
            int grade = input.nextInt();
            // add input to total
            total += grade;
            ++gradeCounter; // keep track of number of grades entered

            // switch statement determine whether it's A B C D F and increase count
            // accordingly
            switch (grade / 10) {
                case 9: // grade was between 90
                case 10: // and 100 inclusive
                    ++aCount;
                    break; // exit switch
                case 8:
                    ++bCount;
                    break;
                case 7:
                    ++cCount;
                    break;
                case 6:
                    ++dCount;
                    break;
                default:
                    ++fCount;
                    break;
            }
        }

        // print out class report
        System.out.printf("%nGrade Report:%n");

        if (gradeCounter == 0) {
            System.out.println("No grades were entered");
        } else {
            double average = (double) total / gradeCounter;
            // output summary of results
            System.out.printf("Total of the %d grades entered is %d%n",
                    gradeCounter, total);
            System.out.printf("Class average is %.2f%n", average);
            System.out.printf("%n%s%n%s%d%n%s%d%n%s%d%n%s%d%n%s%d%n",
                    "Number of students who received each grade:",
                    "A: ", aCount,
                    "B: ", bCount,
                    "C: ", cCount,
                    "D: ", dCount,
                    "F: ", fCount);
        }
    }
}
