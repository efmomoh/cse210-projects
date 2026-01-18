// ENTRY BLUEPRINT
public class Entry
{
    // declare properties, attributes or member variables
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    // declare constructors of early initialization
    public Entry(string date, string promptText, string entryText, string moodEntry)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = moodEntry;
    }

    //declare methods for specific behaviors

    public string GetSaveString() //EXCEEDING REQUIREMENTS => declare a method to save and return string
    {
        return $"{_date}|{_promptText}|{_entryText}|{_mood}";
    }

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompts: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Prompt Mood: {_mood}/5."); // Exceeding requirements
    }
}