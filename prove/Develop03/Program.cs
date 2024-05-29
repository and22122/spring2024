using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture currentScripture = new Scripture();

        do {
            currentScripture.displayScripture();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            currentScripture.hideRandom();
        } while(!currentScripture.scriptureIsHidden());

        currentScripture.displayScripture();
        Console.WriteLine("Done!");
    }
}