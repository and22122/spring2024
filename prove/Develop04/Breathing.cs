class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This activity helps you relax by controlling your breathing. Just focus on breathing.")
    {
    }

    public void boxBreathe()
    {
        Console.Write("Inhale for three seconds.");
        for (int i = 0; i < 3; i ++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.Write("\nHold for three seconds.");
        for (int i = 0; i < 3; i ++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.Write("\nExhale for three seconds.");
        for (int i = 0; i < 3; i ++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.Write("\nHold for three seconds.");
        for (int i = 0; i < 3; i ++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.Write("\n");
    }
    public void run()
    {
        begin();

        do
        {
            boxBreathe();
            _timer += 12;
        } while (_timer < _duration);

        end();
    }
}