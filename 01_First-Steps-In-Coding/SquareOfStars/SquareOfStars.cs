using System;

class SquareOfStars
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());  
              
        for (int row = 1; row <= num; row++)
        {
            for (int col = 1; col <= num; col++)
            {                                         
                if ((row != 1) && (row != num) && (col != 1) && (col != num))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }                              
            }

            Console.WriteLine();           
        }
    }
}

