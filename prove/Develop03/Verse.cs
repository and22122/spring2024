using System.Threading.Tasks.Dataflow;

public class Verse
{
    private List<Word> _words;

    public Verse(string text)
    {
        foreach (String s in text.Split(" "))
        {
            _words.Add(new Word(s));
        }
    }

    public void hideWord()
    {
        Random randGen = new Random();

        _words[randGen.Next(1, _words.Count())].hide();
    }

    public String getVerse()
    {
        return String.Join(" ", _words);
    }

    public bool verseIsHidden()
    {
        bool hidden = true;

        foreach(Word w in _words)
        {
            hidden = hidden && w.wordIsHidden();
        }

        return hidden;
    }
}