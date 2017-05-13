using System;
using System.Linq;

class RhombusOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                new string(' ', n - 1 - i) + 
                "*" + 
                string.Concat(Enumerable.Repeat(" *", i)));
        }

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(
                new string(' ', 1 + i) + 
                "*" + 
                string.Concat(Enumerable.Repeat(" *", n - 2 - i)));
        }
    }
}