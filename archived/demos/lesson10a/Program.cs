namespace lesson10a;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, Georgian College!");

        // 1) Add 1 student and print average
        Student studentA = new Student(10, "Edward", "James", "Programming", Convert.ToDateTime("1986-01-01"));
        Student studentB = new Student(11, "Jon", "Snow", "Arts", Convert.ToDateTime("1990-01-01"));
        studentA.Average = 200;
        studentB.Average = 78;
        Console.WriteLine($"{studentA.FirstName}'s grade letter is {studentA.GetLetterGrade()}");
        Console.WriteLine($"{studentB.FirstName}'s grade letter is {studentB.GetLetterGrade()}");
        // 2) Add a list of students and print averages and grade letters
    }
}
