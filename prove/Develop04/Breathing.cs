class Breathing : Activity
{
    public Breathing(int duration, int timer) : base("Breathing Activity", duration, "This activity helps you relax by controlling your breathing. Just focus on breathing.")
    {
        _timer = timer;
    }

    public void boxBreathe()
    {
        Console.WriteLine("Inhale for three seconds.");
        for (int i = 0; i < 3; i ++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine("Hold for three seconds.");
        for (int i = 0; i < 3; i ++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine("Exhale for three seconds.");
        for (int i = 0; i < 3; i ++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine("Hold for three seconds.");
        for (int i = 0; i < 3; i ++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
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