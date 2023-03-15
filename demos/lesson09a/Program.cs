namespace lesson09a;
class Program
{
    // originally around 85 lines of code
    // best practice is to have at most 15-20 lines of code per method, so that you don't scroll down too much
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Blackjack!");
        // Input
        // Variables that affect the score of the game
        Random cardDealer = new Random();
        int currentCard = 0;
        int playerScore = 0;
        int computerScore = 0;
        // Variables that affect the inner game play
        string choiceCard = ""; // Y/N from the user if they want another card
        bool anotherCard = true;
        // Variables that affect the entire game
        string choiceGame = ""; // Y/N from the user if they want another game
        bool anotherGame = true;

        // Process
        // main game loop
        while (anotherGame == true)
        {
            //      reset game variables
            playerScore = 0;
            computerScore = 0;
            currentCard = 0;
            anotherCard = true;
            //      inner game loop > ask user if they want another card and increase score
            while (anotherCard == true)
            {
                // get card and add to score
                currentCard = cardDealer.Next(1, 12);
                playerScore = playerScore + currentCard;
                Console.WriteLine($"Your current score is {playerScore.ToString()}");
                Console.WriteLine();

                // ask if they want another card or exit
                ProcessYesNonInput("Do you want another card? Press Y to get another card.", ref anotherCard);
            }
            //      generate computer score
            computerScore = cardDealer.Next(15, 30); // more difficult computer > gets 18 to 21

            // Output
            // show scores
            // determine result and show output
            // still breaks because main() is a static method
            // static methods can only call other static methods
            ShowGameResult(playerScore, computerScore);

            // ask if user wants to play again
            // use ref keyword when passing variable to indicate it will be modified by the method
            ProcessYesNonInput("Good game! Would you like to play again? Press Y to play again.", ref anotherGame);
        }

    } // END OF MAIN()

    // method that shows game result based on two scores (player and computer)
    // make methods private if you don't plan to use them outside of this class
    // parameter names don't need to match variable names
    // but best practice is to match the names so that we don't get confused
    // make static so that it can be called from main() which is also a static method
    // unless they are part of another class
    private static void ShowGameResult(int playerScore, int computerScore)
    {
        if (playerScore == 21)
        {
            Console.WriteLine("Player won!");
        }
        else if (playerScore > 21)
        {
            Console.WriteLine("Player lost!");
        }
        else if (playerScore == computerScore)
        {
            Console.WriteLine("It's a tie!");
        }
        else if (playerScore > computerScore)
        {
            Console.WriteLine("Player won!");
        }
        else
        {
            Console.WriteLine("Player lost!");
        }
        Console.WriteLine($"Final Scores >>> Player: {playerScore.ToString()} vs Computer: {computerScore.ToString()}");
    }

    // reusable code
    // Asks a question, retrieves an answer, sets variable true/false depending on the answer
    // We want to make sure the method can permanently modify the value of the boolean variable
    // so use ref next to the bool datatype
    private static void ProcessYesNonInput(string question, ref bool anotherOne)
    {
        // print question text from parameter
        Console.WriteLine(question);
        // declare a local variable, it will be created and destroyed every time the method is called
        string choice = Console.ReadLine().Trim().ToUpper(); // always cleanup user input
        if (choice == "Y")
        {
            anotherOne = true;
        }
        else
        {
            anotherOne = false;
        }
    }

}
