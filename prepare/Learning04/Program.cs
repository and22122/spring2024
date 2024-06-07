using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment mw = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        MathAssignment rr = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(mw.getSummary());
        Console.WriteLine(mw.getWritingInformation());

        Console.WriteLine(rr.getSummary());
        Console.WriteLine(rr.getHomeworkList());
    }
}