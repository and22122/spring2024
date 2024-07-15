public class Reception : Event
{
    private List<String> _attendees;
    private int _capacity;
    private String _rsvpEmail;

    public Reception(String title, String desc, String ed, String et, String addr, String rsvp) : base(title, desc, ed, et, addr)
    {
        _capacity = 0;
        _rsvpEmail = rsvp;
    }

    public void rsvp(String name)
    {
        _attendees.Add(name);
        _capacity ++;
    }

    public override String getFullDetails()
    {
        return $"{getShortDetails()}\n{_rsvpEmail}\nCapacity: {_capacity}";
    }

    public override String getShortDesc()
    {
        return $"Reception:\n{_title}\n{_eventDate}";
    }
}