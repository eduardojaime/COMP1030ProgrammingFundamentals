﻿namespace lesson02a;
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
        int a = 10;
        int b = 3;
        int result = 0; // best practice > always initialize values even if it's just 0
        double resultWithDecimals = 0.0;

        result = a + b;
        Console.WriteLine($"Result of a+b is {result.ToString()}"); // 13
        result = a - b;
        Console.WriteLine($"Result of a-b is {result.ToString()}"); // 7
        result = a * b;        
        Console.WriteLine($"Result of a*b is {result.ToString()}"); // 30
        result = a / b;
        Console.WriteLine($"Result of a/b is {result.ToString()}"); // 3.3333333 >> int operations drop decimals > 3
        resultWithDecimals = (double)a / (double)b;
        Console.WriteLine($"Result of a/b with decimals is {resultWithDecimals.ToString()}"); // 16 digits

        // Int to Byte (Explicit cast)
        // myInt = 2000012345
        myByte = (byte)myInt; // value will be truncated from a binary level
        Console.WriteLine(myByte.ToString());

        // Byte to Int (Implicit cast)
        myLong = myByte; // no need to cast, a byte (8 bits) fits in a long (64 bits) bucket
        Console.WriteLine(myLong.ToString());

        // String methods
        // Count number of characters in a string
        int charCount = myString.Length; // or Count()
        Console.WriteLine($"myString has {charCount.ToString()} characters");
        // Convert to UPPERCASE
        Console.WriteLine(myString.ToUpper()); // or ToLower()
        // Concatenate values
        myString = String.Concat(myString, " ", "cat"); // concatenate using the String class and pass a list of strings
        Console.WriteLine(myString);
        // Contains
        bool containsCat = myString.Contains("cat"); // case sensitive search of the word
        Console.WriteLine(containsCat); // contains returns true or false accordingly
    }    
}
