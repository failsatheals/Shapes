using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Circle(5.0),
                new Triangle(10,50, "Triangle 1"),
                new Rectangle(10,20, "Rectangle 1")
            };

        System.Console.WriteLine("Shapes Collection");
        foreach (Shape s in shapes)
        {
            System.Console.WriteLine(s);
        }
        }
    }
}
