using System.Runtime.CompilerServices;

public class Reflection : Activity
{
    private Random _randGen = new Random();
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public Reflection() : base("Reflection Activity", "This activity invites you to reflect on your life. Think about what you can learn from your experiences.")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something selfless.");
        _prompts.Add("Think of an experience that helped you grow as a person.");
        _prompts.Add("Think of a time when you overcame a significant trial.");
        _prompts.Add("Think of a time when you received personal revelation.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Had you ever done or gone through something like it before?");
        _questions.Add("How did this experience start? What led up to it?");
        _questions.Add("What made this experience different from other experiences in your life?");
        _questions.Add("How did this experience make you feel?");
        _questions.Add("How did this experience help you grow or improve?");
        _questions.Add("What did this experience teach you?");
        _questions.Add("How can you apply the lessons you learned from this experience?");
        _questions.Add("How might you handle similar experiences in the future?");
        _questions.Add("What was this experience like?");
    }

    private void printRandomPrompt()
    {
        int n = _randGen.Next(0, _prompts.Count());
        Console.WriteLine(_prompts[n]);
    }
    private void printRandomQuestion()
    {
        int n = _randGen.Next(0, _questions.Count());
        Console.Write(_questions[n]);
    }
    private void spinner()
    {
        Console.WriteLine("  ");
        for (int i = 0; i < 3; i ++)
        {
            Console.Write("\b\b |");
            Thread.Sleep(1000);
            Console.Write("\b\b /");
            Thread.Sleep(1000);
            Console.Write("\b\b -");
            Thread.Sleep(1000);
            Console.Write("\b\b \\");
            Thread.Sleep(1000);
        }

        Console.Write("\n");
    }
    public void run()
    {
        begin();

        printRandomPrompt();

        Thread.Sleep(10000);
        _timer += 10;

        do
        {
            printRandomQuestion();

            spinner();

            _timer += 12;
        } while (_timer < _duration);

        end();
    }
}