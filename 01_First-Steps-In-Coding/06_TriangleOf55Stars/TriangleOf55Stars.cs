using System;

class TriangleOf55Stars
{
    static void Main()
    {
        for (int row = 1; row <= 10; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

