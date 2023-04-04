// cat inherits from animal
class Cat : Animal
{
    // no errors, all good because virtual methods are optional
    // Polymorphic method
    public override void MakeSound()
    {
        // base.MakeSound(); // calling method from parent class
        Console.WriteLine("Cat goes meow meow!");
    }
    // Mandatory method
    // Must be overriden here
    public override void Sleep()
    {
        Console.WriteLine("Cat goes brrrrr brrrr");
    }
}