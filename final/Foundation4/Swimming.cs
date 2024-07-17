public class Swimming : Exercise
{
    private int _laps;
    public Swimming(String d, int l) : base("Swimming", d)
    {
        _laps = l;
    }
    public Swimming(float di, int du, String d, int l) : base(di, du, "Swimming", d)
    {
        Console.WriteLine("Error: You cannot instantiate Swimming type objects this way.");
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
}