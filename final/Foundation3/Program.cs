using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        events.Add(new Lecture("Jalen Anderson", 3000, "How to start a tire fire", "Tire fires are great! Come learn how to make your own!", "July 15", "4:30", "1234 Legit St."));
        events.Add(new Outdoors("Lasso golf", "It's like horseshoes, but with bolas!", "August 18", "5:00", "Porter park", "Sparse clouds or sunny skies"));

        
        Reception r = new Reception("JavaScript 101", "Learn how to make cool games!", "July 16", "4:30", "STC 198", "stuffiesoflove@gmail.com");

        //Shoutout to the guys who make things happen:
        r.rsvp("Brother Gibbons");
        r.rsvp("Ammon the TA");

        Console.WriteLine(r.getShortDetails());
        Console.WriteLine(r.getFullDetails());
        Console.WriteLine(r.getShortDesc());

        for (int i = 0; i < events.Count(); i ++)
        {
            Console.WriteLine(events[i].getShortDetails());
            Console.WriteLine(events[i].getFullDetails());
            Console.WriteLine(events[i].getShortDesc());
        }
    }
}