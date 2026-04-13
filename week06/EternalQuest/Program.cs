// Creativity:
// Added level system and motivational feedback messages
// based on user score progression.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save/Load");
            Console.WriteLine("6. Quit");
            Console.Write("Choose: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1. Simple 2. Eternal 3. Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    manager.AddGoal(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {
                    manager.AddGoal(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {
                    Console.Write("Target: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == "2")
            {
                manager.DisplayGoals();
            }
            else if (choice == "3")
            {
                manager.DisplayGoals();

                Console.Write("Select goal #: ");

                if (int.TryParse(Console.ReadLine(), out int index))
                {
                    index--; // convert to 0-based index

                    if (index >= 0 && index < manager.GetGoalCount())
                    {
                        manager.RecordEvent(index);
                    }
                    else
                    {
                        Console.WriteLine("❌ Invalid selection. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Please enter a valid number.");
                }
            }
            else if (choice == "4")
            {
                manager.DisplayScore();
            }
            else if (choice == "5")
            {
                Console.Write("Save or Load? ");
                string action = Console.ReadLine();

                Console.Write("Filename: ");
                string file = Console.ReadLine();

                if (action.ToLower() == "save")
                {
                    manager.Save(file);
                }
                else if (action.ToLower() == "load")
                {
                    manager.Load(file);
                }
                else
                {
                    Console.WriteLine("❌ Invalid option.");
                }
            }
        }
    }
}