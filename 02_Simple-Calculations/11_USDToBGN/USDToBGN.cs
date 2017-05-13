using System;

class USDToBGN
{
    static void Main()
    {
        double usd = double.Parse(Console.ReadLine());
        double bgn = usd * 1.79549;

        Console.WriteLine("{0} BGN", Math.Round(bgn, 2));
    }
}

