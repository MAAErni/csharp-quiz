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
        double result = _calculator.add(1, 2);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Subtract_Difference()
    {
        double result = _calculator.subtract(10, 7);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Multiply_Product()
    {
        double result = _calculator.multiply(5, 5);
        Assert.AreEqual(25, result);
    }

    [Test]
    public void Divide_Quotient()
    {
        double result = _calculator.divide(6, 2);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Add_NegativeNumbers()
    {
        double result = _calculator.add(-1, -2);
        Assert.AreEqual(-3, result);
    }

    [Test]
    public void Subtract_NegativeResult()
    {
        double result = _calculator.subtract(5, 10);
        Assert.AreEqual(-5, result);
    }

    [Test]
    public void Multiply_WithZero()
    {
        double result = _calculator.multiply(2, 0);
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Divide_FractionResult()
    {
        double result = _calculator.divide(7, 2);
        Assert.AreEqual(3.5, result);
    }

    [Test]
    public void Divide_ZeroDivider()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.divide(6, 0));
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