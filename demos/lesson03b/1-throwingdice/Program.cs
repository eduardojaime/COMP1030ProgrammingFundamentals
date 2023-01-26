namespace _1_throwingdice;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Dice!");
        // IF STATEMENTS
        // INPUT > 2 DICE (1-6), Y/N
        // Best Practice: Variable declaration first
        int dice1 = 1; // default value is in valid range 1 to 6
        int dice2 = 1;
        // 1 + 1 snake eyes > GI JOE
        string option = ""; // default value for strings is empty string
        string result = ""; // message that we'll show at the end
        // retrieve input (user and generated)
        // always show instructions to the user
        Console.WriteLine("Let's throw dice!!");
        Console.WriteLine("Enter 'y' to throw the dice, or any other key to exit.");
        option = Console.ReadLine(); // ReadLine() waits for the user to enter something in the terminal and press ENTER
        option = option.Trim().ToLower(); // input cleanup
        // PROCESS > ADD TWO RESULTS > SCORE
        // make a decision based on user option
        if (option == "y") // case sensitive comparison
        {
            // play game > generate numbers, calculate score, generate message
            Console.WriteLine("Here we go!");
            // Random Number generator class
            Random myRandom = new Random(); // declaring and instantiating an instance of Random object
            dice1 = myRandom.Next(1, 7); // min value is inclusive, max value is exclusive (will not be generated)
            // returns number greater than or equal to 1 and LESS THAN 7
            dice2 = myRandom.Next(1,7);
            result = $"Dice1: {dice1.ToString()}, Dice2: {dice2.ToString()}, Score: { (dice1 + dice2).ToString() }";
        }
        else
        {
            // exit 
            result = "Thank you, good bye!";
        }
        // OUTPUT > SHOW MESSAGE WITH SCORE OR THANK YOU
        Console.WriteLine(result); // there will always be a message in result
    }
}
