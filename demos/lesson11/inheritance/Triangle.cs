using System;
public class Triangle : Shape
{
    // FIELDS
    public double SideA;
    public double SideB;
    public double SideC;
    // PROPERTIES
    // CONSTRUCTORS
    // METHODS
    // Override optional virtual method
    public override void PrintShape()
    {
        Console.WriteLine("Printing a Triangle");
    }
    // must override abstract methods
    public override double CalculateArea()
    {
        // Herons Formula A = √[4a²b² - (a² + b² - c²)²]/4
        // https://www.omnicalculator.com/math/3-sides-triangle-area
        // √ use Math.Sqrt(num)
        // ² use Math.Pow(num1, num2)
        Console.WriteLine("Calculating Triangle Area");
        return Math.Sqrt((4 * Math.Pow(SideA, 2.0) * Math.Pow(SideB, 2.0)) - Math.Pow((Math.Pow(SideA, 2.0) + Math.Pow(SideB, 2.0) - Math.Pow(SideC, 2.0)), 2.0)) / 4;
    }

    public override double CalculatePerimeter()
    {
        // P = a + b + c
        Console.WriteLine("Calculating Triangle Perimeter");
        return SideA + SideB + SideC;
    }
}