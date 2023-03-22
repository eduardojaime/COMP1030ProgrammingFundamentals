// class definition
class Student
{
    // RECOMMENDED ORDER:
    // FIELDS
    public long StudentId; // no need to add { get; set; }, it's implicit
    public string FirstName { get; set; } // optional but not required for fields
    public string LastName;
    public string Program;
    // PROPERTIES (PRIVATE PROPERTY AND PUBLIC GETTER/SETTER METHODS)
    private DateTime _BirthDate; // use underscore for naming private fields
    public DateTime BirthDate
    { // same name without underscore
        // get; // do we want to make this visible? no, it will be write-only
        set
        { // we'll add validation here
            // (optional) check that value is not already set
            // use keyword 'value' to access the value being set
            if (value < DateTime.Now.AddYears(-100))
            { // .AddYears(-100) subtracts 100 years
                throw new ArgumentException("That's not a valid value. Enter something within the last 100 years.");
            }
            else
            {
                // this refers to the class we are editing
                this._BirthDate = value; // set value of private field
            }
        }
    }

    private float _Average; // this is the actual bucket of data
    public float Average // this is a method, not an actual bucket of data
    {
        get
        {// read operation
            return this._Average; //just return whatever value is stored
        }
        set
        {   // write operation
            // valid averages go from 0 to 100
            if (value >= 0 && value <= 100)
            {
                this._Average = value; // valid range
            }
            else
            {
                this._Average = 0; // no exception, handle invalid range by setting default value
            }
        }
    }
    // CONSTRUCTORS
    public Student(long studentId, string firstName, string lastName, string program, DateTime birthDate)
    {
        // recommendation is to only use constructor to set values
        // not recommended to add validation, use setters for that
        this.StudentId = studentId;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Program = program;
        this.BirthDate = birthDate; // use the property method not the private field in order to keep validation
    }
    // PUBLIC METHODS
    // method to return a letter grade based on the average value
    public string GetLetterGrade()
    {
        if (this.Average >= 90) { return "A"; }
        else if (this.Average >= 80) { return "B"; }
        else if (this.Average >= 70) { return "C"; }
        else if (this.Average >= 60) { return "D"; }
        else { return "F"; }
    }
    // PRIVATE METHODS
    // none for this example
}