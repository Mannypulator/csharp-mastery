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
    bool isOperationValid = true;

    if (op == "+")
    {
        result = num1 + num2;
    }
    else if (op == "-")
    {
        result = num1 - num2;
    }
    else if (op == "*")
    {
        result = num1 * num2;
    }
    else if (op == "/")
    {
        // handle divison by zero
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero");
            isOperationValid = false;
        }
        else
        {
            result = num1 / num2;
        }
    }
    else
    {
        System.Console.WriteLine("Error: Invalid operator entered");
        isOperationValid = false;
    }

    if (isOperationValid)
    {
        System.Console.WriteLine("__________________________");
        System.Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
}
else
{
    System.Console.WriteLine("Error: Please enter a valid number");
}