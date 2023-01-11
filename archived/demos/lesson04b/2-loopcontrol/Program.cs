namespace _2_loopcontrol;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Loop Control!");
        // odd or even numbers
        // show only odd numbers in the range of 1 to 100
        for(int i = 1; i <= 100; i++) 
        {
            // modulus operator in C# is %
            // 10 % 2 = 0 because 10 / 2 = 5.0 > so 0 stays 0
            //  5 % 2 = 1 because  5 / 2 = 2.5 > so 0.5 becomes 1 
            int remainder = i % 2;
            if (remainder == 0) // detect even numbers and skip them
            {
                // break; // stops the execution here and does not continue the loop
                continue; // skips the rest of the code in the for block and carries on with the next iteration
            }
            // else block is optional
            Console.WriteLine(i.ToString()); // prints current number
        }
    }
}
