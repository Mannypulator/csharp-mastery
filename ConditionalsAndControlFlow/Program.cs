// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age = 10;
if (age >= 18)
{
    System.Console.WriteLine("You are an adult");
}
else
{
    System.Console.WriteLine("You are not an adult");
}

System.Console.WriteLine("This line will always be executed");

int score = 30;

if (score >= 90)
{
    System.Console.WriteLine("Grade: A");
}
else if (score < 90 && score >= 80)
{
    System.Console.WriteLine("Grade: B");
}
else if (score < 80 && score >= 70)
{
    System.Console.WriteLine("Grade: C");
}

else if (score < 70 && score >= 60)
{
    System.Console.WriteLine("Grade: D");
}
else if (score < 60 && score >= 50)
{
    System.Console.WriteLine("Grade: E");
}
else
{
    System.Console.WriteLine("Grad: F");
}

bool hasLicense = false;
int driverAge = 22;

if (hasLicense)
{
    Console.WriteLine("Driver has a license.");

    if (driverAge >= 18)
    {
        Console.WriteLine("Driver is eligible to drive.");
    }
    else
    {
        Console.WriteLine("Driver is underage but has a license.");
    }
}
else
{
    Console.WriteLine("Driver does not have a license.");
}

// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");
// System.Console.WriteLine("Emmanuel");

//for loop
// for (int i = 0; i < 5; i++)
// {
//     // 0,1,2,3,4
//     System.Console.WriteLine("Emmanuel");
// }

//while loop
// int j = 0;
// while (j < 5)
// {
//     System.Console.WriteLine("Emmanuel");
//     j++;
// }

// do while loop              //0,
int k = 0;
do
{
    System.Console.WriteLine("Emmanuel");
    k++;
} while (k < 5);


// Example of using break in a for loop
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break; // Exit the loop when i is 5
    }
    Console.WriteLine(i);
}

Console.WriteLine("Loop finished."); // This will be executed after the loop breaks


// Example of using continue in a for loop
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        continue; // Skip even numbers
    }
    Console.WriteLine(i);
}

// Example of nested for loops to print a multiplication table
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.Write(i * j + " ");
    }
    Console.WriteLine(); // Move to the next line after each row
}