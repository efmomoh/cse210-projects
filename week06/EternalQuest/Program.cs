using System;

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