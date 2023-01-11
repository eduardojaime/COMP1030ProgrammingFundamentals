/*
Design > UML Class Diagram

Student
----------
StudentId: int
FirstName: string
LastName: string
BirthDate: datetime > property with validation
Program: string
Average: decimal > property with validation
Grades: decimal[]
----------
GetLetterGrade(): string
EnrollToCourse(): void
RegisterToProgram(): void
*/
public class Student
{
    // FIELDS > simple data stores, no validation or formatting involved
    public int StudentId;
    public string FirstName { get; set; } // optional but not needed, syntactical sugar
    public string LastName;
    public string Program;
    public decimal[] Grades;
    // PROPERTIES
    private DateTime _BirthDate;
    public DateTime BirthDate
    {
        get
        {
            // add here logic to execute when returning the value > formatting
            return this._BirthDate; // optional this. to refer to the current class
        }
        set
        {
            // add here logic to execute when assigning the value > validation
            if (value < (DateTime.Now.AddYears(-100)))
            {
                throw new ArgumentException("That's not a valid birth date!");
            }
            else
            {
                this._BirthDate = value;
            }
        }
    }
    private decimal _Average;
    public decimal Average
    {
        get
        {
            return this._Average;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                this._Average = value; // valid value, accept and store
            }
            else
            {
                this._Average = 0; // invalid value set average to 0 by default, no exception needed
            }
        }
    }
    // CONSTRUCTORS
    public Student(int studentId, string firstName, string lastName, string program, DateTime birthDate)
    {
        this.StudentId = studentId;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Program = program;
        this.BirthDate = birthDate; // I want the validation in the public property method so don't use the private field
    }
    // PUBLIC METHODS
    public string GetLetterGrade()
    {
        if (this.Average >= 90) { return "A"; }
        else if (this.Average >= 80) { return "B"; }
        else if (this.Average >= 70) { return "C"; }
        else if (this.Average >= 60) { return "D"; }
        else { return "F"; }
    }
    // PRIVATE METHODS
}