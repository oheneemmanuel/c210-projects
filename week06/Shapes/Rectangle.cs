public class Rectangle : Shape
{
    private double _sideLength;
    private double _width;


    public Rectangle(string color, double sideLength, double width) : base(color)
    {
        _sideLength = sideLength;
        _width = width;
    }
    

    public override double GetArea()
    {
        return _sideLength * _width;
    }
}