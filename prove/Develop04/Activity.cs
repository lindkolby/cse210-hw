using System;
using System.Threading;

public class Activity
{
    // Diagram fields
    protected string _name;
    protected string _desc;
    protected int _duration;
    protected DateTime _startTime;
    protected DateTime _endTime;

    // Used for Pause() spinner animation
    private readonly char[] _spin = { '|', '/', '-', '\\' };

    // Diagram constructor: +Activity(string n, string d)
    public Activity(string n, string d)
    {
        _name = n;
        _desc = d;
    }

    // Diagram: #StartActivity(): void
    protected void StartActivity()
    {
        _duration = StartMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause(); // "several seconds" spinner
    }

    // Diagram: #EndActivity(): void
    protected void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Pause();

        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        Pause();
    }

    // Diagram: -StartMessage(): int
    private int StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_desc);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        int seconds;
        while (!int.TryParse(Console.ReadLine(), out seconds) || seconds <= 0)
        {
            Console.Write("Please enter a positive whole number: ");
        }

        return seconds;
    }

    // Diagram: #Pause(): void
    // (No parameter per diagram — fixed length pause w/ spinner)
    protected void Pause()
    {
        int frames = 12;          // 12 * 250ms = 3 seconds
        int frameDelay = 250;

        for (int i = 0; i < frames; i++)
        {
            Console.Write(_spin[i % _spin.Length]);
            Thread.Sleep(frameDelay);
            Console.Write("\b");
        }

        // clear final spinner char
        Console.Write(" \b");
    }

    // Diagram: #DisplayCountDown(): void
    // (No parameter per diagram — fixed length countdown)
    protected void DisplayCountDown()
    {
        for (int i = 5; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}