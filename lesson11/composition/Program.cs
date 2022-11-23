namespace lesson11;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Cars!");

        // In composition, the parts must be created first
        // A car in this program cannot exist without an engine and a steering wheel
        Engine myEngine = new Engine();
        myEngine.CylinderCount = 4;

        SteeringWheel mySteeringWheel = new SteeringWheel();
        mySteeringWheel.Color = "Blue";
        // Car is the main entry point from which the program calls methods in the Engine and Steering Wheel objects
        Car myCar = new Car("VW", "1998", "Pointer Pick Up", mySteeringWheel, myEngine);
        myCar.GoDrive();
    }
}
