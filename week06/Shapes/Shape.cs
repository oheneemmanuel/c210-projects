public abstract  class Shape
{
    public string _color;

    public Shape(string color)
    {
        _color = color;
    }
    
    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
    
}