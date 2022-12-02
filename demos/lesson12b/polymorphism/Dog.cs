public class Dog : Animal
{
    // FIELDS, PROPERTIES, CONSTRUCTORS
    // METHODS
    public override void MakeSound()
    {
        Console.WriteLine("Bark bark!");
    }

    public override void Sleep()
    {
        Console.WriteLine("wimwim!");
    }
}