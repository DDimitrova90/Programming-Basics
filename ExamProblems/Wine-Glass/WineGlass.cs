using System;

class WineGlass     // https://judge.softuni.bg/Contests/Practice/Index/8#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(
                new string('.', i) + "\\" + 
                new string('*', n - 2 - (2 * i)) + "/" + 
                new string('.', i));
        }

        int j = (n / 2) - 1;

        if (n >= 12)
        {
            j = (n / 2) - 2;
        }

        for (int i = 0; i < j; i++)
        {
            Console.WriteLine(
                new string('.', (n / 2) - 1) + "||" + 
                new string('.', (n / 2) - 1));
        }

        for (int i = 0; i < (n / 2) - j; i++)
        {
            Console.WriteLine(new string('-', n));
        }
    }
}

