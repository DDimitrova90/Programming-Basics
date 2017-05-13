using System;

class ChristmasTree   // https://judge.softuni.bg/Contests/Practice/Index/102#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine(
                new string('\'', n - i) + 
                new string('^', 1 + 2 * i) + 
                new string('\'', n - i));
        }
        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine(
                new string('\'', n - i - 1) + 
                new string('^', 3 + 2 * i) + 
                new string('\'', n - i - 1));
        }
        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine(
                new string('\'', n - 1) + "| |" + 
                new string('\'', n - 1));
        }

        Console.WriteLine(new string('-', (2 * n) + 1));
    }
}

