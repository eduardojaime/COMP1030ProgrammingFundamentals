namespace polymorphism;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Polymorphic Method!");
        // simple inheritance Animal > Dog and Cat
        Dog myDog = new Dog();
        myDog.MakeSound();

        Cat myCat = new Cat();
        myCat.MakeSound();
    }
}
