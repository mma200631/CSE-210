using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write ("What is your First Name?");
        string fname = Console.ReadLine();
        Console.Write ("What is your Last Name?");
        string lname = Console.ReadLine();
        Console.WriteLine ($"Your Name is {lname} , {fname} {lname}");
    }
}