using System;

class Car      // https://judge.softuni.bg/Contests/Practice/Index/23#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    new string('.', n - i) + "*" + 
                    new string('*', n - 2 + (2 * i)) + "*" + 
                    new string('.', n - i));
            }
            else
            {
                Console.WriteLine(
                    new string('.', n - i) + "*" + 
                    new string('.', n - 2 + (2 * i)) + "*" + 
                    new string('.', n - i));
            }     
        }

        for (int i = 0; i < n / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(
                    new string('*', (n / 2) + 1) + 
                    new string('.', (2 * n) - 2) + 
                    new string('*', (n / 2) + 1));
            }
            else if (i == (n / 2) - 1)
            {
                Console.WriteLine(new string('*', 3 * n));
            }
            else
            {
                Console.WriteLine("*" + new string('.', (3 * n) - 2) + "*");
            }
        }

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            if (i == (n / 2) - 2)
            {
                Console.WriteLine(
                    new string('.', n / 2) + "*" + 
                    new string('*', (n / 2) - 1) + "*" + 
                    new string('.', n - 2) + "*" + 
                    new string('*', (n / 2) - 1) + "*" + 
                    new string('.', n / 2));
            }
            else
            {
                Console.WriteLine(
                    new string('.', n / 2) + "*" + 
                    new string('.', (n / 2) - 1) + "*" + 
                    new string('.', n - 2) + "*" + 
                    new string('.', (n / 2) - 1) + "*" + 
                    new string('.', n / 2));
            }
        }
    }
}

