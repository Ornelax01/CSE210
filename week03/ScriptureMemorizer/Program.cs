// I added a scripture library and the program now selects
// a random scripture each time the program runs.
// This helps users practice different scriptures.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("John",3,16),
            "For God so loved the world that he gave his only Begotten Son"));

        scriptures.Add(new Scripture(
            new Reference("Proverbs",3,5,6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"));

        scriptures.Add(new Scripture(
            new Reference("Philippians",4,13),
            "I can do all things through Christ which strengtheneth me"));

        Random random = new Random();
        int index = random.Next(scriptures.Count);

        Scripture scripture = scriptures[index];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press Enter or type quit: ");

            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}