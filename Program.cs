using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result = 0;
        char operation;

        Console.WriteLine("Simple Calculator");

        // Input first number
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Input operator
        Console.Write("Enter an operator (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        // Input second number
        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Perform the chosen operation
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                return;
        }

        // Display result
        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
    }
}
