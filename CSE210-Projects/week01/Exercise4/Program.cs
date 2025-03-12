using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, Type 0 when finished!");
        List<int> numbers = new List<int>();
        int number;

        while(true)
        {
            Console.Write("Enter a number:");
            string input = Console.ReadLine();

            if (int.TryParse (input, out number))
            {
                if (number==0)
                
                    break;
                
                numbers.Add(number);
            }

            else
            {
                Console.WriteLine("Enter a valid number!");
                
            }
        }

            if (numbers.Count>0)
            {
                int sum=numbers.Sum();
                Console.WriteLine($"The sum of the numbers is: {sum}");

                double average=numbers.Average();
                Console.WriteLine($"The average of the numbers is: {average}");

                int max = numbers.Max();
                Console.WriteLine($"The maximuim number is : {max}");
            }


     
     
     
    } 
} 
