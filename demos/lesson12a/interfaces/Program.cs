namespace interfaces;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Interfaces!");
        Person myPerson = new Person();
        myPerson.FirstName = "Edward";
        myPerson.LastName = "James";
        myPerson.PhoneNumber = "(647) 1234455";
        myPerson.EmailAddress = "ed@georgian.ca";
        //Console.WriteLine(myPerson.SendEmail());
        Console.WriteLine(myPerson.ShowContactInfo());
        SendExternalEmail(myPerson);
        // new requirement, we need to handle Companies in the system     
        Company myCompany = new Company();
        myCompany.CompanyName = "Programmers Inc.";
        myCompany.DirectorName = "James Edwards";
        myCompany.DirectorEmailAddres = "jim@programmers.com";
        myCompany.EmailAddress = "contact@programmes.com";
        //Console.WriteLine(myCompany.SendEmail());
        Console.WriteLine(myCompany.ShowContactInfo());
        SendExternalEmail(myCompany);
    }
    // Another benefit is code reusability
    // you can write methods that utilize interface as parameters
    public static void SendExternalEmail(IEmailable contact)// wrong way >>> (Person person, Company company) {
    {
        Console.WriteLine(contact.SendEmail());
    }
}
