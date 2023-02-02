namespace _2_loopcontrol;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Loop Control!");
        // show only odd numbers
        // 1 3 5  7 9 .... 99
        for (int i = 1; i <= 100; i++)
        {
            // modulo operator to calculate a remainder of a division by 2
            // 100 % 2 = 0 >> even
            // 3 % 2 = 1 >> odd
            int remainder = i % 2; // returns 1 if the remainder of dividing i by 2 is greater than 0
            if (remainder == 0) // even number
            {
                // break; // don't want to print these
                continue;
            }
            Console.Write($"{i.ToString()} ");
        }
    }
}
