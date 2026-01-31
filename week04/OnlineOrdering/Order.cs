// Order class program
public class Order
{
    // declare member variables
    private Customer _customer;
    private List<Product> _products;

    // declare constructors
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // declare member functions
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    public double GetTotalCost()
    {
        double sum = 0;

        foreach (Product product in _products)
        {
            sum += product.GetTotalCost();
        }

        // shopping cost
        if (_customer.LivesInUSA())
        {
            sum += 5;
        }
        else
        {
            sum += 35;
        }
        return sum;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}