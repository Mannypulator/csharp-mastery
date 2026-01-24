using System;

namespace OOP.Polymorphism;

public class Shape
{
    public virtual void Draw()
    {
        System.Console.WriteLine("Drawing a shape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Drawing a circle");
    }
}

public class Square : Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Drawing a square");
    }
}
