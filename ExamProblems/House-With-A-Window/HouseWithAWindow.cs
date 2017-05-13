using System;

class HouseWithAWindow    // https://judge.softuni.bg/Contests/Practice/Index/18#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    new string('.', n - 1 - i) + "*" + 
                    new string('.', n - 1 - i));
            }
            else
            {
                Console.WriteLine(
                    new string('.', n - 1 - i) + "*" + 
                    new string('.', (2 * i) - 1) + "*" + 
                    new string('.', n - 1 - i));
            }
        }

        Console.WriteLine(new string('*', (2 * n) - 1));

        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*" + new string('.', (2 * n) - 3) + "*");
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(
                "*" + 
                new string('.', n / 2) + 
                new string('*', n - 3) + 
                new string('.', n / 2) + 
                "*");
        }

        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*" + new string('.', (2 * n) - 3) + "*");
        }

        Console.WriteLine(new string('*', (2 * n) - 1));
    }
}
