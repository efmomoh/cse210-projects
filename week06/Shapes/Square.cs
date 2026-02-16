// Derived class

public class Square : Shape
{
    // declare member variable 
    private double _side = 0;
    // create a constructor 
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // create a member function
    public override double GetArea()
    {
        return _side * _side;
    }
}