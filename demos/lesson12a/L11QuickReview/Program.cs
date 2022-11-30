namespace L11QuickReview;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, L11 Inheritance and Composition!");

        // L11 Inheritance and Composition
        // Q1 Inheritance > "is-a" type of relationship
        // Dog is an Animal
        Dog myDog = new Dog();
        myDog.ChaseBall();
        myDog.MakeSound();
        // Q2 Composition not very clear
        // Create Engine object and Steering Wheel
        Engine FourCylEngine = new Engine();
        FourCylEngine.CylinderCount = 4;

        Engine SixCylEngine = new Engine();
        SixCylEngine.CylinderCount = 6;

        SteeringWheel ASteeringWheel = new SteeringWheel();

        // then the car
        Car myCar = new Car(FourCylEngine, ASteeringWheel);
    }
}
