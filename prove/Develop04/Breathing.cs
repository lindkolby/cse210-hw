using System;

public class Breathing : Activity
{
    // Diagram: +Breathing()
    public Breathing()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Diagram: +Run(): void
    public void Run()
    {
        StartActivity();

        Console.Clear();
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);

        while (DateTime.Now < _endTime)
        {
            Console.Write("Breathe in... ");
            DisplayCountDown();
            Console.WriteLine();

            if (DateTime.Now >= _endTime)
                break;

            Console.Write("Breathe out... ");
            DisplayCountDown();
            Console.WriteLine();
        }

        EndActivity();
    }
}