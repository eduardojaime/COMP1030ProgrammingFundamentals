// 2.c Inheritance: Individual inherits from Customer
//                 Individual is a Customer
public class Individual : Customer
{
    public string FirstName;
    public string LastName;
    // 2.e Encapsulation: make fields private to hide them
    private string CreditCardNbr;
}