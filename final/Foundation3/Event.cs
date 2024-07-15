public class Event
{
    protected String _title;
    protected String _desc;
    protected String _eventDate;
    protected String _eventTime;
    protected String _addr;

    public Event(String name, String desc, String eventDate, String eventTime, String addr)
    {
        _title = name;
        _desc = desc;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _addr = addr;
    }
}