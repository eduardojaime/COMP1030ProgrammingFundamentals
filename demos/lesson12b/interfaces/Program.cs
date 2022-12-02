namespace interfaces;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Interfaces!");
        // Design Question: What do you usually want in an contact management system?
        // I have information about People
        // Categories: Contact > print info, Emailable > send email
        Person myPerson = new Person();
        myPerson.EmailAddress = "ceo@eduardo.com";

        Company myCompany = new Company();
        myCompany.Email = "admin@company.com";

        SendExternalEmail(myPerson);
        SendExternalEmail(myCompany); // both implement IEmailable so they are valid parameters
    }
    // powerful aspect of interfaces
    // program against the interface
    // the following method can send an email via any object
    // method accepts any class that implements IEmailable
    public static void SendExternalEmail(IEmailable contact)
    {
        // method defined in interface
        contact.SendEmail();
    }
}
