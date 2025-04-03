using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        
        MathsAssignment mathsAssignment=new MathsAssignment("12.6", "20-35", "Assumpta chidinma", "Abstraction");
        Console.WriteLine(mathsAssignment.GetSummary());
        Console.WriteLine(mathsAssignment.GetHomeWorkList());

        WritingAssignment writingAssignment= new WritingAssignment( "Accessing Private Data","Assumpta Chidinma", "inheritance");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}