using System;

class ImpressTheGirlfriend  // https://judge.softuni.bg/Contests/Practice/Index/138#0
{
    static void Main()
    {
        uint rubles = uint.Parse(Console.ReadLine());
        uint dollars = uint.Parse(Console.ReadLine());
        uint euro = uint.Parse(Console.ReadLine());
        uint levaB = uint.Parse(Console.ReadLine());
        uint levaM = uint.Parse(Console.ReadLine());

        decimal opt1 = rubles * 0.035M;
        decimal opt2 = dollars * 1.5M;
        decimal opt3 = euro * 1.95M;
        decimal opt4 = levaB / 2M;

        if (opt1 > opt2 && opt1 > opt3 && opt1 >opt4 && opt1 > levaM)
        {
            Console.WriteLine("{0:F2}", Math.Ceiling(opt1));
        }
        else if (opt2 > opt3 && opt2 > opt4 && opt2 > levaM)
        {
            Console.WriteLine("{0:F2}", Math.Ceiling(opt2));
        }
        else if (opt3 > opt4 && opt3 > levaM)
        {
            Console.WriteLine("{0:F2}", Math.Ceiling(opt3));
        }
        else if (opt4 > levaM)
        {
            Console.WriteLine("{0:F2}", Math.Ceiling(opt4));
        }
        else
        {
            Console.WriteLine("{0:F2}", Math.Ceiling((decimal)levaM));
        }
    }
}

