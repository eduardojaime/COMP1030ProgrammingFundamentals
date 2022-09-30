using System.Collections; // add this to import ArrayLists in your file
namespace _2_arraylists;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Array List!");
        // arrays are fixed size so they work only when we know max number of elements we will have
        // if we don't know how many elements we will have we can use Array List
        ArrayList studentList = new ArrayList(); // Declaring and initializing an ArrayList object

        bool addAnother = true;
        while (addAnother == true) {
            // Ask user to enter name and retrieve it
            Console.WriteLine("Please enter a name to add to the list:");
            string studentName = Console.ReadLine();
            // Add name to list
            studentList.Add(studentName);
            // Ask if they want to add another name
            Console.WriteLine("Would you like to add another student? Press Y or ANY key to exit");
            char selection = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (selection == 'Y' || selection == 'y') {
                addAnother = true; // carry on
            }
            else {
                addAnother = false; // exit
            }
        }
        // Output
        studentList.Sort();
        Console.WriteLine($"There are {studentList.Count} students registered.");
        Console.WriteLine($"Here's the list:");
        foreach (string student in studentList) 
        {
            Console.WriteLine(student);
        }
    }
}
