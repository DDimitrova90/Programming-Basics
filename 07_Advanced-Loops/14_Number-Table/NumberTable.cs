using System;

class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); 
          
        // other way:
        // int p = 1;

        for (int row = 0; row < n; row++)
        {
            // p = 1;
            for (int col = 0; col < n; col++)
            {
                int count = row + col + 1;

                if (count > n)
                {
                    Console.Write((2 * n) - count + " ");    

                    //Console.Write(count - (2 * p) + " ");
                    //p++;
                }
                else
                {
                    Console.Write(row + col + 1 + " ");
                }
            }

            Console.WriteLine();
        }
    }
}

