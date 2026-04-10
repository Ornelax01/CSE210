using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing", "List as many items as you can.")
    {
    }

    public void Run()
    {
        StartMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine($"\n{prompt}");
        Console.Write("Start in: ");
        Countdown(5);

        Console.WriteLine("\nStart listing:");

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndMessage();
    }
}