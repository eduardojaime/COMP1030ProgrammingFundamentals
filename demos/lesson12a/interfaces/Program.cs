namespace interfaces;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Interfaces!");
        Person myPerson = new Person();
        myPerson.FirstName = "Edward";
        myPerson.LastName = "James";
        myPerson.PhoneNumber ="(647) 1234455";
        myPerson.EmailAddress = "ed@georgian.ca";
        Console.WriteLine(myPerson.SendEmail());
        Console.WriteLine(myPerson.ShowContactInfo());        
    }
}
