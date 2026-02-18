using System.ComponentModel;

public class SimpleGoal : Goal
{
    // declare attributes or member functions
    private bool _isComplete;

    // create a constructor
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points) { }

    // create a getter and setter
    public bool GetGoalCompleted()
    {
        return _isComplete;
    }

    public void SetGoalCompleted(bool isComplete)
    {
        _isComplete = isComplete;
    }

    // declare behaviors
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {GetShortName()}, {GetDescription()}, {GetPoints()}, {_isComplete}";
    }
}
