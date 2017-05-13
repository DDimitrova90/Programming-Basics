using System;

class TriangleArea   // https://judge.softuni.bg/Contests/Practice/Index/157#0
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        int sideA = Math.Abs(x2 - x3);
        int height = Math.Abs(y2 - y1);
        double area = (sideA * (double)height) / 2;

        Console.WriteLine(area); 
    }
}

