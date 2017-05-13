using System;

class Dumbbell    // https://judge.softuni.bg/Contests/Practice/Index/78#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(
            new string('.', n / 2) + 
            new string('&', n - (n / 2)) + 
            new string('.', n) + 
            new string('&', n - (n / 2)) + 
            new string('.', n / 2));

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine(
                new string('.', (n / 2) - 1 - i) + 
                "&" + 
                new string('*', (n / 2) + i) + 
                "&" + 
                new string('.', n) + 
                "&" + 
                new string('*', (n / 2) + i) + 
                "&" + 
                new string('.', (n / 2) - 1 - i));
        }

        Console.WriteLine(
            "&" + 
            new string('*', n - 2) + 
            "&" + 
            new string('=', n) + 
            "&" + 
            new string('*', n - 2) + 
            "&");

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine(
                new string('.', i + 1) + 
                "&" + 
                new string('*', n - 3 - i) + 
                "&" + 
                new string('.', n) + 
                "&" + 
                new string('*', n - 3 - i) + 
                "&" + 
                new string('.', i + 1));
        }

        Console.WriteLine(
            new string('.', n / 2) + 
            new string('&', n - (n / 2)) + 
            new string('.', n) + 
            new string('&', n - (n / 2)) + 
            new string('.', n / 2));
    }
}

