using System;

namespace ClassesAndObject;

public class Rectangle
{
    public double width { get; set; }
    public double height { get; set; }

    public double CalculateArea()
    {
        return width * height;
    }
}
