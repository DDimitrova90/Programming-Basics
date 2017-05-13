using System;

class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());   // continue - sends to the beginning of the loop
        int count = 1;                           // break - ends the loop
                                                 // return - ends all loops
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j ++)
            {
                Console.Write(count + " ");
                count++;
                if (count > n)
                {
                    return;
                }
            }

            Console.WriteLine();
        }
    }
}

