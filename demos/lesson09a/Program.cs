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
            // setup the game
            // inner game loop > another card? increase score
            // computer play

            // OUTPUT determine winner
            
            // ask user whether they want to play again
            Console.WriteLine("Good game! Would you like to play again?");
            choiceGame = Console.ReadLine().Trim().ToUpper(); 
            if (choiceGame == "Y") {
                anotherGame = true;
            }
            else {
                anotherGame = false;
            }
            Console.WriteLine();
        }
    }
}
