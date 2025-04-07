//Asked for username to do a proper introduction for them that how i exceeded requriements
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Nice to meet you, {userName}!\n");
        Console.WriteLine("Press Enter to begin...");
        Console.ReadLine();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();
            if (choice == "4") break;

            Console.Write("Enter the duration (in seconds): ");
            int duration = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    new BreathingActivity(duration).StartBreathing();
                    break;
                case "2":
                    new ReflectionActivity(duration).StartReflection();
                    break;
                case "3":
                    new ListingActivity(duration).StartListing();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}