namespace _3_pizzapicker;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Pizza Time! Kawabonga!");
        // Requirements:
        // Declare variables for keeping count
        int pepperoniCount = 0; // default 0
        int hawaiianCount = 0;
        int vegetarianCount = 0;
        int cheeseCount = 0;

        // flag to continue execution
        bool addPizza = true; // set to true to iterate once
        while (addPizza == true)
        {
            // Show options to user
            string options = @"Please select the Pizzas you wish to order:
            1 - Pepperoni
            2 - Hawaiian
            3 - Vegetarian
            4 - Cheese and Tomato

            Or Press ANY other key to exit
            "; // @ allows you to add text with multiple lines
            Console.WriteLine(options);
            // Retrieve input (once)
            char selection = Console.ReadKey().KeyChar; // store user selection in variable
            Console.WriteLine(); // print empty line
                                 // Increment count (if-else)
            if (selection == '1')
            {
                pepperoniCount++; // ++ is shorthand increment 
            }
            else if (selection == '2')
            {
                hawaiianCount++;
            }
            else if (selection == '3')
            {
                vegetarianCount++;
            }
            else if (selection == '4')
            {
                cheeseCount++;
            }
            else
            {
                // not an option, exit the program
                addPizza = false;
            }
            // Show results to user
            // message template
            string message = @"Your order includes:
            Pepperoni   x PEPPERONICOUNT
            Hawaiian    x HAWAIIANCOUNT
            Vegetarian  x VEGETARIANCOUNT
            Cheese      x CHEESECOUNT
            ";
            // replace values in the template
            message = message.Replace("PEPPERONICOUNT", pepperoniCount.ToString());
            message = message.Replace("HAWAIIANCOUNT", hawaiianCount.ToString());
            message = message.Replace("VEGETARIANCOUNT", vegetarianCount.ToString());
            message = message.Replace("CHEESECOUNT", cheeseCount.ToString());

            Console.WriteLine(message);
            // Implement while loop to exit and compare
        }
    }
}
