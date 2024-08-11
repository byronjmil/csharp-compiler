using System;

namespace CSharpCompiler;

public class Program
{
    public static void Main()
    {
        DateTime start = new(2024, 7, 12);
        DateTime end = new(2025, 7, 12);
        TimeSpan diff = end - start;
        int days = diff.Days;
        double goal = 0.05;
        double dailyInput = goal / days;
        double payStubInput = Math.Round(dailyInput * 14, 8);
        Console.WriteLine($"Daily = {dailyInput} BTC");
        Console.WriteLine($"PayStub = {payStubInput} BTC");
        Console.WriteLine($"PayStub = {Math.Round(payStubInput * 1000, 5)} mBTC");
    }
}