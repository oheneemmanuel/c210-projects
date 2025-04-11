using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(4);
        square.SetColor("Red");
        Console.WriteLine($"Square Area: {square.GetArea()}");
    }
}