using System;

class CheatSheet     // https://judge.softuni.bg/Contests/Practice/Index/53#1
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        long vertical = long.Parse(Console.ReadLine());
        long horizontal = long.Parse(Console.ReadLine());

        for (long i = vertical; i < vertical + rows; i++)
        {
            for (long j = horizontal; j < horizontal + columns; j++)
            {
                if (j == horizontal + columns - 1)
                {
                    Console.Write(i * j);
                }
                else
                {
                    Console.Write((i * j) + " ");
                }
            }

            Console.WriteLine();
        }
    }
}

