using System;
// Triangle is a Shape
public class Triangle : Shape
{
    public double SideA;
    public double SideB;
    public double SideC;
    // Virtual methods can be overridden but this is optional
    public override void PrintShape()
    {
        Console.WriteLine("PRINTING: TRIANGLE");
    }
    // Class must implement all abstract methods
    // use the 'override' keyword to indicate that the method will specify code for the corresponding abstract method
    public override double CalculateArea()
    {
        // Herons Formula A = √[4a²b² - (a² + b² - c²)²]/4
        // https://www.omnicalculator.com/math/3-sides-triangle-area
        Console.WriteLine("Calculating Rectangle Area");
        return Math.Sqrt((4 * Math.Pow(SideA, 2.0) * Math.Pow(SideB, 2.0)) - Math.Pow((Math.Pow(SideA, 2.0) + Math.Pow(SideB, 2.0) - Math.Pow(SideC, 2.0)), 2.0)) / 4;
    }
    public override double CalculatePerimeter()
    {
        // Formula P = a+b+c
        Console.WriteLine("Calculating Rectangle Perimeter");
        return SideA + SideB + SideC;
    }
}