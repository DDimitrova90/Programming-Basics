using System;

class Summertime       // https://judge.softuni.bg/Contests/Practice/Index/100#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        Console.WriteLine(
            new string(' ', (n - 1) / 2) + 
            new string('*', n + 1));

        for (int i = 0; i < n - i; i++)
        {
            Console.WriteLine(
                new string(' ', (n - 1) / 2) + "*" + 
                new string(' ', n - 1) + "*");

            count++;
        }
        for (int i = 0; i < n - 1 - count; i++)
        {
            Console.WriteLine(
                new string(' ', ((n - 2) / 2) - i) + "*" + 
                new string(' ', n + 1 + 2 * i) + "*");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*" + new string('.', 2 * n - 2) + "*");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*" + new string('@', 2 * n - 2) + "*");
        }

        Console.WriteLine(new string('*', 2  * n));
    }
}

