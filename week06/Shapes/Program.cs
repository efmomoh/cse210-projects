using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // instantiate the square object
        Square square1 = new Square("blue", 11);
        Console.WriteLine($"Your color is: {square1.GetColor()}");
        Console.WriteLine($"With an area of: {square1.GetArea()}");
        shapes.Add(square1);


        // instantiate the rectangle object
        Rectangle rectangle1 = new Rectangle("White", 2, 4);
        Console.WriteLine($"Color: {rectangle1.GetColor()}, Length: {rectangle1.GetLength()}, and Width: {rectangle1.GetWidth()}");
        shapes.Add(rectangle1);

        // create a circle instance
        Circle circle1 = new Circle("Red", 3);
        Console.WriteLine($"Color: {circle1.GetColor()} - Radius: {circle1.GetArea()}");
        shapes.Add(circle1);


        // create a foreach loop to iterate over the list of shapes
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The color is {color} while the area is {area}");
        }

    }
}