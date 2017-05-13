using System;

class KingOfThieves    // https://judge.softuni.bg/Contests/Practice/Index/81#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char type = char.Parse(Console.ReadLine());

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine(
                new string('-', ((n - 1) / 2) - i) + 
                new string(type, 1 + (2 * i)) + 
                new string('-', ((n - 1) / 2) - i));
        }

        Console.WriteLine(new string(type, n));

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine(
                new string('-', 1 + i) + 
                new string(type, n - 2 - (2 * i)) + 
                new string('-', 1 + i));
        }
    }
}

