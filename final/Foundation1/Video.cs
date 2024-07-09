using System.Transactions;

public class Video
{
    public String _title;
    public String _user;
    public int _duration;
    public List<Comment> _comments = new List<Comment>();

    public Video(String title, String user, int duration)
    {
        _title = title;
        _user = user;
        _duration = duration;
    }

    public int countComments()
    {
        return _comments.Count;
    }
}