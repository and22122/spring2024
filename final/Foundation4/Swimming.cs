public class Swimming : Exercise
{
    private int _laps;
    public Swimming(int du, String d, int l) : base(0, du, "Swimming", d)
    {
        _laps = l;
    }
    public Swimming(float di, int du, String d, int l) : base(di, du, "Swimming", d)
    {
        Console.WriteLine("Error: Swimming type objects take a lap integer, not a distance float");
        throw new ArgumentException();
    }
    public override float getDistance()
    {
        return _laps * 50 / 1000;
    }
    public override float getSpeed()
    {
        return getDistance() / _duration * 60;
    }

    public override float getPace()
    {
        return 60 / getSpeed();
    }

    public void setLaps(int n)
    {
        _laps = n;
    }
}