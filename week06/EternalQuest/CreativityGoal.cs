using System;

// This class adds creative "leveling up" and "negative points" functionality
// Exceeding Requirements: Shows creativity by adding gamification mechanics.
public class CreativeGoal : Goal
{
    private int _pointsLostForBadHabit;
    private int _timesCompleted;
    private int _levelUpThreshold;
    private int _bonusPerLevel;

    public CreativeGoal(string name, string description, string points, int pointsLostForBadHabit, int levelUpThreshold, int bonusPerLevel)
        : base(name, description, points)
    {
        _pointsLostForBadHabit = pointsLostForBadHabit;
        _timesCompleted = 0;
        _levelUpThreshold = levelUpThreshold;
        _bonusPerLevel = bonusPerLevel;
    }

    // Record a positive event
    public override void RecordEvent()
    {
        _timesCompleted++;
    }

    // Record a negative event (bad habit)
    public void RecordNegativeEvent()
    {
        int currentPoints = int.Parse(GetPoints());
        int newPoints = Math.Max(0, currentPoints - _pointsLostForBadHabit);
        SetPoints(newPoints.ToString());
        Console.WriteLine($"Uh-oh! You lost {_pointsLostForBadHabit} points for a bad habit. Current points: {newPoints}");
    }

    public override bool IsComplete()
    {
        // This goal never truly completes; it levels up instead
        return false;
    }

    // Returns the current level based on completions
    public int GetLevel()
    {
        return (_timesCompleted / _levelUpThreshold) + 1;
    }

    public override string GetDetailsString()
    {
        return $"[Creative Goal] {GetShortName()} - {GetDescription()} | Completed {_timesCompleted} times | Level {GetLevel()} | Points: {GetPoints()}";
    }

    public override string GetStringRepresentation()
    {
        return $"CreativeGoal: {GetShortName()}, {GetDescription()}, {GetPoints()}, {_pointsLostForBadHabit}, {_timesCompleted}, {_levelUpThreshold}, {_bonusPerLevel}";
    }
}
