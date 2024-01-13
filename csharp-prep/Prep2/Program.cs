using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What grade percentage did you recieve?");
        string percentFromUser = Console.ReadLine() ;
        string letterGrade = "";
        string letter = "";
        int grade = int.Parse(percentFromUser);
        float final =  grade%10;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        

        if (grade >= 90)
        {
            letterGrade = "A";
            
        }
        else if (grade >=80)
        {
            letterGrade = "B";
        }
        else if (grade >=70)
        {
            letterGrade = "C";
        }
        else if (grade >=60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }
         
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (final >= 7)
        {
            letter = "+";
        }

        else if (final >= 3)
        {
            letter = "";
        }

        else
        {
            letter = "-";
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        if (grade >= 97)
        {
           Console.WriteLine($"Your grade is {letterGrade}");
        }

        else if (grade<= 59)
        {
            Console.WriteLine($"Your grade is {letterGrade}");
        }

        else
        {
            Console.WriteLine($"Your grade is {letterGrade}{letter}.");
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
        
        if (grade >= 70)
        {
            Console.WriteLine($"Congradulations you have passed!");
        }
        else
        {
            Console.WriteLine($"Sorry you did not pass");
        }
        
        

        
       
    }
}