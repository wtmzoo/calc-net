namespace CalcNet.Cli.Utils;

public class Calculator
{
    public double Add(double a, double b) => a + b;

    public double Subtract(double a, double b) => a - b;

    public double Multiply(double a, double b) => a * b;
    
    public double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();
    
    public double Power(double baseNumber, double exponent) => Math.Pow(baseNumber, exponent);
    
    public double SquareRoot(double number) => number < 0 ? throw new ArgumentException("Нельзя извлечь корень из отрицательного числа") : Math.Sqrt(number);

    public double Percentage(double number, double percent) => (number * percent) / 100;
}