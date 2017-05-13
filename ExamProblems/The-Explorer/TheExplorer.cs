using System;

class TheExplorer     // https://judge.softuni.bg/Contests/Practice/Index/4#2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(
            new string('-', (n - 1) / 2) + "*" + 
            new string('-', (n - 1) / 2));

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine(
                new string('-', (n / 2) - 1 - i) + "*" + 
                new string('-', 1 + (2 * i)) + "*" + 
                new string('-', (n / 2) - 1 - i));
        }
        
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine(
                new string('-', 1 + i) + "*" + 
                new string('-', n - 4 - (2 * i)) + "*" + 
                new string('-', 1 + i));
        } 

        Console.WriteLine(
            new string('-', (n - 1) / 2) + "*" + 
            new string('-', (n - 1) / 2));
    }
}

