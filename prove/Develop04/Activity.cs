using System.Reflection.Metadata;

public class Activity
{
    protected String _name;
    protected int _duration;

    public Activity(String name, int duration)
    {
        _name = name;
        _duration = duration;
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