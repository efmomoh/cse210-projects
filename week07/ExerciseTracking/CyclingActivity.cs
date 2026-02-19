// Derived class

public  class CyclingActivity : Activity
{
    //declare member variables
    private double _speed;

    // create a constructor
    public CyclingActivity(string date, int lengthInMinutes, string units, double speed) 
        : base(date, lengthInMinutes, units)
    {
        _speed = speed;
    }
    

    // create a getter 
    public double GetSpeed()
    {
        return _speed;
    }

    // define methods
    public override double Distance()
    {
        return (double)(_speed * GetLengthInMinutes()) / 60;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLengthInMinutes()} min) - Distance {Distance():0.00} km, Speed {Speed():0.00} kph, Pace: {Pace():0.00} min per km";
    }
} 