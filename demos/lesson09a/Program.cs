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
        string choiceCard = ""; // Y or N
        bool anotherCard = true; // set to true by default
        // variables that affect main game
        string choiceGame = ""; // Y or N
        bool anotherGame = true;

        // Main game loop > play again?, encloses everything
        while (anotherGame == true)
        {
            // setup/reset the game
            playerTotal = 0;
            computerTotal = 0;
            currentCard = 0;
            anotherCard = true;
            // inner game loop > another card? increase score
            while (anotherCard == true)
            {
                // deal another card
                currentCard = myRandom.Next(1, 12);
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
                    Console.WriteLine("Would you like another card?");
                    choiceCard = Console.ReadLine().Trim().ToUpper();
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
            }
            // computer play

            // OUTPUT determine winner

            // ask user whether they want to play again
            Console.WriteLine("Good game! Would you like to play again?");
            choiceGame = Console.ReadLine().Trim().ToUpper();
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
