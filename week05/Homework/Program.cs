using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment a1 = new Assignment("Ohene", "Decimals");
        Console.WriteLine(a1.GetSummary());
        
        Console.WriteLine();
    
        MathAssignment math1 = new MathAssignment("Kwakye", "Fractions", "10.2", "13-18");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeWorkList());
        Console.WriteLine();
    
        WritingAssignment writing1 = new WritingAssignment("Emmanuel", "The Great Laws", "The Principles of life");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInfo());
        Console.WriteLine();

    }
}