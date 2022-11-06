using System;
namespace lesson09;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, BlackJack!");

        // Variables that affect score
        Random myRandom = new Random();
        int currentCard = 0;
        int playerTotal = 0;
        int computerTotal = 0;
        // variables that affect inner play
        // string choiceCard = "";
        bool anotherCard = true;
        // variables that affect entire game
        // string choiceGame = "";
        bool anotherGame = true;

        // main game loop
        while (anotherGame == true)
        {
            // passing arguments as references so we can modify them
            ResetGame(ref playerTotal, ref computerTotal, ref currentCard, ref anotherCard);

            // inner game loop > dealing another card
            InnerPlayerLoop(myRandom, ref anotherCard, ref playerTotal);

            // computer plays
            computerTotal = ComputerPlays(myRandom);

            // show output > determine winner
            ShowGameResult(playerTotal, computerTotal);

            // Ask if player wants to play again > y/n input
            ProcessYesNoInput("Good game! Would you like to play again?", ref anotherGame);
        }
    }

    // pass total scores to method to determine who won 
    private static void ShowGameResult(int playerTotal, int computerTotal)
    {
        if (playerTotal == 21)
        {
            // instant win
            Console.WriteLine("Player Won!");
        }
        if (playerTotal > 21)
        {
            // instant lose
            Console.WriteLine("Player Lost!");
        }
        else if (playerTotal == computerTotal)
        {
            Console.WriteLine("It's a Tie!");
        }
        else if (playerTotal > computerTotal)
        {
            Console.WriteLine("Player Won!");
        }
        else
        {
            Console.WriteLine("Player Lost!");
        }
        Console.WriteLine($"Final Scores >>> Player: {playerTotal} | Computer: {computerTotal}");
        Console.WriteLine();
    }
    
    // pass random number generator object to simulate computer playing and return the total score
    // example of returning a value
    private static int ComputerPlays(Random myRandom)
    {
        int computerTotal = myRandom.Next(15, 22);
        Console.WriteLine($"Computer total is {computerTotal}");
        Console.WriteLine();
        return computerTotal;
    }

    // pass as ref so we can modify them
    private static void ResetGame(ref int playerTotal, ref int computerTotal, ref int currentCard, ref bool anotherCard)
    {
        playerTotal = 0;
        computerTotal = 0;
        currentCard = 0;
        anotherCard = true;
    }

    // Another common action is to process Y/N Input > when asking for another card or another game
    // This process will ask the user whether they want to do an action
    // expected input is either Y or N
    // a given flag will be updated accordingly
    private static void ProcessYesNoInput(string question, ref bool anotherOne)
    {
        Console.WriteLine(question);
        // we can make this variable local
        string choice = Console.ReadLine().Trim().ToUpper(); // clean and standardize input
        if (choice == "Y")
        {
            anotherOne = true;
        }
        else
        {
            anotherOne = false;
        }
        Console.WriteLine();
    }

    // this represents the player playing the game
    // they might be dealt with another card which adds to their score
    private static void InnerPlayerLoop(Random myRandom, ref bool anotherCard, ref int playerTotal)
    {
        while (anotherCard == true)
        {
            // this can become local
            int currentCard = myRandom.Next(1, 12);
            playerTotal = playerTotal + currentCard;
            Console.WriteLine($"Your total is {playerTotal}");
            Console.WriteLine();

            if (playerTotal < 21)
            {
                // ask if player wants another card > y/n input
                ProcessYesNoInput("Do you want another card? Y/N", ref anotherCard);
            }
            else if (playerTotal == 21)
            {
                Console.WriteLine("Awesome! That's exactly 21!");
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
