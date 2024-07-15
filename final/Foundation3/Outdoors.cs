public class Outdoors : Event
{
    private String _weather;

    public Outdoors(String title, String desc, String ed, String et, String addr, String weather) : base(title, desc, ed, et, addr)
    {
        _weather = weather;
    }

    public String getWeather()
    {
        return _weather;
    }

    public String getShortDetails()
    {
        return $"{_title}:\n{_desc}\n{_eventDate} at {_eventTime}\n{_addr}";
    }

    public String getFullDetails()
    {
        return $"{getShortDetails()}\nWeather:\n{_weather}";
    }

    public String getShortDesc()
    {
        return $"Outdoor event:\n{_title}\n{_eventDate}";
    }
}