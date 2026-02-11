using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;


/*
CREATIVITY FEATURES ADDED:

1. Activity log saved to file (activity_log.txt)
2. Added Gratitude Activity
3. No repeated prompts/questions until all used
4. Added progress bar animation
5. Session statistics displayed at exit
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Mindfulness Project.\n");

        int option = 0;

        while (option != 5)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity (NEW)");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            int.TryParse(Console.ReadLine(), out option);

            Activity activity = null;

            if (option == 1)
                activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. Relax by pacing your breathing slowly.", 0);


            else if (option == 2)
                activity = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);

            else if (option == 3)
                activity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);

            else if (option == 4)
                activity = new GratitudeActivity("Gratitude Activity", "Focus on gratitude to increase happiness.", 0);

            if (activity != null)
            {
                activity.Run();
                Log.Save(activity.GetName(), activity.GetDuration());
            }
        }

        Log.ShowStats();
        Console.WriteLine("\nThanks for using Mindfulness Program!");
    }
}