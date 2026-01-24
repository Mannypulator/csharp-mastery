

Dog myDog = new Dog();

var mySecondDog = new Dog();
Dog myThirdDog = new();

myDog.setName("Buddy");
myDog.Age = 10;
myDog.breed = "Golden Retriever";

mySecondDog.setName("Lucy");
mySecondDog.Age = 3;


System.Console.WriteLine(myDog.GetName());

System.Console.WriteLine(mySecondDog.GetName());

class Dog
{
    private string name;
    public string breed;
    public int Age;

    public string GetName()
    {
        return name;
    }

    public void setName(string newName)
    {
        this.name = newName;
    }

    public void Bark()
    {
        System.Console.WriteLine("Woof!");
    }
}

//HomeAddress AdminUser

