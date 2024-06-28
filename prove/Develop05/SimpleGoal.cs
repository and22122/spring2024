public class SimpleGoal : Goal
{

    public SimpleGoal(int pts, String desc) : base(pts, desc)
    {
    }

    public override void update()
    {
        _progress = 1;
    }

    public override int scoreUp()
    {
        return _progress * _points;
    }

    public override void display()
    {
        if (_progress == 1)
        {
            Console.WriteLine($"+ {_description}: {_points} points");
        }
        else {
            Console.WriteLine($"- {_description}");
        }
    }
}