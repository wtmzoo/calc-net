using CalcNet.Cli.Utils;

namespace CalcNet.Cli;

public static class Program
{
    public static void Main(string[] args)
    {
        var calcObj = new Calculator();
        
        Console.WriteLine(calcObj.Add(12, 11));
        Console.WriteLine(calcObj.Subtract(11, 21));
        Console.WriteLine(calcObj.Multiply(11, 51));
        Console.WriteLine(calcObj.Divide(10, 5));
        Console.WriteLine(calcObj.Power(21, 3));
        Console.WriteLine(calcObj.SquareRoot(10));
        Console.WriteLine(calcObj.Percentage(100, 10));
    }
}