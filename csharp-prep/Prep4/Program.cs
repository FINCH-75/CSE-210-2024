using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        //List<int> numbers = new List<int>();
        
        List<int> numbers = new List<int>();

        int listNumber = -1;

        while (listNumber != 0)
        {
            Console.WriteLine("Give me a number. Enter 0 when finished" );
            string response = Console.ReadLine();
            listNumber = int.Parse(response);
        
            if (listNumber != 0 )
            {
                numbers.Add(listNumber);
            }
        
        

        }
        //foreach (int num in numbers)
        //{
           // Console.WriteLine(num);
        //}

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum of all the numbers is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Your average is {average}");

        int max = 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"your max is {max}");
    }
}