using System;

class Histogram       // https://judge.softuni.bg/Contests/Practice/Index/169#3 06.03.2016
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int num = 0;
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        int n4 = 0;
        int n5 = 0;

        for (int i = 0; i < n; i++)
        {
            num = int.Parse(Console.ReadLine());

            if (num < 200)
            {
                n1++;
            }
            else if ((num >= 200) && (num <= 399))
            {
                n2++;
            }
            else if ((num >= 400) && (num <= 599))
            {
                n3++;
            }
            else if ((num >= 600) && (num <= 799))
            {
                n4++;
            }
            else
            {
                n5++;
            }
        }

        double p1 = ((double)n1 / n) * 100;
        double p2 = ((double)n2 / n) * 100;
        double p3 = ((double)n3 / n) * 100;
        double p4 = ((double)n4 / n) * 100;
        double p5 = ((double)n5 / n) * 100;

        Console.WriteLine("{0:F2}%", p1);
        Console.WriteLine("{0:F2}%", p2);
        Console.WriteLine("{0:F2}%", p3);
        Console.WriteLine("{0:F2}%", p4);
        Console.WriteLine("{0:F2}%", p5);
    }
}

