using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Microsoft", "Software Engineer", 2015, 2020);
        Job job2 = new Job("Apple", "Information Technician", 2020, 2021);

        job1.DisplayJob();
        job2.DisplayJob();

        Resume res1 = new Resume("John Doe");
        res1._jobs.Add(job1);
        res1._jobs.Add(job2);

        res1.DisplayResume();
    }
}