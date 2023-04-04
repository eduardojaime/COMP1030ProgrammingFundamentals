class Goldfish : Animal
{
    // this is just simple inheritance
    // MakeSound() comes from Animal
    
    // Polymorphic mandatory method
    public override void Sleep()
    {
        Console.WriteLine("Goldfish goes blub blub");
    }
}