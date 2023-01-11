import java.util.Scanner;

public class RockPaperScissors {
    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // get input from user
        System.out.println("Please enter R, P or S, and press enter");
        String userInputLetter = scanner.nextLine();

        // validate and terminate
        // use OR || since only one must be true for this to be valid
        if (userInputLetter == "R" || userInputLetter == "P" || userInputLetter == "S") {
            // generate input from computer
            // It returns a pseudorandom double value >= to 0.0 and < 1.0.
            double computerInputNumber = Math.random(); // use without creating a math object
            // 0.0 to 0.33 = R
            // 0.34 to 0.64 = P
            // 0.65 to 1.0 = S
            String computerInputLetter = "";
            if (computerInputNumber >= 0 && computerInputNumber <= 0.33) {
                computerInputLetter = "R";
            } else if (computerInputNumber >= 0.34 && computerInputNumber <= 0.64) {
                computerInputLetter = "P";
            } else {
                computerInputLetter = "S";
            }
            // decide result of match
            if (userInputLetter == "R") {
                // print out result
                if (computerInputLetter == "R") {
                    System.out.println("It's a draw!");
                } else if (computerInputLetter == "P") {
                    System.out.println("You lost!");
                } else {
                    System.out.println("You won!");
                }
            }
            // do same for userInput P and S
        } else {
            // computerInputLetter no longer exists
            System.out.println("Invalid choice, try again!");
        }
    }
}
