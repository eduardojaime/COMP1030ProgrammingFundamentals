namespace _3_pizzapicker;
class Program
{
    // Requirements:
    // Declare variables for keeping count
    // Show options (menu) to the user and map selections to variables
    // Retrieve input (number)
    // Increment counter variables representing quantity
    // While loop to exit and show output
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Pizza Time!"); // <<< TMNT KAWABONGA!
        // variables to keep count of how many pizzas of each type the user ordered
        int pepperoniCount = 0; // default as 0
        int hawaiianCount = 0;
        int vegetarianCount = 0;
        int cheeseCount = 0;

        // while loop needs a counter (flag) variable declared beforehand
        bool addPizza = true; // set to true so execution enters loop
        while (addPizza) // READS >> WHILE USER WANTS TO ADD PIZZA TO THE ORDER
        {
            string options = @"Please select the Pizza you wish to order from the menu below: 
            1 - Pepperoni
            2 - Hawaiian
            3 - Vegetarian
            4 - Cheese and Tomato

            Press ANY other key to exit and complete your order

            "; // @ indicates this string contains multiple lines
            // INPUT
            Console.WriteLine(options);
            char selection = Console.ReadKey().KeyChar; // extracts whichever character the user entered, limits input to one char only
            Console.WriteLine(); // print empty lines after readkey()

            // PROCESS > increase count OR set add pizza to false
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
                // the user entered any other key so they want to exit
                // set flag to false so while loop exits in the next check
                addPizza = false;
            }
            // OUTPUT > show current order, use string interpolation
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
