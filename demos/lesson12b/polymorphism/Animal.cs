using System;
// What makes an animal?
// class must be abstract in order to contain abstract methods
public abstract class Animal
{
    // FIELD
    // PROPERTIES
    // CONSTRUCTORS
    // METHODS
    // Design Decision: do we want to have default behaviour?
    // non-polymorphic method, because we cannot override it, only inherit it
    public void Run()
    {
        Console.WriteLine("Animal is running fast!");
    }
    // virtual makes this method optionally overridable
    public virtual void MakeSound()
    {
        Console.WriteLine("This is an animal making a sound!");
    }
    // abstract makes the overriding of the method mandatory
    public abstract void Sleep();
}