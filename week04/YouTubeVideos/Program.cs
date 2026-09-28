using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create  videos
        Video video1 = new Video(
            "Introduction to C#",
            "Programming Academy",
            420
        );

        Video video2 = new Video(
            "How to Learn Programming",
            "Code With Me",
            615
        );

        Video video3 = new Video(
            "Object-Oriented Programming Explained",
            "Tech Tutorials",
            780
        );

        Video video4 = new Video(
            "C# Classes and Objects",
            "Learn to Code",
            530
        );

        // Add comments to video 1
        video1.Comments.Add(new Comment("John", "This was very helpful!"));
        video1.Comments.Add(new Comment("Maria", "I finally understand the basics."));
        video1.Comments.Add(new Comment("David", "Great explanation."));
        video1.Comments.Add(new Comment("Sarah", "Looking forward to the next video."));

        // Add comments to video 2
        video2.Comments.Add(new Comment("Alex", "These tips really helped me."));
        video2.Comments.Add(new Comment("Emma", "Thanks for sharing this!"));
        video2.Comments.Add(new Comment("James", "Very informative video."));
        video2.Comments.Add(new Comment("Olivia", "I learned a lot from this."));

        // Add comments to video 3
        video3.Comments.Add(new Comment("Michael", "The explanation of classes was great."));
        video3.Comments.Add(new Comment("Sophia", "This made OOP much easier to understand."));
        video3.Comments.Add(new Comment("Daniel", "Excellent tutorial."));
        video3.Comments.Add(new Comment("Emily", "Very clear and easy to follow."));

        // Add comments to video 4
        video4.Comments.Add(new Comment("William", "I really enjoyed this lesson."));
        video4.Comments.Add(new Comment("Ava", "The examples were very useful."));
        video4.Comments.Add(new Comment("Lucas", "This helped me with my assignment."));
        video4.Comments.Add(new Comment("Mia", "Great job explaining the concepts."));

        // Put all videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}