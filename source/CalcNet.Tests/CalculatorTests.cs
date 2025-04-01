using CalcNet.Cli.Utils;

namespace CalcNet.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(2.5, 3.7, 6.2)]
    public void Add_ReturnsCorrectResult(double a, double b, double expected)
    {
        var result = Calculator.Add(a, b);
        Assert.Equal(expected, result, precision: 10);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(10, -2, 12)]
    [InlineData(0, 0, 0)]
    [InlineData(5.5, 2.3, 3.2)]
    public void Subtract_ReturnsCorrectResult(double a, double b, double expected)
    {
        var result = Calculator.Subtract(a, b);
        Assert.Equal(expected, result, precision: 10);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(0, 5, 0)]
    [InlineData(2.5, 4, 10)]
    public void Multiply_ReturnsCorrectResult(double a, double b, double expected)
    {
        var result = Calculator.Multiply(a, b);
        Assert.Equal(expected, result, precision: 10);
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(10, 2, 5)]
    [InlineData(5, 2, 2.5)]
    [InlineData(-10, 2, -5)]
    public void Divide_ReturnsCorrectResult(double a, double b, double expected)
    {
        var result = Calculator.Divide(a, b);
        Assert.Equal(expected, result, precision: 10);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(5, 0));
    }

    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(3, 0, 1)]
    [InlineData(4, -1, 0.25)]
    [InlineData(2.5, 2, 6.25)]
    public void Power_ReturnsCorrectResult(double baseNumber, double exponent, double expected)
    {
        var result = Calculator.Power(baseNumber, exponent);
        Assert.Equal(expected, result, precision: 10);
    }

    [Theory]
    [InlineData(4, 2)]
    [InlineData(9, 3)]
    [InlineData(2.25, 1.5)]
    public void SquareRoot_ReturnsCorrectResult(double number, double expected)
    {
        var result = Calculator.SquareRoot(number);
        Assert.Equal(expected, result, precision: 10);
    }

    [Fact]
    public void SquareRoot_NegativeNumber_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Calculator.SquareRoot(-1));
    }

    [Theory]
    [InlineData(100, 10, 10)]
    [InlineData(200, 50, 100)]
    [InlineData(80, 25, 20)]
    [InlineData(150, 33.33, 49.995)]
    public void Percentage_ReturnsCorrectResult(double number, double percent, double expected)
    {
        var result = Calculator.Percentage(number, percent);
        Assert.Equal(expected, result, precision: 5);
    }
}