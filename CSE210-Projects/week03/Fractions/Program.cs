using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction1=new Fraction();
        Fraction fraction2= new Fraction(3);
        Fraction fraction3=new Fraction(3,7);

        Console.WriteLine("Testing Constructors");
        fraction1.PrintFraction();
        fraction2.PrintFraction();
        fraction3.PrintFraction();

        //Using setters to set new values
        fraction1.setTop(5);
        fraction1.setBottom(6);
        fraction2.setTop(4);
        fraction2.setBottom(2);
        fraction3.setTop(5);
        fraction3.setBottom(7);
        
        //using getters to retrive the new values
        Console.WriteLine("Updated values using setters:");
        Console.WriteLine($"Fraction1: {fraction1.GetTop()}/{fraction1.GetBottom()}");
        Console.WriteLine($"Fraction2: {fraction2.GetTop()}/{fraction2.GetBottom()}");
        Console.WriteLine($"Fraction3: {fraction3.GetTop()}/{fraction3.GetBottom()}");

        DisplayFractionalDetails(fraction1);
        DisplayFractionalDetails(fraction2);
        DisplayFractionalDetails(fraction3); 
        
    }
    public static void DisplayFractionalDetails(Fraction fraction)
    {
        Console.WriteLine($"Fraction {fraction.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {fraction.GetDecimalValue():0.00}");
    }

}