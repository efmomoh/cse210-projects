using System;
using System.Collections.Generic;
using System.Threading;

// Super, base or parent Activity Class
public class Activity
{
    // declare member variables
    private string _name;
    private string _description;
    private int _duration;

    // create a constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // create getters for name and duration
    public string GetName() => _name;

    public int GetDuration() => _duration;


    // create methods or member functions
    public virtual void Run() { }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"---Welcome to the {_name} ---\n");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou completed {_duration} seconds of {_name}.");
        ShowProgressBar(3);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spin = new()
        {
         "|",
         "/",
         "-",
        "\\"
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spin[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spin.Count;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void ShowProgressBar(int seconds)
    {
        int total = seconds * 10;
        for (int i = 0; i < total; i++)
        {
            Console.Write("█");
            Thread.Sleep(100);
        }
        Console.WriteLine();
    }
}