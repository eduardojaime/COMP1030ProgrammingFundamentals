namespace throwdie;
/*
    Requirements:
    - Console application
    - Users will run the app 
    - We'll have two variables, each represent a dice
    - App generates numbers at random for two variables
    - App sums numbers and shows result to user
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Dice!");
        // INPUT
        // whether user wants to play
        string option = "";
        // hardcoded input
        long dice1 = 1; // you can use int too but will need to cast the result of random() call
        long dice2 = 1; // good idea to set default values explicitly
        string result = ""; // I'll use this to store the message that I'll print out at the end

        // always print out instructions to users
        Console.WriteLine("Enter 'y' to throw dice, and any other letter/symbol to exit.");
        // ask the user whether they want to play
        option = Console.ReadLine(); // listens to the console, and read text from the user until they press 'enter' key
        
        // PROCESS
        // use option and act accordingly
        // method chaining
        if (option.Trim().ToLower() == "y") { // recommendation for when comparing strings: trim and tolower()
            // continue game
            Console.WriteLine("Here we go!"); // print confirmation messages, always give feedback to the user
            // use the random number generator to produce a value for each dice
            Random myRandom = new Random(); // creates an instance of the Random number generator object
            dice1 = myRandom.NextInt64(1, 7); // upper bound is exclusive (excludes 7), lower bound is inclusive (includes 1)
            dice2 = myRandom.NextInt64(1,7);  
            
            // string interpolation to generate a message
            result = $"Dice1: {dice1.ToString()}, Dice2: {dice2.ToString()}, Total: {(dice1 + dice2).ToString()}";
        }
        else {
            // say goodbye
            result = $"Later gator!";
        }
        // OUTPUT
        Console.WriteLine(result); // PRINT RESULT regardless of what message got generated
    }
}
