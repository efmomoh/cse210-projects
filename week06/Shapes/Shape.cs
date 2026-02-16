// Base class

public abstract class Shape
{
    // declare member variables
    private string _color = "";


    // create a constructor 
    public Shape(string color)
    {
        _color = color;
    }
    // create a setter
    public string GetColor()
    {
        return _color;
    }

    // create setter
    public void SetColor(string color)
    {
        _color = color;
    }

    // create a member function
    // public virtual double GetArea()
    // {
    //     return 1;
    // }

    // or we can declare an abstract method
    public abstract double GetArea();
}