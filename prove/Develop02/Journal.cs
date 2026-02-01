using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public List<string> _prompts = ["What did I do today?",
    "One thing that went well today was...",
    "One thing that was hard or frustrating today was...",
    "How did I feel most of the day?",
    "Something small that I appreciated today was...",
    "Did I learn or realize anything today?",
    "How did I take care of myself today?",
    "How did I treat other people today?",
    "What is one thing I would like to do differently tomorrow?",
    "One word that describes today is ___ because..."];
    public string _fileName;

    public void DisplayMenu()
    {
        bool running = true;

        while (running)
        {
            Console.Write("Please select one of the following choices:\n"+
            "1. Write\n"+
            "2. Display\n"+
            "3. Load\n"+
            "4. Save\n"+
            "5. Quit\n"+
            "What would you like to do? ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    _journal.Add(GeneratePrompt());
                    break;
            
                case 2:
                    DisplayJournal();
                    break;
                case 3:

                    Console.WriteLine("What is the file name?");
                    string filePath = Console.ReadLine();
                    _journal = LoadFile(filePath);
                    break;

                case 4:
                    Console.WriteLine("What is the File name?");
                    string filename = Console.ReadLine();
                    SaveFile(filename);
                    break;

                default:
                    Exit();
                    running = false;
                    break;
            }
        }
    }

    public Entry GeneratePrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();

        Console.WriteLine(prompt);
        Console.Write("> ");
        string userInput = Console.ReadLine();

        entry._prompt = prompt;
        entry._entry = userInput;

        return entry;
    }
    
    public void DisplayJournal()
    {
        foreach (Entry entry in _journal)
        {
            entry.Display();
        }
    }

    public List<Entry> LoadFile(string filePath)
    {
        List<Entry> loaded = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach( string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];

            loaded.Add(entry);
        }
        return loaded;
    }

    public void SaveFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _journal)
            {
                string outputLine = "";
                outputLine += entry._date + "|";
                outputLine += entry._prompt +  "|";
                outputLine += entry._entry + "|";

                outputFile.WriteLine(outputLine);
            }
        }
    }

    public void Exit()
    {
        Console.WriteLine("Goodbye!");
    }
}
