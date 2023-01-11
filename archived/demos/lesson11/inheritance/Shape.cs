using System;
// make abstract so the program cannot create Shape objects
// we want to use Shape ONLY for inheritance purposes
public  abstract class Shape
{
    // FIELDS
    public string Name;
    // PROPERTIES
    // CONSTRUCTORS
    // METHODS
    // make virtual to allow derived classes to override this behavior (OPTIONAL)
    public virtual void PrintShape() {
        Console.WriteLine("PRINTING DEFAULT SHAPE");
    }
    // make abstract to force derived classes to override these (MUST)
    // abstract methods don't contain any code
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}