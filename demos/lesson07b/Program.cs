namespace lesson07b;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Basic game loop
        // INPUT > PROCESS > OUTPUT > REPEAT?
        // flag to indicate whether we play another round
        bool continuePlaying = true; // set to true to enter the loop the first time

        while (continuePlaying == true) 
        {
            // INPUT
            // PROCESS
            // OUTPUT
            // REPEAT?
            Console.WriteLine("Do you want to play another round? Press Y to continue. ANY other key will exit the game.");
            string answer = Console.ReadLine().Trim().ToUpper(); // cleanup user input
            if (answer == "Y") {
                continuePlaying = true;
            } 
            else {
                continuePlaying = false;
            }
        }
        Console.WriteLine("Thank you for playing!");
    }
}
