public class Job (String company, String title, int start, int end) 
{
    private String _company = company;
    private String _jobTitle = title;
    private int _startYear = start;
    private int _endYear = end;

    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}