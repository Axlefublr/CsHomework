using NUnit.Framework;
using Practice;

namespace Practice.Tests;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_MustReturnCorrectValue()
    {
        Calculator calculator = new();
        Assert.Equals(calculator.Add(1, -3), -2);
    }

    [Test]
    public void Subtract_MustReturnCorrectValue()
    {
        Calculator calculator = new();
        Assert.Equals(calculator.Subtract(-3, -5), 2);
    }

    [Test]
    public void Multiply_MustReturnCorrectValue() {
        Calculator calculator = new();
        Assert.Equals(calculator.Multiply(3, 5), 15);
    }

    [Test]
    public void Divide_MustThrowDivideByZeroException() {
        Calculator calculator = new();
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
    }

    [Test]
    public void Divide_MustReturnCorrectValue() {
        Calculator calculator = new();
        Assert.Equals(calculator.Divide(5, 1), 1);
    }

}
