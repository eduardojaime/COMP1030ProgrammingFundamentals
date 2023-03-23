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
    // PUBLIC METHODS
    // PRIVATE METHODS
}