using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lenghtSeconds;
    public List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }
    public int ReturnCommentsNumber()
    {
        return _comments.Count;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"The video is from: {_author}.");
        Console.WriteLine($"The title is \"{_title}\", and has a lenght of {_lenghtSeconds} seconds.");
        Console.WriteLine($"The video has {ReturnCommentsNumber()} comments in total.");

        for (int i = 0; i < _comments.Count; i++)
        {
            _comments[i].DisplayComment();
        }
    }

}