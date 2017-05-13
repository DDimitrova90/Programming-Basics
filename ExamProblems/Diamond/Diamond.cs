using System;

class Diamond    // https://judge.softuni.bg/Contests/Practice/Index/233#4
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(
            new string('.', n) + 
            new string('*', 3 * n) + 
            new string('.', n));

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(
                new string('.', n - 1 - i) +
                "*" + 
                new string('.', (3 * n) + (2 * i)) + 
                "*" + 
                new string('.', n - 1 - i));
        }

        Console.WriteLine(new string('*', 5 * n));

        for (int i = 0; i < 2 * n; i++)
        {
            Console.WriteLine(
                new string('.', i + 1) + 
                "*" + 
                new string('.', (5 * n) - 4 - (2 * i)) + 
                "*" + 
                new string('.', i + 1));
        }

        Console.WriteLine(
            new string('.', (2 * n) + 1) + 
            new string('*', n - 2) + 
            new string('.', (2 * n) + 1));
    }
}

