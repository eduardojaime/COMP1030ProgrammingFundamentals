namespace _2_grades;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Grades!");
        // Switch
        // INPUT > Letter representing a grade (CHAR)
        Console.WriteLine("Enter a letter: A, B, C, D, or F"); // always show what the valid range of values is
        char grade = Console.ReadKey().KeyChar; // returns ConsoleKeyInfo object, access KeyChar to retrieve actual character
        string result = "";
        // PROCESS > comparing that value against a list and generating a message accordingly
        switch (grade) 
        {
            // multiple cases
            case 'A': // single quote for single characters (char data type)
                result = "Excellent!";
                break; // important to add break to prevent program from continuing checking cases
            case 'B': // OR C
            case 'C':
                result = "Well done!";
                break;
            case 'D':
                result = "You passed...";
                break;
            case 'F':
                result = "Please try again. :)";
                break;
            // default case for any invalid input
            default:
                result = "Invalid Input!";
                break; // best practice, consistency
        }
        // OUTPUT > show message in console
        Console.WriteLine(result);

    }
}
