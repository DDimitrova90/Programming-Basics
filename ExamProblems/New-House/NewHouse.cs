using System;

class NewHouse    // https://judge.softuni.bg/Contests/Practice/Index/5#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine(
                new string('-', ((n - 1) / 2) - i) + 
                new string('*', 1 + (2 * i)) + 
                new string('-', ((n - 1) / 2) - i));
        }

        Console.WriteLine(new string('*', n));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|" + new string('*', n - 2) + "|");
        }
    }
}

