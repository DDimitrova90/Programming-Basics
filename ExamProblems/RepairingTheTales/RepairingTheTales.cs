using System;

class RepairingTheTales   // 24.04.2016 https://judge.softuni.bg/Contests/Practice/Index/181#0
{
    static void Main()
    {
        double sideOfSquare = double.Parse(Console.ReadLine());
        double taleWidth = double.Parse(Console.ReadLine());
        double taleHeight = double.Parse(Console.ReadLine());
        double benchWidth = double.Parse(Console.ReadLine());
        double benchHeight = double.Parse(Console.ReadLine());

        double squareArea = sideOfSquare * sideOfSquare;
        double taleArea = taleWidth * taleHeight;
        double benchArea = benchWidth * benchHeight;
        double areaToRepair = squareArea - benchArea;
        double neededTales = areaToRepair / taleArea;
        double neededTime = neededTales * 0.2;
        Console.WriteLine(neededTales);
        Console.WriteLine(neededTime);
    }
}

