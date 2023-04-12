using System.Xml.Schema;
namespace lesson13a;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter a number:");
            string response = Console.ReadLine();
            int value = int.Parse(response);
            // IF ELSE is one option, but you will have to cover ALL possible choices
            // cover all possible user inputs 100% is not possible
            // the best way is to just cover valid options we expect
            // and enclose the code that could break in a try...catch block
            // anything that interacts to an external source: user, database, web content, third party packages
            value = value * value; // get the squared number
            Console.WriteLine("Result is: " + value.ToString());
        }
        catch (FormatException ex)
        {
            // handles only FormatException types
            // cleanup, set some default values and continue, OR show user guidance
            Console.WriteLine("Only digits from 0 to 9 are allowed as input." + ex.Message);
        }
        catch (Exception ex)
        {
            // will handle any type of exception
            Console.WriteLine("Oops!" + ex.Message); // <<< not useful at all, always tell the user what to do or expect next
        }
    }
}
