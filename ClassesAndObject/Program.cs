

using ClassesAndObject;

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

var firstRectangle = new Rectangle();
firstRectangle.height = 5;
firstRectangle.width = 2;
var secondRectangle = new Rectangle()
{
    height = 6.5,
    width = 3.3
};

var person1 = new Person()
{
    firstName = "Emmanuel",
    lastName = "Imion",
    age = 32,
};

var person2 = new Person();
person2.firstName = "Daniel";
person2.lastName = "Obende";
person2.age = 35;

System.Console.WriteLine($"Area of first rectangle: {firstRectangle.CalculateArea()}");
System.Console.WriteLine($"Area of second rectangle: {secondRectangle.CalculateArea()}");

person1.Introduce();
person2.Introduce();

var myBankAccount1 = new BankAccount("0118789108", 1000000000);
System.Console.WriteLine(myBankAccount1.GetAccountNumber());
System.Console.WriteLine(myBankAccount1.GetBalance());
myBankAccount1.Withdraw(5000);
System.Console.WriteLine(myBankAccount1.GetBalance());
myBankAccount1.Deposit(100000000000);
System.Console.WriteLine(myBankAccount1.GetBalance());


var circle = new Circle(3);
System.Console.WriteLine($"Area of circle is : {circle.Area()}");

var square = new Square(3);
System.Console.WriteLine($"Area of square is :{square.Area()}");

var circle1 = new Circlev2(4);
System.Console.WriteLine($"Area of circle is : {circle1.Area()}");

var square1 = new Squarev2(4);
System.Console.WriteLine($"Area of square is :{square1.Area()}");

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

