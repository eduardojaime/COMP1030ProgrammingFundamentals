namespace lesson02b;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Data!");
        // declare variables
        // whole numbers
        byte myByte; // unsigned = stores only positive numbers
        sbyte mySignedByte; // signed = stores negative numbers
        int myInt;
        long myLong;
        // real numbers
        float myFloat; // 7 digits
        double myDouble; // 16 digits
        decimal myDecimal; // 64 digits for extra precision
        // text
        string myText; // text of any size
        char myChar; // single character
        // special
        bool myBoolean;
        DateTime myBirthday;

        // assign values to these variables and print them out
        // byte stores 0 to 255
        // store 1000
        // myByte = 1000; // breaks because it's a larger number than the bucket size
        myByte = 8;
        myInt = 2000012345; // 2 billion
        myLong = 7000000000000000000; // quintillions > 7 + 18 zeros

        // floating point numbers > always use suffix
        // 10.99 > default double
        myFloat = 10.99F; // F tells the compiler that 10.99 is a float
        myDouble = 10.99D; // doesn't need suffix, C# by default assumes it's double
        myDecimal = 10.99M;  // M is for Money

        // Text and special ones
        myText = "A coffee in France is \u20AC 3.00";
        Console.WriteLine(myText);
        myChar = 'A'; // single quote single character
        // myChar = (char)8364; // you can cast int to char and get, this is the decimal representation of Euro symbol
        Console.WriteLine(myChar);

        myBoolean = true;
        myBirthday = new DateTime(2023, 09, 16, 07, 00, 00);

        // perform mathematical operations on numbers
        int a = 10;
        int b = 3;
        int result = 0;
        double resultWithDecimals = 0.0;

        // Perform mathematical operations and show results
        result = a + b;
        Console.WriteLine($"The result of a + b is {result.ToString()}"); // embeds value in result in string
        
        result = a * b;
        Console.WriteLine($"The result of a * b is {result.ToString()}");
        
        result = a / b; // remainder is lost in divisions with ints
        resultWithDecimals = (double)a / (double)b; // need to cast int to double to access the decimals
        Console.WriteLine($"The result of a / b is {result.ToString()}");
        Console.WriteLine($"The result (with decimals) of a / b is {resultWithDecimals.ToString()}");
        
        result = a - b;
        Console.WriteLine($"The result of a - b is {result.ToString()}");

        // convert values

        // string methods for string manipulation
    }
}
