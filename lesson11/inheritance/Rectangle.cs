using System;
// Rectangle is a Shape
public class Rectangle : Shape
{
    public double Width;
    public double Height;
    // Virtual methods can be overridden but this is optional
    public override void PrintShape()
    {
        Console.WriteLine("PRINTING: RECTANGLE");
    }
    // Class must implement all abstract methods
    // use the 'override' keyword to indicate that the method will specify code for the corresponding abstract method
    public override double CalculateArea()
    {
        // Formula A = ab
        Console.WriteLine("Calculating Rectangle Area");
        return Width * Height;
    }
    public override double CalculatePerimeter()
    {
        // Formula P = (a+b)*2
        Console.WriteLine("Calculating Rectangle Perimeter");
        return (Width + Height) * 2;
    }
}