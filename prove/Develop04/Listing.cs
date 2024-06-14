public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private DateTime _startTime;
    private List<string> _items = new List<string>();
    private Random randGen = new Random();

    public Listing() : base("Listing Activity", "This activity invites you to list examples from your life that relate to a given prompt.")
    {
        _startTime = DateTime.Now;
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

        Console.WriteLine("Please list as many examples as you can.");

        do
        {
            _items.Add(Console.ReadLine());
        } while(DateTime.Now < _startTime.AddSeconds(_duration));

        end();
    }
}