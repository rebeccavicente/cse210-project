using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video 1
        Video video1 = new Video();
        video1._title = "Introduction to C#";
        video1._author = "Programming Academy";
        video1._length = 420;

        Comment comment1 = new Comment();
        comment1._name = "John";
        comment1._text = "This was very helpful!";

        Comment comment2 = new Comment();
        comment2._name = "Maria";
        comment2._text = "I finally understand the basics.";

        Comment comment3 = new Comment();
        comment3._name = "David";
        comment3._text = "Great explanation.";

        Comment comment4 = new Comment();
        comment4._name = "Sarah";
        comment4._text = "Looking forward to the next video.";

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        video1._comments.Add(comment4);


        // Create video 2
        Video video2 = new Video();
        video2._title = "How to Learn Programming";
        video2._author = "Code With Me";
        video2._length = 615;

        Comment comment5 = new Comment();
        comment5._name = "Alex";
        comment5._text = "These tips really helped me.";

        Comment comment6 = new Comment();
        comment6._name = "Emma";
        comment6._text = "Thanks for sharing this!";

        Comment comment7 = new Comment();
        comment7._name = "James";
        comment7._text = "Very informative video.";

        Comment comment8 = new Comment();
        comment8._name = "Olivia";
        comment8._text = "I learned a lot from this.";

        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);
        video2._comments.Add(comment8);


        // Create video 3
        Video video3 = new Video();
        video3._title = "Object-Oriented Programming Explained";
        video3._author = "Tech Tutorials";
        video3._length = 780;

        Comment comment9 = new Comment();
        comment9._name = "Michael";
        comment9._text = "The explanation of classes was great.";

        Comment comment10 = new Comment();
        comment10._name = "Sophia";
        comment10._text = "This made OOP much easier to understand.";

        Comment comment11 = new Comment();
        comment11._name = "Daniel";
        comment11._text = "Excellent tutorial.";

        Comment comment12 = new Comment();
        comment12._name = "Emily";
        comment12._text = "Very clear and easy to follow.";

        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        video3._comments.Add(comment11);
        video3._comments.Add(comment12);


        // Create video 4
        Video video4 = new Video();
        video4._title = "C# Classes and Objects";
        video4._author = "Learn to Code";
        video4._length = 530;

        Comment comment13 = new Comment();
        comment13._name = "William";
        comment13._text = "I really enjoyed this lesson.";

        Comment comment14 = new Comment();
        comment14._name = "Ava";
        comment14._text = "The examples were very useful.";

        Comment comment15 = new Comment();
        comment15._name = "Lucas";
        comment15._text = "This helped me with my assignment.";

        Comment comment16 = new Comment();
        comment16._name = "Mia";
        comment16._text = "Great job explaining the concepts.";

        video4._comments.Add(comment13);
        video4._comments.Add(comment14);
        video4._comments.Add(comment15);
        video4._comments.Add(comment16);


        // Put all videos in a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        // Display each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}
