using System;

class TeleportPoints  // https://judge.softuni.bg/Contests/Practice/Index/104#3
{                     
    static void Main()
    {
        string pointA = Console.ReadLine();
        string pointB = Console.ReadLine();
        string pointC = Console.ReadLine();
        string pointD = Console.ReadLine();
        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        string[] coordinates1 = pointA.Split();
        double xA = double.Parse(coordinates1[0]);
        double yA = double.Parse(coordinates1[1]);
        string[] coordinates2 = pointB.Split();
        double xB = double.Parse(coordinates2[0]);
        double yB = double.Parse(coordinates2[1]);
        string[] coordinates3 = pointC.Split();
        double xC = double.Parse(coordinates3[0]);
        double yC = double.Parse(coordinates3[1]);
        string[] coordinates4 = pointD.Split();
        double xD = double.Parse(coordinates4[0]);
        double yD = double.Parse(coordinates4[1]);

        int pointCounter = 0;

        for (double x = 0; x <= radius; x += step)
        {
            for (double y = 0; y <= radius; y += step)
            {
                if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(radius, 2))
                {
                    if (x > xA && x < xB && y > yB && y < yC)
                    {
                        pointCounter++;
                    }
                }                
            }

            for (double y = - step; y >= - radius; y -= step)
            {
                if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(radius, 2))
                {
                    if (x > xA && x < xB && y > yB && y < yC)
                    {
                        pointCounter++;
                    }
                }
            }
        }

        for (double x = - step; x >= - radius; x -= step)
        {
            for (double y = 0; y <= radius; y += step)
            {
                if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(radius, 2))
                {
                    if (x > xA && x < xB && y > yB && y < yC)
                    {
                        pointCounter++;
                    }
                }
            }

            for (double y = - step; y >= - radius; y -= step)
            {
                if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(radius, 2))
                {
                    if (x > xA && x < xB && y > yB && y < yC)
                    {
                        pointCounter++;
                    }
                }
            }
        }

        Console.WriteLine(pointCounter);
    }
}

