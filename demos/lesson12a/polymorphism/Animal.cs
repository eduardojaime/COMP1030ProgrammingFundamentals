// This class represents animals in my system
// I want to use this class to specify behaviours for my animals
// Classes must be declared abstract 
// to contain abstract methods
abstract class Animal
{
    // Make some sound
    // Implementation for this is optional, I want to provide some 'default' sound
    // virtual = optional
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal is making a default sound: blop blop!");
    }

    // Sleep
    // This is a mandatory method
    // All animals MUST implement Sleep()
    public abstract void Sleep();
}