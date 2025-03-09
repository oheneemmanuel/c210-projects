using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenrator = new Random();
        int magicNumber = randomGenrator.Next(1, 100);

        int guess = -1;
        

        while (guess != magicNumber)
        {
            Console.Write("What is your guesss? : ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Try guessing a higher number ");

            }
            else if (magicNumber < guess )
            {
                Console.WriteLine("Try to guess a lower number instead");
            }
            else
            {
                Console.WriteLine("You guessed it !");
            }
            


        }
        
    }
}