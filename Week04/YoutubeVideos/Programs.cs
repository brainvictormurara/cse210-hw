using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create a list to store videos
        List<Video> videos = new List<Video>();

        // 2. Create Video 1 and add comments
        Video v1 = new Video("C# Abstraction Tutorial", "CodeMaster", 600);
        v1.AddComment(new Comment("Alice", "Great explanation!"));
        v1.AddComment(new Comment("Bob", "I finally understand classes."));
        v1.AddComment(new Comment("Charlie", "Can you do a video on Inheritance next?"));
        videos.Add(v1);

        // 3. Create Video 2 and add comments
        Video v2 = new Video("Top 10 Cooking Hacks", "Chef Joy", 300);
        v2.AddComment(new Comment("Dave", "The onion trick worked!"));
        v2.AddComment(new Comment("Eve", "I love your kitchen setup."));
        v2.AddComment(new Comment("Frank", "Needs more salt."));
        videos.Add(v2);

        // 4. Create Video 3 and add comments
        Video v3 = new Video("Travel Vlog: Tokyo", "Wanderlust", 1200);
        v3.AddComment(new Comment("Grace", "Tokyo looks amazing at night."));
        v3.AddComment(new Comment("Heidi", "Added to my bucket list!"));
        v3.AddComment(new Comment("Ivan", "What camera are you using?"));
        videos.Add(v3);

        // 5. Iterate through the list and display everything
        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}