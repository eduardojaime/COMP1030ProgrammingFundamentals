namespace _2_loopcontrol;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Loop Control!");
        // Problem: Show only odd numbers from 1 to 100 in console
        // 1 3 5 7 9 ..... 99
        // How do you know a number is odd? if the remainder of the operation N / 2 is > 0
        // 5 / 2 = 2.5 << .5 is the remainder, so it's odd
        // 10 / 2 = 5.0 << .0 means no remainder, so it's even
        for (int i = 1; i <= 100; i++)
        {
            int remainder = i % 2; // % is MODULUS operator, returns the remainder of dividing number / 2
            // % operation returns 1 for odd numbers divided by 2 and 0 for even numbers divided by 2
            if (remainder == 0) // check if even
            {
                // if even then skip
                // break;
                continue;
            }
            Console.WriteLine(i.ToString()); // tostring converts the value in the variable in its string representation
        }
    }
}
