public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private DateTime _startTime;
    private List<string> _items = new List<string>();
    private Random randGen = new Random();

    public Listing() : base("Listing Activity", "This activity invites you to list examples from your life that relate to a given prompt.")
    {
        _startTime = DateTime.Now;

        _prompts.Add("Who are people you appreciate?");
        _prompts.Add("What are some things that you're grateful for?");
        _prompts.Add("How have you felt the Spirit lately?");
        _prompts.Add("How have you blessed others lately?");
        _prompts.Add("Who are some of your role models?");
        _prompts.Add("What things make you happy?");
        _prompts.Add("How have you improved your life?");
        _prompts.Add("What are your personal strengths?");
        _prompts.Add("Who have you blessed recently?");
        _prompts.Add("What are some good things you could do?");
        _prompts.Add("How can you serve others?");
        _prompts.Add("What can you do to draw closer to God?");
    }
    private void printRandomPrompt()
    {
        int n = randGen.Next(0, _prompts.Count);

        Console.WriteLine(_prompts[n]);
    }
    private void show()
    {
        foreach (String i in _items)
        {
            Console.WriteLine(i);
        }
    }
    public void run()
    {
        begin();

        printRandomPrompt();

        Thread.Sleep(10000);

        Console.WriteLine("Please list as many examples as you can.");

        do
        {
            _items.Add(Console.ReadLine());
        } while(DateTime.Now < _startTime.AddSeconds(_duration));

        end();

        Console.WriteLine($"You managed to list {_items.Count} examples!");
        Thread.Sleep(5000);
    }
}