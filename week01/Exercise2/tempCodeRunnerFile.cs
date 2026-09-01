using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine(); //Reads user input
        int gradePercent = int.Parse(userInput); //Creates new variable for user input as integer
        string gradeAsText; //Creates new variable for letter
        int lastDigit = gradePercent % 10; //get last digit of user input
        string symbol; //Creates new variable for symbol
        
        //Conversion percentage to letter
        if (gradePercent >= 90  )
        {
           gradeAsText = "A";
        }
        else if (gradePercent >= 80)
        {
            gradeAsText = "B";
        }
        else if (gradePercent >= 70)
        {
            gradeAsText = "C";
        }
        else if (gradePercent >= 60)
        {
             gradeAsText = "D";       
        }
        else
        {
            gradeAsText = "F";
        }


        //Conversion last digit to symbol

         if (lastDigit >= 7)
         {
            symbol="+";
        }

        else if (lastDigit < 3)
        {
         symbol="-";
        }

        else
{
        symbol = "";
}


        //Exception for F
        if (gradeAsText == "F")
        {
            symbol = "";
        }



        //Exception for A
        else if (gradeAsText == "A" && lastDigit < 4 && gradePercent != 100)
        {
            symbol = "-";
        }
        else if (gradeAsText == "A")
        {
            symbol = "";
        }


        //Between + and -
        else
        {
            symbol = "";
        }


        //Prints grade
        Console.Write($"Your grade is {gradeAsText} {symbol} ");



        //Passed or not
        if (gradePercent>= 70)

        { 
            Console.Write("Congrats! You passed this course. ");  
        }
        else if (gradePercent <70)

        {
            Console.Write("I'm sorry you didn't pass, but you can try again! "); 
        }

        
       
    }
}