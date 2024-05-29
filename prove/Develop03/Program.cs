using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please define a scripture reference.");
        Scripture currentScripture = new Scripture();

        do {
            currentScripture.displayScripture();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            currentScripture.hideRandom();
        } while(!currentScripture.scriptureIsHidden());

        currentScripture.displayScripture();
        Console.WriteLine("Done!");
    }
}