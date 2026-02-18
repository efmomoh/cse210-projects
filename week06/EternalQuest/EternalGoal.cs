public class EternalGoal : Goal
{
    // no member variables are declared (none needed)

    // create a constructor
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    // declare member functions
    public override void RecordEvent()
    {
        // Eternal goals never complete, so nothing to mark
    }

    public override bool IsComplete()
    {
        return false; // never completes
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetShortName()}, {GetDescription()}, {GetPoints()}";
    }
}
