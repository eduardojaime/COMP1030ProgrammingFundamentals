// this base class represents an animal in general
// for this class to define abstract methods
// the class itself must be abstract
abstract class Animal
{
    // What makes an animal?
    // Fields, Properties, Constructors
    
    // Methods
    // These are inherited to derived classes
    // Should we allow derived classes to implement their own sound?
    // virtual make this is optional for overriding
    public virtual void MakeSound() {
        Console.WriteLine("Animal goes wargggghhh!"); 
    }
    // mandatory methods to be overriden in derived classes
    // abstract forces the method to be overriden
    public abstract void Sleep(); // no code here
}