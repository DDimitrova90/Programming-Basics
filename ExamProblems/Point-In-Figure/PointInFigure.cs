using System;

class PointInFigure    // https://judge.softuni.bg/Contests/Practice/Index/157#3
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (y > 3 || 
            (y <= 3 && y > 1 && x < 4) ||
            (y <= 1 && y >= -3 && x < 2) ||
            (y < -3 && y >= -5 && x < 4) || 
            y < -5 || 
            (y >= -5 && y < -3 && x > 10) || 
            (y >= -3 && y <= 1 && x > 12) || 
            (y > 1 && y <= 3 && x > 10))
        {
            Console.WriteLine("out");
        }
        else
        {
            Console.WriteLine("in");
        }
    }
}

