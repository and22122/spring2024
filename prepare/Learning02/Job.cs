public class Job (String company, String title, int start, int end) 
{
    String _company = company;
    String _jobTitle = title;
    int _startYear = start;
    int _endYear = end;

    public void DisplayJob()
    {
        Console.writeLine($"{_jobTitle \(_company\) _startYear-_endYear}");
    }
}