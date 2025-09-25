public class Video
{
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}