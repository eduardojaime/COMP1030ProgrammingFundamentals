namespace loopstructures;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Loops!");

        Random myRandom = new Random();
        int counter1 = myRandom.Next(1, 11);
        int counter2 = myRandom.Next(1, 11);
        // while
        while (counter1 < 10)
        { // condition is checked then code is executed
            Console.Write($"{counter1.ToString()} ");
            counter1++;
        }
        Console.WriteLine();

        // do-while
        do
        {
            Console.Write($"{counter2.ToString()} ");
            counter2++;
        }
        while (counter2 < 10); // code executes then condition is check
        Console.WriteLine();

        // for
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine();

        // foreach
        string[] daysOfWeek = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
        foreach (string day in daysOfWeek)
        {
            Console.Write($"{day} ");
        }
        Console.WriteLine();
    }
}
