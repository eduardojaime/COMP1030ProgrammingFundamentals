using System.Collections; // Non-generic > they work with object types
using System.Collections.Generic;

namespace lesson06;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Collections!");
        // Arrays and ArrayList review
        int myNumber = 100; // -2b to 2b
        // 100, 200, 300, 400, 500 ....
        // [] means list
        int[] myNumbers = { 100, 200, 300, 400, 500 };
        foreach (int x in myNumbers) {
            Console.Write($"{x.ToString()} ");
        }
        Console.WriteLine(); // empty line

        // initalize without a list
        int[] my5Numbers = new int[5]; // 5 positions
        foreach(int x in my5Numbers) {
            Console.Write($"{x.ToString()} ");            
        }
        Console.WriteLine(); // empty line

        // arrays are fixed in size
        // ArrayList are dynamically resized
        ArrayList myList = new ArrayList(); // creates an empty list of objects
        // it's not bound to a specific datatype
        // behind scenes it's an array of objects
        myList.Add("Eduardo");
        myList.Add(35);
        myList.Add(true);
        myList.Add(new DateTime(2023,02,11));
        // since arraylist can contain any data type
        // it's useful to use var to declare the element variable
        // foreach(string s in myList) <<< throws invalidcastexception
        foreach(var elem in myList) {
            Console.Write(elem.ToString() + " "); // best practice
        }
        Console.WriteLine();
        // Restrictions of VAR
        // var age; // << breaks
        var age = 25; // declare and initialize in the same line of code

        // Generic Collections
        // List<>
        List<int> myIntList = new List<int>(); // creates an empty list of ints
        // myIntList.Add("Eduardo"); // cannot convert string to int
        myIntList.Add(100);
        myIntList.Add(200);
        myIntList.Add(300);
        myIntList.Add(400);
        myIntList.Add(500);

        foreach (int elem in myIntList) {
            Console.Write(elem.ToString() + " ");
        }
        Console.WriteLine();

        // Common Collection Methods and Attributes
        // Add() > adds a new element (see above)
        myIntList.Add(600);
        // Remove() > removes element from the list if found
        myIntList.Remove(300);
        // RemoveAt() > removes element at a specific position index
        myIntList.RemoveAt(0); // removes first element 
        // iterate and test
        foreach (int elem in myIntList) {
            Console.Write(elem.ToString() + " ");
        }
        Console.WriteLine();
        // Count > returns number of elements in list
        Console.WriteLine($"There are {myIntList.Count} elements in the list.");
        // Contains() > searches for a value in the list and returns T/F accordingly
        bool isThere500 = myIntList.Contains(500);
        Console.WriteLine($"List contains 500 > {isThere500.ToString()}");
        bool isThere800 = myIntList.Contains(800);
        Console.WriteLine($"List contains 800 > {isThere800.ToString()}");
        // clear() > removes all elements in the list;
        myIntList.Clear();
        Console.WriteLine($"After calling Clear() there are {myIntList.Count} elements in the list.");

        // Dictionary > set of key/value pairs, specify the data type for the key and the value
        // key > identifies the record and are unique
        // value > data associated with the key, are not unique
        // List of students
        Dictionary<int, string> myStudents = new Dictionary<int, string>(); // creates an empty dictionary
        // Add and Remove the same way
        myStudents.Add(111111, "Alan");
        myStudents.Add(222222, "Elva");
        myStudents.Add(333333, "Vilas");
        // myStudents.Add(333333, "Breaking"); // duplicate keys throw argumentException
        myStudents.Remove(333333);
        myStudents.Add(333333, "NonBreaking");

        // check if key exists before adding
        if (myStudents.ContainsKey(444444) == false) // if key is not already in the dictionary then I can add
        {
            myStudents.Add(444444, "Roman");
        }

        // iterate
        foreach(var keyValuePair in myStudents) {
            Console.WriteLine($"StudentId {keyValuePair.Key} is {keyValuePair.Value}");
        }
        Console.WriteLine();

        // return list of all keys
        var keyList = myStudents.Keys;
        foreach (int key in keyList) {
            Console.Write(key.ToString() + " ");
        }
        Console.WriteLine();
        
        // return list of all values
        var valueList = myStudents.Values;
        foreach(string val in valueList) {
            Console.Write(val + " ");
        }
        Console.WriteLine();


    }
}
