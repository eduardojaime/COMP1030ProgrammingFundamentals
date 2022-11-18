namespace lesson10b;
class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Hello, Georgian College!");
        // Declare and initialize instances of students and print the grade letter
        Student edward = new Student(10, "Edward", "James", "Programming", Convert.ToDateTime("1986-01-01"));
        Student jon = new Student(11,"Jon","Snow","Arts", Convert.ToDateTime("1990-01-01"));
        edward.Average = 200; // invalid value, should produce F
        jon.Average = 78;
        Console.WriteLine($"{edward.FirstName}'s avg is {edward.Average} and grade is {edward.GetLetterGrade()}"); // F
        Console.WriteLine($"{jon.FirstName}'s avg is {jon.Average} and grade is {jon.GetLetterGrade()}"); // C
    }
}
