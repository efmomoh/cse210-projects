using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        // call, declare and instantiate the prompt generator class
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        // while loop choice => stores user menu choice
        int choice = 0;

        // menu loops continously until user chooses to quit
        while (choice != 5)
        {

            // display menu options
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            // validate numeric choice input
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            // if, else if and else statemments => handles menu or choice selection
            if (choice == 1)
            {

                // declare and save current date string => create journal entry
                string date = DateTime.Now.ToString("dddd, MMMM d, yyyy @ H:mm tt");

                string promptText = promptGenerator.GetRandomPrompt(); // gets a journal random question and store it for the entry 
                Console.WriteLine(promptText);
                Console.Write("> ");
                string entryText = Console.ReadLine();

                // validate mood input => EXCEEDING REQUIREMENTS
                Console.Write("Mood Today (1-5): ");
                int moodEntry;
                while (!int.TryParse(Console.ReadLine(), out moodEntry) || moodEntry < 1 || moodEntry > 5)
                {
                    Console.WriteLine("Please enter a number between 1 and 5: ");
                }


                // declare an Entry class constructor and pass the constructor parameters as argument => Add entry to journal
                Entry anEntry = new Entry(date, promptText, entryText, moodEntry.ToString());
                journal.AddEntry(anEntry);
            }
            else if (choice == 2)
            {
                // call and display the journal method
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                // prompt and saves filename
                Console.WriteLine("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);


            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);


            }

        }
        // print exit message
        Console.WriteLine("\nThank you for using our journal service!\n");

    }
}