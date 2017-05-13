using System;

class Disk       // https://judge.softuni.bg/Contests/Practice/Index/10#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int centerRow = n / 2;
        int centerCol = n / 2;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int distanceX = col - centerCol;
                int distanceY = row - centerRow;
                double distanceToCenter = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
                bool isInCirle = distanceToCenter <= r;

                if (isInCirle)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}

