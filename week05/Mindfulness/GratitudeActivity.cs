// 5th sub, child or derived class
using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    // declare member variable
    private List<string> _prompts = new()
    {
        "Name something simple you are grateful for.",
        "Name a person you appreciate.",
        "Name a recent positive moment.",
        "Name something about yourself you value."
    };

    // create a constructor
    public GratitudeActivity(string name, string desc, int dur)
        : base(name, desc, dur) { }


    // declare member functions
    public override void Run()
    {
        DisplayStartingMessage();

        Random r = new();
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.WriteLine("\n" + _prompts[r.Next(_prompts.Count)]);
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }
}