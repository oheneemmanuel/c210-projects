using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string user_name = PromptUserName();
        int user_number = prompt_user_number();

        int squared_number = square_number(user_number);

        display_result(user_name, squared_number); 

    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");

    }

    static string PromptUserName()
    {
        Console.Write("What is your name : ");
        string name = Console.ReadLine();
        return name;
    }

    static int prompt_user_number()
    {
        Console.Write("Enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int square_number(int number)
    {
        int square = number * number;
        return square;
    }

    static void display_result(string name, int square)
    {
        Console.WriteLine($"{name}, the sqaure of your number is {square}");
    }

}   
