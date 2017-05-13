using System;

class PerfectDiamond    // https://judge.softuni.bg/Contests/Practice/Index/157#8
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int i = 1; i <= n - row; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int i = 1; i <= row - 1; i++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();
        }

        for (int row = 1; row <= n - 1; row++)
        {
            for (int i = 1; i <= row; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int i = 1; i <= n - (row + 1); i++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();
        }
    }
}

