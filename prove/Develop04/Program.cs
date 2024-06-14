using System;

class Program
{
    static void Main(string[] args)
    {
        String option = "";

        do
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("- Breathing activity\n - Reflection activity\n - Listing activity\n - quit");
            Console.WriteLine("Please type the first word of the option you want to choose.");
            option = Console.ReadLine();

            switch (option.ToLower())
            {
                case "breathing":
                    Breathing b = new Breathing();
                    b.run();

                    break;
                case "reflection":
                    Reflection r = new Reflection();
                    r.run();

                    break;
                case "listing":
                    Listing l = new Listing();
                    l.run();

                    break;
                case "quit":
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Invalid input received.");
                    break;
            }
        } while(option.ToLower() != "quit");

        Console.WriteLine("Program has finished running.");
    }
}