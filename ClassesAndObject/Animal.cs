using System;

namespace ClassesAndObject;

public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }

    public virtual string MakeSound()
    {
        return "Generic animal sound";
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    public override string MakeSound()
    {
        return "Woof!";
    }
}

public class Cat : Animal
{
    public int Lives { get; set; }

    public override string MakeSound()
    {
        return "Meow!";
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog { Name = "Buddy", Color = "Golden", Breed = "Golden Retriever" };
        Cat cat = new Cat { Name = "Whiskers", Color = "Gray", Lives = 9 };

        Console.WriteLine("Dog Name: " + dog.Name);
        Console.WriteLine("Dog Sound: " + dog.MakeSound());
        Console.WriteLine("Cat Name: " + cat.Name);
        Console.WriteLine("Cat Sound: " + cat.MakeSound());
    }
}
