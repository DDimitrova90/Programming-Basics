using System;

class RadiansToDegrees
{
    static void Main()
    {
        double radians = double.Parse(Console.ReadLine());
        double degree = (radians * 180) / Math.PI;

        Console.WriteLine(Math.Round(degree));
    }
}

