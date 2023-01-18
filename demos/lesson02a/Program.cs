namespace lesson02a;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Data Types!");

        // declare variables > creates the bucket in memory, but it's empty
        // whole number data types > default value is 0
        byte myByte;
        int myInt;
        long myLong;

        // real number data types > default value is 0.0
        float myFloat; // ~ 7 digits, suffix F for float
        double myDouble; // ~15-16 digits (precision), suffix D for Double
        decimal myDecimal; // 64 digits (extra precision), suffix M for money

        // text data types > default value is null
        string myString; // a series of characters, text, no limit
        char myChar; // single character

        // special data types > default are FALSE, or 01-01-01 00:00:00 for date times
        bool myBoolean;
        DateTime myBirthday; 

        // assign values
        // for integers, data type will be detected by compiler
        // 8 > any number data type work
        // 1000 > byte or sbyte won't work... the rest will
        // myByte = 1000; // red squiggly line
        myByte = 8; // range 0 to 255
        // myInt = 8; // range -2billion to +2billion, storing 8 wastes a lot of space in memory
        myInt = 2000012345; // valid range
        myLong = 7000000000000000000; // 7 + 18 zeros

        // for floating point numbers, always use the suffix
        myFloat = 10.99F;
        myDouble = 10.99D; // no need to use suffix because C# assumes all numbers with digits are doubles
        myDecimal = 10.99M; 

        myString = "A coffee in France is \u20AC 3"; // remember to escape characters
        // myChar = (char)8364; // 8364 is the € symbol in Unicode table
        myChar =  'A'; // single quote, single character
        // Console.WriteLine(myString);
        // Console.WriteLine(myChar.ToString());

        myBoolean = true;
        myBirthday = new DateTime(1986, 09, 16, 07, 00, 00);

        // print them out to the console
        Console.WriteLine($"The value of myInt is {myInt.ToString()}");
        Console.WriteLine($"The value of myFloat is {myFloat.ToString()}");
        Console.WriteLine($"The value of myString is {myString}"); // no interpolation
        Console.WriteLine($"The value of myChar is {myChar}");
        Console.WriteLine($"The value of myBirthday is {myBirthday.ToShortDateString()}");


        // review mathematical operations

        // print results

        // convert values

        // utilize string methods
    }    
}
