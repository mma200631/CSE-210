using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square MySquare=new Square("Blue", 16);

        string color=MySquare.GetColor();
        double area=MySquare.GetArea();

        Rectangle MyRectangle= new Rectangle(4, 2, "Red");

        string RectangleColor=MyRectangle.GetColor();
        double RectangleArea=MyRectangle.GetArea();

        Circle MyCircle= new Circle(6, "Purple");
        
        string CircleColor=MyCircle.GetColor();
        double CircleArea=MyCircle.GetArea();


        Console.WriteLine($"The square color is {color}");
        Console.WriteLine($"The area of a sqaure is {area}");
        Console.WriteLine();

        Console.WriteLine($"The Rectangle color is {RectangleColor}");
        Console.WriteLine($"The area of a Rectangle is {RectangleArea}");
        Console.WriteLine();

         Console.WriteLine($"The Circle color is {CircleColor}");
        Console.WriteLine($"The area of a Circle is {CircleArea}");
        Console.WriteLine();

        List<Shapes> shapes=new List<Shapes>();
        shapes.Add(new Square("Blue", 5));
        shapes.Add(new Rectangle(6, 4, "pink"));
        shapes.Add(new Circle(5, "yellow"));

        foreach(Shapes shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}