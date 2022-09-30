namespace _1_basicarrays;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Arrays!");
        // Array 1 - initialize empty, show default values
        Console.WriteLine("Array 1");
        int[] arr1 = new int[10]; // array of 10 elements
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine($"Index: {i.ToString()} Value: {arr1[i].ToString()}");
        }
        // Array 2 - initialize with a list of data
        Console.WriteLine("Array 2");
        int[] arr2 = { 20, 30, 10, 400, 123, 34, 76 };
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.WriteLine($"Index: {i.ToString()} Value: {arr2[i].ToString()}");
        }
        // Array 3 - access/modify the values in the array and then print
        Console.WriteLine("Array 3");
        int[] arr3 = new int[10];
        for (int i = 0; i < arr3.Length; i++)
        {
            // modify values
            arr3[i] = 2 + 2 * i;
        }
        // print new values
        for (int i = 0; i < arr3.Length; i++)
        {
            Console.WriteLine($"Index: {i.ToString()} Value: {arr3[i].ToString()}");
        }
        // Array 4 - find the total sum of elements in the array
        Console.WriteLine("Array 4");
        int total = 0;
        int[] arr4 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        for (int i = 0; i < arr4.Length; i++)
        {
            // access current element in position i and add it to total
            total = total + arr4[i];
        }
        Console.WriteLine($"Total sum of elements is {total.ToString()}");
    }
}
