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
        string choiceCard = "";
        bool anotherCard = true;
        // variables that affect main game loop
        string choiceGame = "";
        bool anotherGame = true;

        // Main Game Loop
        while (anotherGame == true)
        {
            // reset game
            playerTotal = 0;
            computerTotal = 0;
            currentCard = 0;
            anotherCard = true; // because we want to give a card to the user at the beginning of the game
            // inner game loop > another card y/n
            while (anotherCard == true)
            {
                // generate number from 1 to 11
                currentCard = myRandom.Next(1, 12);
                // add to the player score
                playerTotal = playerTotal + currentCard;
                Console.WriteLine($"Your total is {playerTotal}");
                if (playerTotal < 21)
                {
                    // ask if they want another card > y/n
                    Console.WriteLine("Would you like another card? Y/N");
                    choiceCard = Console.ReadLine().Trim().ToUpper(); // validate and clean inputs
                    if (choiceCard == "Y")
                    {
                        anotherCard = true;
                    }
                    else
                    {
                        anotherCard = false;
                    }
                    Console.WriteLine(); // prints empty line for formatting
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
            // generate computer score
            computerTotal = GenerateComputerScore(myRandom);

            // determine winner and show scores
            ShowGameResult(playerTotal, computerTotal);

            // ask for another game > y/n
            Console.WriteLine("Good game! Do you want to play again? Y/N");
            choiceGame = Console.ReadLine().Trim().ToUpper(); // validate and clean inputs
            if (choiceGame == "Y")
            {
                anotherGame = true;
            }
            else
            {
                anotherGame = false;
            }
            Console.WriteLine(); // prints empty line for formatting
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
}
