using System;

namespace OOP.Abstraction;

public class Car
{
    // use interfaces or abstract classes
    public void Start()
    {
        System.Console.WriteLine("Car started");

    }

    public void Accelerate()
    {
        System.Console.WriteLine("Car accelarating");
    }

    public void Brake()
    {
        System.Console.WriteLine("Car braking");
    }
}
