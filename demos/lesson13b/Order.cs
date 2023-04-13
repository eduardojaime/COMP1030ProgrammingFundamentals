class Order
{
    // fields
    public decimal Amount; // property/field names start with capital letter
    public List<Product> Products;
    // custom constructor
    // parameter names are all lower case
    public Order(decimal amount, List<Product> products)
    {
        this.Amount = amount; // alternative syntax, best practice
        this.Products = products;
    }
    // methods
    public void Close()
    {
        // TODO or Console.WriteLine()
    }
}