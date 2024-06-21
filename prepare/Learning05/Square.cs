public class Square : Shape
{
    private double _side;
    public Square(double side, String color) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}