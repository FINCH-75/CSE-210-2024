using System;

class Program
{
    static void Main(string[] args)
    {


        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        //Console.WriteLine($"The random number is {number}");

       
        int userGuess = -1;

       while (userGuess != number)
       {
        Console.Write("What is your guess?");
        userGuess = int.Parse(Console.ReadLine());

        if (userGuess < number)
        {
            Console.WriteLine($"higher");
        }
        else if (userGuess > number)
        {
            Console.WriteLine($"Lower");
        }
        else
        {
            Console.WriteLine($"Congrats you guessed it! {number}");
        }
       }
    }
}