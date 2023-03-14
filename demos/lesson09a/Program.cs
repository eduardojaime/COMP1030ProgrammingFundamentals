namespace lesson09a;
class Program
{
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
                Console.WriteLine("Do you want another card? Press Y to get another card. Any other key to exit.");
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
            //      generate computer score
            computerScore = cardDealer.Next(18, 22); // more difficult computer > gets 18 to 21

            // determine result and show output
            if (playerScore == 21) {
                Console.WriteLine("Player won!");
            }
            else if (playerScore > 21) {
                Console.WriteLine("Player lost!");
            }
            else if (playerScore == computerScore) {
                Console.WriteLine("It's a tie!");
            }
            else if (playerScore > computerScore) {
                Console.WriteLine("Player won!");
            }
            else {
                Console.WriteLine("Player lost!");
            }
            Console.WriteLine($"Final Scores >>> Player: {playerScore.ToString()} vs Computer: {computerScore.ToString()}");

            // ask if user wants to play again
            Console.WriteLine("Good game! Would you like to play again? Press Y to play again. Any other key to exit.");
            choiceGame = Console.ReadLine().Trim().ToUpper(); // always cleanup user input
            if (choiceGame == "Y") // does this read better?
            {
                anotherGame = true;
            }
            else
            {
                anotherGame = false;
            }
        }

        // Output
        // show scores
    }
}
