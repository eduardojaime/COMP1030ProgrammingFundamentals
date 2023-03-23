// define class with the same name as file
class Student
{
    // FIELDS
    // no need to use { get; set; }
    public int StudentId;
    // this is optional, no need for private field in the simplified version
    public string FirstName { get; set; }
    public string LastName;
    public string Program;
    // PROPERTIES
    // Use properties when you need some validation logic
    // BirthDates > must be born in the last 100 years to be considered valid
    private DateTime _BirthDate; // _ for private fields
    public DateTime BirthDate
    {
        // get; // read operation, it can be omitted
        set
        { // write-only property
            // set is called when the value is assigned
            if (value < DateTime.Now.AddYears(-100))
            {
                throw new ArgumentException("That's not a valid date.");
            }
            else
            {
                this._BirthDate = value;
            }
        }
    }
    // valid avg range is 0 to 100
    private float _Average;
    public float Average
    {
        get
        {
            // no need to format or do anything else, just return val
            return this._Average;
        }
        set
        {
            // invalid ranges are handled as 0s
            if (value >= 0 && value <= 100)
            {
                this._Average = value; // valid val so complete assignment
            }
            else
            {
                this._Average = 0;
            }
        }
    }
    // CONSTRUCTORS
    // as with every method, it's recommended that parameter names
    // match field names
    // this method will force user to pass these parameters
    // when creating an object
    public Student(int studentId, string firstName, string lastName,
                    string program, DateTime birthDate)
    {
        // it's a bad practice to add logic here (validation)
        // just use this for assigning initial values
        this.StudentId = studentId;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Program = program;
        // this._BirthDate = birthDate; // not the right way
        this.BirthDate = birthDate; // use property so value is validated
    }
    // PUBLIC METHODS
    // returns a letter based on the avg score
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