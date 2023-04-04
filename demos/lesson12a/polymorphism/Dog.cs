class Dog : Animal
{
    // Polymorphic method
    public override void MakeSound()
    {
        Console.WriteLine("Dog goes woof woof!");
    }
    // Polymorphic and Mandatory method
    public override void Sleep()
    {
        Console.WriteLine("Husky goes wimwim!");
    }
}