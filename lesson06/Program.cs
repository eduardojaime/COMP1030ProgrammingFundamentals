using System.Buffers;
using System.Collections; // ArrayLists, and other non-generic data structures
using System.Collections.Generic;
namespace lesson06;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Review!");
        // strongly typed language
        int myNumber = 100;
        decimal myDecimalNumber = 100.45M; // m for money
        string myText = "This is text";

        // int value  
        var age = 25;
        Console.WriteLine("var holds an int = {0}", age);
        // string value  
        var name = "Mahesh Chand";
        Console.WriteLine("var holds a string = {0}", name);

        // Arrays > fixed, specific data type
        // List of int with 10 elements
        int[] myIntArr = new int[10];
        // Access by index 0 to n-1
        myIntArr[9] = 100; // add 100 to the last box in my array

        int[] myTwoBoxArray = new int[2];
        myTwoBoxArray[0] = 50; // 50 is assigned to index 0 (first position)
        myTwoBoxArray[1] = 100; // 100 is assigned to index 1 (second and last position)

        // return myTwoBoxArray; // for HackerRank
        object[] myObjArr = new object[10]; // at the end of the day everything in C# is a descendant of object
        myObjArr[0] = "this is element in position 0";
        myObjArr[1] = true; // boolean
        myObjArr[2] = 100.89F; // float

        // ArrayList > dynamic (increase/decrease size), doesn't require a data type
        ArrayList myArrList = new ArrayList(); // behind scenes it's an object array
        // lists offer helper methods
        myArrList.Add(100); // pos 0
        myArrList.Add("text"); // pos 1
        myArrList.Add(true); // pos 2
        myArrList.Add(1); // pos 3
        // myArrList.Add(null); // would make the program break in line 44

        var count = myArrList.Count; // property that returns how many elements there are 

        myArrList.Remove("text");
        myArrList.RemoveAt(1); // what happens here?

        // option 1 for loop
        for (int i = 0; i < myArrList.Count; i++)
        {
            object element = myArrList[i]; // retrieve elements by index
            Console.WriteLine(element.ToString()); // convert object to string
        }

        // option 2 and the best is foreach loop
        foreach (var element in myArrList)
        {
            Console.WriteLine(element.ToString()); // convert object to string
        }

        // Generic Collections > require you to specify a data type
        // List > similar to ArrayList but force you to specify a data type for the collection
        List<string> myNames = new List<string>(); // initialize with a constructor using the keyword new
        int listCount = myNames.Count; // returns 0

        foreach (var person in myNames) // won't enter the loop at all
        {
            Console.WriteLine(person);
        }

        myNames.Add("Edward");
        myNames.Add("Ricardo");
        myNames.Add("Julia"); // count is 3 so index is in range of 0 to 2

        myNames[0] = "Edward James"; // assignment is valid but be careful not to access an index greater or equal to count

        // myNames.Add(true); // error!

        listCount = myNames.Count; // 3

        myNames.Remove("Ricardo"); // removes 2nd element
        myNames.RemoveAt(1); // removes Julia

        foreach (var person in myNames)
        {
            Console.WriteLine(person); // will print Edward
        }

        // Dictionary > set of key/value pairs, specify data type for key and value
        // keys > identify the record and are unique
        // values > contain data associated to the record, are not unique
        Dictionary<int, string> myStudents = new Dictionary<int, string>(); // Initialize
        // similar methods to the list and array list
        myStudents.Add(123456, "Alan");
        myStudents.Add(234567, "Max");
        myStudents.Add(345678, "Vilas");
        //  myStudents.Add(345678, "Same key"); // will break with error: An item with the same key has already been added.

        bool succesAdd = myStudents.TryAdd(345678, "repeated key"); // return false because key exists already

        bool removedSuccess = myStudents.Remove(234567); // returns true because key exists
        bool removedFail = myStudents.Remove(1); // returns false because key doesn't exist

        bool studentExists = myStudents.ContainsKey(345678); // returns true because key exists
        int studentCount = myStudents.Count;

        var valueList = myStudents.Values;
        var keyList = myStudents.Keys;

        foreach (var student in myStudents)
        {
            // string interpolation
            Console.WriteLine($"Key: {student.Key} Value: {student.Value}"); // Key: 345678 Value: Vilas
        }
    }
}
