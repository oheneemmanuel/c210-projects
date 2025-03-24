using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;


    // this is a constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction( int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }    
     public Fraction(int top, int bottom)
     {
        _top = top;
        _bottom = bottom;
     }
    // this is a getter method used to access the private member variables
     public int GetTop()
     {
        return _top;
     }
     // this is a setter used 
     public void SetTop(int top)
     {
        _top = top;
     }

     public int GetBottom()
     {
        return _bottom;
     }
     public void SetBottom(int bottom)
     {
        _bottom = bottom;
     }
    // the getter method will always return something
    // the setter method will not(void) return anything 
     public string GetFractionString()
     {
        string text = $"{_top} / {_bottom}";
        return text;
     }

     public double GetDecimalValue()
     {
        double num = (double)_top / (double)_bottom;
        return num;

     }





}