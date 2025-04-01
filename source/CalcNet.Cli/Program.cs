using CalcNet.Cli.Utils;

namespace CalcNet.Cli;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Calculator.Add(12, 11));
        Console.WriteLine(Calculator.Subtract(11, 21));
        Console.WriteLine(Calculator.Multiply(11, 51));
        Console.WriteLine(Calculator.Divide(10, 5));
        Console.WriteLine(Calculator.Power(21, 3));
        Console.WriteLine(Calculator.SquareRoot(10));
        Console.WriteLine(Calculator.Percentage(100, 10));
        Console.WriteLine(Calculator.Add(13, 11));
        Console.WriteLine(Calculator.Add(15, 41));
    }
}