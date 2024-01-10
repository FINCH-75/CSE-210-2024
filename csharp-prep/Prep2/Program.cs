using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your final score?");
        string userScore = Console.ReadLine();
        int grade = int.Parse(userScore);
        
        
        string letter = "";

        if (grade >= 90)
        {
             
             letter = "A";
             Console.WriteLine($"You got a {letter}");
             
             
        }
        else if (grade >= 80)
        {
            
            letter = "B";
            Console.WriteLine($"You got a {letter}");
            
        }
        else if (grade >= 70)
        {
            
            letter = "C";
            Console.WriteLine($"You got a {letter}");
            

        }
        else if (grade >= 60)
        {
        
        letter = "D";
        Console.WriteLine($"You got a {letter}");
        

        }
        else 
        {
           
           letter = "F";
           Console.WriteLine($"You got a {letter}");
            

        }

        if (grade >= 70)
        {
            Console.Write("Congradulations you have recieved a passing score!");
        }

        else 
        {
            Console.Write("We are sorry to inform you that you did not recieve a passing grade. Better luck next year.");
        }
        
    }
}