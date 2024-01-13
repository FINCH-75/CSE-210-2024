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
        Console.Write("Guess a number between 1 and 100." );
        userGuess = int.Parse(Console.ReadLine());

        if (userGuess < number)
        {
            Console.WriteLine($"Guess higher");
        }
        else if (userGuess > number)
        {
            Console.WriteLine($"Guess lower");
        }
        else
        {
            Console.WriteLine($"Congrats you guessed it! {number}");
        }
       }
    }
}