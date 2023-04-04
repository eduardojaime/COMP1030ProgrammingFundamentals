namespace polymorphism;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Declare and instantiate 3 objects
        Cat myCat = new Cat();
        Dog myDog = new Dog();
        Goldfish dory = new Goldfish();
        // Simple inheritance
        dory.MakeSound();
        
        myCat.MakeSound();
        myDog.MakeSound();

    }
}
