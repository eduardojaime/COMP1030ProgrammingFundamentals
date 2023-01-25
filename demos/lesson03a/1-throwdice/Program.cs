using System.Security.Cryptography;
using System;
namespace _1_throwdice;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Dice!");
        // 1) INPUT >> Y/N, Values for two dice
        Console.WriteLine("Let's throw some dice!");
        // Set up variables
        // we'll play with two die (valid range 1 - 6)
        int dice1 = 1; // always provide a default value
        int dice2 = 1;
        string option = ""; // user will enter Y/N
        string result = ""; // message that the program will generate at the end

        // always print instructions
        Console.WriteLine("Enter 'y' to throw the dice, and any other letter to exit.");
        // retrieve input
        option = Console.ReadLine(); // Listens for any number of characters and the ENTER key
        // cleanup 
        option = option.Trim().ToLower(); // removes white spaces and converts to lowercase because Y != y
        // 2) PROCESS >> determining whether to play, add values to calculate score, generate message
        if (option == "y")
        {
            // calculate score and generate message
            Console.WriteLine("Here we go!");
            // Use a random number generator to produce two values in the range of 1 to 6
            Random myRandom = new Random(); // declare and initialize an instance of Random
            dice1 = myRandom.Next(1, 7); // maxValue is exclusive, which means it's not included in calculation
            // dice1 = RandomNumberGenerator.GetInt32(1,7); // Alternative approach
            dice2 = myRandom.Next(1, 7); // min value is inclusive, which means I can get a 1
            // generate result message using string interpolation
            result = $"Dice1: {dice1.ToString()}, Dice2: {dice2.ToString()}, Total: {(dice1 + dice2).ToString()}";
        }
        else
        {
            // generate a message
            result = "Thank you, good bye!";
        }
        // 3) OUTPUT >> show score
        Console.WriteLine(result);
    }
}
