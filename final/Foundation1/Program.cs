using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Scott Sterling Volleyball Blocks", "Studio C", 8.3f);
        Video video2 = new Video("Channel Surfing", "Studio C", 6.5f);
        Video video3 = new Video("Awkward Avoidance Viking", "Studio C", 7.2f);

        video1.AddComment(new Comment("Alice", "This is hilarious!"));
        video1.AddComment(new Comment("Bob", "I can't stop laughing!"));
        video1.AddComment(new Comment("Charlie", "Scott Sterling is a legend!"));

        video2.AddComment(new Comment("Dave", "This is so relatable."));
        video2.AddComment(new Comment("Eve", "I love channel surfing!"));
        video2.AddComment(new Comment("Frank", "Great sketch!"));

        video3.AddComment(new Comment("Grace", "This is so awkwardly funny."));
        video3.AddComment(new Comment("Heidi", "Vikings were awesome."));
        video3.AddComment(new Comment("Ivan", "I enjoyed this a lot."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}