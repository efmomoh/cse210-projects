// Derived class

public class Rectangle : Shape
{
    // declare member variable
    private double _length = 0;
    private double _width = 0;

    //instantiate a constructor
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // create a getter
    public double GetLength()
    {
        return _length;
    }

    // create a setter
    public void SetLength(double length)
    {
        _length = length;
    }

    // create a getter
    public double GetWidth()
    {
        return _width;
    }

    // create a setter
    public void SetWidth(double width)
    {
        _width = width;
    }

    // create a member function 
    public override double GetArea()
    {
        return _length * _width;
    }
}