public class Assignment
{
    protected String _studentName;
    protected String _topic;

    public Assignment(String name, String topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public String getSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}