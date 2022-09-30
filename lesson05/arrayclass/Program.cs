namespace arrayclass;
class Program
{
    // Reference and examples:
    // https://www.geeksforgeeks.org/c-sharp-array-class/
    // https://www.tutorialspoint.com/csharp/csharp_array_class.htm
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Array Class!");

        int[] arr1 = { 34, 72, 13, 44, 25, 30, 10 };
        int[] arr2 = arr1;
        Console.Write("Original Array: ");
        foreach (int i in arr1)
        {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine();

        // reverse the array
        Array.Reverse(arr2);
        Console.Write("Reversed Array: ");

        foreach (int i in arr2)
        {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine();

        //sort the array
        Array.Sort(arr1);
        Console.Write("Sorted Array: ");

        foreach (int i in arr1)
        {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine();
    }
}
