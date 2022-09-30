namespace _3_arrayclass;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Array Class!");

        int[] arr1 = { 34, 72, 13, 44, 25, 30, 10 };
        int[] arr2 = arr1;

        // Print original array values
        Console.Write("Original Array: ");
        foreach (int i in arr1) 
        {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine();

        // Reverse Array
        Array.Reverse(arr2);
        Console.Write("Reversed Array: ");
        foreach(int i in arr2) 
        {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine();

        // Sort Array
        Array.Sort(arr1); // sorts in ascending order
        // Array.Reverse(arr1); // sort then reverse for descending order
        Console.Write("Sorted Array: ");
        foreach(int i in arr1) {
            Console.Write($"{i.ToString()} ");
        }
        Console.WriteLine();
    }
}
