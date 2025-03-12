using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayMessage();
        string username=UserName();
        int favnum= UserFavoriteNumber();
        int squarenumber=SquaredNumber(favnum);
        DisplayResult(username, squarenumber);

        
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
       

        static string UserName()
        {
        Console.Write("What is your Name?");
        string UserName= Console.ReadLine();
        Console.WriteLine($"Hello {UserName}");
        return UserName;
        }

        static int UserFavoriteNumber()
        {
            Console.Write("Please Enter your favourite number:");
            string input= Console.ReadLine();
            
            if (int.TryParse(input, out int number))
        {
            return number;
        }

        else{
            Console.WriteLine("Invalid input");
            return UserFavoriteNumber();
        }
        }

        static int SquaredNumber(int favouriteNumber)
        {
            return favouriteNumber* favouriteNumber;
        }

        static void DisplayResult(string name, int SquaredNumber)
        {
            Console.WriteLine($"{name} the square of your number is {SquaredNumber}");
    
        }
}