class Person : IContact, IEmailable
{
    public string FirstName;
    public string LastName;
    public string PhoneNumber;
    public string EmailAddress;
    public bool SendEmail()
    {
        // Connect to SMTP server and send email
        return true;
    }
    public string ShowContactInfo()
    {
        return $"{FirstName} {LastName}: {PhoneNumber}";
    }
}