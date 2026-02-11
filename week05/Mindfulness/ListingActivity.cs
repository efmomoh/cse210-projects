// 4nd derived, sub or child ListingActivity 
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{

    // declare member variables
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What makes you happy?",
        "Who are some of your personal heroes?",
        "When have you felt the Holy Ghost this month?"
    };

    // create a constructor
    public ListingActivity(string name, string desc, int dur)
        : base(name, desc, dur) { }


    // declare member functions
    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new();
        Console.WriteLine("\n" + _prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("\nStart listing. Press Enter after each item.");

        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        DisplayEndingMessage();
    }
}