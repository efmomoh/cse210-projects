using System;

// Exceeding Requirements:
// Added the CreativeGoal class to implement gamification features like leveling up and negative points.


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the EternalQuest Project.");

        // instantiate the goal manager
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}