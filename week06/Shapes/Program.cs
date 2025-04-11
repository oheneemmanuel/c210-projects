using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 5.0);
        Square square2 = new Square("yellow", 6.0);
        Square square3 = new Square("green", 4.0);

        Rectangle rectangle1 = new Rectangle("blue", 4.0, 6.0);
        Rectangle rectangle2 = new Rectangle("black", 5.0, 10.0);
        Rectangle rectangle3 = new Rectangle("grey", 6.0, 6.0);

        Circle circle1 = new Circle("purple", 3.0);
        Circle circle2 = new Circle("orange", 4.0);
        Circle circle3 = new Circle("pink", 5.0);
       

        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(square2);
        shapes.Add(square3);
        shapes.Add(circle1);
        shapes.Add(circle2);
        shapes.Add(circle3);
        shapes.Add(rectangle1);
        shapes.Add(rectangle2);
        shapes.Add(rectangle3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}