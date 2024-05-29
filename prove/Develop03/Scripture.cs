using System.Diagnostics;

public class Scripture
{
    private List<Verse> _verses;

    public Scripture()
    {
        String option = "";
        do
        {
            Console.WriteLine("Please enter the text for the verse.");
            _verses.Add(new Verse(Console.ReadLine()));
            Console.WriteLine("If you want to continue adding verses, press 'y'.");
            option = Console.ReadLine();
        } while(option.ToLower() == "y");
    }
    public void displayScripture()
    {
        foreach (Verse v in _verses)
        {
            Console.WriteLine(v.getVerse());
        }
    }
    
    public void hideRandom()
    {
        Random randGen = new Random();

        _verses[randGen.Next(1, _verses.Count())].hideWord();
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