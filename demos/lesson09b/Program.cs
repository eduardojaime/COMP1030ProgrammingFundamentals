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
            // inner game loop > another card y/n
            // generate computer score
            // determine winner
            // ask for another game > y/n
            Console.WriteLine("Good game! Do you want to play again?");
            choiceGame = Console.ReadLine().Trim().ToUpper(); // validate and clean inputs
            if (choiceGame == "Y") {
                anotherGame = true;
            }
            else {
                anotherGame = false;
            }
            Console.WriteLine(); // prints empty line for formatting
        }
    }
}
