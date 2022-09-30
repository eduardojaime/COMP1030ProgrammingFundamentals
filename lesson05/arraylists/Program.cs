using System.Collections;

namespace arraylists;
class Program
{
    // Reference and examples: 
    // https://www.programiz.com/csharp-programming/arraylist
    // https://www.c-sharpcorner.com/UploadFile/3d39b4/arraylist-in-C-Sharp/
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Array List!");
        // arrays are fixed size so they work only when we know max number of elements we will have
        // if we don't know how many elements we will have we can use Array List
        ArrayList studentList = new ArrayList();

        bool addAnother = true;
        while (addAnother)
        {
            Console.WriteLine("Please enter a name to add to the list: ");
            string studentName = Console.ReadLine();

            studentList.Add(studentName);

            Console.WriteLine("Would you like to add another name? Press Y to continue, ANY other key to exit.");
            char selection = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (selection == 'Y' || selection == 'y')
            {
                addAnother = true;
            }
            else
            {
                addAnother = false; // exit
            }
        }

        Console.WriteLine($"There are {studentList.Count} students registered.");
        Console.WriteLine($"Here's the list:");
        foreach(string student in studentList) {
            Console.WriteLine(student);
        }
    }
}
