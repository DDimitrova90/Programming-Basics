using System;

class Increasing4Numbers   // https://judge.softuni.bg/Contests/Practice/Index/157#10
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());    

        if (b - a < 3)    
        {
            Console.WriteLine("No");
        } 

        for (int i = a; i <= b; i++)
        {
            for (int j = a; j <= b; j++)
            {
                for (int k = a; k <= b; k++)
                {
                    for (int l = a; l <= b; l++)
                    {
                        if ((i < j) && (j < k) && (k < l))
                        {
                            Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);
                        }
                    }
                }
            }
        }       
    }
}

