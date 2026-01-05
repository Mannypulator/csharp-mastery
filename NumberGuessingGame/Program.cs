// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random = new Random();

int targetNumber = random.Next(1, 101);

int guess = 0;
int attempts = 0;

System.Console.WriteLine("___ Number Guessing Game____");
System.Console.WriteLine("I am thinking of a number between 1 and 100.");
System.Console.WriteLine("Can you guess what that number is?");

while (guess != targetNumber)
{
    System.Console.WriteLine("Enter your guess");
    string input = Console.ReadLine();

    // first you need to convert the string to integer

    // int userGuess = Convert.ToInt32(input);

    bool isDigit = int.TryParse(input, out guess);

    if (isDigit)
    {
        attempts++;

        if (guess < targetNumber)
        {
            System.Console.WriteLine("Too low! Try again");
        }
        else if (guess > targetNumber)
        {
            System.Console.WriteLine("Too high! Try again");

        }
        else
        {
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine($"Correct! The number was {targetNumber}");
            System.Console.WriteLine($"It took you {attempts} attempts");
        }
    }
    else
    {
        System.Console.WriteLine("Invalid input. Please enter a number");
    }
}