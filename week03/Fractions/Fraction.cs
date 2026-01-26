using System;
// exercise activity 

public class Fraction
{
    // declare attributes, properties or member variables
    private int _top;
    private int _bottom;

    // declare constructors
    public Fraction() // empty constructor
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    // declare methods or member functions
    public string GetFractionString()
    {
        string stringFraction = $"{_top}/{_bottom}";
        return stringFraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }


}