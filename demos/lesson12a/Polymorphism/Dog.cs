public class Dog : Animal
{
    public override void MakeSound() {
        Console.WriteLine("Bark bark!");
    }
    public override void Sleep()
    {  
        Console.WriteLine("wimwim!");
    }
}