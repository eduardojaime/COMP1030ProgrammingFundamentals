namespace _2_loopcontrol;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Loop Control!");
        // Use Case > detect a condition that we want to skip or stop running the loop completely
        // display odd numbers in the terminal
        for (int i = 1; i <= 100; i++)
        {
            // use modulo operator to obtain the remainder of a division by 2
            // 10 % 2 = 0 
            // 11 % 2 = 1 
            int remainder = i % 2;
            // Console.WriteLine($"Remainder: {remainder.ToString()}");
            // check if the remainder is 0 in which case number is even
            // if remainder is larger than 0 then number is odd
            if (remainder > 0)
            {
                // break; // stops the execution of the entire loop here, and exits
                continue; // skips current iteration and goes on to the next one
            }
            Console.Write($"{i.ToString()} ");
        }
    }
}
