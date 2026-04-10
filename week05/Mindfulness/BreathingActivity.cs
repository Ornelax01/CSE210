using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity helps you relax by breathing slowly.")
    {
    }

    public void Run()
    {
        StartMessage();

        int time = 0;

        while (time < _duration)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            Countdown(4);
            Console.WriteLine();

            time += 8;
        }

        EndMessage();
    }
}