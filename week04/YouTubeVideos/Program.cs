using System;
using System.Collections.Generic;

// Class  comment on a video
class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    // initialize a comment
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

// Class YouTube video
class Video
{
    //video title, author, length in seconds
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }

    // List to store comments 
    private List<Comment> comments = new List<Comment>();

    // Method to add comment 
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to count comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Method to get the list of comments 
    public IReadOnlyList<Comment> GetComments()
    {
        return comments.AsReadOnly();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // list to hold videos
        List<Video> videos = new List<Video>();

        // Create and populate Videos
        //video 1
        Video video1 = new Video()
        {
            Title = "The Life of Jesus",
            Author = "Jesus Filim",
            LengthInSeconds = 10980
        };
        video1.AddComment(new Comment("Alice", "For sure we need to repent of our sins."));
        video1.AddComment(new Comment("Jacky", "Jesus carried our burden indeed."));
        video1.AddComment(new Comment("Charles", "Very heartbreaking to see what He went through for our sins."));

        //video 2
        Video video2 = new Video()
        {
            Title = "I Am Gabriel",
            Author = "Christian Movies",
            LengthInSeconds = 7200
        };
        video2.AddComment(new Comment("Tom", "I love it."));
        video2.AddComment(new Comment("Alex", "Educates one to live a holy life."));
        video2.AddComment(new Comment("Fiona", "Helps one to grow spiritually."));
        video2.AddComment(new Comment("Joel", "Spiritually building"));

        // video 3
        Video video3 = new Video()
        {
            Title = "The Gospel of John",
            Author = "Christian Movies",
            LengthInSeconds = 5580
        };
        video3.AddComment(new Comment("Florence", "Food for my soul. I feel nourished."));
        video3.AddComment(new Comment("Praise", "I feel encouraged and understand the Word even the more."));
        video3.AddComment(new Comment("Effie", "This changed my life."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate over the videos and display 
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"\t{comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(); // Blank line between videos
        }
    }
}
