using System;

class Arrow    // https://judge.softuni.bg/Contests/Practice/Index/7#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    new string('.', (n - 1) / 2) + 
                    new string('#', n) + 
                    new string('.', (n - 1) / 2));
            }
            else
            {
                Console.WriteLine(
                    new string('.', (n - 1) / 2) + "#" + 
                    new string('.', n - 2) + "#" + 
                    new string('.', (n - 1) / 2));
            }
        }

        Console.WriteLine(
            new string('#', (n + 1) / 2) + 
            new string('.', n - 2) + 
            new string('#', (n + 1) / 2));

        for (int i = 0; i < n - 1; i++)
        {
            if (i == n - 2)
            {
                Console.WriteLine(
                    new string('.', n - 1) + "#" + 
                    new string('.', n - 1));
            }
            else
            {
                Console.WriteLine(
                    new string('.', 1 + i) + "#" + 
                    new string('.', (2 * n) - 5 - (2 * i)) + "#" + 
                    new string('.', 1 + i));
            }
        }
    }
}

