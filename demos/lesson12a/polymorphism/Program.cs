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
        // Polymorphism in action
        myCat.MakeSound();
        myDog.MakeSound();

        // Polymorphic methods
        dory.Sleep();
        myCat.Sleep();
        myDog.Sleep();
    }
}
