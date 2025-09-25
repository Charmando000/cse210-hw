using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //video 1
        Video video1 = new Video("The Joy of Painting", "Bob Ross", 300);
        video1.AddComment(new Comment("Alice", "I love this show!"));
        video1.AddComment(new Comment("Bob", "So relaxing to watch."));
        video1.AddComment(new Comment("Charlie", "I wish I could paint like that."));
        videos.Add(video1);


        //video 2
        Video video2 = new Video("Learn C# in 10 Minutes", "Code Academy", 600);
        video2.AddComment(new Comment("Dave", "Great tutorial!"));
        video2.AddComment(new Comment("Eve", "Very informative."));
        video2.AddComment(new Comment("Frank", "Helped me a lot, thanks!"));
        videos.Add(video2);

        //video 3
        Video video3 = new Video("Top 10 Travel Destinations", "Wanderlust", 450);
        video3.AddComment(new Comment("Grace", "I want to visit all of these places!"));
        video3.AddComment(new Comment("Heidi", "Amazing video, very inspiring."));
        video3.AddComment(new Comment("Ivan", "Adding these to my bucket list."));
        videos.Add(video3);

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}