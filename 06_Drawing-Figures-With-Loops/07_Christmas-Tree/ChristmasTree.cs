using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string(' ', n + 1) + "|");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                new string(' ', n - 1 - i) + 
                new string('*', i + 1) + " | " + 
                new string('*', i + 1));
        }
    }
}

