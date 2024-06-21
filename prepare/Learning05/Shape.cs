public abstract class Shape
{
    protected String _color;

    public Shape(String color)
    {
        _color = color;
    }
    public String getColor()
    {
        return _color;
    }
    public void setColor(String color)
    {
        _color = color;
    }
    public abstract double GetArea();
}