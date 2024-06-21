public class Rectangle : Shape
{
    private double _width;
    private double _length;
    public Rectangle(string color, double width, double length) : base(color)
    {
        _width = width;
        _length = length;
        _color = color;
    }
    public override double GetArea()
    {
        return _width * _length;
    }
}