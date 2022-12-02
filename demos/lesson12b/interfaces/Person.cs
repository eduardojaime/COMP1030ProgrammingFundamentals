public class Person : IContact, IEmailable
{
    // What makes a person?
    public string FirstName;
    public string LastName;
    public string PhoneNumber;
    public string EmailAddress;
    // what can they do? defined by the interface
    public bool SendEmail()
    {
        // how do they do it? defined in the class
        // create smtp client with some credentials
        // create an email message object
        // send email via smtp client
        return true; // everything went well
    }
    public string ShowContactInfo()
    {
        // how do they do it? defined in the class
        return $"{FirstName} {LastName}: {PhoneNumber}";
    }
}