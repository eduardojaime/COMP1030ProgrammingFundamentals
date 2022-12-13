// 2.d Make sure that no instances of Customer can be created in the system
// make abstract class
public abstract class Customer : IBillable
{
    // fields
    public int CustomerId;
    public string Address;
    public string PhoneNumber;
    // methods
    public void PrintOrderHistory()
    {
        // TODO
    }
    // interface methods
    public bool ProcessPayment()
    {
        return true;
    }
}