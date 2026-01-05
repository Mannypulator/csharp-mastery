# C# Mastery

A collection of C# learning projects demonstrating fundamental programming concepts and practical applications.

## 📚 Resources

For a comprehensive guide and detailed explanations, check out the [Complete Guide to C# Mastery](https://tremendous-ant-c4d.notion.site/A-Complete-Guide-to-C-Mastery-261372ab327e800087b0f9d49bcedcd7).

## 📋 Projects Overview

### 1. SyntaxAndDataTypes

**Concepts Covered:**

- Variable declaration and naming conventions
- C# data types (value types and reference types)
- Scope and lifetime of variables
- Using statements and namespaces
- Interfaces (IUser)
- User-defined types
- Operators

**Key Files:**

- [Program.cs](SyntaxAndDataTypes/Program.cs) - Main demonstrations of syntax and data types
- [User.cs](SyntaxAndDataTypes/User.cs) - Custom user class
- [IUser.cs](SyntaxAndDataTypes/abstractions/IUser.cs) - User interface abstraction
- [Operators.cs](SyntaxAndDataTypes/Operators/Operators.cs) - Operator demonstrations

### 2. ConditionalsAndControlFlow

**Concepts Covered:**

- If-else statements
- Nested conditionals
- Multi-condition logic
- Control flow patterns
- Boolean logic

**Key Files:**

- [Program.cs](ConditionalsAndControlFlow/Program.cs) - Conditional statements and control flow examples
- [Activities01.cs](ConditionalsAndControlFlow/Activities01.cs) - Practice activities

**Examples:**

- Age verification
- Grade calculation system
- Driver license validation

### 3. SimpleCalculator

**Description:** A console-based calculator that performs basic arithmetic operations.

**Features:**

- Addition, subtraction, multiplication, and division
- Input validation using `TryParse`
- User-friendly console interface

### 4. LeapYearChecker

**Description:** A program that determines if a given year is a leap year.

**Logic:**

- Divisible by 4 and 100, OR
- Not divisible by 400

**Features:**

- Input validation
- Clear user feedback
- Handles invalid input gracefully

### 5. NumberGuessingGame

**Description:** An interactive number guessing game where the player tries to guess a randomly generated number.

**Features:**

- Random number generation (1-100)
- User hints (too high/too low)
- Attempt counter
- Input validation
- Loop control (while loop)

## 🛠️ Technologies

- **Language:** C# 10.0
- **Framework:** .NET 10.0
- **IDE:** Visual Studio Code (recommended)

## 🚀 Getting Started

### Prerequisites

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) or higher

### Running a Project

1. Navigate to a specific project directory:

```bash
cd SyntaxAndDataTypes
```

2. Run the project:

```bash
dotnet run
```

### Building the Solution

To build all projects:

```bash
dotnet build CsharpMastery.sln
```

## 📂 Project Structure

```
CsharpMastery/
├── CsharpMastery.sln              # Solution file
├── SyntaxAndDataTypes/            # Basic C# syntax and data types
├── ConditionalsAndControlFlow/    # Conditionals and control structures
├── SimpleCalculator/              # Calculator application
├── LeapYearChecker/              # Leap year validation
└── NumberGuessingGame/           # Interactive guessing game
```

## 🎯 Learning Objectives

This repository demonstrates:

- **Fundamentals:** Variables, data types, and operators
- **Control Flow:** Conditionals, loops, and logical operators
- **Input/Output:** Console interaction and user input handling
- **Validation:** Error handling and input validation patterns
- **OOP:** Classes, interfaces, and abstractions
- **Problem Solving:** Practical applications of programming concepts

## 📝 Notes

- Each project is self-contained and can be run independently
- Projects follow C# naming conventions and best practices
- Code includes comments for clarity and learning purposes

## 🤝 Contributing

Feel free to fork this repository and add your own learning projects or improvements.

## 📄 License

This is a learning project. Feel free to use it for educational purposes.

---

**Happy Coding! 🚀**
