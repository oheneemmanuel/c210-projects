public abstract class Shape
{
    public string _color
    
    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();
    
}