using System;

class Plane     // https://judge.softuni.bg/Contests/Practice/Index/37#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(
            new string('.', ((3 * n) - 1) / 2) + 
            "*" + 
            new string('.', ((3 * n) - 1) / 2));

        for (int i = 0; i < (n + 3) / 2; i++)
        {
            Console.WriteLine(
                new string('.', (((3 * n) - 3) / 2) - i) + 
                "*" + 
                new string('.', 1 + (2 * i)) + 
                "*" + 
                new string('.', (((3 * n) - 3) / 2) - i));
        }

        for (int i = 0; i < ((n - 1) / 2) - 1; i++)
        {
            Console.WriteLine(
                new string('.', n - 4 - (2 * i)) + 
                "*" + 
                new string('.', n + 6 + (4 * i)) + 
                "*" + 
                new string('.', n - 4 - (2 * i)));
        }

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    "*" + 
                    new string('.', n - 2 - (2 * i)) + 
                    "*" + 
                    new string('.', n) + 
                    "*" + 
                    new string('.', n - 2 - (2 * i)) + 
                    "*");
            }
            else
            {
                Console.WriteLine(
                    "*" + 
                    new string('.', n - 2 - (2 * i)) + 
                    "*" + 
                    new string('.', (2 * i) - 1) + 
                    "*" + 
                    new string('.', n) + 
                    "*" + 
                    new string('.', (2 * i) - 1) + 
                    "*" + 
                    new string('.', n - 2 - (2 * i)) + 
                    "*");
            }
        }

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(
                new string('.', n - 1 - i) + 
                "*" + 
                new string('.', n + (2 * i)) + 
                "*" + 
                new string('.', n - 1 - i));
        }

        Console.WriteLine(new string('*', 3 * n));
    }
}

