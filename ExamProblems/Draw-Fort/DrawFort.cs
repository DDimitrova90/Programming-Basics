using System;

class DrawFort
{
    static void Main()      // https://judge.softuni.bg/Contests/Practice/Index/169#4  06.03.2016
    {
        int n = int.Parse(Console.ReadLine());

        int colSize = n / 2;
        int midSize = 2 * n - ((2 * colSize) + 4);

        Console.WriteLine("/{0}\\{1}/{0}\\", 
            new string('^', colSize), 
            new string('_', midSize));

        for (int i = 0; i < n - 2; i++)
        {
            if ((n >= 5) && (i == n - 3))
            {
                Console.WriteLine("|{0}{1}{0}|",
                    new string(' ', colSize + 1), 
                    new string('_', midSize));
            }
            else
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            }
        }

        Console.WriteLine("\\{0}/{1}\\{0}/", 
            new string('_', colSize), 
            new string(' ', midSize));
    }
}

