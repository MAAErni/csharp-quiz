using System.ComponentModel;
using Microsoft.Extensions.Logging;

namespace CalculatorApp;

public class Calculator
{
    private static readonly ILogger _logger = LoggerProvider.CreateLogger<Program>();

    public double PerformOperation(double num1, double num2, string operation)
    {
        double result;

        switch (operation)
        {
            case "add":
                result = add(num1, num2);
                break;
            case "subtract":
                result = subtract(num1, num2);
                break;
            case "multiply":
                result = multiply(num1, num2);
                break;
            case "divide":
                result = divide(num1, num2);
                break;
            default:
                _logger.LogError($"Unsopported Operation: {operation}");
                throw new InvalidOperationException("Operation is not supported.");
        }

        return result;
    }


    public double add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            _logger.LogError("Attempted to divide by zero.");
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
}