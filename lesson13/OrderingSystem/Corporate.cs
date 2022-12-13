public class Corporate : Customer
{
    public string CompanyName;
    public string ContactName;
    public string BankAcctNbr;
    public bool SendReminder()
    {
        return true;
    }
}