namespace Polymorphism;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Polymorphism!");
        // NOT ALLOWED
        // Animal myAnimal = new Animal();
        Cat myCat = new Cat();
        myCat.MakeSound();
        myCat.Sleep();

        Dog myDog = new Dog();
        myDog.MakeSound();
        myDog.Sleep();
    }
}
