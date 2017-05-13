using System;

class SumsStep3    // https://judge.softuni.bg/Contests/Practice/Index/157#6
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;

        for (int i = 1; i <= n; i++)
        {
            a = int.Parse(Console.ReadLine());

            if (i % 3 == 1)
            {
                sum1 += a;
            }
            if (i % 3 == 2)
            {
                sum2 += a;
            }
            if (i % 3 == 0)
            {
                sum3 += a;
            }
        }
        
        Console.WriteLine("sum1 = {0}", sum1);
        Console.WriteLine("sum2 = {0}", sum2);
        Console.WriteLine("sum3 = {0}", sum3);
    }
}

