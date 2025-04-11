public class Square : Shape
{
    private double _sideLength;

    public Square(double sideLength)
    {
        _sideLength = sideLength;
    }

    public override double GetArea()
    {
        return _sideLength * _sideLength;
    }
}