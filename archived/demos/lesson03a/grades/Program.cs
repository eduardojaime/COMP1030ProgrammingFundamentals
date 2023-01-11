namespace grades;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Grades!");
        // INPUT 
        Console.WriteLine("Enter a letter: A, B, C, D, E or F");
        char grade = Convert.ToChar(Console.ReadKey().KeyChar.ToString().ToUpper()); // readkey listens for a single character input
        string result = ""; // variable to store the message
        Console.WriteLine(); // enters new line
        // PROCESS
        // determine which message to show
        switch(grade) {
            case 'A': // A is different than a
                result ="Excellent!";
                break; // always break so that other cases don't execute, exits switch statement
            case 'B': // B is different than b
            case 'C':
                result = "Well done!";
                break;
            case 'D':
                result ="You passed...";
                break;
            case 'F':
                result = "Try again";
                break;
            default: // if nothing matches
                result ="Invalid input!";
                break;
        }
        // OUTPUT
        Console.WriteLine(result);
    }
}
