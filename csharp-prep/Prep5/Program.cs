using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");

        DisplayMessage();
        string Name = DisplayUserName();
        int Number = PromptUserNumber();
        int SquareNumber = Squared(Number);
        DisplayResult( Name,SquareNumber);

    }

        static void DisplayMessage()
    {
    Console.WriteLine("Welcome to the Program!");
    }

    static string DisplayUserName()
    {
        Console.Write($"Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite Number: ");
        int Number = int.Parse(Console.ReadLine());

        return Number;
    }

    static int Squared(int Number)
    {
        int squared = Number * Number;

        return squared;
    }

    static void DisplayResult(string Name, int SquareNumber)
    {
        Console.WriteLine($"{Name}, the square of your number is {SquareNumber}");
    }


}