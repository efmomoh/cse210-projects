// base class

public class Circle : Shape
{
    // declare member variables
    private double _radius = 0;

    // create constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // create a member function 
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}