using System;

namespace lesson11;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Shapes!");
        // Abstract classes cannot be instantiated
        // Shape myShape = new Shape();
        // Concrete classes: Rectangle and Triangle
        Rectangle myRectangle = new Rectangle();
        myRectangle.Height = 100.0;
        myRectangle.Width = 150.0;
        
        myRectangle.PrintShape();
        double rectanglePerimeter = myRectangle.CalculatePerimeter();
        Console.WriteLine($"Perimeter of Rectangle is {rectanglePerimeter}");
        double rectangleArea = myRectangle.CalculateArea();
        Console.WriteLine($"Area of Rectangle is {rectangleArea}");

        Triangle myTriangle = new Triangle();
        myTriangle.SideA = 10.0;
        myTriangle.SideB = 15.0;
        myTriangle.SideC = 20.0;

        myTriangle.PrintShape();
        double trianglePerimeter = myTriangle.CalculatePerimeter();
        Console.WriteLine($"Perimeter of Triangle is {trianglePerimeter}");
        double triangleArea = myTriangle.CalculateArea();
        Console.WriteLine($"Area of Triangle is {triangleArea}");
    }
}
