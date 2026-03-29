using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Create videos
        Video video1 = new Video("Python Basics", "John Doe", 600);
        Video video2 = new Video("Learn Flask API", "Jane Smith", 900);
        Video video3 = new Video("Data Structures", "Mike Johnson", 750);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Nice explanation."));

        // Add comments to video2
        video2.AddComment(new Comment("David", "This helped me a lot."));
        video2.AddComment(new Comment("Eve", "Good job!"));
        video2.AddComment(new Comment("Frank", "Clear and simple."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Awesome content!"));
        video3.AddComment(new Comment("Hannah", "Loved it."));
        video3.AddComment(new Comment("Isaac", "Well explained."));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}