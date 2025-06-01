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