# calculator

This project is a simple C# console application that acts as a basic calculator.

## How it works

When the program starts, it displays a menu with these options:

1. Add
2. Subtract
3. Multiply
4. Divide
5. Exit

The user is prompted to enter a choice, then two numbers. The program performs the selected operation and prints the result.

## Operations

- Add: adds two integers
- Subtract: subtracts the second integer from the first
- Multiply: multiplies two integers
- Divide: divides the first integer by the second

## Error handling

- If the user selects an invalid menu option, the program prints "Invalid choice."
- If the user tries to divide by zero, the program catches the exception and prints "Cannot divide by zero."

## Example

The program runs in the terminal and looks like this:

```text
Simple Calculator
1) Add
2) Subtract
3) Multiply
4) Divide
5) Exit
Enter your choice:
Enter first number:
Enter second number:
Result: 42
```

This is a beginner-friendly calculator app that demonstrates console input/output, switch statements, methods, and exception handling in C#.
