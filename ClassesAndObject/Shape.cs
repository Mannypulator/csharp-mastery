using System;

namespace ClassesAndObject;

public abstract class Shape
{
    public abstract double Area();

    public virtual string Description()
    {
        return "This is a shape";
    }
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }
    public override double Area()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }


    // polymorphism
    public override string Description()
    {
        return "This is a circle";
    }
}

public class Square : Shape
{
    private double _length;

    public Square(double length)
    {
        _length = length;
    }
    public override double Area()
    {
        return Math.Pow(_length, 2);
    }

    public override string Description()
    {
        return "This is a square";
    }
}
