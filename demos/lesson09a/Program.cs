namespace lesson09a;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // INPUT related Variables
        // variables that affect score
        Random myRandom = new Random();
        int currentCard = 0; // card
        int playerTotal = 0; // score
        int computerTotal = 0;  // score
        // variables that affect inner play
        bool anotherCard = true; // set to true by default
        // variables that affect main game
        bool anotherGame = true;

        // Main game loop > play again?, encloses everything
        while (anotherGame == true)
        {
            // setup/reset the game
            // use keyword ref when passing arguments so the method can modify their values
            ResetGame(ref playerTotal, ref computerTotal, ref currentCard, ref anotherCard);
            // Inner game loop
            StartInnerPlayerLoop(myRandom, ref anotherCard, ref playerTotal);
            // computer play
            // assign the result of calling GenerateComputerScore() to computerTotal
            computerTotal = GenerateComputerScore(myRandom);
            // OUTPUT determine winner
            ShowGameResult(playerTotal, computerTotal);
            // ask user whether they want to play again
            ProcessYesNoInput("Good game! Would you like to play again?", ref anotherGame);
        }
    }

    // Method that receives two total scores and determines the winner
    // no return value
    private static void ShowGameResult(int playerTotal, int computerTotal)
    {
        if (playerTotal == 21)
        {
            Console.WriteLine("Player Won!");
        }
        else if (playerTotal > 21)
        {
            Console.WriteLine("Player Lost!");
        }
        else if (playerTotal == computerTotal)
        {
            Console.WriteLine("It's a tie!");
        }
        else if (playerTotal > computerTotal)
        {
            Console.WriteLine("Player Won!");
        }
        else
        {
            Console.WriteLine("Player Lost!");
        }
        Console.WriteLine($"Final Scores >>> Player: {playerTotal} Computer: {computerTotal}");
        Console.WriteLine();
    }

    // Method that generates and returns computer score
    private static int GenerateComputerScore(Random myRandom)
    {
        int computerTotal = myRandom.Next(15, 22);
        Console.WriteLine($"Computer total is {computerTotal}");
        Console.WriteLine();
        return computerTotal; // this is a local variable that stores the value I'm returning
    }

    // Method that resets values of variables to 0
    // use ref so the method can modify each value
    private static void ResetGame(ref int playerTotal, ref int computerTotal, ref int currentCard, ref bool anotherCard)
    {
        playerTotal = 0;
        computerTotal = 0;
        currentCard = 0;
        anotherCard = true;
    }

    // show a message and process y/n input, update flag accordingly
    private static void ProcessYesNoInput(string message, ref bool another)
    {
        Console.WriteLine(message);
        string choice = Console.ReadLine().Trim().ToUpper();
        if (choice == "Y")
        {
            another = true;
        }
        else
        {
            another = false;
        }
        Console.WriteLine();
    }

    private static void StartInnerPlayerLoop(Random myRandom, ref bool anotherCard, ref int playerTotal)
    {
        // inner game loop > another card? increase score
        while (anotherCard == true)
        {
            // deal another card
            int currentCard = myRandom.Next(1, 12); // can be local variable
            // increase score
            playerTotal = playerTotal + currentCard;
            Console.WriteLine($"Your total is {playerTotal}");
            Console.WriteLine();

            // instant win
            if (playerTotal == 21)
            {
                Console.WriteLine("Awesome! Instant win!");
                anotherCard = false;
            }
            // instant lose
            else if (playerTotal > 21)
            {
                Console.WriteLine("Oops! That's more than 21!");
                anotherCard = false;
            }
            // normal gameplay > ask if they want another one
            else
            {
                ProcessYesNoInput("Would you like another card?", ref anotherCard);
            }
        }
    }
}
