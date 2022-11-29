public class Person : IContact, IEmailable
{
    public string FirstName;
    public string LastName;
    public string PhoneNumber;
    public string EmailAddress;

    public bool SendEmailAddress()
    {
        // Send email address via SMTP
        return true;
    }

    public string ShowContactInfo()
    {
        return $"{FirstName} {LastName}: {PhoneNumber}";
    }
}