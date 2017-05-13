using System;

class IlluminatiLock    // https://judge.softuni.bg/Contests/Practice/Index/149#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(
            new string('.', n) + 
            new string('#', n) + 
            new string('.', n));

        Console.WriteLine(
            new string('.', n - 2) + "###" + 
            new string('.', n - 2) + "###" + 
            new string('.', n - 2));

        for (int i = 0; i < (n - 3) / 2; i++)
        {
            Console.WriteLine(
                new string('.', n - 4 - (2 * i)) + "##" + 
                new string('.', 2 + (2 * i)) + "#" + 
                new string('.', n - 2) + "#" + 
                new string('.', 2 + (2 * i)) + "##" + 
                new string('.', n - 4 - (2 * i)));
        }

        for (int i = 0; i < (n - 3) / 2; i++)
        {
            Console.WriteLine(
                new string('.', (2 * i) + 1) + "##" + 
                new string('.', n - 3 - (2 * i)) + "#" + 
                new string('.', n - 2) + "#" + 
                new string('.', n - 3 - (2 * i)) + "##" + 
                new string('.', (2 * i) + 1));
        }

        Console.WriteLine(
            new string('.', n - 2) + "###" + 
            new string('.', n - 2) + "###" + 
            new string('.', n - 2));
        Console.WriteLine(
            new string('.', n) + 
            new string('#', n) + 
            new string('.', n));
    }
}

