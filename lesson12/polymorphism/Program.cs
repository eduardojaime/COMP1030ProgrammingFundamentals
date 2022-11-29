namespace polymorphism;
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello, Animals!");
		Cat myCat = new Cat();
		myCat.MakeSound(); // outputs Meow meow

		Dog myDog = new Dog();
		myDog.MakeSound(); // outputs Bark bark
	}
}


