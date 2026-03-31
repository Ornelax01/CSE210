using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1._title = "Learning C# Basics";
        v1._author = "Code Academy";
        v1._length = 600;

        v1._comments.Add(new Comment("Juan","Very helpful video!"));
        v1._comments.Add(new Comment("Maria","Great explanation."));
        v1._comments.Add(new Comment("Ricardo","I learned a lot."));

        Video v2 = new Video();
        v2._title = "Object Oriented Programming";
        v2._author = "Tech Channel";
        v2._length = 850;

        v2._comments.Add(new Comment("Ana","Very clear examples."));
        v2._comments.Add(new Comment("Luis","Helped me understand classes."));
        v2._comments.Add(new Comment("David","Thanks!"));

        Video v3 = new Video();
        v3._title = "Data Structures";
        v3._author = "Programming Hub";
        v3._length = 720;

        v3._comments.Add(new Comment("Karla","Nice introduction."));
        v3._comments.Add(new Comment("Carlos","Good production."));
        v3._comments.Add(new Comment("Elena","Very informative."));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}