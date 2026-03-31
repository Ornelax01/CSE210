using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._name}: {comment._text}");
        }

        Console.WriteLine();
    }
}