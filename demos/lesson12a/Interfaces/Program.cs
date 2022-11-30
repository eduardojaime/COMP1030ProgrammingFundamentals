using System.Reflection.PortableExecutable;
namespace Interfaces;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Interfaces!");
        Person myPerson = new Person();
        myPerson.FirstName = "Edward";
        myPerson.LastName = "James";
        myPerson.EmailAddress = "ejames@georgian.ca";
        myPerson.PhoneNumber = "6471234455";
        Console.WriteLine(myPerson.SendEmail());
        Console.WriteLine(myPerson.ShowContactInfo());

        // from a method
        SendExternalEmail(myPerson);
    }
    // method that accepts any type of object that implements IEmailable
    static void SendExternalEmail(IEmailable contact)
    {
        Console.WriteLine(contact.SendEmail());
    }
}
