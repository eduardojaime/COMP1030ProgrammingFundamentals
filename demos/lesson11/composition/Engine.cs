using System;
public class Engine
{
    public int CylinderCount;
    public void TurnOn(){
        Console.WriteLine("Turning On!");
    }
    public void TurnOff() {
        Console.WriteLine("Turning Off!");        
    }
    public void Accelerate() {
        Console.WriteLine("Moving!");        
    }
}