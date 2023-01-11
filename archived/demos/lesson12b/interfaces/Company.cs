public class Company: IContact, IEmailable
{
    public string Name;
    public string PhoneNumber;
    public string Email;
    // best practice approach
    public bool SendEmail()
    {
        return true;
    }

    public string ShowContactInfo()
    {
        return $"{Name}: {PhoneNumber}";
    }

    // Bad code
    // // inconsistency > bad
    // public void SendMessage() {
    //     // send email
    // }
    // // confusing code, similar behaviour different name
    // public string ShowInfo(){
    //     return Name;
    // }
}