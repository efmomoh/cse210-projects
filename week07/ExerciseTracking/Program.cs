using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the ExerciseTracking Project.");

        // create list of activities (Polymorphism)
        List<Activity> activities = new List<Activity>();

        // let's instantiate objects
        activities.Add(new RunningActivity("19 Feb 2026", 30, "km", 4.8));
        activities.Add(new CyclingActivity("20 Feb 2026", 45, "km", 20.0));
        activities.Add(new SwimmingActivity("21 Feb 2026", 40, "km", 20));

        // display summaries
        foreach (Activity activity in activities)
        {
            DisplayActivityDetails(activity);

        }

        Console.WriteLine();

    }
    static void DisplayActivityDetails(Activity a)
    {
        Console.WriteLine(a.GetSummary());
    }
}