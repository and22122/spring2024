using System;
using System.IO;
using System.Net;
using System.Threading.Tasks.Dataflow;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    List<String> _prompts = new List<String>();

    public Journal()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public String generatePrompt()
    {
        Random randGen = new Random();

        int n = randGen.Next(0, _prompts.Count());

        return _prompts[n];
    }
    public void createEntry(String message = "")
    {
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

        foreach (String entryText in textEntries) {
            string[] parts = entryText.Split("\n");

            _entries.Add(new Entry(parts[1], parts[2], parts[0]));
        }
    }
}