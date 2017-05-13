using System;

class FallenInLove
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string dot = new string('.', 2 * n);
        Console.WriteLine("##" + dot + "##" + dot + "##");

        for (int i = 1; i <= n - 1; i++)
        {
            Console.WriteLine("#" + 
                new string('~', i) + "#" +
                new string('.', (2 * n - 2 * i)) + "#" + 
                new string('.', 2 * i) + "#" +
                new string('.', (2 * n - 2 * i)) + "#" +
                new string('~', i) + "#");
        }
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                new string('.', 1 + 2 * i) + "#" + 
                new string('~', n - i) + "#" +
                new string('.', (2 * n - 2 * i)) + "#" +
                new string('~', n - i) + "#" +
                new string('.', 1 + 2 * i));
        }

        Console.WriteLine(
            new string('.', (2 * n + 1)) + 
            new string('#', 4) + 
            new string('.', (2 * n + 1)));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                new string('.', (2 * n + 2)) + "##" + 
                new string('.', (2 * n + 2)));
        }                   
    }
}

