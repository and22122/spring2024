using System.Reflection.Metadata;

public class Activity
{
    protected String _name;
    protected int _duration;
    protected String _desc;
    protected int _timer;

    public Activity(String name, int duration, String description)
    {
        _name = name;
        _duration = duration;
        _desc = description;
        _timer = 0;
    }

    public void begin()
    {
        Console.WriteLine($"Now beginning the {_name}.");
    }
    public void end()
    {
        Console.WriteLine($"Congratulations! You finished the {_name}!");
    }
}