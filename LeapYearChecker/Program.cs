// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// a leap is year is divisible by 4 and 100 but not by 400

// divisible by 4 => year % 4 == 0
// divisible by 100 => year % 100  == 0
// not divisible by 400 => year % 400 != 0


System.Console.WriteLine("___ Leap Year Checker");
System.Console.WriteLine("Enter a year:");
string input = Console.ReadLine();

bool isDigit = int.TryParse(input, out int year);

if (isDigit)
{
    if ((year % 4 == 0 && year % 100 == 0) || year % 400 != 0)
    {
        System.Console.WriteLine($"{year} is a LEAP year.");
    }
    else
    {
        System.Console.WriteLine($"{year} is not a LEAP year.");
    }
}
else
{
    System.Console.WriteLine("Invalid input. Please enter a valid numeric year.");
}
