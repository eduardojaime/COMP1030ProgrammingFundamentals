using System;
// colon symbol can be read as 'is a' or 'inherits from'
public class Rectangle : Shape
{
    // FIELDS
    public double Width;
    public double Height;
    // PROPERTIES
    // CONSTRUCTORS
    // METHODS
    // optional override PrintShape()
    // will not override here
    // must override abstract methods in base class
    public override double CalculateArea()
    {
        
        // A = ab
        Console.WriteLine("Calculating Rectangle Area");
        return Width * Height;
    }
    public override double CalculatePerimeter()
    {
        // P = (a+b) * 2
        Console.WriteLine("Calculating Rectangle Perimeter");
        return (Width + Height) * 2;
    }
}