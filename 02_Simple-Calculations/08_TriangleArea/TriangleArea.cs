using System;

class TriangleArea
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = (sideA * height) / 2;

        Console.WriteLine("Triangle area = " + Math.Round(area, 2));
    }
}

