namespace grades;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Grades!");
        // INPUT 
        Console.WriteLine("Enter a letter: A, B, C, D, or F");
        char grade = Console.ReadKey().KeyChar; // readkey listens for a single character input
        string result = ""; // variable to store the message
        // PROCESS
        // determine which message to show
        switch (grade)
        {
            case 'A':
                result = "Excellent!";
                break; // always break so that other cases don't execute, exits switch statement
            case 'B':
            case 'C':
                result = "Well done!";
                break;
            case 'D':
                result = "You passed...";
                break;
            case 'F':
                result = "Try again";
                break;
            default: // if nothing matches
                result = "Invalid input!";
                break;
        }
        // Compare with nested if version
        if (grade == 'A')
        {
            result = "Excellent!";
        }
        else if (grade == 'B' || grade == 'C')
        {
            result = "Well done!";
        }
        else if (grade == 'D')
        {
            result = "You passed...";
        }
        else if (grade == 'F')
        {
            result = "Please try again";
        }
        else
        {
            result = "Invalid input!";
        }
        // OUTPUT
        Console.WriteLine(result);
    }
}
