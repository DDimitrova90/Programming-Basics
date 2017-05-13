using System;

class AceOfDiamonds   // https://judge.softuni.bg/Contests/Practice/Index/138#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n));

        for (int i = 0; i < (n - 3) / 2; i++)
        {
            Console.WriteLine(
                "*" + 
                new string('-', ((n - 3) / 2) - i) + 
                new string('@', 2 * i + 1) + 
                new string('-', ((n - 3) / 2) - i) + 
                "*");
        }

        Console.WriteLine("*" + new string('@', n - 2) + "*");

        for (int i = 0; i < (n - 3) / 2; i++)
        {
            Console.WriteLine(
                "*" + 
                new string('-', i + 1) + 
                new string('@', n - 4 - (2 * i)) + 
                new string('-', i + 1) + 
                "*");
        }

        Console.WriteLine(new string('*', n));
    }
}

