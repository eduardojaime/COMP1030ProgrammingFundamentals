namespace _1_loopstructures;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Loops!");
        // Setup for while loops
        Random myRandom = new Random(); // declare and initialize a random object
        int counter1 = myRandom.Next(1, 11); // random number from 1 to 10 
        int counter2 = myRandom.Next(1, 11);
        // while to print an unknown number of ints
        while (counter1 < 10)
        {
            Console.Write($"{counter1.ToString()} "); // 1 2 3 4 5 ...
            counter1++; // shorthand increment operator, increases value by 1
        }
        Console.WriteLine(); // print empty line to move the cursor ahead
        // do-while to print an unknown number of ints
        do
        {
            Console.Write($"{counter2.ToString()} ");
            counter2++;
        }
        while (counter2 < 5);
        Console.WriteLine(); // print empty line to move the cursor ahead
        // for to count to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine();
        // foreach to print all elements in a list
        string[] daysOfWeek = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
        foreach (string day in daysOfWeek)
        {
            Console.Write($"{day} ");
        }
        Console.WriteLine();
    }
}
