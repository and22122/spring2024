using System;

class Program
{
    static void Main(string[] args)
    {
        bool isValid = false;
        Journal currentJournal = new Journal();

        do
        {
            Console.WriteLine("What do you want to do?\n- (w)rite a new entry\n- (d)isplay the current journal\n- (s)ave the current journal\n- (l)oad a journal from a file\n- (q)uit\nPlease type a letter to select an option.");
            String option = Console.ReadLine();
            
            if (option.ToLower() == "w")
            {
                isValid = true;

                currentJournal.createEntry();
            }
            else if (option.ToLower() == "d")
            {
                isValid = true;

                currentJournal.display();
            }
            else if (option.ToLower() == "s")
            {
                isValid = true;

                Console.WriteLine("What do you want to name the file?");
                currentJournal.save(Console.ReadLine());
            }
            else if (option.ToLower() == "l")
            {
                isValid = true;

                Console.WriteLine("What file do you want to use?");
                currentJournal.decodeFromFile(Console.ReadLine());
            }
            else if (option.ToLower() == "q")
            {
                isValid = false;

                Console.WriteLine("Hope to see you again soon!");
            }
        } while(isValid);
    }
}