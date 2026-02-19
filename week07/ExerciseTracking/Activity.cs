// BASE  CLass

public abstract class Activity
{
    // declare member variables
    private string _date;
    private int _lengthInMinutes;
    private string _units;

    // create a constructor
    public Activity(string date, int lengthInMinutes, string units)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
        _units = units;
    }

    // let's declare getters
    public string GetDate()
    {
        return _date;
    }

    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public string GetUnits()
    {
        return _units;
    }

    // define member functions or methods
    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} Running ({_lengthInMinutes} min): - Distance {Distance():0.00} {GetUnits()}, Speed {Speed():0.00} {GetUnits()}/h, Pace: {Pace():0.00} min per {GetUnits()}";
    }

}