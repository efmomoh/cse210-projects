public class ChecklistGoal : Goal
{
    // declare member variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // create a constructor
    public ChecklistGoal(string name, string description, string points, int bonus, int amountCompleted, int target)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    // create bonus getter
    public int GetBonus()
    {
        return _bonus;
    }

    // override the points method to return base points (NOT bonus)
    public override string GetPoints()
    {
        return base.GetPoints();
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[✓]" : "[]";
        return $"{status}: {GetShortName()} - {GetDescription()} -- You have currently completed ({_amountCompleted}/{_target}) goals.";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {GetShortName()}, {GetDescription()}, {GetPoints()}, {_bonus}, {_amountCompleted}, {_target}";
    }
}
