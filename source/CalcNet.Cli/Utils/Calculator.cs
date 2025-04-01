namespace CalcNet.Cli.Utils;

public static class Calculator
{
    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;
    
    public static double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();
    
    public static double Power(double baseNumber, double exponent) => Math.Pow(baseNumber, exponent);
    
    public static double SquareRoot(double number) => number < 0 ? throw new ArgumentException("Нельзя извлечь корень из отрицательного числа") : Math.Sqrt(number);

    public static double Percentage(double number, double percent) => (number * percent) / 100;
}