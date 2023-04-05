// derived class
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog goes woof woof!");
    }
    public override void Sleep()
    {
        Console.WriteLine("Dog goes wim wim...");
    }
}
