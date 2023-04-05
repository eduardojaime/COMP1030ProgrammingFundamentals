// derived class
class Cat : Animal
{
    // at this point this is simple inheritance
    // we cannot override MakeSound() yet
    // after defining MakeSound() as virtual we can override it
    // override means this method replaces
    // the one from Animal
    public override void MakeSound() {
        Console.WriteLine("Cat goes meow meow!");
    }

    public override void Sleep()
    {
        Console.WriteLine("Cat goes brrr brrr...");
    }
}