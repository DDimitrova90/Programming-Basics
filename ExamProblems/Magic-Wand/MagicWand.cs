using System;

class MagicWand     // https://judge.softuni.bg/Contests/Practice/Index/79#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(
            new string('.', ((3 * n) + 1) / 2) + 
            "*" + 
            new string('.', ((3 * n) + 1) / 2));

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine(
                new string('.', (((3 * n) - 1) / 2) - i) + 
                "*" + 
                new string('.', 1 + (2 * i)) + 
                "*" + 
                new string('.', (((3 * n) - 1) / 2) - i));
        }

        Console.WriteLine(
            new string('*', n) + 
            new string('.', n + 2) + 
            new string('*', n));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(
                new string('.', i + 1) + 
                "*" + 
                new string('.', (3 * n) - 2 - (2 * i)) + 
                "*" + 
                new string('.', i + 1));
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(
                new string('.', (n / 2) - 1 - i) + 
                "*" + 
                new string('.', n / 2) + 
                "*" + 
                new string('.', i) + 
                "*" + 
                new string('.', n) + 
                "*" + 
                new string('.', i) + 
                "*" + 
                new string('.', n / 2) + 
                "*" + 
                new string('.', (n / 2) - 1 - i));
        }

        Console.WriteLine(
            new string('*', n - (n / 2)) + 
            new string('.', n / 2) + 
            "*" + 
            new string('.', n) + 
            "*" + 
            new string('.', n / 2) + 
            new string('*', n - (n / 2)));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                new string('.', n) + 
                "*" + 
                new string('.', n) + 
                "*" + 
                new string('.', n));
        }

        Console.WriteLine(
            new string('.', n) + 
            new string('*', n + 2) + 
            new string('.', n));
    }
}

