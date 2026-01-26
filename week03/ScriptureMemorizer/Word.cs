using System;
using System.Diagnostics;
// Reference class 
// that handles behaviors internally or privately

public class Word
{
    // declare member variables
    private string _text;
    private bool _isHidden;

    // declare constructors that takes a sting parameter
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // declare methods or member functions

    // let's try to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    // checking if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // returning what should be display 
    public string GetDisPlayText()
    {
        if (_isHidden)
        {
            return "____";
        }
        else
        {
            return _text;
        }
    }
}