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
        string choiceCard = "";
        bool anotherCard = true;
        // variables that affect entire game
        string choiceGame = "";
        bool anotherGame = true;

        // main game loop
        while (anotherGame == true)
        {
            // reset game
            playerTotal = 0;
            computerTotal = 0;
            currentCard = 0;
            anotherCard = true;

            // inner game loop > dealing another card
            while (anotherCard == true)
            {
                currentCard = myRandom.Next(1, 12);
                playerTotal = playerTotal + currentCard;
                Console.WriteLine($"Your total is {playerTotal}");
                Console.WriteLine();

                if (playerTotal < 21)
                {
                    // ask if player wants another card > y/n input
                    Console.WriteLine("Do you want another card? Y/N");
                    choiceCard = Console.ReadLine().Trim().ToUpper(); // clean and standardize input
                    if (choiceCard == "Y")
                    {
                        anotherCard = true;
                    }
                    else
                    {
                        anotherCard = false;
                    }
                    Console.WriteLine();
                }
                else if (playerTotal == 21) {
                    Console.WriteLine("Awesome! That's exactly 21!");                    
                    anotherCard = false;
                    Console.WriteLine();
                }
                else {
                    Console.WriteLine("Oops! That's more than 21...");                    
                    anotherCard = false;
                    Console.WriteLine();
                }
            }

            // computer plays
            computerTotal = myRandom.Next(15, 22);
            Console.WriteLine($"Computer total is {computerTotal}");
            Console.WriteLine();

            // show output > determine winner
            if (playerTotal == 21) {
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

            // Ask if player wants to play again > y/n input
            Console.WriteLine("Good game! Would you like to play again?");
            choiceGame = Console.ReadLine().Trim().ToUpper(); // clean and standardize input
            if (choiceGame == "Y")
            {
                anotherGame = true;
            }
            else
            {
                anotherGame = false;
            }
            Console.WriteLine();
        }
    }
}
