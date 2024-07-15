public class Lecture : Event
{
    private String _speaker;
    private int _capacity;

    public Lecture(String sp, int cap, String title, String desc, String ed, String et, String addr) : base(title, desc, ed, et, addr)
    {
        _speaker = sp;
        _capacity = cap;
    }

    public override String getFullDetails()
    {
        return $"{getShortDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override String getShortDesc()
    {
        return $"Lecture:\n{_title}\n{_eventDate}";
    }
}