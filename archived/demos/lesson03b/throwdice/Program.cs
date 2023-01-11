namespace throwdice;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's throw dice!");
        // INPUT 
        int dice1 = 1; // best practice is to assign a default value in your variables 
        int dice2 = 1;
        string result = ""; // variable to store message that will be shown at the end

        // Let's ask users if they want to play
        // always print instructions to them
        Console.WriteLine("Enter 'y' to throw the dice, and any other letter to exit");
        // retrieve the input from the console
        string option = Console.ReadLine(); // listens for any number of characters until user presses enter

        // PROCESS
        if (option.Trim().ToLower() == "y") // best practice: Trim() and ToLower() your strings when comparing them
        {
            // they want to play the game, so generate random values and calculate total score to show
            // Use the random number generator object to produce a value from 1 to 6
            Random myRandom = new Random(); // creates an instance of Random class and assigns it to the myRandom variable
            dice1 = myRandom.Next(1, 7); // 1 is inclusive, 7 is exclusive meaning it'll never return 7
            dice2 = myRandom.Next(1, 7);
            // generate a result message using string interpolation showing total score
            result = $"Dice1: {dice1.ToString()}, Dice2: {dice2.ToString()}, Total: {(dice1 + dice2).ToString()}";
        }
        else
        {
            // they don't want to play
            result = "Goodbye!";
        }   
        // OUTPUT
        Console.WriteLine(result);
    }
}
