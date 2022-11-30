class Car
{
    // Composition
    // Parts are declared as fields
    // A Car has a VIN Number
    public string VINNumber;
    public string Make;
    public string Model;
    public int Year;
    // composition fields
    // "has-a" relationship
    // A Car has an Engine
    public Engine MyEngine;
    // A Car has a SteeringWheel
    public SteeringWheel BlueSteeringWheel;
    // Constructor method
    public Car(Engine myEngine, SteeringWheel mySteeringWheel)
    {
        this.MyEngine = myEngine;
        this.BlueSteeringWheel = mySteeringWheel;
    }
    // methods
    public void GoDrive()
    {
        // using the engine and steering wheel 
        // only make sense if used from the car
        this.MyEngine.TurnOn();
        this.BlueSteeringWheel.TurnLeft();
        this.BlueSteeringWheel.TurnRight();
        this.MyEngine.TurnOff();
    }
}