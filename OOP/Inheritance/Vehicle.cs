using System;

namespace OOP.Inheritance;

public class Vehicle
{
    public int NumberOfWheels { get; set; }

    public void StartEngine()
    {
        System.Console.WriteLine("Engine Started");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void Drive()
    {
        System.Console.WriteLine("Driving the car");
    }
}

public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

    public void Haul()
    {
        System.Console.WriteLine("Hauling a load");
    }
}
