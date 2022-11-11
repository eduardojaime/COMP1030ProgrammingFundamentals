namespace lesson09b;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Variables that affect score
        Random myRandom = new Random();
        int currentCard = 0;
        int playerTotal = 0;
        int computerTotal = 0;
        // variables that affect inner game loop
        bool anotherCard = true;
        // variables that affect main game loop
        bool anotherGame = true;

        // Main Game Loop
        while (anotherGame == true)
        {
            // reset game
            ResetGame(ref playerTotal, ref computerTotal, ref currentCard, ref anotherCard);
            // inner game loop > another card y/n
            InnerPlayerLoop(myRandom, ref anotherCard, ref playerTotal);
            // generate computer score
            computerTotal = GenerateComputerScore(myRandom);
            // determine winner and show scores
            ShowGameResult(playerTotal, computerTotal);
            // ask for another game > y/n
            ProcessYesNoInput("Would you like to play another game? Y/N", ref anotherGame);
            Console.Clear();
        }
    }

    // pass total scores to method to determine winner
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
    // pass random number generator object to simulate computer playing and returning score
    // example of returning a value
    private static int GenerateComputerScore(Random myRandom)
    {
        // make into local variable
        int computerTotal = myRandom.Next(15, 22);
        Console.WriteLine($"Computer total is {computerTotal}");
        Console.WriteLine();
        return computerTotal;
    }

    // pass variables as ref to modify their values
    private static void ResetGame(ref int playerTotal, ref int computerTotal,
                                    ref int currentCard, ref bool anotherCard)
    {
        playerTotal = 0;
        computerTotal = 0;
        currentCard = 0;
        anotherCard = true; // because we want to give a card to the user at the beginning of the game
    }
    // Another common action in my program is to process Y/N input
    // method takes a message, prints it, retrieves input, and modifies a flag accordingly
    private static void ProcessYesNoInput(string question, ref bool anotherOne)
    {
        Console.WriteLine(question);
        // make this into local variable
        string choice = Console.ReadLine().Trim().ToUpper(); // validate and clean inputs
        if (choice == "Y")
        {
            anotherOne = true;
        }
        else
        {
            anotherOne = false;
        }
        Console.WriteLine(); // prints empty line for formatting
    }

    private static void InnerPlayerLoop(Random myRandom, ref bool anotherCard, ref int playerTotal)
    {
        while (anotherCard == true)
        {
            // generate number from 1 to 11
            // make local variable
            int currentCard = myRandom.Next(1, 12);
            // add to the player score
            playerTotal = playerTotal + currentCard;
            Console.WriteLine($"Your total is {playerTotal}");
            if (playerTotal < 21)
            {
                // ask if they want another card > y/n
                ProcessYesNoInput("Would you like another card? Y/N", ref anotherCard);
            }
            else if (playerTotal == 21)
            {
                Console.WriteLine("Awesome! You scored exactly 21!");
                anotherCard = false;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Oops! That's more than 21...");
                anotherCard = false;
                Console.WriteLine();
            }
        }
    }
}
