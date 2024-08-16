using System;
using Microsoft.Extensions.Logging;

namespace CalculatorApp;

class Program
{
    private static readonly ILogger _logger = LoggerProvider.CreateLogger<Program>();
    static void Main(string[] args)
    {
        try
        {
            _logger.LogInformation("Calculator Started");

            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

            var calculator = new Calculator();
            double result = calculator.PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
        }
        catch (FormatException)
        {
            _logger.LogError("Invalid input. Please enter numeric values.");
        }
        catch (DivideByZeroException ex)
        {
            _logger.LogError(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            _logger.LogError(ex.Message);
        }
        finally
        {
            _logger.LogInformation("Calculation attempt finished.");
        }
    }
}