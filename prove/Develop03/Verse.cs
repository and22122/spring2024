using System.Threading.Tasks.Dataflow;

public class Verse
{
    private List<Word> _words = new List<Word>();

    public Verse(string text)
    {
        foreach (String s in text.Split(" "))
        {
            Word w = new Word(s);
            _words.Add(w);
        }
    }

    public void hideWord()
    {
        Random randGen = new Random();

        int n;

        do
        {
            n = randGen.Next(0, _words.Count);
        } while (_words[n].wordIsHidden());

        _words[n].hide();
    }

    public String getVerse()
    {
        List<String> words = new List<String>();
        foreach (Word w in _words)
        {
            words.Add(w.getText());
        }

        return String.Join(" ", words);
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