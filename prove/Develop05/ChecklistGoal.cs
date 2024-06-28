public class ChecklistGoal : Goal
{
    bool _completed;
    int _targetTimes;
    int _bonus;

    public ChecklistGoal(int pts, String desc, int target, int bonus) : base(pts, desc)
    {
        _targetTimes = target;
        _bonus = bonus;
    }

    public override void update()
    {
        _progress = Math.Min(_progress + 1, _targetTimes);
    }

    public override int scoreUp()
    {
        if (_progress == _targetTimes)
        {
            _completed = true;
            return _progress * _points + _bonus;
        }
        else {
            return _progress * _points;
        }
    }

    public override void display()
    {
        if (_completed)
        {
            Console.WriteLine($"+ {_description}: {scoreUp} points ({_targetTimes} x {_points} points + {_bonus} points)");
        }
        else {
            Console.WriteLine($"- {_description}: {scoreUp} points (completed {_progress}/{_targetTimes} times for {_points} points each)");
        }
    }
}