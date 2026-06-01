using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video video1 = new Video("C# Programming for Beginners", "TechTeacher", 600);
            video1.AddComment(new Comment("Alice", "This tutorial really helped me understand classes!"));
            video1.AddComment(new Comment("Joe", "Great explanation of abstraction."));
            video1.AddComment(new Comment("Nathan", "Can you make a video about polymorphism next?"));
            video1.AddComment(new Comment("Ruth", "I finally get it! Thank you."));
            videos.Add(video1);

            Video video2 = new Video("Top 10 Funny Cat Moments", "PetLover123", 180);
            video2.AddComment(new Comment("Emma", "The cat at 1:30 made me laugh so hard!"));
            video2.AddComment(new Comment("Frank", "My cat does the same thing lol"));
            video2.AddComment(new Comment("Grace", "Best 3 minutes of my day"));
            videos.Add(video2);

            Video video3 = new Video("Healthy Meal Prep in 20 Minutes", "ChefHealthy", 1200);
            video3.AddComment(new Comment("Henry", "Tried the quinoa bowl, it was delicious!"));
            video3.AddComment(new Comment("Ken", "These recipes saved me so much time"));
            video3.AddComment(new Comment("Noah", "Can you do a vegan version next week?"));
            video3.AddComment(new Comment("Kelly", "Love how simple your instructions are"));
            videos.Add(video3);

            Video video4 = new Video("JavaScript Async/Await Explained", "CodeMaster", 450);
            video4.AddComment(new Comment("Leo", "Better than 3 other videos I watched on this topic"));
            video4.AddComment(new Comment("Mia", "Finally someone who explains it clearly"));
            video4.AddComment(new Comment("Ket", "Subscribed! Keep up the great work"));
            videos.Add(video4);

            Console.WriteLine("===== YOUTUBE VIDEO COMMENTS TRACKER =====\n");
            
            foreach (Video video in videos)
            {
                video.DisplayInfo();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}