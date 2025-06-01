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