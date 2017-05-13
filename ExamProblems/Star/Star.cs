using System;

class Star      // https://judge.softuni.bg/Contests/Practice/Index/24#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    new string('.', n) + "*" + 
                    new string('.', n));
            }
            else
            {
                Console.WriteLine(
                    new string('.', n - i) + "*" + 
                    new string('.', (2 * i) - 1) + "*" + 
                    new string('.', n - i));
            }
        }

        for (int i = 0; i < n / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    new string('*', (n / 2) + 1) + 
                    new string('.', n - 1) + 
                    new string('*', (n / 2) + 1));
            }
            else
            {
                Console.WriteLine(
                    new string('.', i) + "*" + 
                    new string('.', (2 * n) - 3 - ((2 * i) - 2)) + "*" + 
                    new string('.', i));
            }
        }

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            if (i == n / 2)
            {
                Console.WriteLine(
                    new string('*', (n / 2) + 1) + 
                    new string('.', n - 1) + 
                    new string('*', (n / 2) + 1));
            }
            else if (i == 0)
            {
                Console.WriteLine(
                    new string('.', n / 2) + "*" + 
                    new string('.', (n / 2) - 1) + "*" + 
                    new string('.', (n / 2) - 1) + "*" + 
                    new string('.', n / 2));
            }
            else
            {
                Console.WriteLine(
                    new string('.', (n / 2) - i) + "*" + 
                    new string('.', (n / 2) - 1) + "*" + 
                    new string('.', (2 * i) - 1) + "*" + 
                    new string('.', (n / 2) - 1) + "*" + 
                    new string('.', (n / 2) - i));
            }
        }
    }
}

