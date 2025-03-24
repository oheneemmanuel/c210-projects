using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.SetTop(4);
        Console.WriteLine($"the first constructor is {f1.GetTop()}");


        // using the 2nd constructor 
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetDecimalValue());


        // using the 3rd constructor 

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());



        





    }
}