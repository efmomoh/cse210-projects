using System;
using System.IO;
using System.Collections.Generic;

// Journal blueprint 
public class Journal
{
    // declare properties, attributes or member variables 
    // => stores all journal entries
    public List<Entry> _entries;

    // declare constructors of early initialization
    public Journal()
    {
        _entries = new List<Entry>();
    }

    //declare objects or methods for specific behaviors 
    // => add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // display all journal entries
    public void DisplayAll()
    {
        // foreach loop that iterates through the entries
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    // save journal entries to file
    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.GetSaveString()}");
            }
            Console.WriteLine($"The '{file}' file has been saved successfully.");

        }
    }

    // load  journal entries from the file
    public void LoadFromFile(string file)
    {
        // EXCEEDING REQUIREMENTS => If file does not exist
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear(); // EXCEEDING REQUIREMENTS => does clearing and avoid multiple duplicate entries

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            // making sure that the line has all required fields or length checked
            if (parts.Length < 4)
            {
                continue; // skips invalid or old format entries
            }

            Entry entry = new Entry(parts[0], parts[1], parts[2], parts[3]);
            _entries.Add(entry);

        }
        Console.WriteLine($"The '{file}' file has loaded successfully.");

    }


}