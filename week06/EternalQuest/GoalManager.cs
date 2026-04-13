using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        int i = 1;
        foreach (Goal g in _goals)
        {
            string status = g.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i}. {status} {g.GetDetailsString()}");
            i++;
        }
    }

    public void RecordEvent(int index)
    {
        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");

        // 🎮 Creativity: Level system
        int level = _score / 1000;
        Console.WriteLine($"Your level: {level}");

        if (points > 0)
        {
            Console.WriteLine("🔥 Keep going! You're doing great!");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    // 💾 SAVE
    public void Save(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    // 📂 LOAD
    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[4]),
                    int.Parse(data[5])
                );
                _goals.Add(g);
            }
        }
    }
}