using System;

class Nums    // https://judge.softuni.bg/Contests/Practice/Index/50#1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0:F3}", Math.Sqrt(i));
            }
            else
            {
                Console.WriteLine("{0:F3}", Math.Pow(i, 2));
            }
        }
    }
}

