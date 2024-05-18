public class Resume(String name)
{
    private String _name = name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");

        for (var i = 0; i < _jobs.Count; i ++)
        {
            _jobs[i].DisplayJob();
        }
    }
}