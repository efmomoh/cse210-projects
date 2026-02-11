// 2nd sub, derived or child ReflectingActivity class
using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{

    // declare member variables
    private List<string> _prompts = new()
    {
        "hink of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time you were proud of yourself.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "What did you learn?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What can you apply in future?",
        "What made it special?"
    };

    private int _promptIndex = 0;
    private int _questionIndex = 0;

    // create a constructor and invoke the base constructor
    public ReflectingActivity(string name, string desc, int dur) : base(name, desc, dur) 
    { }


    // declare member functions
    public override void Run()
    {
        DisplayStartingMessage();

        ShuffleStringList(_prompts);
        ShuffleStringList(_questions);

        Console.WriteLine("\n" + _prompts[_promptIndex++]);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n" + _questions[_questionIndex++]);
            ShowSpinner(4);

            if (_questionIndex >= _questions.Count)
            {
                ShuffleStringList(_questions);
                _questionIndex = 0;
            }
        }

        DisplayEndingMessage();
    }

    private void ShuffleStringList(List<string> list)
    {
        Random random = new();
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
}