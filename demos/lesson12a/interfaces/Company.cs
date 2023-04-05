// interfaces help in enhancing the system by giving us references
class Company : IContact, IEmailable
{
    public string CompanyName;
    public string DirectorName;
    public string PhoneNumber;
    public string EmailAddress;
    public string DirectorEmailAddres;
    public bool SendEmail()
    {
        // send to director via smtp server
        return true;
    }
    public string ShowContactInfo()
    {
        return $"{CompanyName}: {PhoneNumber}";
    }
}