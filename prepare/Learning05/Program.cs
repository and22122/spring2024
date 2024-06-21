using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        shapes.Add(new Square(1.5, "blue"));
        shapes.Add(new Rectangle(2.3, 2.0, "white"));
        shapes.Add(new Circle(1.0, "pink"));

        foreach (Shape s in shapes)
        {
            String c = s.getColor();
            double a = s.GetArea();
            Console.WriteLine($"The {c} shape has an area of {a}.");
        }
    }
}