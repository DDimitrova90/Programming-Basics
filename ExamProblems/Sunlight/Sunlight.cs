using System;

class Sunlight     // https://judge.softuni.bg/Contests/Practice/Index/82#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(
            new string('.', ((3 * n) - 1) / 2) + 
            "*" + 
            new string('.', ((3 * n) - 1) / 2));

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(
                new string('.', i + 1) + 
                "*" + 
                new string('.', (((3 * n) - 5) / 2) - i) + 
                "*" + 
                new string('.', (((3 * n) - 5) / 2) - i) + 
                "*" + 
                new string('.', i + 1));
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(
                new string('.', n) + 
                new string('*', n) + 
                new string('.', n));
        }

        Console.WriteLine(new string('*', 3 * n));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(
                new string('.', n) + 
                new string('*', n) + 
                new string('.', n));
        }

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(
                new string('.', n - 1 - i) + 
                "*" + 
                new string('.', (n / 2) + i) + 
                "*" + 
                new string('.', (n / 2) + i) + 
                "*" + 
                new string('.', n - 1 - i));
        }

        Console.WriteLine(
            new string('.', ((3 * n) - 1) / 2) + 
            "*" + 
            new string('.', ((3 * n) - 1) / 2));
    }
}

