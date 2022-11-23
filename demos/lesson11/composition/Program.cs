namespace composition;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Cars!");

        // same as in a factory
        // engine and steering wheel must exist before we can make a car
        Engine myEngine = new Engine();
        myEngine.CylinderCount = 4;        

        SteeringWheel mySteeringWheel = new SteeringWheel();
        mySteeringWheel.Color = "blue";

        Car myCar = new Car("VW", 1994, "GOLF", mySteeringWheel, myEngine);
        myCar.GoDrive();
    }
}
