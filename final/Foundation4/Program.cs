using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises= new List<Exercise>();

        exercises.Add(new Running(1000, 8, "7 July 2024"));
        exercises.Add(new Cycling(22, 60, "8 July 2024"));
        exercises.Add(new Swimming("10 July 2024", 200));

        foreach (Exercise e in exercises)
        {
            Console.WriteLine(e.getSummary());
        }
    }
}