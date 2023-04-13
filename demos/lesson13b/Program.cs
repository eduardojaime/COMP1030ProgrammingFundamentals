namespace lesson13b;
class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            try
            {
                // 1) try catch blocks would usually go closer to the code that handles user input
                Console.WriteLine("Hello, World!");
                int[] myArr = { 1, 2, 3 };
                Console.WriteLine("Please enter an index number to show the value: ");
                // The following lines can break
                string? choice = Console.ReadLine(); // depending on user input, setting nullable type (?) makes program expect and handle nulls
                // int index = int.Parse(choice); // can only parse any numeric (int) value represented as string
                int index = 0;
                int.TryParse(choice, out index);// this method has a inner try-catch
                Console.WriteLine($"Index {index.ToString()} value is {myArr[index].ToString()}"); // if index is out of bounds
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid numeric value. Please enter only digits.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Invalid number. Please enter a number from 0 to 2.");
            }
            catch (Exception ex)
            {
                // Exception type catches everything
                // Message is not very useful as it makes the user guess what they need to do to fix the issue
                Console.WriteLine("Oops! Something happened: " + ex.Message); // format and index
            }
            Console.WriteLine("Exit?");
            string exit = Console.ReadLine();
            if (exit == "Y") { keepRunning = false; }
        }
    
        decimal amt = 10.0M;
        // OPTION A
        List<Product> products = new List<Product>(); // EMPTY LIST
        Product prodA = new Product();
        Product prodB = new Product();
        products.Add(prodA);
        products.Add(prodB);

        List<Product> prodAlternative = new List<Product>() { prodA, prodB };
    
    }
}
