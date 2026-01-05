// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
System.Console.WriteLine("___Simple Calculator___");

//Get First Number
System.Console.WriteLine("Enter the first number: ");
string firstNumber = Console.ReadLine();

//Get operator
System.Console.WriteLine("Enter the operator (+, -, *, /): ");
string op = Console.ReadLine();

// Get Second number
System.Console.WriteLine("Enter the second number: ");
string secondNumber = Console.ReadLine();

if (double.TryParse(firstNumber, out double num1) && double.TryParse(secondNumber, out double num2))
{
    double result = 0;
    bool isValidOperation = true;

    if(op == "+")
    {
        result = num1 + num2;
    }
}