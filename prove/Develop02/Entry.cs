using System;

public class Entry
{
    String _date; //date = string form of creation date
    String _prompt;
    String _text;

    public Entry(String prompt, String text = "", String date = "")
    {
        if (date == "")
        {
            _date = DateTime.Now.ToShortDateString();
        }
        else
        {
            _date = date;
        }

        Console.WriteLine(prompt);
        _prompt = prompt;

        if (text == "") {
            Console.WriteLine("What do you want your entry to say?");

            _text = Console.ReadLine();
        }
        else
        {
            _text = text;
        }
    }

    public String getText()
    {
        return _text;
    }
    public String toStringType()
    {
        return $"{_date}\n{_prompt}\n{_text}";
    }
    public void displayEntry()
    {
        Console.WriteLine($"{_date}\n{_prompt}\n{_text}");
    }
}