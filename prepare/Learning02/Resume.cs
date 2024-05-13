public class Resume(String name)
{
    String _name = name;
    List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"{_name}");

        for (var i = 0; i < _jobs.length; i ++)
        {
            _jobs[i].DisplayJob();
        }
    }
}