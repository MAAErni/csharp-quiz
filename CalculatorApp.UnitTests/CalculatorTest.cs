using NUnit.Framework;

namespace CalculatorApp.UnitTests;

[TestFixture]
public class CalculatorTest
{
    private Calculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_Sum()
    {
        double num1 = 1;
        double num2 = 2;
        double expectedResult = 3;
        double result = _calculator.add(num1, num2);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Subtract_Difference()
    {
        double num1 = 10;
        double num2 = 7;
        double expectedResult = 3;
        double result = _calculator.subtract(num1, num2);
        Assert.That(result, Is.EqualTo(expectedResult));

    }

    [Test]
    public void Multiply_Product()
    {
        double num1 = 5;
        double num2 = 5;
        double expectedResult = 25;
        double result = _calculator.multiply(num1, num2);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Divide_Quotient()
    {
        double num1 = 6;
        double num2 = 2;
        double expectedResult = 3;
        double result = _calculator.divide(num1, num2);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Add_NegativeNumbers()
    {
        double num1 = -1;
        double num2 = -2;
        double expectedResult = -3;
        double result = _calculator.add(num1, num2);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Subtract_NegativeResult()
    {
        double num1 = 5;
        double num2 = 10;
        double expectedResult = -5;
        double result = _calculator.subtract(num1, num2);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Multiply_WithZero()
    {
        double num1 = 2;
        double num2 = 0;
        double expectedResult = 0;
        double result = _calculator.multiply(num1, num2);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Divide_FractionResult()
    {
        double num1 = 7;
        double num2 = 2;
        double expectedResult = 3.5;
        double result = _calculator.divide(num1, num2);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Divide_ZeroDivider()
    {
        double num1 = 6;
        double num2 = 0;
        Assert.Throws<DivideByZeroException>(() => _calculator.divide(num1, num2));
    }

    [Test]
    public void PerformOperation_InvalidOperation()
    {
        Assert.Throws<InvalidOperationException>(() => _calculator.PerformOperation(1, 1, "Invalid Operation"));
    }

    [Test]
    public void PerformOperation_InvalidInput()
    {
        Assert.Throws<FormatException>(() => _calculator.PerformOperation(double.Parse("Invalid Input"), 1, "add"));
    }
}