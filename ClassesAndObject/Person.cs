using System;

namespace ClassesAndObject;

public class Person
{
    public string firstName;
    public string lastName;

    public int age;

    public void Introduce()
    {
        System.Console.WriteLine($"Hello, my name is {firstName} {lastName} and I am {age} years old.");
    }
}
