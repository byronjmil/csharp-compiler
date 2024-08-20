using System;

class Program
{
    static void Main()
    {
        double legacy = 68621.93;
        double liquid = 0;
        double assets = legacy + liquid;
        // Create a DateTime variable
        DateTime start = new(2024, 6, 28);

        // Add 14 days to the original DateTime
        DateTime end = start.AddDays(14 * 26);

        Console.WriteLine($"End Date: {end}");

        DateTime today = DateTime.Today;

        TimeSpan difference = end - today;

        int stmts = difference.Days / 14;

        Console.WriteLine($"Statments left: {stmts}");

        double interestToInv = 1 + (.07 * stmts / 26);

        Console.WriteLine($"Interest left on assets: {Math.Round(interestToInv, 8)}");

        double inv = Math.Round(assets * interestToInv, 2);

        Console.WriteLine($"Assets: ${assets.ToString("N2")}");

        double remainder = Math.Round((
            Math.Pow(10, 5) - (inv + (613.69 * stmts))
        ), 2);

        double sideInvestment = remainder / stmts;

        Console.WriteLine($"Remaining Inv per Statement ${sideInvestment.ToString("N2")}");
    }
}
