using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("100 College Ave", "Rexburg", "ID", "USA");
        Address receptionAddress = new Address("55 Grand Hall", "Boise", "ID", "USA");
        Address outdoorAddress = new Address("789 Park Lane", "Idaho Falls", "ID", "USA");

        Lecture lecture = new Lecture(
            "Tech Innovation Night",
            "A lecture about future trends in software and AI.",
            "April 20, 2026",
            "6:00 PM",
            lectureAddress,
            "Dr. Sarah Johnson",
            150
        );

        Reception reception = new Reception(
            "Networking Reception",
            "An evening reception for professionals and students.",
            "May 2, 2026",
            "7:30 PM",
            receptionAddress,
            "rsvp@events.com"
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Summer Community Picnic",
            "A fun outdoor event with food and games.",
            "June 15, 2026",
            "1:00 PM",
            outdoorAddress,
            "Sunny with a light breeze"
        );

        List<Event> events = new List<Event>();
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        foreach (Event currentEvent in events)
        {
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine(currentEvent.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("FULL DETAILS");
            Console.WriteLine(currentEvent.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("SHORT DESCRIPTION");
            Console.WriteLine(currentEvent.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
        }
    }
}