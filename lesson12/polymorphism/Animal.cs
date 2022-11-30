public abstract class Animal
{
    // What makes an animal?
    // Fields
    // Properties
    // Constructors

    // Methods << focus for Polymorphism
    // Should all animals have a 'default' sound? This makes sense in my system
    // Do I want to allow other classes that inherit from animal to define what sound they make? Yes
    // Will this be optional or required? For this example let's make it optional (virtual)
    public virtual void MakeSound()
    {
        Console.WriteLine("This is an animal making a sound!");
    }
    // abstract is mandatory
    public abstract void Sleep(); // no code
}