﻿using System;

class SquareFrame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i == 0 || i == n - 1) && (j == 0 || j == n - 1))
                {
                    Console.Write("+ ");
                }
                else if (i > 0 && i < n - 1 && (j == 0 || j == n - 1))
                {
                    Console.Write("| ");
                }
                else
                {
                    Console.Write("- ");
                }
            }

            Console.WriteLine();
        }
    }
}

