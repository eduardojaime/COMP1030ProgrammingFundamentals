namespace lesson09b;
class Program
{
    // static refers to a method that's available for the CPU even before the program loads in memory
    // that's why main is the starting point of the app
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, BlackJack!");
        // INPUTS
        // variables that affect the scores
        Random cardDealer = new Random();
        int currentCard = 0;
        int playerScore = 0;
        int computerScore = 0;
        // variables that affect the inner game loop
        bool anotherCard = true;
        string choiceCard = "";
        // variables that affect the main game loop
        bool anotherGame = true;
        string choiceGame = "";

        // PROCESS
        // main game loop (round)
        while (anotherGame == true)
        {
            //  reset the game
            playerScore = 0;
            computerScore = 0;
            currentCard = 0;
            anotherCard = true; // so that I can enter the inner game loop the first time

            //  inner game loop (player)
            RunInnerGameLoop(cardDealer, ref anotherCard, ref playerScore);

            //  generate computer score
            computerScore = GenerateComputerScore(cardDealer);

            // OUTPUTS
            ShowGameResult(playerScore, computerScore);

            //  ask player if they want to play again
            ProcessYesNoInput("Good game! Press Y to play again, any other key to exit.", ref anotherGame);
        }
    } // END OF MAIN METHOD

    // method that takes two scores and prints a message indicating the result of the game
    // public makes method visible outside of the class, private makes it visible only inside of the class
    // since main method is static, and static methods can only call other static methods directly
    // we need ShowGameResult to also be static
    private static void ShowGameResult(int playerScore, int computerScore)
    {
        // bring over code from above
        //  determine winner and show a message
        //  instant win = 21
        if (playerScore == 21)
        {
            Console.WriteLine("Player wins!");
        }
        //  instant lose > 21
        else if (playerScore > 21)
        {
            Console.WriteLine("Player loses!");
        }
        //  tie comp = player
        else if (playerScore == computerScore)
        {
            Console.WriteLine("It's a tie!");
        }
        //  normal win player > comp
        else if (playerScore > computerScore)
        {
            Console.WriteLine("Player wins!");
        }
        //  normal lose comp > player and everything else I didn't cover
        else
        {
            Console.WriteLine("Player loses!");
        }
    }

    // a common action in my code is asking a question, retrieving an answer, and setting the value of a flag accordingly
    // parameters receive only a copy of the value
    // if the method needs to be able to permanently modify the value of a variable, we need to use the keyword ref
    private static void ProcessYesNoInput(string question, ref bool anotherOne)
    {
        Console.WriteLine(question);
        // local variable, no need to receive this from the parameter list since it only holds a temp value
        string choice = Console.ReadLine().Trim().ToUpper();
        if (choice == "Y")
        {
            anotherOne = true; // I want the method to modify the value of the variable passed as anotherOne (ref)
        }
        else
        {
            anotherOne = false;
        }
    }

    // method that represents the player playing the game, getting cards and increasing their score
    // parameter names don't need to match variable names (not mandatory)
    // however, it's a good practice to have them match
    // use ref for both anotherCard and playerScore because the method needs to make permanent changes to their values
    private static void RunInnerGameLoop(Random cardDealer, ref bool anotherCard, ref int playerScore)
    {
        while (anotherCard == true)
        {
            //      give user a card and increase score << if score > 21 then no more cards
            // make this a local variable, it holds a temp value
            int currentCard = cardDealer.Next(1, 12); // it'll give me values 1 to 11 inclusive
            playerScore = playerScore + currentCard;
            Console.WriteLine($"Your total score is now {playerScore.ToString()}");
            Console.WriteLine();
            //      ask if user wants another card
            ProcessYesNoInput("Press Y to get another card, any other key to end your turn.", ref anotherCard);
        }
    }

    // method that returns the computer score
    private static int GenerateComputerScore(Random cardDealer)
    {
        int score = cardDealer.Next(15, 22);
        Console.WriteLine($"Computer Score is {score.ToString()}");
        Console.WriteLine();
        return score;
    }
}
