using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random random = new Random();
        int magicNumber = random.Next(1, 101); 
        int guess = -1; 
        int guessCount=0;

        Console.WriteLine("Welcome to the Number Guessing Game!");

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out guess))  
            {
                guessCount++;
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} attempts");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }
        }

    }
}
