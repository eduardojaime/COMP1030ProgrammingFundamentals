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

        // from a method
        SendExternalEmail(myPerson);
    }
    // method that accepts any type of object that implements IEmailable
    // powerful aspect of interfaces
    // program against the interface
    // the following method can send an email via any object
    // method accepts any class that implements IEmailable
    static void SendExternalEmail(IEmailable contact)
    {
        Console.WriteLine(contact.SendEmail());
    }
}
