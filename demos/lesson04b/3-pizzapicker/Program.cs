namespace _3_pizzapicker;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pizza Time! Kawabonga!");
        // INPUT
        // keep count of ordered pizzas
        int pepperoniCount = 0; // default 0 ordered
        int hawaiianCount = 0;
        int vegetarianCount = 0;
        int cheeseCount = 0;

        // 1 control variable
        bool addPizza = true; // true because users want pizza by default
        // 2 condition
        while (addPizza == true)
        {
            // show options in the terminal, use multi-line text with @
            string options = @"Please select the Pizza you wish to order:
            1 - Pepperoni
            2 - Hawaiian
            3 - Vegetarian
            4 - Cheese and Tomato

            Press ANY other key to exit and complete your order
            ";
            Console.WriteLine(options);
            char selection = Console.ReadKey().KeyChar; // extracts the character they entered
            Console.WriteLine(); // print new line after calling ReadKey()

            // PROCESS
            // what structure to use?
            // could also use switch 
            if (selection == '1') // use single quote when comparing char value
            {
                pepperoniCount++; // shorthand increment operator
            }
            else if (selection == '2') // use single quote when comparing char value
            {
                hawaiianCount++;
            }
            else if (selection == '3') // use single quote when comparing char value
            {
                vegetarianCount++;
            }
            else if (selection == '4') // use single quote when comparing char value
            {
                cheeseCount++;
            }
            else
            {
                // handle everything else, EXIT and SHOW ORDER
                // 3 updating the control variable
                addPizza = false;
            }

            // OUTPUT
            // Construct a message TEMPLATE
            string message = @"Your order includes:
            Pepperoni   x PEPPERONICOUNT
            Hawaiian    x HAWAIIANCOUNT
            Vegetarian  x VEGETARIANCOUNT
            Cheese      x CHEESECOUNT
            ";
            // Replace keywords in the template with values
            // replaces a string in the message with a value
            message = message.Replace("PEPPERONICOUNT", pepperoniCount.ToString());
            message = message.Replace("HAWAIIANCOUNT", hawaiianCount.ToString());
            message = message.Replace("VEGETARIANCOUNT", vegetarianCount.ToString());
            message = message.Replace("CHEESECOUNT", cheeseCount.ToString());

            Console.WriteLine(message);
        }
    }
}
