// Derived class

public class SwimmingActivity : Activity
{
    //declare member variables
    private int _lapsNumber;

    // create a constructor
    public SwimmingActivity(string date, int lengthInMinutes, string units, int lapsNumber)
        : base(date, lengthInMinutes, units)
    {
        _lapsNumber = lapsNumber;
    }

    // define methods
    public override double Distance()
    {
        return _lapsNumber * 50 / 1000;
    }

    public override double Speed()
    {
        return (double)(Distance() / GetLengthInMinutes()) * 60;
    }

    public override double Pace()
    {
        return GetLengthInMinutes() / Distance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLengthInMinutes()} min) - Distance {Distance():0.00} km, Speed {Speed():0.00} kph, Pace: {Pace():0.00} min per km";
    }

}