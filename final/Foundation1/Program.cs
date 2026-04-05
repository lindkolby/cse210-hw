using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Beginner C# Tutorial", "Code Academy", 720);
        video1.AddComment(new Comment("Sarah", "This explained classes really well."));
        video1.AddComment(new Comment("Mike", "Thanks for keeping it simple."));
        video1.AddComment(new Comment("Emma", "Can you make one about inheritance?"));

        Video video2 = new Video("Desk Setup Ideas", "Tech Space", 480);
        video2.AddComment(new Comment("John", "I like the monitor suggestions."));
        video2.AddComment(new Comment("Ava", "The lighting looked awesome."));
        video2.AddComment(new Comment("Chris", "Great budget options too."));

        Video video3 = new Video("Healthy Morning Routine", "Daily Growth", 600);
        video3.AddComment(new Comment("Lila", "This motivated me to wake up earlier."));
        video3.AddComment(new Comment("Noah", "The workout tip was helpful."));
        video3.AddComment(new Comment("Olivia", "I want to try this tomorrow."));

        Video video4 = new Video("How to Build a Resume", "Career Help", 540);
        video4.AddComment(new Comment("Ethan", "This helped me fix my resume."));
        video4.AddComment(new Comment("Grace", "I liked the formatting section."));
        video4.AddComment(new Comment("Mason", "Please do an interview video next."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}