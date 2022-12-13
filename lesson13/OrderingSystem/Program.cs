namespace DEMO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // if anything, utilize the classes and call the methods
        // code below should break after making Customer an abstract class
        // Customer myCustomer = new Customer();
        // myCustomer.PrintOrderHistory();

        Individual myIndv = new Individual();
        // Line below should break due to encapsulation
        // myIndv.CreditCardNbr = "12345465";
    }
}
