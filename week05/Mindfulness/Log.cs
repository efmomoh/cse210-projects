// 6th derived, sub or child class
using System;
using System.IO;

public static class Log
{

    // create a member variable and initialize file name
    private static string _file = "activity_log.txt";


    // declare member functions
    public static void Save(string name, int duration)
    {
        File.AppendAllText(_file,
            $"{DateTime.Now}: {name} for {duration} seconds\n");
    }

    public static void ShowStats()
    {
        Console.WriteLine("\n--- Session Log ---");

        if (!File.Exists(_file))
        {
            Console.WriteLine("No activities logged yet.");
            return;
        }

        string[] lines = File.ReadAllLines(_file);
        Console.WriteLine($"Total Activities Completed: {lines.Length}");
    }
}