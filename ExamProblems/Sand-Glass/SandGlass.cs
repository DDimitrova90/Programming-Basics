using System;

class SandGlass    // https://judge.softuni.bg/Contests/Practice/Index/1#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine(
                new string('.', i) + 
                new string('*', n - (2 * i)) + 
                new string('.', i));
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(
                new string('.', ((n - 3) / 2) - i) + 
                new string('*', 3 + (2 * i)) + 
                new string('.', ((n - 3) / 2) - i));
        }
    }
}

