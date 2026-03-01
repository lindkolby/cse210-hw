using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Listing : Activity
{
    // Diagram private fields
    private List<string> _prompts;
    private List<int> _chosen;

    // Diagram: +Listing()
    public Listing()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _chosen = new List<int>();
    }

    // Diagram: +Run(): void
    public void Run()
    {
        StartActivity();

        Console.Clear();
        Random rand = new Random();

        int pIndex = rand.Next(_prompts.Count);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[pIndex]} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        DisplayCountDown();
        Console.WriteLine();

        List<string> items = new List<string>();

        Stopwatch watch = new Stopwatch();
        watch.Start();

        while (watch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(entry))
            {
                items.Add(entry.Trim());
            }
        }

        watch.Stop();

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");

        EndActivity();
    }
}