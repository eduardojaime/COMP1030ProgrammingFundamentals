using System;
// Abstract classes cannot be instantiated
// It doesn't make sense to create a Shape in our program
public abstract class Shape
{
    // Fields
    public string Name;
    // Properties
    // Constructors
    // Methods
    // Virtual methods CAN be 'overridden' in the derived class
    // In this case, it makes sense to have some sort of default behavior
    public virtual void PrintShape(){
        // shapes can be taken from here https://texteditor.com/characters/shapes/
        Console.WriteLine("This is a default shape");
    }
    // Abstract methods don't need default behavior and MUST be 'overriden' in the derived class
    // For these two, we need to force the derived classes to specify how to calculate each
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}