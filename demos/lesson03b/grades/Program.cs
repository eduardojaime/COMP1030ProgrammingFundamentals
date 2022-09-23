namespace grades;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Grades!");
        // INPUT
        Console.WriteLine("Enter a letter: A, B, C, D, or F");
        char grade = Console.ReadKey().KeyChar; // readkey listens to a single character input and returns its associated info
        string result = ""; // assign default values to your variables
        Console.WriteLine();
        // PROCESS
        // determine which message to show
        switch (grade)
        {
            case 'A':
                result = "Excellent!";
                break;
            case 'B': // double case is an OR operation
            case 'C':
                result = "Well done!";
                break;
            case 'D':
                result = "You passed...";
                break;
            case 'F':
                result = "Please try again...";
                break;
            default:
                result = "Invalid input, enter only A, B, C, D, or F";
                break;
        }
        // Compare with nested if
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
