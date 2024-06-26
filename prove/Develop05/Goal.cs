public abstract class Goal
{
    protected int _points;
    protected String _description;
    protected int _progress;

    public Goal(int points, String description)
    {
        _points = points;
        _description = description;
        _progress = 0;
    }
    
    public Goal(int points, String description, int progress)
    {
        _points = points;
        _description = description;
        _progress = progress;
    }

    public abstract void update();

    public abstract int scoreUp();

    public abstract void display();

    public abstract String toStringType();
}