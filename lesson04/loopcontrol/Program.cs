namespace loopcontrol;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Loop Control!");
        // show only odd numbers
        for (int i = 1; i <= 100; i++)
        {
            int remainder = i % 2; // modulus operator is the remainder of the division
            if (remainder == 0)
            {
                // break; // stops the execution here and does not continue
                continue; // skips the rest of the code in the for block and carries on with the next iteration
            }
            Console.Write($"{i.ToString()} ");
        }
    }
}
