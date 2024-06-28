public class EternalGoal : Goal
{
    public EternalGoal(int pts, String desc) : base(pts, desc)
    {
    }

    public override void update()
    {
        _progress ++;
    }

    public override int scoreUp()
    {
        return _points * _progress;
    }

    public override void display()
    {
        if (_progress == 0)
        {
            Console.WriteLine($"- {_description}");
        }
        else
        {
            Console.WriteLine($"+ {_description}: {scoreUp()} points ({_points} points each)");
        }
    }
}