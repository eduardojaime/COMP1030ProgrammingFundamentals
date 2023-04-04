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
}