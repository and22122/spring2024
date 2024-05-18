using System;

public class Entry(string prompt, string text)
{
    String _date = DateTime.Now.ToShortDateString(); //date = string form of creation date
    String _prompt = prompt;
    String _text = text;

    public String getText()
    {
        return _text;
    }
    public String toString()
    {
        return $"{_date}\n{_prompt}\n{_text}";
    }
    public void displayEntry()
    {
        Console.WriteLine($"{_date}\n{_prompt}\n{_text}");
    }
}