namespace lesson02b;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // declare variables
        byte myByte;
        int myInt;
        long myLong;

        float myFloat; // ~ 7 digits of precision
        double myDouble; // ~ 15 digits
        decimal myDecimal; // ~ 32 extra precision for monetary values

        string myString; // string of characters
        char myChar; // single character in unicode representation

        bool myBoolean;
        DateTime myDateTime; // special/complex data type
        // at this point all the buckets are empty
        // however... numbers default to a value of 0
        // strings default to a value of NULL/EMPTY << BE CAREFUL WITH THESE

        // assign values to variables created above
        // myByte = 1000; // can't store 1000 in a bucket that can contain only 0 to 255....
        myByte = 8;
        myInt = 2000000000; // 2 + 9 zeros
        myLong = 7000000000000000000; // 7 + 18 zeros

        myFloat = 10.99F; // suffixes tell the compiler what data type we mean, F for float
        myDouble = 10.99; // by default numbers with decimal digits are doubles, suffix is optional but recommended
        myDecimal = 10.99M; // M for money

        myString = "This is a very long text!"; // double quotes, as long as memory you have
        // can even be empty
        // myString = "";
        myChar = 'A'; // single quote for single character

        myBoolean = true; // or false
        myDateTime = new DateTime(2022, 09, 15, 20, 19, 00); // recommended approach
        myDateTime = Convert.ToDateTime("2022-09-15"); // can also do this, but make sure string is in international date format

        // print these variables to the console using string interpolation
        Console.WriteLine($"The value of myInt is {myInt.ToString()}"); // always convert to string
        Console.WriteLine($"The value of myFloat is {myFloat.ToString()}");
        Console.WriteLine($"The value of myString is {myString}"); // string is already a string
        Console.WriteLine($"The value of myChar is {myChar}"); // char can be converted to string implicitly or explicitly
        Console.WriteLine($"The value of myChar is {myChar.ToString()}");
        Console.WriteLine($"The value of myDateTime is {myDateTime.ToShortDateString()}");

        // declare three more int variables
        int a = 10;
        int b = 3;
        int result = 0; // 0 because I'll overwrite it all the time

        // review basic math operations printing the result of each operation every time
        result = a + b;
        Console.WriteLine($"The result of a + b is {result.ToString()}");
        result = a * b; // overwriting first result
        Console.WriteLine($"The result of a * b is {result.ToString()}");
        result = a / b; // 10 / 3 = 3??? int division drops the fractions
        Console.WriteLine($"The result of a / b is {result.ToString()}"); // where are the fractions???
        result = a - b;
        Console.WriteLine($"The result of a - b is {result.ToString()}");
        // use double to keep decimal digits in division
        double myResultWithDigits = 0.0;
        myResultWithDigits = (double)a / (double)b; // read as divide a as a double by b as a double
        Console.WriteLine($"The result of a / b is {myResultWithDigits.ToString()}");

        // convert int to byte (explicit, larger to smaller)
        myInt = 234000;
        myByte = (byte)myInt; // value will be truncated, some bits will be dropped during conversion
        Console.WriteLine(myByte.ToString());
        // convert byte to int (implicit, smaller to larger)
        myLong = myByte; // no need to cast, a bite (8 bits) fits in a long (64 bits) bucket
        Console.WriteLine(myLong.ToString());

        // explore string methods
        // Count number of characters in string
        int charCount = myString.Count();
        Console.WriteLine($"myString has {charCount.ToString()} characters");
        // convert to UPPERCASE
        Console.WriteLine(myString.ToUpper());
        Console.WriteLine(myString.ToLower());
        // Concatenate values
        myString = String.Concat(myString, " ", "cat"); // concatenate using the String class and pass a list of strings
        Console.WriteLine(myString);
        // Search for a string within a string
        bool containsCat = myString.Contains("cat");
        Console.WriteLine(containsCat.ToString()); // returns true or false accordingly
    }
}
