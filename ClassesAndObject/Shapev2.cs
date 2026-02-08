using System;

namespace ClassesAndObject;

public interface Shapev2
{
    double Area();
    public virtual string Description()
    {
        return "This is a shape";
    }
}

public class Squarev2 : Shapev2
{
    private double _length;
    public Squarev2(double length)
    {
        _length = length;
    }
    public double Area()
    {
        return Math.Pow(_length, 2);
    }
}

public class Circlev2 : Shapev2
{
    private double _radius;

    public Circlev2(double radius)
    {
        _radius = radius;
    }
    public double Area()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }


    // polymorphism
    public string Description()
    {
        return "This is a circle";
    }
}
