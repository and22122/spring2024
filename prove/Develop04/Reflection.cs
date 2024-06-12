using System.Runtime.CompilerServices;

public class Reflection : Activity
{
    private Random _randGen = new Random();
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public Reflection(int duration) : base("Reflection Activity", duration, "This activity invites you to reflect on your life. Think about what you can learn from your experiences.")
    {
        _prompts.Add("");
    }

    private void printRandomPrompt()
    {
        int n = _randGen.Next(0, _prompts.Count());
        Console.WriteLine(_prompts[n]);
    }
    private void printRandomQuestion()
    {
        int n = _randGen.Next(0, _questions.Count());
        Console.WriteLine(_questions[n]);
    }
    private void spinner()
    {
        Console.Write(" |");
        Thread.Sleep(1000);
        Console.Write("\b\b /");
        Thread.Sleep(1000);
        Console.Write("\b\b -");
        Thread.Sleep(1000);
        Console.Write("\b\b |");
        Thread.Sleep(1000);
    }
    public void run()
    {
        begin();

        printRandomPrompt();

        do
        {
            printRandomQuestion();

            spinner();

            _timer += 8;
        } while (_timer < _duration);

        end();
    }
}