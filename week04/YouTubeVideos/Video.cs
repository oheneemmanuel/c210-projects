using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;

    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenght: {_length}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comments in _comments)
        {
            Console.WriteLine($"- {comments.GetName()} : {comments.Gettext()}");
        }
        Console.WriteLine();
    }
    

    
    
}





