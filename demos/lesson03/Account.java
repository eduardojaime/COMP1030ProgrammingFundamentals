// Simple class that represents a bank account in my application
public class Account {
    // Properties
    // instance variable or property of a class
    // each object created based on this class will contain its own copy of 'name'
    private String name;
    private double balance;
    // Methods
    // Constructor methods that allows us to set a default state for this object
    // Default Constructor
    public Account() {
        // best practice is to add it and leave empty if not used
    }
    // Custom Constructor
    public Account(String _name, double _balance) {
        this.name = _name;
        if (_balance > 0.0) {
            this.balance = _balance;
        }
    }

    // Methods to modify balance
    public void deposit(double depositAmt) {
        if (depositAmt > 0.0) {
            balance = balance + depositAmt;
        }
    }

    public double getBalance() {
        return balance;
    }

    // SetMethod to allow an external caller (program) to set the value in name
    public void setName(String _name) {
        this.name = _name;
    }
    // GetMethod to return the value of name to the caller (program)
    public String getName() {
        return this.name;
    }
}