// Person "is" Contact, Person is Emailable
public class Person : IContact, IEmailable
{
    public string FirstName;
    public string LastName;
    public string PhoneNumber;
    public string EmailAddress;
    // required methods
    public string ShowContactInfo()
    {
        return $"{FirstName} {LastName}: {PhoneNumber}";
    }

    public bool SendEmail()
    {
        // Connect to SMTP server
        // Create email message
        // call smtp.Send()
        return true;
    }
}