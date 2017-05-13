using System;

class ConsoleGraphics     // https://judge.softuni.bg/Contests/Practice/Index/50#6
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string asteriks = new string('*', 2 * n);
        string waves = new string('~', 2 * n);

        Console.WriteLine(asteriks);
        Console.WriteLine(asteriks);

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(
                new string('*', (n + 1) / 2) + 
                new string(' ', n - 1) + 
                new string('*', (n + 1) / 2));
        }

        Console.WriteLine(waves);
        Console.WriteLine(waves);
    }
}

