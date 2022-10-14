using System.Collections; // Namespaces are toolboxes, this one contains ArrayList
using System.Collections.Generic; // This one contains List<> and Dictionary<,>

namespace lesson06b;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // var
        // C# is a strongly typed language
        int myNumber = 100; // specify the data type needed
        decimal myDecimalNumber = 100.0M;
        string myText = "This is text";
        // when you use var, c# will guess the data type you need
        var myNumber2 = 200;
        var myDecimalNumber2 = 100.0M; // suffix M means money
        var myText2 = "This is also text";

        string[] authors = { "Mahesh", "Mike", "Allen", "David", "Monica" };
        var authorQ = from author in authors
                      where author[0] == 'M'
                      select author;
        foreach (var a in authorQ)
        {
            Console.WriteLine(a);
        }

        // Non-Generic Collections
        // Arrays > fixed size, specific data type
        // List of int with 10 elements
        int[] myIntArr = new int[10]; // declare and initialize an array
        myIntArr[1] = 100; // assigns 100 to the second box in the array

        foreach(var number in myIntArr) {
            Console.WriteLine(number.ToString());
        }

        // "everything in C# is an object" literally because everything descends from Object
        object[] myObjArr = new object[3];
        myObjArr[0] = "this is a string";
        myObjArr[1] = true; // boolean
        myObjArr[2] = 100.9F; // float
        
        // this is where var becomes useful
        foreach(var element in myObjArr) {
            Console.WriteLine(element.ToString());
        }

        // ArrayLists > built-in C# class, System.Collections namespace, looks like a dynamic list (increases/decreases in size)
        // but behind scenes implements an array of object
        // offers helper methods to manipulate data in the collection: Add(), Remove(), Count
        // NonGeneric collection > we don't specify which data type to use
        ArrayList myArrList = new ArrayList(); // declare and initialize
        // count is 0
        myArrList.Add("Jack");
        myArrList.Add("Logan");
        myArrList.Add("Waqas");
        myArrList.Add("Jeff");
        myArrList.Add(true); // boolean
        myArrList.Add(100); // int
        // count is 4
        // var studentCount = myArrList.Count;
        Console.WriteLine($"There are {myArrList.Count} students in my list");
        // Update
        myArrList[0] = "Edward"; // updating the name for element in first position
        // avoid accessing index positions greater than or equal to Count
        // myArrList[10] = "TEST"; // Throws System.ArgumentOutOfRangeException: Index was out of range

        // Remove
        myArrList.Remove("Edward"); // 3
        myArrList.RemoveAt(2); // last position should be n-1 which is 2

        Console.WriteLine($"There are {myArrList.Count} students in my list");
        foreach(var student in myArrList) {
            Console.WriteLine(student);
        }

        // Generic Collections
        // Lists<> > similar to ArrayList but forces you to specify a data type for the collection
        // It's contained in the System.Collections.Generic namespace
        List<string> myNames = new List<string>(); // declare and initialize
        // empty list, count = 0, no elements
        int initialCount = myNames.Count;
        foreach(var person in myNames) {
            Console.WriteLine("Execution won't enter the loop at all");
        }
        // Add
        myNames.Add("Edward"); // pos 0
        myNames.Add("Ricardo"); // pos 1
        myNames.Add("Julia"); // pos 2
        Console.WriteLine($"There are {myNames.Count} names in my list"); // 3
        // Update
        myNames[0] = "Edward James";

        // cannot mix datatypes
        // myNames.Add(true); // error cannot convert from 'bool' to 'string'

        // Remove
        myNames.Remove("Ricardo");
        myNames.RemoveAt(1); // removes Julia

        Console.WriteLine($"There are {myNames.Count} names in my list"); // 3
        foreach(var person in myNames) {
            Console.WriteLine(person);
        }

        // Dictionaries > set of key/value pairs, specify data type for key and value
        // keys > identify the records and are unique (cannot be repeated in the dictionary)
        // values > data associated to the record, not unique
        Dictionary<int, string> myStudents = new Dictionary<int, string>(); // declare and initialize
        // similar methods to those in the list
        myStudents.Add(123456, "Eric");
        myStudents.TryAdd(234567, "Arshpreet"); // tryAdd is better since it doesn't break
        myStudents.TryAdd(345678, "Taiwo");
        // myStudents.Add(345678, "Edward"); // this one will break because 345678 already exists
        // System.ArgumentException: An item with the same key has already been added. Key: 345678
        bool successAdd = myStudents.TryAdd(345678, "Edward"); // returns true on success, false on failure
        Console.WriteLine($"There are {myStudents.Count} students in my dictionary");

        bool studentExists = myStudents.ContainsKey(345678);
        Console.WriteLine($"Student Number 345678 exists: {studentExists.ToString()}");

        bool removeByKeySuccess = myStudents.Remove(123456); // returns true
        bool removeFail = myStudents.Remove(1); // returns false because 1 does not exist as a key

        // Access keys and values separately
        foreach(var student in myStudents) {
            Console.WriteLine($"Key: {student.Key} Value: {student.Value}");
        }
    }
}
