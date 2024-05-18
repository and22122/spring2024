using System;
using System.IO;
using System.Net;
using System.Threading.Tasks.Dataflow;

public class Journal()
{
    List<Entry> _entries = new List<Entry>();
    List<String> _prompts = new List<String>();

    public String generatePrompt()
    {
        Random randGen = new Random();

        int n = randGen.Next(0, _prompts.Count());

        return _prompts[n];
    }
    public void createEntry(String message)
    {
        //should createEntry add an entry to _entries?
        //or should it return an entry?
        _entries.Add(new Entry(generatePrompt(), message));
    }
    public void display()
    {
        foreach (Entry e in _entries)
        {
            e.displayEntry();
        }
    }
    public void save(String filename)
    {
        StreamWriter outFile = new StreamWriter(filename);

        foreach (Entry e in _entries)
        {
            outFile.WriteLine($"\\\\{e.toString()}");
        }
    }
    public void decodeFromFile(String filename)
    {
        string[] sourceText = System.IO.File.ReadAllLines(filename);

        string[] textEntries = String.Join(" ", sourceText).Split("\\\\");
    }
}