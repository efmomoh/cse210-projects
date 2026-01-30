using System;
// Comment class => that tracks both the name of the person
// who made the comment and the text of the comment

public class Comment
{
    // declare member variables
    public string _name;
    public string _text;

    // declare constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // declare member function 
    public string DisplayComment()
    {
         return $"  {_name}: {_text}";
    }
}