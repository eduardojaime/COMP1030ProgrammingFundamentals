using System;
// concrete class
public class Car
{
    public string Make;
    public string Year;
    public string Model;
    public SteeringWheel SteeringWheel;
    public Engine Engine;

    // Constructor > What does a car need to be created and function properly?
    // Among other info, it also needs an Engine and a Steering Wheel
    public Car(string make, string year, string model, SteeringWheel steeringWheel, Engine engine)
    {
        this.Make = make;
        this.Year = year;
        this.Model = model;
        this.SteeringWheel = steeringWheel;
        this.Engine = engine;
    }

    public void GoDrive()
    {
        this.Engine.TurnOn();
        this.Engine.Accelerate();
        this.SteeringWheel.TurnLeft();
        this.Engine.Accelerate();
        this.SteeringWheel.TurnRight();
        this.Engine.Accelerate();
        this.SteeringWheel.TurnRight();
        this.Engine.TurnOff();
    }

}