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
        
        
        

        if (grade >= 90)
        {
             string textGrade = grade.ToString();
             textGrade = "A";
             Console.WriteLine($"You got a {textGrade}");
             Console.WriteLine($"Congrats you passed!");
             
        }
        else if (grade >= 80)
        {
            string textGrade = grade.ToString();
            textGrade = "B";
            Console.WriteLine($"You got a {textGrade}");
            Console.WriteLine($"Congrats you passed!");
        }
        else if (grade >= 70)
        {
            string textGrade = grade.ToString();
            textGrade = "C";
            Console.WriteLine($"You got a {textGrade}");
            Console.WriteLine($"Congrats you passed!");

        }
        else if (grade >= 60)
        {
        string textGrade = grade.ToString();
        textGrade = "D";
        Console.WriteLine($"You got a {textGrade}");
        Console.WriteLine($"Sorry you did not pass.");

        }
        else 
        {
           string textGrade = grade.ToString();
           textGrade = "F";
           Console.WriteLine($"You got a {textGrade}");
           Console.WriteLine($"Sorry you did not pass."); 

        }

        
    }
}