using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 4);

        Rectangle rectangle = new Rectangle("Red", 3, 5);

        Circle circle = new Circle("Yellow", 2);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"Color: {color} - Area: {area}");
        }
    }
}