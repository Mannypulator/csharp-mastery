System.Console.WriteLine("----- Factorial Calculator -----");
System.Console.WriteLine("Enter a non-negative number");

var userInput = Console.ReadLine();

if (int.TryParse(userInput, out int number) && number > 0)
{
    long factorial = 1;

    // 5! = 5 * 4 * 3 * 2 * 1;
    // LOOP DOES: 5 => 1,2,3,4,5
    for (int i = number; i >= 1; i--)
    {
        factorial *= i;
    }

    System.Console.WriteLine($"The factorial of {number} is : {factorial}");
}
else
{
    System.Console.WriteLine("Error: Invalid input. Please check the number and try again");
}

System.Console.WriteLine("Press any key to exit");
Console.ReadLine();
