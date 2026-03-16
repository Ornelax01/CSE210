// Creativity added:
// I added a mood tracker (1-5) to help users quickly record how they felt.
// This helps reduce the feeling of being overwhelmed by allowing emotional tracking
// without needing to write long entries.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How was your mood today (1-5)? ");
                int mood = int.Parse(Console.ReadLine());

                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry();
                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
        }
    }
}