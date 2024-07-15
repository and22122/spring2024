public class Reception : Event
{
    private List<String> _attendees;
    private int _capacity;
    private String _rsvpEmail;

    public Reception(String title, String desc, String ed, String et, String addr, int cap, String rsvp) : base(title, desc, ed, et, addr)
    {
        _capacity = cap;
        _rsvpEmail = rsvp;
    }

    public void getRsvpInfo()
    {

    }

    public void rsvp(String name)
    {
        _attendees.Add(name);
        _capacity ++;
    }

    public String getShortDetails()
    {
        return $"{_title}:\n{_desc}\n{_eventDate} at {_eventTime}\n{_addr}";
    }

    public String getFullDetails()
    {
        return $"{getShortDetails()}\n{_rsvpEmail}\nCapacity: {_capacity}";
    }

    public String getShortDesc()
    {
        return $"Reception:\n{_title}\n{_eventDate}";
    }
}