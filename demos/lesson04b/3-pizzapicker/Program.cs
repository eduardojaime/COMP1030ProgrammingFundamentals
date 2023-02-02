namespace _3_pizzapicker;
class Program
{
    // Requirements
    // Declare variables for keeping count of each pizza ordered
    // Show options to user (menu)
    // Retrieve input (as a single character)
    // Show final order to user
    // Implement While loop and Nested If statements
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Pizza Time!");
        // Counter variables
        int pepperoniCount = 0; // default value 0
        int hawaiianCount = 0;
        int vegetarianCount = 0;
        int cheeseCount = 0;
        // implement while > show menu, ask for input, increase count
        // counter (flag) variables are declared outside while loops
        bool addPizza = true; // default is true so that it enters the while loop
        while (addPizza) 
        {
            // show menu
            string options = @"Please select the Pizza you wish to add to your order:
            1 - Pepperoni
            2 - Hawaiian
            3 - Vegetarian
            4 - Cheese and Tomato

            Press ANY other key to exit and complete your order.
            "; // multi line string
            Console.WriteLine(options);
            // get input as a single character
            char selection = Console.ReadKey().KeyChar; // keychar represents the actual character
            Console.WriteLine(); // add new line
            // increase count accordingly
            if (selection == '1') {
                pepperoniCount++;
            }
            else if (selection == '2') {
                hawaiianCount++;
            }
            else if (selection == '3') {
                vegetarianCount++;
            }
            else if (selection == '4') {
                cheeseCount++;
            }
            else {
                addPizza = false; // user wants to exit
            }

            string message = @$"Your order includes:
            Pepperoni   x   {pepperoniCount.ToString()}
            Hawaiian    x   {hawaiianCount.ToString()}
            Vegetarian  x   {vegetarianCount.ToString()}
            Cheese      x   {cheeseCount.ToString()}
            "; // multi-line string with interpolation
            Console.WriteLine(message);
        }
    }
}
