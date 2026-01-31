// product class

public class Product
{
    // declare member variables
    private string _name;
    private string _ProductId;
    private double _price;
    private int _quantity;

    // declare constructors
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _ProductId = productId;
        _price = price;
        _quantity = quantity;
    }

    // declare member functions or behaviors
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _ProductId;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}