using System;

class Boat       //  https://judge.softuni.bg/Contests/Practice/Index/53#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - (n / 2); i++)
        {
            Console.WriteLine(
                new string('.', n - 1 - (2 * i)) + 
                new string('*', 1 + (2 * i)) + 
                new string('.', n));
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(
                new string('.', 2 + (2 * i)) + 
                new string('*', n - 2 - (2 * i)) + 
                new string('.', n));
        }
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine(
                new string('.', i) + 
                new string('*', (2 * n) - (2 * i)) + 
                new string('.', i));
        }
    }
}

