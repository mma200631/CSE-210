using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos= new List<Video>();

        Video video1=new Video("Learn C# in 10 Minutes", "John Doe",600);
        video1.AddComment("Alice", "Great tutorial!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "I loved the examples.");
        videos.Add(video1);

        Video video2 =new Video("Cooking Pasta 101", "Chef Mario", 900);
        video1.AddComment("Sophia", "This looks delicious!");
        video2.AddComment("Liam", "Tried this recipe, it's amazing!");
        video2.AddComment("Emma", "Best pasta ever.");
        videos.Add(video2);

        Video video3 = new Video("Travel Vlog: Japan", "Sarah Smith", 1200);
        video3.AddComment("James", "Such beautiful scenery!");
        video3.AddComment("Olivia", "I want to visit Japan someday.");
        video3.AddComment("Mason", "Thanks for sharing!");
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}