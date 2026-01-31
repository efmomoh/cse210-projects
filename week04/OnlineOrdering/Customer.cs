// Customer program
public class Customer
{
    // declare member variables 
    private string _name;
    private Address _address;

    // constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // declare behaviours or methods or member functions
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}