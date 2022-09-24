namespace gameloop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Game Loop!");

        // INPUT
        bool keepPlaying = true;
        char selection = 'y';
        // PROCESS
        do {
            Console.WriteLine("You are playing this Amazing game!");
            // Add here your game code

            Console.WriteLine("Would you like to play again? Press 'y' to play another round");
            selection = Console.ReadKey().KeyChar;
            if (selection == 'y' || selection == 'Y') {
                keepPlaying = true;
            }
            else {
                keepPlaying = false;
            }
        }
        while (keepPlaying);

        // OUTPUT
        Console.WriteLine("Thank you for playing!");
        
    }
}
