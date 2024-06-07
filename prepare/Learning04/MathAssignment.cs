public class MathAssignment : Assignment
{
    private String _textbookSection;
    private String _problems;

    public MathAssignment(String name, String topic, String section, String problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public String getHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}