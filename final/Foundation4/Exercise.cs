public abstract class Exercise:
{
    protected float _distance;
    protected int _duration;
    protected String _eType;
    protected String _date;

    public Exercise(String et, String eDate)
    {
        _distance = 0;
        _duration = 0;
        _eType = et;
        _date = eDate;
    }
    public Exercise(float di, int du, String et, String eDate)
    {
        _distance = di;
        _duration = du;
        _eType = et;
        _date = eDate;
    }
    
    public virtual float getDistance()
    {
        return _distance;
    }
    public virtual float getSpeed()
    {
        return _distance / _duration * 60;
    }
    public virtual float getPace()
    {
        return _duration / _distance;
    }
    public virtual String getSummary()
    {
        return $"{_date} {_eType} ({_duration})- Distance {_distance} km, Speed: {getSpeed()} kph, Pace: {getPace()} min per km";
    }
    public void setDist(float n)
    {
        _distance = n;
    }
    public void setDur(int n)
    {
        _duration = n;
    }
}