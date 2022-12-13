public class Order : IShippable
{
    public int OrderNumber;
    public decimal Amount;
    public DateTime TimeStamp;
    public bool Fulfilled;
    // 2.b Composition
    // Orders contain Products as a list
    // Product class must be available before writing the code below
    public List<Product> Products;

    // Constructors
    // To create an order, you need an amount and a list of products
    public Order(decimal amount, List<Product> products)
    {
        this.Amount = amount;
        this.Products = products;
    }
    // Methods
    public void Close()
    {
        // TODO
    }
    // interface methods
    public string ShipOrder()
    {
        return "CDN239102932A";
    }
}
