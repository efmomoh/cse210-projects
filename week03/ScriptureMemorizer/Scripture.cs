using System;
// Scripture class that privately references the
// reference and word list

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // declare constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // declare a string of array variable, split the words and reference it there
        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    // declare methods or member function
    public void HideRandomWords(int numberToHide)
    {
        Random _random = new Random();

        int hiddenCounter = 0;
        while (hiddenCounter < numberToHide)
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCounter++;

            }
        }
    }
    
    //returns the scripture text hidden words or shown blanks
    public string GetDisPlayText()
    {
        string dispayText = _reference.GetDisPlayText() + " ";
        foreach (Word word in _words)
        {
            dispayText += word.GetDisPlayText() + " ";
        }

        return dispayText.Trim();
    }

// checking if all words are hidden completely 
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
