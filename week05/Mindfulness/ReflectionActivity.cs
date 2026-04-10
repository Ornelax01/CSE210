using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you showed courage."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "How can you apply this again?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base("Reflection", "This helps you reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        StartMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Think about it...");
        ShowSpinner(3);

        int time = 0;

        while (time < _duration)
        {
            string question = _questions[_random.Next(_questions.Count)];

            Console.WriteLine($"\n{question}");
            ShowSpinner(4);

            time += 4;
        }

        EndMessage();
    }
}