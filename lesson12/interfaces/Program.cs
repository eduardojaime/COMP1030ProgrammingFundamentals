namespace interfaces;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Interfaces!");

        Person myPerson = new Person();
        myPerson.FirstName = "Edward";
        myPerson.LastName = "James";
        myPerson.PhoneNumber = "(647) 123 4455";
        myPerson.EmailAddress = "ceo@mycompany.com";

        Console.WriteLine(myPerson.SendEmailAddress());
        Console.WriteLine(myPerson.ShowContactInfo());
    }
}
