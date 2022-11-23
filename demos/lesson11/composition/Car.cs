using System.Net;
using System;
public class Car
{
    public string Make;
    public string Model;
    public int Year;
    // composition
    public SteeringWheel SteeringWheel;
    public Engine Engine;

    // constructor > what does a car need in order to function properly?
    public Car(string make, int year, string model, SteeringWheel steeringWheel, Engine engine)
    {
        this.Make = make;
        this.Year = year;
        this.Model = model;
        this.SteeringWheel = steeringWheel;
        this.Engine = engine;
    }

    public void GoDrive()
    {
        // car utilizes engine and steering wheel for driving
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