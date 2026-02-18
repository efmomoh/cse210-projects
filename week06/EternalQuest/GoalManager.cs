using System;
using System.IO;

public class GoalManager
{
    // declare member variables
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // create an empty constructor
    public GoalManager() { }

    //start
    public void Start()
    {
        int choice = 0;

        while (choice != 7)
        {
            Console.WriteLine();
            DisplayPlayerInfo(); // displays player info

            Console.WriteLine("\n~~ WELCOME TO THE ETERNAL QUEST PROGRAM ~~");
            Console.WriteLine("Author: Enssah Fayia Momoh");
            Console.WriteLine("=================================================");
            Console.WriteLine("\nMenu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            // validate input choice
            Console.Write("Select a choice from the menu: ");
            int.TryParse(Console.ReadLine(), out choice);
            Console.WriteLine();

            if (choice == 1)
                CreateGoal();
            else if (choice == 2)
                ListGoalDetails();
            else if (choice == 3)
                SaveGoals();
            else if (choice == 4)
                LoadGoals();
            else if (choice == 5)
                RecordEvent();
            else if (choice == 6)
                DisplayPlayerInfo();
            else if (choice == 7)
                Console.WriteLine("Goodbye! Keep progressing on your Eternal Quest.");
            else
                Console.WriteLine("Invalid choice, try again!\n");
        }
    }

    // create new goals
    public void CreateGoal()
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Creative Goal (Exceeding Requirements)"); // new option
        Console.WriteLine("");

        Console.Write("Which type of goal would you like to create? ");
        int.TryParse(Console.ReadLine(), out int type);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (type == 1)
            _goals.Add(new SimpleGoal(name, description, points));
        else if (type == 2)
            _goals.Add(new EternalGoal(name, description, points));
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int.TryParse(Console.ReadLine(), out int target);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int.TryParse(Console.ReadLine(), out int bonus);

            _goals.Add(new ChecklistGoal(name, description, points, bonus, 0, target));
        }
        else if (type == 4) // CreativeGoal
        {
            Console.Write("How many points are lost for a bad habit? ");
            int.TryParse(Console.ReadLine(), out int pointsLost);

            Console.Write("How many completions required to level up? ");
            int.TryParse(Console.ReadLine(), out int levelUpThreshold);

            Console.Write("What is the bonus per level? ");
            int.TryParse(Console.ReadLine(), out int bonusPerLevel);

            _goals.Add(new CreativeGoal(name, description, points, pointsLost, levelUpThreshold, bonusPerLevel));
        }
        else
            Console.WriteLine("Invalid type selection.\n");
    }


    public void ListGoalDetails()
    {
        int i = 1;

        // Loops through all goals in the _goals list
        foreach (Goal g in _goals)
        {
            // displays each goal with details and current status
            Console.WriteLine($"{i}. {g.GetDetailsString()}");
            i++;
        }

        // If no goals exist, show a message
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to display.");
        }
    }


    // save goals 
    public void SaveGoals()
    {
        Console.Write("Enter Filename: ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {file} file successfully.\n");
    }

    // Load the saved goals
    public void LoadGoals()
    {
        Console.Write("Load Saved Filename: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("No such saved file found.\n");
            return;
        }

        string[] lines = File.ReadAllLines(file);

        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        _goals.Clear();

        if (!int.TryParse(lines[0], out _score))
            _score = 0;

        for (int i = 1; i < lines.Length; i++)
        {
            if (lines[i].Trim() == "")
                continue;

            string[] parts = lines[i].Split(":");
            if (parts.Length < 2)
                continue;

            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal" && data.Length >= 4)
            {
                SimpleGoal g = new SimpleGoal(data[0], data[1], data[2]);
                g.SetGoalCompleted(bool.Parse(data[3]));
                _goals.Add(g);
            }
            else if (type == "EternalGoal" && data.Length >= 3)
                _goals.Add(new EternalGoal(data[0], data[1], data[2]));
            else if (type == "ChecklistGoal" && data.Length >= 6)
                _goals.Add(new ChecklistGoal(
                    data[0], data[1], data[2],
                    int.Parse(data[3]),
                    int.Parse(data[4]),
                    int.Parse(data[5])
                ));
        }

        Console.WriteLine($"{file} file loaded successfully.");
    }

    // record events 
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available or recorded.");
            return;
        }

        ListGoalDetails();

        Console.Write("Which goal did you complete? ");
        int.TryParse(Console.ReadLine(), out int index);
        index -= 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid Selection");
            return;
        }

        Goal g = _goals[index];
        g.RecordEvent();

        int points = int.Parse(g.GetPoints());

        // Correctly handle bonus for checklist goals
        if (g is ChecklistGoal checklist && checklist.IsComplete())
        {
            points += checklist.GetBonus();
        }

        _score += points;

        Console.WriteLine($"\nCongratulations! You have earned {points} points!");
        Console.WriteLine($"Your total score is now {_score} points!");
    }

    // displayer information
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have earned {_score} points.");
    }
}
