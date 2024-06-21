using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 2.0),
            new Rectangle("White", 2.0, 3.0),
            new Circle("Blue", 2.0)           
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetColor()} shape is {shape.GetArea()}");
        }
    }
}