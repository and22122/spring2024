class WritingAssignment : Assignment
{
    private String _title;

    public WritingAssignment(String name, String topic, String title) : base(name, topic)
    {
        _title = title;
    }

    public String getWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}