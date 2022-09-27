namespace _1_loopstructures;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Loops!");

        Random myRandom = new Random(); // initialize random generator object
        int counter1 = myRandom.Next(1, 11); // generate a number from 1 to 10, used in while
        int counter2 = myRandom.Next(1, 11); // used in do-while

        // while > we don't know how many executions we need, it might be 0
        while (counter1 < 10)
        {
            Console.Write($"{counter1.ToString()} "); // prints in the same line
            counter1++; // ++ is the shorthand increment operator it means counter1 = counter1 + 1;
        }
        Console.WriteLine(); // print empty line

        // do while > we want to execute code at least 1 time
        do
        {
            Console.Write($"{counter2.ToString()} "); // prints in the same line
            counter2++;
        }
        while (counter2 < 10);
        Console.WriteLine(); // print empty line

        // for > we want to repeat a block of code n number of times
        for (int i = 1; i <= 10; i++) // initialize i to 1, check i is less than or equal to 10, increase i by 1
        {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine();

        // foreach > we have a list
        string[] daysOfWeek = {"SUNDAY", "MONDAY", "TUESDAY","WEDNESDAY","THURSDAY","FRIDAY","SATURDAY"};
        foreach(string day in daysOfWeek) {
            Console.WriteLine(day);
        }

    }
}
