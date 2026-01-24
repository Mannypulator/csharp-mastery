
// instantiate the BankAccount

using OOP;
using OOP.Abstraction;
using OOP.Inheritance;
using OOP.Polymorphism;
using Car = OOP.Abstraction.Car;

var bankAccount = new BankAccount(1000);
var myBalance = bankAccount.GetBalance();

System.Console.WriteLine($"My current balance is: {myBalance}");

bankAccount.Deposit(5000);


System.Console.WriteLine($"My current balance after deposit is: {bankAccount.GetBalance()}");

bankAccount.Withdraw(3000);

System.Console.WriteLine($"My current balance after withdrawal is: {bankAccount.GetBalance()}");

// bankAccount._balance = 0;

// System.Console.WriteLine($"My current balance after setting is: {bankAccount.GetBalance()}");



//Abstraction

var car = new OOP.Abstraction.Car();
car.Start();
car.Accelerate();
car.Brake();

// inheritance

var parent = new Parent();
parent.Id = 1;
parent.DateCreated = DateTime.Now;
parent.Name = "Emmanuel Imion";
parent.HousAddress = "Lagos";

var teacher = new Teacher
{
    Id = 1,
    Name = "Suvasubramaniam Raj",
    Class = "SS1",
    DateCreated = DateTime.Now,
};

var myCar = new OOP.Inheritance.Car();
myCar.NumberOfWheels = 4; // Inherited from Vehicle
myCar.NumberOfDoors = 4;
myCar.StartEngine(); // Inherited from Vehicle
myCar.Drive();

Truck myTruck = new Truck();
myTruck.NumberOfWheels = 6; // Inherited from Vehicle
myTruck.LoadCapacity = 10000;
myTruck.StartEngine(); // Inherited from Vehicle
myTruck.Haul();


// polymorphism
Shape shape1 = new Circle();
Shape shape2 = new Square();

shape1.Draw();
shape2.Draw();