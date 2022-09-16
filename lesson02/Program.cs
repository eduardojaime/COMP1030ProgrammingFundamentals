namespace basicprogram;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // declare variables
        byte myByte;
        int myInt;
        long myLong;

        float myFloat; // ~ 7 digits
        double myDouble; // ~ 15 digits
        decimal myDecimal; // ~ 64 extra precision for monetary values

        string myString;
        char myChar;

        bool myBoolean;
        DateTime myBirthday;

        // Assign values to variables
        // myByte = 1000; // incorrect because byte is -128 to 127
        myByte = 8;
        myInt = 2000012345;
        myLong = 7000000000000000000;

        myFloat = 10.99F; // f for float
        myDouble = 10.99; // numbers with fractional values without suffix are double by default
        myDecimal = 10.99M; // decimals represent Money (M)

        myString = "This is a very long text CAT!"; // double quotes, as long as the constitution
                                                // myString = ""; // or empty
        myChar = 'A'; // note the single-quotes

        myBoolean = false; // or true;
        myBirthday = new DateTime(2022, 09, 16, 07, 00, 00); // complex type

        // Print values to console (convert to String)
        // use interpolation
        Console.WriteLine($"The value of myInt is {myInt.ToString()}");
        Console.WriteLine($"The value of myFloat is {myFloat.ToString()}");
        Console.WriteLine($"The value of myString is {myString}");
        Console.WriteLine($"The value of myChar is {myChar}");
        Console.WriteLine($"The value of myDate is {myBirthday.ToShortDateString()}");

        // Declare 3 additional int variables
        int a = 10;
        int b = 3;
        int result = 0;
        double resultWithDecimals = 0.0;

        // Perform mathematical operations and show results
        result = a + b;
        Console.WriteLine($"The result of a + b is {result.ToString()}");
        result = a * b;
        Console.WriteLine($"The result of a * b is {result.ToString()}");
        result = a / b; // remainder is lost in divisions with ints
        resultWithDecimals = (double)a / (double)b; // need to cast int to double to access the decimals
        Console.WriteLine($"The result of a / b is {result.ToString()}");
        Console.WriteLine($"The result (with decimals) of a / b is {resultWithDecimals.ToString()}");
        result = a - b;
        Console.WriteLine($"The result of a - b is {result.ToString()}");

        // Int to Byte (Explicit cast)
        myByte = (byte)myInt; // value will be truncated
        Console.WriteLine(myByte.ToString());

        // Byte to Int (Implicit cast)
        myLong = myByte; // no need to cast, a bite (8 bits) fits in a long (64 bits) bucket
        Console.WriteLine(myLong.ToString());

        // String methods
        // Count number of characters in a string
        int charCount = myString.Count();
        Console.WriteLine($"myString has {charCount.ToString()} characters");
        // Convert to UPPERCASE
        Console.WriteLine(myString.ToUpper());
        // Concatenate values
        myString = String.Concat(myString, " ", "cat"); // concatenate using the String class and pass a list of strings
        Console.WriteLine(myString);
        // Contains
        bool containsCat = myString.Contains("cat"); // case sensitive search of the word
        Console.WriteLine(containsCat); // contains returns true or false accordingly
    }
}
