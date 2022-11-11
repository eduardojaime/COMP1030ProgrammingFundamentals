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
                // add to the player score
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
                Console.Clear();
            }
            // generate computer score
            // determine winner
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
}
