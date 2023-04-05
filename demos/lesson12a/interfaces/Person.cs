// I have a class and don't know what else to do with this
// Interfaces help by providing reference
class Person : IContact, IEmailable
{
    public string FirstName;
    public string LastName;
    public string PhoneNumber;
    public string EmailAddress;

    public string ShowContactInfo()
    {
        return $"{FirstName} {LastName}: {PhoneNumber}";
    }
    public bool SendEmail()
    {
        // TODO Send via SMTP SERVER
        return true;
    }
}