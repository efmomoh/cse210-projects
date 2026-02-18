//BASE CLASS

public abstract class Goal
{
    //declare member variables or attributes
    private string _shortName;
    private string _description;
    private string _points;

    // create a constructor
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // create getters and setters for each member variables

    // Short Name
    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string name)
    {
        _shortName = name;
    }

    // Description
    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string desc)
    {
        _description = desc;
    }

    // points
    public virtual string GetPoints()
    {
        return _points;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }

    // declare methods, behaviors or member functions
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    // here, GetDetailString, I marked it virtual though it is not required but to allow me override it in the ChecklistGoal Class method
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[✓]" : "[]";
        return $"{status}: {_shortName} - {_description}";
    }

    public abstract string GetStringRepresentation();
}
