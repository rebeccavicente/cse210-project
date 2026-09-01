using System;

class Program
{
    static void Main(string[] args)
    {
                
        string answer="yes";


        while (answer=="yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);
            Console.WriteLine("What is the magic number?");
            string userInput=Console.ReadLine();
            int guess = int.Parse(userInput);
            int quantityOfGuesses=1;
            while (guess!=magicNumber)
            {
                
                quantityOfGuesses=quantityOfGuesses+1;
                if (guess>magicNumber)
                {
                    Console.WriteLine("Lower");
                    userInput=Console.ReadLine();
                    guess = int.Parse(userInput);
                }
                else if (guess<magicNumber)
                    {
                        Console.WriteLine("Higher");
                        userInput=Console.ReadLine();
                        guess = int.Parse(userInput);
                    }
                else
                {
                    Console.WriteLine("No");
                }
            }

            if (guess==magicNumber)
                {
                    Console.WriteLine("You guessed it!");
            
                }

            Console.WriteLine($"It took you {quantityOfGuesses} to guess it.");
            Console.WriteLine("Do you want to play again?");
            answer=Console.ReadLine();

        }


    } 
}