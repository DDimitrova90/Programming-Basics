using System;

class PowersOfTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(Math.Pow(2, i));
        }

        // for (int i = 0; i < n; i++)
        // {
        //    int number = 1;   
        //    Console.WriteLine(number);
        //    number *= 2;
        // }
    }
}     