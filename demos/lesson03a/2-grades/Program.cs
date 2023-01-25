namespace _2_grades;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Grades!");
        // 1) INPUT > Letter > A B C D F
        Console.WriteLine("Enter a letter: A, B, C, D, or F");
        char grade = Console.ReadKey().KeyChar; // readkey listens for a single character
        // cleanup input
        grade = grade.ToString().ToUpper().ToCharArray()[0];// 'a' > "a" > "A" > ['A'] > 'A'
        string result = ""; // to store the generated message
        // 2) PROCESS > generate a message based on the letter using switch
        // why switch? we have a letter value, we want todo something based on the value not a T/F expression
        // another consideration is that I have a predefined list of values to compare
        switch (grade)
        {
            // cases to cover A to F
            case 'A': // single quote for single char
                result = "Excellent!";
                break; // use break to skip checking any other case afterwards
            case 'B':
            case 'C': // this is a B or C
                result = "Well done!";
                break;
            case 'D':
                result ="You passed....";
                break;
            case 'F':
                result = "Please try again. :)";
                break;
            // default for any other letter
            default:
                result ="Invalid input!\n"; // \n is a new line character
                break; // optional in default case but recommended for consistency
        }
        Console.WriteLine(); // empty WriteLine prints new line
        // 3) OUTPUT > show the generated message
        Console.WriteLine(result);
    }
}
