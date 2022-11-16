/* design
    Student
    --------
    studentId: int
    firstName: string
    lastName: string
    birthDate: datetime // property > validation
    program: string
    average: decimal
    grades: decimal[]
    ---------
    void registerToProgram(program)
    void enrollToClass(classId)
    void dropFromClass(classId)
*/
public class Student
{
    // fields
    public int StudentId; // get;set; is implicit
    public string FirstName { get; set; } // optionally you can add get;set; to explicitly indicate this is a field
    public string LastName;
    public string Program;
    // properties (I want validation) > more complex field that can have logic
    private DateTime _BirthDate; // private field names start with underscore
    public DateTime BirthDate
    { // 1800-01-01 or 0001-01-01 ??? are these valid?
        get
        {
            // get is called when the value is retrieved for example student.BirthDate
            return this._BirthDate; // return normally, no validation needed
        }
        set
        {
            // set is called when the value is assigned for example student.BirthDate = '1986-01-01'
            // validate then set or throw error
            if (value < (DateTime.Now.AddYears(-100)))
            {
                throw new ArgumentException("That's not a valid value for the birth date!");
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
            // averages go from 0 to 100
            if (value >= 0 && value <= 100)
            {
                this._Average = value;
            }
            else
            {
                this._Average = 0; // invalid value, set to default 0
            }
        }
    }
    // Constructor
    
    // Methods

}