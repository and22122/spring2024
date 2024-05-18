using System;

class Program
{
    static void Main(string[] args)
    {
        string[] text = ["Hi!", "How are you?", "I am doing well today."];

        text.Append("Hi!");

        Console.WriteLine(text);

        string newtext = String.Join(" ", text);

        Console.WriteLine(newtext);
    }
}