using System;

class Program
{
    static void Main(string[] args)
    {
        List<Fraction> fractions = new List<Fraction>();
        fractions.Add(new Fraction());
        fractions.Add(new Fraction(5));
        fractions.Add(new Fraction(3, 4));
        fractions.Add(new Fraction(1, 3));
        fractions.Add(new Fraction(3));
        fractions.Add(new Fraction(3));

        fractions[4].SetBottom(2);
        fractions[5].SetTop(4);
        fractions[5].SetBottom(4);

        foreach (Fraction f in fractions)
        {
            Console.WriteLine(f.GetTop());
            Console.WriteLine(f.GetBottom());
            Console.WriteLine(f.GetFractionString());
            Console.WriteLine(f.GetDecimalValue());
        }
    }
}