using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        events.Add(new Lecture("Jalen Anderson", 3000, "How to start a tire fire", "Tire fires are great! Come learn how to make your own!", "July 15", "4:30", "1234 Legit St."));
        events.Add(new Reception("JavaScript 101", "Learn how to make cool games!", "July 16", "4:30", "STC 198", "stuffiesoflove@gmail.com"));
        events.Add(new Outdoors("Lasso golf", "It's like horseshoes, but with bolas!", "August 18", "5:00", "Porter park", "Sparse clouds or sunny skies"));

        for (int i = 0; i < events.Count(); i ++)
        {
            events[i].getShortDetails();
            events[i].getFullDetails();
            events[i].getShortDesc();
        }
    }
}