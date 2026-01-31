// Address class program
public class Address
{
    // declare member variables
    private string _street;
    private string _city;
    private string _state;
    private int _postalCode;
    private string _country;

    // declare object constructor
    public Address(string street, string city, string state, int postalCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _postalCode = postalCode;
        _country = country;
    }

    // declare methods or member functions  
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state} {_postalCode}\n{_country}";
    }
}