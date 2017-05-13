using System;

class RockLq      // https://judge.softuni.bg/Contests/Practice/Index/36#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < ((n - 1) / 2) + 1; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    new string('.', n - (2 * i)) + 
                    "*" + 
                    new string('*', n - 2 + (4 * i)) + 
                    "*" + 
                    new string('.', n - (2 * i)));
            }
            else
            {
                Console.WriteLine(
                    new string('.', n - (2 * i)) + 
                    "*" + 
                    new string('.', n - 2 + (4 * i)) + 
                    "*" + 
                    new string('.', n - (2 * i)));
            }
        }

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    "*" + 
                    new string('.', n - 2) + 
                    "*" + 
                    new string('.', n) + 
                    "*" + 
                    new string('.', n - 2) + "*");
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
                new string('.', n - 1 -i) + 
                "*" + 
                new string('.', n + (2 * i)) + 
                "*" + 
                new string('.', n - 1 - i));
        }

        Console.WriteLine(new string('*', 3 * n));
    }
}

