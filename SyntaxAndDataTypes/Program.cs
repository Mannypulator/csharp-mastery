// See https://aka.ms/new-console-template for more information
using SyntaxAndDataTypes;
using SyntaxAndDataTypes.abstractions;// namespace being imported

Console.WriteLine("Hello, World!");

// declare variable
int myAge;
string firstName;
double priceOfGoods;
decimal accountBalance;
string _myAcctBlc;
decimal acountBlc2;
decimal secondAccountBalance;
int MyAge;
int @class = 0;


myAge = 32; // assigning of value;

string name = "Emmanuel Imion";
char firstLetter = 'A';


// Rules for naming a variable
//1. start with a letter

MyMethod();

void MyMethod()
{
    int x = 10; // access it within this method

    if (true)
    {
        int y = 20; // y is only accessible within this if statement 
        Console.WriteLine(x); // x is also accessible here
    }

    // Console.WriteLine(y);
}

//Data Types

//Value Types 

int definedAge = 32;
float definedFloatAge = 32F;
double definedWeight = 90.0;
double definedWeight2 = 90D;
decimal accountBalancev3 = 1000000M;
bool isMyAccount = false;
bool canDeleteUser = true;
char initial = 'E';

long longAge = 0;

int newAge = definedAge;

System.Console.WriteLine(newAge);
// struct Person()
// {
//     int Age = 32;
//     string Name = "Emmanuel Imion";
//     bool IsMarried = true;

// }




//Reference Types
string fullName = "Emmanuel Adesola Imion";

string newFullName = fullName;

System.Console.WriteLine(fullName);
System.Console.WriteLine(newFullName);

fullName = "Emmanuel Ehis Ose";
System.Console.WriteLine(fullName);
System.Console.WriteLine(newFullName);

var firstUser = new User
{
    FirstName = "Emmanuel",
    LastName = "Imion"
};

var secondUser = firstUser;

firstUser.FirstName = "Ehis";


System.Console.WriteLine($"First User Name: {firstUser.FirstName} {firstUser.LastName}");
System.Console.WriteLine($"Second User Name: {secondUser.FirstName} {secondUser.LastName}");

// default values


System.Console.WriteLine(default(string));
System.Console.WriteLine(default(bool));

// Operators

int x = 4;
int y = 5;

int result = x * y;
System.Console.WriteLine(result);
var quotientResult = result / 4;
System.Console.WriteLine(quotientResult);

var remainderResult = quotientResult % 2;
System.Console.WriteLine(remainderResult);

var doubleExpectedResult = 7.0 / 2;
System.Console.WriteLine(doubleExpectedResult);

x += 5;
y += 5;

x *= 2;

bool isTrue = x <= y;
System.Console.WriteLine(isTrue);
System.Console.WriteLine(!isTrue);

System.Console.WriteLine(false && true);


// Practical Acivities
//1.
int numberofCars = 5;
double gasPrice = 3.50;
string carModel = "Toyota Camry";
bool isElectric = false;

Console.WriteLine(numberofCars);
System.Console.WriteLine(gasPrice);
System.Console.WriteLine(carModel);
System.Console.WriteLine(isElectric);

//2.
int width = 10;
int height = 5;

int area = width * height;

System.Console.WriteLine($"Area of rectangle equals={area}");

int perimeter = 2 * (width + height);

System.Console.WriteLine($"Perimeter of rectangle equals={perimeter}");

//3.
int age = 20;
bool hasLicense = false;

bool canDrive = age >= 16 && hasLicense;

System.Console.WriteLine(canDrive);

//4.
int intergerValue = 100;
double doubleValue = intergerValue; // implicit conversion

System.Console.WriteLine(doubleValue);

double anotherDoubleValue = 3.75;

int integerValue2 = (int)anotherDoubleValue; //explicit conversion(casting)
System.Console.WriteLine(integerValue2);
