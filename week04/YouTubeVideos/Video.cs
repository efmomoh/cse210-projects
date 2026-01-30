using System;
using System.Collections.Generic;
// Video class => that tracks the title, author and length (seconds)
// and return number of comments

public class Video
{
    // declare member variables
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    // declare constructor object
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // declare methods or member function
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComment()
    {
        return _comments.Count;

    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Name: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Total comments: ({GetNumberOfComment()})");
        Console.WriteLine($"Comments: ");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.DisplayComment()}");
        }
        Console.WriteLine();
    }
}