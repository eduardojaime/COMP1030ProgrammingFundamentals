namespace lesson10b;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Georgian College!");
        // Student student1 = new Student();
        // Console.WriteLine(student1.FirstName); // null/emptyfields
        DateTime invalidDate = new DateTime(); // default value 0001/01/01 00:00:00 
        // we added validation for the birthdate values
        // Student studentA = new Student(230001, "Edward", "James", "Programmer Analyst", invalidDate); // broken
        
        DateTime birthDateA = new DateTime(1986, 01, 01);
        Student studentA = new Student(230001, "Edward", "James", "Programmer Analyst", birthDateA); // this would work
        studentA.Average = 200; // invalid avg range
        Console.WriteLine($"{studentA.FirstName}'s grade letter is {studentA.GetLetterGrade()}");

        Student studentB = new Student(230002, "Jon", "Snow", "Arts", new DateTime(1990, 01,01));
        studentB.Average = 78;
        Console.WriteLine($"{studentB.FirstName}'s grade letter is {studentB.GetLetterGrade()}");
    }
}
