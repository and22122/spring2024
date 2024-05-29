using System.Diagnostics;

public class Scripture
{
    private List<Verse> _verses = new List<Verse>();
    private String _reference;

    public Scripture()
    {
        Console.WriteLine("Please enter the reference.");
        _reference = Console.ReadLine();

        String option = "";
        do
        {
            Console.WriteLine("Please enter the text for the verse.");
            _verses.Add(new Verse(Console.ReadLine()));
            Console.WriteLine("If you want to continue adding verses, press 'y' and then enter.");
            option = Console.ReadLine();
        } while(option.ToLower() == "y");
    }
    public void displayScripture()
    {
        Console.WriteLine(_reference);
        
        foreach (Verse v in _verses)
        {
            Console.WriteLine(v.getVerse());
        }
    }
    
    public void hideRandom()
    {
        Random randGen = new Random();

        int n;

        do
        {
            n = randGen.Next(0, _verses.Count);
        } while(_verses[n].verseIsHidden());

        _verses[n].hideWord();
    }

    public bool scriptureIsHidden()
    {
        bool sHidden = true;

        foreach (Verse v in _verses) {
            sHidden = sHidden && v.verseIsHidden();
        }

        return sHidden;
    }
}