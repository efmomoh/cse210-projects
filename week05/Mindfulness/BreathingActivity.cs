// 1st derived, sub or child Breathing Activity 
using System;

public class BreathingActivity : Activity
{
    // create a constructor from the base class (Acrtivity)
    public BreathingActivity(string name, string desc, int dur)
        : base(name, desc, dur) { }


// declare member function Run
    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(5);

            Console.Write("\nNow Breathe out...");
            ShowCountdown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}