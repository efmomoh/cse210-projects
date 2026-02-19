// Derived class

public class RunningActivity : Activity
{
    //declare member variables
    private double _distance;


    // create a constructor
    public RunningActivity(string date, int lengthInMinutes, string units, double distance)
        : base(date, lengthInMinutes, units)
    {
        _distance = distance;
    }

    // create a getter 
    public double GetLaps()
    {
        return _distance;
    }

    // define methods
    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        
        return Distance() / GetLengthInMinutes() * 60;
    }

    public override double Pace()
    {
        return GetLengthInMinutes() / Distance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLengthInMinutes()} min) - Distance {Distance():0.00} km, Speed {Speed():0.00} kph, Pace: {Pace():0.00} min per km";
    }

}