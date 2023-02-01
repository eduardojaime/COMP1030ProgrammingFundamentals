namespace pizzapicker;
class Program
{
    // Requirements:
    // Declare variables for keeping count
    // Show options to user
    // Retrieve input (once)
    // Increment count (if-else)
    // Show results to user
    // Implement while loop to exit and compare
    static void Main(string[] args)
    {
        Console.WriteLine("Pizza Time! Kawabonga!");
        // We want to keep count of how many pizzas of each type are ordered
        int pepperoniCount = 0;
        int hawaiianCount = 0;
        int vegetarianCount = 0;
        int cheeseCount = 0;

        bool addPizza = true;
        while (addPizza)
        {
            string options = @"Please select the Pizza you wish to order:
            1 - Pepperoni
            2 - Hawaiian
            3 - Vegetarian
            4 - Cheese and Tomato
            Press ANY other key to exit and complete your order
        ";
            Console.WriteLine(options);
            char selection = Console.ReadKey().KeyChar;
            Console.WriteLine(); // new line

            if (selection == '1')
            { // pepperoni
                pepperoniCount++;
            }
            else if (selection == '2')
            { // hawaiian
                hawaiianCount++;
            }
            else if (selection == '3')
            { // vegetarian
                vegetarianCount++;
            }
            else if (selection == '4')
            { // cheese and tomato
                cheeseCount++;
            }
            else
            { // any other input (invalid)
              // do nothing
                addPizza = false;
            }

            string message = @$"Your order includes:
            Pepperoni   x   {pepperoniCount.ToString()}
            Hawaiian    x   {hawaiianCount.ToString()}
            Vegetarian  x   {vegetarianCount.ToString()}
            Cheese      x   {cheeseCount.ToString()}
            ";
            Console.WriteLine(message);
        }
    }
}
