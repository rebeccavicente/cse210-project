using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int number=1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Please enter as many numbers as you can think of. Press 0 when you are done");
        int maxNumber=0;
        int count=0;

        while (number!=0)
        {
            
            number = int.Parse(Console.ReadLine());
            if (number != 0)
                {
                    numbers.Add(number);
                    count=count+1;
                }
        }

        foreach (int item in numbers)
        {
                    
                 if (item>maxNumber)
                {
                maxNumber=item;
                
                }
        }
         Console.WriteLine($"The largest number is {maxNumber}");

        int total = 0;

        foreach (int item in numbers)
        {
            total += item;
        }

        Console.WriteLine($"The total is {total}");
        int average=total/count;
        Console.WriteLine($"The average is {average}");


    }

    
}