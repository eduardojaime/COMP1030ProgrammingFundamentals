namespace _1_loopstructures;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Loops Structures!");
        // Demo all different loop structures
        // Input
        Random myRandom = new Random(); // random number generator
        int counter1 = myRandom.Next(1, 15); // assigns random number from 1 to 10 (11 not included)
        int counter2 = myRandom.Next(1, 15); // assigns a different random number from 1 to 10
        Console.WriteLine($"Counter1: {counter1.ToString()} Counter2: {counter2.ToString()}");
        // Process + Output (writeline)
        // while > condition checked and if true then code executed
        while (counter1 < 11) // so any number from 1 to 10 will return true
        {
            Console.Write($"{counter1.ToString()} "); // write() prints in the same line
            counter1++; // increment operator
        }
        Console.WriteLine(); // print a new line <<
        // Console.Write("\n\n\n"); // << three spaces
        // do-while > code executed once and then condition checked
        do 
        {
            Console.Write($"{counter2.ToString()} ");
            counter2++;
        }
        while (counter2 < 11);
        Console.WriteLine(); // empty line
        // for > similar execution than while
        // counter is usually declared and used inside for loop
        int counter3 = myRandom.Next(1,11);
        for (int i = counter3; i < 11; i++) {
            Console.Write($"{i.ToString()} "); // counter somehow used inside the code of for loops
        }
        Console.WriteLine();
        // foreach > works with lists and iterates automatically, no need to stop execution or increase counters
        // string[] daysOfWeek = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
        // Advantage no need to modify code if list changes
        string[] daysOfWeek = { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY" }; // most of the time lists come from a data store
        foreach (string day in daysOfWeek) 
        {
            Console.Write($"{day} ");
        }
        Console.WriteLine();
        
        // Advanced question > accessing a collection of keyvalue pairs
        // Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        // foreach(KeyValuePair<string, string> pair in myDictionary) {}
        // foreach(string key in myDictionary.Keys) {}
        // foreach(string val in myDictionary.Values) {}
    }
}
