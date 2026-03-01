using System;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("===================");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("\nChoose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing b = new Breathing();
                b.Run();
            }
            else if (choice == "2")
            {
                Reflection r = new Reflection();
                r.Run();
            }
            else if (choice == "3")
            {
                Listing l = new Listing();
                l.Run();
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}