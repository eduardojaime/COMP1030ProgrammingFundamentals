namespace _2_throwdie;
class Program
{
    static void Main(string[] args)
    {
        // PROGRAM STEP 1 INPUT
        Console.WriteLine("Let's throw dice!");

        // when playing dice you'd usually use two die
        long dice1 = 0;
        long dice2 = 0;
        string result = ""; // message that will be printed at the end

        // always print instructions to your user
        Console.WriteLine("Enter 'y' to throw the dice, and any other letter to exit");
        // retrieve input from console
        String option = Console.ReadLine(); // ReadLine() listens for any number of character followed by the enter key

        // PROGRAM STEP 2 PROCESS
        // act accordingly
        if (option.Trim().ToLower() == "y")
        {
            Console.WriteLine("Here we go!");
            // Use the random number generator to produce a value from 1 to 6
            Random myRandom = new Random();
            dice1 = myRandom.NextInt64(1, 7); // upper bound is exclusive, it does not include 7
            dice2 = myRandom.NextInt64(1, 7);
            // generate result message using string interpolation
            result = $"Dice1: {dice1.ToString()}, Dice2: {dice2.ToString()}, Total: {dice1 + dice2}";
        }
        else
        {
            result = "Goodbye!";
        }

        // PROGRAM STEP 3 OUTPUT
        // Print output to console using string interpolation
        Console.WriteLine(result);
    }
}
