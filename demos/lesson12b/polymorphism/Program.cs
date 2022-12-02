namespace polymorphism;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Animals!");
        // Cats and Dogs
        Cat myCat = new Cat();
        myCat.MakeSound(); // default
        myCat.Sleep(); // brrr brr
        myCat.Run(); // default

        Dog myDog = new Dog();
        myDog.MakeSound(); // bark bark
        myDog.Sleep(); // wim wim
        myDog.Run(); // default
    }
}
