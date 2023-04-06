class Company : IContact, IEmailable
{
    public string CompanyName;
    public string DirectorName;
    public string PhoneNumber;
    public string DirectorPhoneNumber;
    public string DirectorEmailAddress;
    public bool SendEmail()
    {
        // CONNECT TO SMTP SERVER AND SEND TO DirectorEmailAddress
        return true;
    }
    public string ShowContactInfo()
    {
        return $"{CompanyName}, run by {DirectorName}: {PhoneNumber}";
    }
}