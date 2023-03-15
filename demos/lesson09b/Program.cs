namespace lesson09b;
class Program
{
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
            while (anotherCard == true)
            {
                //      give user a card and increase score << if score > 21 then no more cards
                currentCard = cardDealer.Next(1, 12); // it'll give me values 1 to 11 inclusive
                playerScore = playerScore + currentCard;
                Console.WriteLine($"Your total score is now {playerScore.ToString()}");
                Console.WriteLine();
                //      ask if user wants another card
                Console.WriteLine("Press Y to get another, any other key to end your turn.");
                choiceCard = Console.ReadLine().Trim().ToUpper();
                if (choiceCard == "Y")
                {
                    anotherCard = true;
                }
                else
                {
                    anotherCard = false;
                }
            }
            //  generate computer score

            // OUTPUTS
            //  determine winner and show a message
            //  instant win = 21
            //  instant lose > 21
            //  tie comp = player
            //  normal win player > comp
            //  normal lose comp > player and everything else I didn't cover

            //  ask player if they want to play again
            Console.WriteLine("Good game! Press Y to play again, any other key to exit.");
            choiceGame = Console.ReadLine().Trim().ToUpper(); // always clean up user input
            //  yes > repeat game loop
            if (choiceGame == "Y")
            {
                anotherGame = true;
            }
            //  no > show goodbye message and end
            else
            {
                anotherGame = false;
            }
        }
    }
}
