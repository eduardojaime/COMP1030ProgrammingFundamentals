namespace lesson10a;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Georgian College!");
        DateTime birthDateA = new DateTime(1986, 01, 01);
        // Instantiate student objects
        Student studentA; // <<< this is variable and it's empty at this point, NULL in memory
        studentA = new Student(2023010101, "Edward", "James", "Programmer Analyst", birthDateA); // should break with new DateTime()
        studentA.Average = 5000;
        Console.WriteLine($"{studentA.FirstName}'s grade letter is {studentA.GetLetterGrade()}");

        // Another 
        DateTime birthDateB = new DateTime(1990,01,01);
        Student studentB = new Student(2023010102, "Jon", "Snow", "Arts", birthDateB);
        studentB.Average = 78;
        Console.WriteLine($"{studentB.FirstName}'s grade letter is {studentB.GetLetterGrade()}");
    }
}
