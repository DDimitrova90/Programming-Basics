using System;

class House      // https://judge.softuni.bg/Contests/Practice/Index/6#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    new string('.', (n - 1) / 2) + "*" + 
                    new string('.', (n - 1) / 2));
            }
            else
            {
                Console.WriteLine(
                    new string('.', ((n - 1) / 2) - i) + "*" + 
                    new string('.', (2 * i) - 1) + "*" + 
                    new string('.', ((n - 1) / 2) - i));
            }
        }

        Console.WriteLine(new string('*', n));

        int dist = n / 4;

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            if (i == (n - 3) / 2)
            {
                Console.WriteLine(
                    new string('.', dist) + 
                    new string('*', n - (2 * dist)) + 
                    new string('.', dist));
            }
            else
            {
                Console.WriteLine(
                    new string('.', dist) + "*" + 
                    new string('.', n - (2 * dist) - 2) + "*" + 
                    new string('.', dist));
            }
        }
    }
}

