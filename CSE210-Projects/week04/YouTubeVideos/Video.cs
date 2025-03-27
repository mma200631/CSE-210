public class Video
{
    private string _Title;
    private string _Author;
    private int _Length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _Title=title;
        _Author=author;
        _Length=length;
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name,text));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title:{_Title}");
        Console.WriteLine($"Author:{_Author}");
        Console.WriteLine($"Length:{_Length} seconds");
        Console.WriteLine($"Number of Comments:{GetCommentCount()}");
    }

    public void displayComment()
    {
        foreach( var Comment in _comments)
        {
            Console.WriteLine(Comment.GetDisplayText());
        }
    }

}