namespace _1_loopstructures;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Loops!");
        // Declare variables 
        Random myRandom = new Random(); // Random number generator
        int counter1 = myRandom.Next(1, 11); // 11 is not included, gets number from 1 to 10
        int counter2 = myRandom.Next(1, 11); // 1 <= number < 11
        Console.WriteLine($"Counter1: {counter1.ToString()}, Counter2: {counter2.ToString()}");
        // while > checks and if true then executes
        while (counter1 < 11)
        {
            Console.Write($"{counter1.ToString()} ");
            counter1++; // increment operator ++, increases value by 1
        }
        Console.WriteLine(); //print new line
        // do-while > executes once and then checks and if true it does another round
        do
        {
            Console.Write($"{counter2.ToString()} ");
            counter2++;
        }
        while (counter2 < 11);
        Console.WriteLine(); // add empty line
        // for
        for (int i = 1; i < 11; i++)
        {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine(); // add empty line

        // foreach
        string[] daysOfWeek = { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY" }; // lists usually come from a third party
        foreach (string day in daysOfWeek) 
        {
            Console.Write($"{day} ");
        }

    }
}
