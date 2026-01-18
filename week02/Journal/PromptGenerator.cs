// promptGenerator blueprint
using System;
using System.Collections.Generic;
public class PromptGenerator
{
    // declare properties, attributes or member variables
    public List<string> _prompts;
    public Random _random;

    // declare constructors of early initialization
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What does your favorite scripture says?",
        };

        _random = new Random();
    }

    //declare methods for specific behaviors
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];

    }
}